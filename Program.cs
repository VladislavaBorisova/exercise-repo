using System;


namespace Cypher_Roulette
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";
            int br = 1;
            string word = string.Empty; 

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
               
                if (text == "spin")
                {
                    br++; n++;
                }

                if (text != word && text != "spin")
                {
                    if (br % 2 == 1) result += text;
                    else result = text + result;
                }

                if (text == word)
                {
                    result = "";
                    
                    if (text == "spin") br ++;
                    
                }
                
                word = text;                  
            }
            Console.WriteLine(result);
        }
    }
}
