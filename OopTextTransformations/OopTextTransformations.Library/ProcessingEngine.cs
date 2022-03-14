using OopTextTransformations.Library.Rules;

namespace OopTextTransformations.Library
{
    public class ProcessingEngine : ITransform
    {
        public ProcessingEngine(params ITransform[] rules)
        {
            Rules = rules ?? new ITransform[0];
        }

        public ITransform[] Rules { get; }

        public string Transform(string input)
        {
            string result = input;
            foreach (ITransform rule in Rules)
            {
                result = rule.Transform(result);
            }

            return result;
        }
    }
}
