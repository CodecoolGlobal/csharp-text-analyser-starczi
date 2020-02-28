using System;
using System.Linq;
namespace csharp_text_analyser_starczi
{
    class CharIterator : Iterator
    {
        public FileContent Content { get; set; }
        public string[] SlicedContent { get; set; }
        public int Current { get; set; } = 0;
        public CharIterator(FileContent content)
        {
            Content = content;
            // Linq used to maintain string[] type of SlicedContent
            var SlicedText = content.Text.Trim().Replace(" ", string.Empty).ToCharArray().Select(c => c.ToString()).ToArray();
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
            return "There is no more chars to iterate over";
        }
    }
}
