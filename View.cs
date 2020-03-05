using System.Collections.Generic;
namespace csharp_text_analyser_starczi
{
    public class View
    {
        public static void Print(string msg, int result)
        {
            System.Console.WriteLine($"{msg} ---> {result}");
        }
        public static void Print(string msg, List<string> List)
        {
            var i = 1;
            System.Console.WriteLine(msg);
            foreach(var element in List)
            {
                System.Console.WriteLine($"{i}. {element}");
                i++;
            }
        }
    }
}
