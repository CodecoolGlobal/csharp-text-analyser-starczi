using System.IO;
namespace csharp_text_analyser_starczi
{
    class FileContent : IterableText
    {
        public string FileName { get; set; }
        public string Text { get; set; }
        public FileContent(string fileName)
        {
            FileName=fileName;
            Text = File.ReadAllText(FileName).ToLower();
        }
        public Iterator CharIterator()
        {
            return new CharIterator(this);
        }
        public Iterator WordIterator()
        {
            return new WordIterator(this);    
        }
    }
}
