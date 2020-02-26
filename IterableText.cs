namespace csharp_text_analyser_starczi
{
    interface IterableText
    {
        Iterator CharIterator(); 
        Iterator WordIterator(); 
    }
}
