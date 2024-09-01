using System;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

class Program
{
    static void Main(string[] args)
    {
        // Path to your large reference file
        var filePath = "Reference.cs";

        // Directory paths for Models and Enums
        var modelsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Models");
        var enumsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Enums");

        // Ensure directories exist
        Directory.CreateDirectory(modelsDirectory);
        Directory.CreateDirectory(enumsDirectory);

        var code = File.ReadAllText(filePath);
        var tree = CSharpSyntaxTree.ParseText(code);
        var root = tree.GetCompilationUnitRoot();

        // Extract and save classes
        foreach (var @class in root.DescendantNodes().OfType<ClassDeclarationSyntax>())
        {
            var className = @class.Identifier.Text;

            // Process properties to remove  prefix
            var modifiedClass = @class.ReplaceNodes(
                @class.Members.OfType<PropertyDeclarationSyntax>(),
                (originalNode, rewrittenNode) =>
                {
                    var propertyType = rewrittenNode.Type.ToString();
                    if (propertyType.StartsWith("GenOrder."))
                    {
                        var newPropertyType = propertyType.Replace("GenOrder.", string.Empty);
                        return rewrittenNode.WithType(SyntaxFactory.ParseTypeName(newPropertyType));
                    }
                    return rewrittenNode;
                });

            var classCode = modifiedClass.ToFullString();
            File.WriteAllText(Path.Combine(modelsDirectory, $"{className}.cs"), classCode);
            Console.WriteLine($"Saved class: {className}");
        }

        // Extract and save enums
        foreach (var @enum in root.DescendantNodes().OfType<EnumDeclarationSyntax>())
        {
            var enumName = @enum.Identifier.Text;
            var enumCode = @enum.ToFullString();
            File.WriteAllText(Path.Combine(enumsDirectory, $"{enumName}.cs"), enumCode);
            Console.WriteLine($"Saved enum: {enumName}");
        }
    }
}
