namespace csharp_text_analyser_starczi
{
    interface Iterator
    {
        FileContent Content { get; set; }
        string[] SlicedContent { get; set; }
        int Current { get; set; }
        bool HasNext();
        string MoveNext();
    }
}
