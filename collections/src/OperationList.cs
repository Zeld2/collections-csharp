using static System.Console;

namespace collections.src

{
    public class OperationLista
    {
        public void PrintList(List<string> lista)
        {
            WriteLine($"Quantidade de elementos na lista: {lista.Count}");
            WriteLine("----------------");
            for (int i = 0; i < lista.Count; i++)
            {
                WriteLine($"Índice {i}, Valor {lista[i]}");
            }
        }
    }
}