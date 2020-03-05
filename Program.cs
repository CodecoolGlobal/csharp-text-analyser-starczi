using System.Collections.Generic;

namespace csharp_text_analyser_starczi
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var textFile in args)
            {
                System.Console.WriteLine($"Name of the analyzed file: {textFile}");
                IterableText fileContent = new FileContent(textFile);
                StatisticalAnalysis CharAnalyzer = new StatisticalAnalysis(fileContent.CharIterator());
                StatisticalAnalysis WordAnalyzer = new StatisticalAnalysis(fileContent.WordIterator());
                View.Print("Number of words", WordAnalyzer.Size());
                View.Print("Number of unique words", WordAnalyzer.DictionarySize());
                View.Print("Number of chars", CharAnalyzer.Size());
                try
                {
                    View.Print("Number of times 'me' and 'you' was used", WordAnalyzer.CountOf("me", "you"));
                }
                catch (KeyNotFoundException)
                {
                    System.Console.WriteLine($"One or more of entered words have not been found in the file!");
                }
                View.Print("Words that have been used more than 1500 times:", WordAnalyzer.OccurMoreThan(1500));
                System.Console.WriteLine();
            }
        }
    }
}
