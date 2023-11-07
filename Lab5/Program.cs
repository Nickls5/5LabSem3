using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab35
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix:");
            MyMatrix matrix = new MyMatrix(5, 5, -10, 10);
            matrix.Show();

            Console.WriteLine();
            matrix.Fill(-10, 10);

            Console.WriteLine("Part of Matrix:");
            matrix.ShowPartially(2, 3, 2, 3);
            Console.WriteLine();

            Console.WriteLine("New size Matrix:");
            matrix.ChangeSize(4, 4, -10, 10);
            matrix.Show();
            

        }
    }*/


    class MyMatrix
    {
        private int n => matrix.Count;
        private int m => matrix[0].Count;
        private List<List<double>> matrix;

        public MyMatrix(int n, int m, int min, int max)
        {
            Random rand = new Random();
            matrix = new List<List<double>>();
            for (int j = 0; j < n; j++)
            {
                matrix.Add(new List<double>());
                for (int i = 0; i < m; i++)
                {
                    matrix[j].Add(rand.Next(min, max));
                }
            }
        }

        public void Fill(int min, int max)
        {
            Random rand = new Random();
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    matrix[j][i] = rand.Next(min, max);
                }
            }
        }

        public void ChangeSize(int nNew, int mNew, int min, int max)
        {
            Random rand = new Random();
            List<List<double>> newMatrix = new List<List<double>>(nNew);
            for (int i = 0; i < nNew; i++)
            {
                for (int j = 0; j < mNew; j++)
                {
                    newMatrix.Add(new List<double>());
                    if (i < n && j < m)
                    {
                        newMatrix[i].Add(matrix[i][j]);
                    }
                    else
                    {
                        newMatrix[i].Add(rand.Next(min, max));
                    }
                }
            }

            matrix = newMatrix;
        }

        public void ShowPartially(int nS, int nF, int mS, int mF)
        {
            for (int i = nS - 1; i < nF; i++)
            {
                for (int j = mS - 1; j < mF; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }

                Console.WriteLine();
            }
        }

        public void Show()
        {
            foreach (var row in matrix)
            {
                foreach (var num in row)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }

        public double this[int a, int b]
        {
            get => this.matrix[a][b];
            set => this.matrix[a][b] = value;
        }
    }





}

