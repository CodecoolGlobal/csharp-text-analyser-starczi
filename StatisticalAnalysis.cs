using System.Collections.Generic;
namespace csharp_text_analyser_starczi
{
    class StatisticalAnalysis
    {
        public Iterator Iterator { get; set; }
        public View View { get; set; }
        public StatisticalAnalysis(Iterator iterator)
        {
            View = new View();
            Iterator = iterator;
        }
        public int CountOf(params string[] list)
        {
            return 1;
        }
        public int DictionarySize()
        {
            return 1;
        }
        public int Size()
        {
            return 1;
        }
        // ISet<string> OccurMoreThan(int Integer)
        // {
        //     return;
        // }
    }
}
