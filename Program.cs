using System.Collections.Generic;

namespace csharp_text_analyser_starczi
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var fileName in args)
            {
                FileContent fileContent = new FileContent(fileName);
                var charIter = fileContent.CharIterator();
                var wordIter = fileContent.WordIterator();
                StatisticalAnalysis Analyzer = new StatisticalAnalysis(charIter);

                View.Print(Analyzer.CountOf("p"));
            }
        }
    }
}
