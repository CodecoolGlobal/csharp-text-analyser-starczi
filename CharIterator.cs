using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace csharp_text_analyser_starczi
{
    class CharIterator : Iterator
    {
        public FileContent Content { get; set; }
        public string[] SlicedContent { get; set; }
        public int Current { get; set; } = -1;
        public CharIterator(FileContent content)
        {
            GenerateContent(content);
        }
        private void GenerateContent(FileContent content)
        {
            Content = content;
            // Linq used to maintain string[] type of SlicedContent
            var SlicedText = content.Text.Trim().Replace("\n", string.Empty).Replace(" ", string.Empty)
                                         .ToCharArray().Select(c => c.ToString()).ToArray();
            SlicedContent = new string[SlicedText.Length];
            Array.Copy(SlicedText, SlicedContent, SlicedContent.Length); 
        }
        public bool HasNext()
        {
            if(Current < SlicedContent.Length-1)
            {
                return true;
            }
            return false;
        }
        public string MoveNext()
        {
            Current++;
            return SlicedContent[Current];
        }
        public void Reset()
        {
            Current = -1;
        }
    }
}
