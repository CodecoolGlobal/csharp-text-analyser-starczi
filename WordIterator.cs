using System;
namespace csharp_text_analyser_starczi
{
    class WordIterator : Iterator
    {
        public FileContent Content { get; set; }
        public string[] SlicedContent { get; set; }
        public int Current { get; set; } = 0;
        public WordIterator(FileContent content)
        {
            Content = content;
            var SlicedText = content.Text.Trim().Split(' ');
            SlicedContent = new string[SlicedText.Length];
            Array.Copy(SlicedText, SlicedContent, SlicedContent.Length);
        }
        public bool HasNext()
        {
            if(SlicedContent[Current+1] != null)
            {
                return true;
            }
            return false;
        }
        public string MoveNext()
        {
            if(HasNext())
            {
                Current++;
                return SlicedContent[Current];
            }
            return "There is no more words to iterate over";
        }
    }
}
