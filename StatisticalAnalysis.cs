using System.Collections.Generic;
namespace csharp_text_analyser_starczi
{
    class StatisticalAnalysis
    {
        public Iterator Iterator { get; set; }
        public StatisticalAnalysis(Iterator iterator)
        {
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
            return Iterator.SlicedContent.Length;
        }
        // ISet<string> OccurMoreThan(int Integer)
        // {
        //     return;
        // }
    }
}
