namespace GenericsSetDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            // Generics permitem que classes, interfaces e metodos possam ser parametrizados por tipo
            // Colecoes
            List<string> names = new List<string>();

            names.Add("Lailton");
            names.Add("Alves");
            names.Add("Bento");

            string jog = names[0];

            // Equals : Compara se um objeto é igual ao outro
            // Retorna true ou false
            System.Console.WriteLine(names[1].Equals(names[2]));

            // Sets: Uma coleçao que contem apenas elementos distintos
            // HashSet e SortedSet
            /*
             HashSet • Armazenamento em tabela hash
                    Extremamente rápido: inserção, remoção e busca
                    A ordem dos elementos não é garantida

            SortedSet • Armazenamento em árvore
                    Rápido: inserção, remoção e busca
                    Os elementos são armazenados ordenadamente conforme implementação IComparer<T>
            */

            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("Celular");
            hashSet.Add("Computador");
            hashSet.Add("Televisao");

            System.Console.WriteLine(hashSet.Contains("Computador"));

            foreach (String produtos in hashSet)
            {
                System.Console.WriteLine(produtos);
            }

        }


    }
}