namespace ExpressoesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Expressoes Lambda podem criar funcoes anonimas 
            // Codigo mais conciso e menos linhas para uma mesma funcionalidade


            // Programacao Imperativa
            List<int> numberList = new List<int>();
            int sum = 0;
            foreach (int x in numberList)
            {
                sum += x;
            }

            // Programacao Funcional (Declarativa)
            int sum1 = numberList.Aggregate(0, (x, y) => x + y);
        }
    }
}