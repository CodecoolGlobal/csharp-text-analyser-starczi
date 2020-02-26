namespace csharp_text_analyser_starczi
{
    class WordIterator : Iterator
    {
        public FileContent Content { get; set; }
        WordIterator(FileContent content)
        {
            Content = content;
        }
        public bool HasNext()
        {
            return true;
        }
        public string MoveNext()
        {
            return "Hello";
        }
    }
}
