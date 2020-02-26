using System.IO;
namespace csharp_text_analyser_starczi
{
    class FileContent : IterableText
    {
        public string Content { get; set; }
        FileContent(string content)
        {
            Content=content;
        }
        public Iterator CharIterator()
        {
            var CharIterator = new CharIterator();
            return CharIterator;
        }
        public Iterator WordIterator()
        {
            var WordIterator = new WordIterator();
            return WordIterator;        
        }
        public string GetFilename()
        {
            return "name";
        }
    }
}
