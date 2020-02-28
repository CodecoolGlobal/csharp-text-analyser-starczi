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
            Text = File.ReadAllText(FileName).Replace("\n", string.Empty);

        }
        public Iterator CharIterator()
        {
            var CharIterator = new CharIterator(new FileContent(FileName));
            return CharIterator;
        }
        public Iterator WordIterator()
        {
            var WordIterator = new WordIterator(new FileContent(FileName));
            return WordIterator;    
        }
    }
}
