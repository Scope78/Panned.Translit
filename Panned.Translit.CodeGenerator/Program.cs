using Panned.Translit.CodeGenerator;

var xmlInputDir = args.Length > 0 ? args[0] : null;
var codeOutputDir = args.Length > 1 ? args[1] : null;

var errors = new List<string>();

if (string.IsNullOrEmpty(xmlInputDir))
{
    errors.Add("Missing XML input directory");
}
else if (!Directory.Exists(xmlInputDir))
{
    errors.Add($"{xmlInputDir} does not exist");
}

if (string.IsNullOrEmpty(codeOutputDir))
{
    errors.Add("Missing code output directory");
}
else if (!Directory.Exists(codeOutputDir))
{
    errors.Add($"{codeOutputDir} does not exist");
}

if (errors.Count > 0)
{
    Console.WriteLine(@"
C# code generator for Translit XML files
----------------------------------------
Usage: TranslitTest.CodeGenerator <XML-Input-Directory> <Code-Output-Directory>
");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(string.Join(Environment.NewLine, errors));
    Console.WriteLine();
    Console.ResetColor();
    Environment.Exit(1);
    return;
}

try
{
    var codeGenerator = new TranslitCodeGenerator(xmlInputDir!, codeOutputDir!);
    codeGenerator.Run();
}
catch(Exception ex)
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine(ex.ToString());
    Console.ResetColor();
    Environment.Exit(1);
}
