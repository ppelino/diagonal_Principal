using System;

namespace Programa {

    class Program {

        static void Main(string[] args) {

            int N, cont;

            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            cont = 0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] < 0) {
                        cont++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADES DE NEGATIVOS = " + cont);
        }
    }
}

   

          