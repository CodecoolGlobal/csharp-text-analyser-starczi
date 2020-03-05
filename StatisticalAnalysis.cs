using System.Collections.Generic;
namespace csharp_text_analyser_starczi
{
    class StatisticalAnalysis
    {
        public Iterator Iterator { get; set; }
        public Dictionary<string, int> Elements { get; set; }
        public StatisticalAnalysis(Iterator iterator)
        {
            Iterator = iterator;
            Elements = new Dictionary<string, int>();
            SlicedTextToDictionary();
        }
        public void SlicedTextToDictionary()
       {
           while(Iterator.HasNext())
           {
               var nextElement = Iterator.MoveNext();

                if (!Elements.ContainsKey(nextElement))
                {
                    Elements[nextElement] = 1;
                }
                else
                {
                    Elements[nextElement]++;
                }
           }
           Iterator.Reset();
       } 
        public int CountOf(params string[] elements)
        {
            int totalCount = 0;
            foreach(var el in elements)
            {
                totalCount = totalCount + Elements[el.ToLower()];
            }
            return totalCount;
        }
        public int DictionarySize()
        {
            return Elements.Count;
        }
        public int Size()
        {
            int totalCount = 0;
            while(Iterator.HasNext()) 
            {
                Iterator.MoveNext();
                totalCount++;
            }
            return totalCount;
        }
        public List<string> OccurMoreThan(int Occurance)
        {
            var stringList = new List<string>();

            foreach(var kvp in Elements)
            {
                if(kvp.Value > Occurance)
                {
                    stringList.Add(kvp.Key);
                }
            }
            return stringList;
        }
    }
}
