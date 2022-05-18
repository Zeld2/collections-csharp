using System;
using static System.Console;
using collections.src;

namespace collections
{
    class Program
    {
        static void Demo1()
        {
            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;

            WriteLine("Percorrendo o array pelo For");
            for (var i = 0; i < arrayInteiros.Length; i++)
            {
                WriteLine(arrayInteiros[i]);
            }

            WriteLine("Percorrendo o array pelo ForEach");
            foreach (var item in arrayInteiros)
            {
                WriteLine(item);
            }
        }
        static void Demo2()
        {
            int[,] matriz = new int[4, 2]
            {
                {8, 8},
                {10 , 20},
                {50 , 100},
                {90, 200}
            };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    WriteLine(matriz[i, j]);
                }
            }

        }

        static void Demo3()
        {
            ArrayOperations op = new ArrayOperations();
            int[] array = new int[] { 6, 3, 8, 1, 9 };
            int[] arrayCopy = new int[10];
            string[] arrayString = op.ArrayToString(array);
            
            // WriteLine($"Capacidade atual do array: {array.Length}");

            // op.Resize(ref array, array.Length * 2);

            // WriteLine($"Capacidade atual do array: {array.Length}");

            //int valorProcurado = 7;

            // int valorAchado = op.FindValue(array, valorProcurado);
            // if (valorAchado > -1)
            // {
            //     WriteLine($"Encontrei o valor na posição {valorAchado}");
            // }
            // else
            // {
            //     WriteLine("Não encontrei o valor");
            // }

            // bool maiorQue = op.AllBigger(array, valorProcurado);
            // if(maiorQue)
            // {
            //     WriteLine($"Todos os valores são maiores que {valorProcurado}");
            // }else{WriteLine($"Nem todos os valores são maiores que {valorProcurado}");}
            // op.Copy(array, arrayCopy);

            // WriteLine("Array original: ");
            // op.PrintArray(array);

            // op.Sort(array);

            // WriteLine("Array ordenado: ");
            // op.PrintArray(array);

            // WriteLine("Array copiado ");
            // op.PrintArray(arrayCopy);
        }
    
        static void Main()
        {
            OperationLista opList = new OperationLista();
            List<string> estados = new List<string>();
            estados.Add("SP");
            estados.Add("MG");
            estados.Add("BA");

            opList.PrintList(estados);

            WriteLine("");
            WriteLine("Removendo elemento");
            WriteLine("");

            estados.Remove("MG");

            opList.PrintList(estados);

        }    
    }
}