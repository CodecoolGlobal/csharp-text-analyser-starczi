namespace csharp_text_analyser_starczi
{
    class CharIterator : Iterator
    {
        public FileContent Content { get; set; }
        CharIterator(FileContent content)
        {
            Content = content;
        }
        public bool HasNext()
        {
            return false;
        }
        public string MoveNext()
        {
            return "Hello";
        }   
    }
}
