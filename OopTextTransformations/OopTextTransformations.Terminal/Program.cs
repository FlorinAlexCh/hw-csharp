using OopTextTransformations.Library;
using OopTextTransformations.Library.Rules;
using System;

namespace OopTextTransformations.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is the Initial text";

            ProcessingEngine engine = new ProcessingEngine(
                new StringRemoveRule("Not "),
                new StringInsertRule(0, "Maybe "),
                new StringReplaceRule("Initial", "changed"));

            string transformed = engine.Transform(text);

            Console.WriteLine($"First text={text}");
            Console.WriteLine($"Modified Text={transformed}");
        }
    }
}
