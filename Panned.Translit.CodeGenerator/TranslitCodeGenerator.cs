using System.Text;

namespace Panned.Translit.CodeGenerator
{
    internal class TranslitCodeGenerator(string xmlInputPath, string codeOutputPath)
    {
        private readonly string _xmlInputPath = xmlInputPath;
        private readonly string _codeOutputPath = codeOutputPath;

        public void Run()
        {
            var dirInfo = new DirectoryInfo(_xmlInputPath);
            var files = dirInfo.EnumerateFiles("*.xml", SearchOption.TopDirectoryOnly).ToList();
            var namesClassNames = new List<Tuple<string, string>>();

            foreach (var file in files)
            {
                var fileNameWithoutExt = Path.GetFileNameWithoutExtension(file.FullName).Replace("-", "_").Replace(" ", "_");

                if (fileNameWithoutExt == "template")
                {
                    continue;
                }

                var className = "Translit_" + fileNameWithoutExt;
                namesClassNames.Add(new Tuple<string, string>(fileNameWithoutExt, className));

                var compiler = new TranslitParser(file.FullName);

                using var streamWriter = new StreamWriter(Path.Combine(_codeOutputPath, $"{className}.cs"), false, Encoding.UTF8);

                streamWriter.Write($@"using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class {className} : TranslitBase
{{
    public override Transliteration Transliteration => Transliteration.{fileNameWithoutExt};

    public override bool IsReversable => {compiler.IsReversableValue};

    public override string Transliterate(string input)
    {{
        string output = input;
");

                foreach (var rule in compiler.Rules)
                {
                    streamWriter.Write($@"
        output = {rule.MethodName}().Replace(output, @""{rule.To}"");");

                }

                streamWriter.Write(@"

        return output;
    }

    public override string Reverse(string input)
    {");
                if (!compiler.IsReversable)
                {
                    streamWriter.Write(@"
        throw new NotReversableException();");
                }
                else
                {
                    streamWriter.Write(@"
        string output = input;
");
                    foreach (var rule in compiler.Rules)
                    {
                        streamWriter.Write($@"
        output = {rule.MethodNameReverse}().Replace(output, @""{rule.From}"");");
                    }

                    streamWriter.Write(@"

        return output;");

                }

                streamWriter.Write(@"
    }
");

                foreach (var rule in compiler.Rules)
                {
                    streamWriter.Write($@"              
    [GeneratedRegex(@""{rule.RegEx}"")]
    private static partial Regex {rule.MethodName}();
");

                    if (compiler.IsReversable)
                    {
                        streamWriter.Write($@"                   
    [GeneratedRegex(@""{rule.RegExReverse}"")]
    private static partial Regex {rule.MethodNameReverse}();
");
                    }
                }

                streamWriter.Write(@"
}
");
            }

            using var streamWriterFactory = new StreamWriter(Path.Combine(_codeOutputPath, "TranslitFactory.cs"), false, Encoding.UTF8);

            streamWriterFactory.Write(@"using Panned.Translit.Contracts;

namespace Panned.Translit;

public class TranslitFactory : ITranslitFactory
{
    public ITranslit Create(Transliteration transliteration)
    {
        switch(transliteration)
        {");
            foreach (var nameClassName in namesClassNames)
            {
                streamWriterFactory.Write($@"
            case Transliteration.{nameClassName.Item1}:
                return new {nameClassName.Item2}();");
            }

            streamWriterFactory.Write(@"
            default:
                throw new InvalidOperationException($""Unknown Transliteration {transliteration}"");
        }
    }
}
");

        }
    }
}
