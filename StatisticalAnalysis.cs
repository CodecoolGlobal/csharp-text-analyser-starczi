using System.Collections.Generic;
namespace csharp_text_analyser_starczi
{
    class StatisticalAnalysis
    {
        public Iterator Iterator { get; set; }
        public StatisticalAnalysis(Iterator iterator)
        {
            View view = new View();
            Iterator = iterator;
        }
        int CountOf(params string[] list)
        {
            return 1;
        }
        int DictionarySize()
        {
            return 1;
        }
        int Size()
        {
            return 1;
        }
        // ISet<string> OccurMoreThan(int Integer)
        // {
        //     return;
        // }
    }
}
