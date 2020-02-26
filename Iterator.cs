namespace csharp_text_analyser_starczi
{
    interface Iterator
    {
        bool HasNext();
        string MoveNext();
        void Remove()
        {
            
        }
    }
}
