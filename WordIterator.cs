using System;
using System.Linq;
namespace csharp_text_analyser_starczi
{
    class WordIterator : Iterator
    {
        public FileContent Content { get; set; }
        public string[] SlicedContent { get; set; }
        public int Current { get; set; } = -1;
        public WordIterator(FileContent content)
        {
            GenerateContent(content);
        }
        private void GenerateContent(FileContent content)
        {
            Content = content;
            var SlicedText = content.Text.Trim().Split(new char[] {' ', '\n'}).Where(str => !string.IsNullOrEmpty(str)).ToArray();
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
