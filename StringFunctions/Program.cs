using System;

namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Outras funçoes de String:

            // Format: ToLower(), ToUpper(), Trim()
            // Search: IndexOf(), LastIndexOf()
            // Recortar: Substring(inicio), Substring(inicio, tamanho)
            // Substituir: Replace(char, char), Replace(string, string)
            // String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)
            // string.Split('')
            // Convert to number: int x = int.Par(string), int x = Convert.ToInt32(string) 
            // Convert number: string = x.ToString(), string = x.ToString("C")

            string original = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = original.ToUpper();
            Console.WriteLine(s1);
            // "ABCDE FGHIJ ABC ABC DEFG    "

            string s2 = original.ToLower();
            Console.WriteLine(s2);
            // "abcde fghij abc abc defg   "

            string s3 = original.Trim();
            Console.WriteLine(s3);
            // "abcde FGHIJ ABC abc DEFG"

            int n1 = original.IndexOf('d');
            Console.WriteLine(n1);
            // 3

            int n2 = original.LastIndexOf("abc");
            Console.WriteLine(n2);
            // 16

            string s4 = original.Substring(5);
            Console.WriteLine(s4);
            //" FGHIJ ABC abc DEFG"

            string s5 = original.Replace('a', 'z');
            Console.WriteLine(s5);
            // "zbcde FGHIJ ABC zbc DEFG"

            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine(b1);
            // False

            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine(b2);
            // False


            // Split() function:
            char spearator = ' ';
            string[] s6 = original.Split(spearator);
            foreach (string s in s6)
            {
                Console.WriteLine(s);
                    //abcde
                    //FGHIJ
                    //ABC
                    //abc
                    //DEFG
            }
        }
    }
}
