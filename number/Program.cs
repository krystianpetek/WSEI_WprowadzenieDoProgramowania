using System;

namespace LED_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string liczby = Console.ReadLine();
            char[] n = liczby.ToCharArray();

            string[,] tab0 = new string[,]
            {
                {" ", "_", " "},
                {"|", " ", "|"},
                {"|", "_", "|" },
            };

            string[,] tab1 = new string[,]
            {
                {" ", " ", " "},
                {" ", "|", " "},
                {" ", "|", " "},
            };


            string[,] tab2 = new string[,]
            {
                {" ", "_", " "},
                {" ", "_", "|"},
                {"|", "_", " "},
            };

            string[,] tab3 = new string[,]
            {
                {" ","_"," "},
                {" ","_","|"},
                {" ","_","|"},
            };

            string[,] tab4 = new string[,]
            {
                {" ", " ", " "},
                {"|","_", "|" },
                {" ", " ", "|" },
            };

            string[,] tab5 = new string[,]
            {
                {" ", "_", " "},
                {"|", "_"," "},
                {" ", "_","|"},
            };

            string[,] tab6 = new string[,]
            {
                {" ", "_", " "},
                {"|", "_", " "},
                {"|","_", "|" },
            };

            string[,] tab7 = new string[,]
            {
                {"_", " ", " "},
                {" ", "|", " "},
                {" ", "|", " "},
            };

            string[,] tab8 = new string[,]
            {
                {" ", "_"," "},
                {"|", "_", "|"},
                {"|", "_", "|"},
            };

            string[,] tab9 = new string[,]
            {
                {" ", "_", " "},
                {"|", "_", "|"},
                {" ", " ", "|"},
            };

            for (int x = 0; x < n.Length; x++)
            {
                switch (n[x])
                {
                    case '0':
                        for (int i = 0; i < tab0.GetLength(0); i++)
                            Console.Write(tab0[0, i]);
                        break;
                    case '1':
                        for (int i = 0; i < tab1.GetLength(0); i++)
                            Console.Write(tab1[0, i]);
                        break;
                    case '2':
                        for (int i = 0; i < tab2.GetLength(0); i++)
                            Console.Write(tab2[0, i]);
                        break;
                    case '3':
                        for (int i = 0; i < tab3.GetLength(0); i++)
                            Console.Write(tab3[0, i]);
                        break;
                    case '4':
                        for (int i = 0; i < tab4.GetLength(0); i++)
                            Console.Write(tab4[0, i]);
                        break;
                    case '5':
                        for (int i = 0; i < tab5.GetLength(0); i++)
                            Console.Write(tab5[0, i]);
                        break;
                    case '6':
                        for (int i = 0; i < tab6.GetLength(0); i++)
                            Console.Write(tab6[0, i]);
                        break;
                    case '7':
                        for (int i = 0; i < tab7.GetLength(0); i++)
                            Console.Write(tab7[0, i]);
                        break;
                    case '8':
                        for (int i = 0; i < tab8.GetLength(0); i++)
                            Console.Write(tab8[0, i]);
                        break;
                    case '9':
                        for (int i = 0; i < tab9.GetLength(0); i++)
                            Console.Write(tab9[0, i]);
                        break;
                }
                if(x == n.Length-1)
                    Console.WriteLine();
            }
            for (int x = 0; x < n.Length; x++)
            {
                switch (n[x])
                {
                    case '0':
                        for (int i = 0; i < tab0.GetLength(0); i++)
                            Console.Write(tab0[1, i]);
                        break;
                    case '1':
                        for (int i = 0; i < tab1.GetLength(0); i++)
                            Console.Write(tab1[1, i]);
                        break;
                    case '2':
                        for (int i = 0; i < tab2.GetLength(0); i++)
                            Console.Write(tab2[1, i]);
                        break;
                    case '3':
                        for (int i = 0; i < tab3.GetLength(0); i++)
                            Console.Write(tab3[1, i]);
                        break;
                    case '4':
                        for (int i = 0; i < tab4.GetLength(0); i++)
                            Console.Write(tab4[1, i]);
                        break;
                    case '5':
                        for (int i = 0; i < tab5.GetLength(0); i++)
                            Console.Write(tab5[1, i]);
                        break;
                    case '6':
                        for (int i = 0; i < tab6.GetLength(0); i++)
                            Console.Write(tab6[1, i]);
                        break;
                    case '7':
                        for (int i = 0; i < tab7.GetLength(0); i++)
                            Console.Write(tab7[1, i]);
                        break;
                    case '8':
                        for (int i = 0; i < tab8.GetLength(0); i++)
                            Console.Write(tab8[1, i]);
                        break;
                    case '9':
                        for (int i = 0; i < tab9.GetLength(0); i++)
                            Console.Write(tab9[1, i]);
                        break;
                }
                if (x == n.Length - 1)
                    Console.WriteLine();

            }
            for (int x = 0; x < n.Length; x++)
            {
                switch (n[x])
                {
                    case '0':
                        for (int i = 0; i < tab0.GetLength(0); i++)
                            Console.Write(tab0[2, i]);
                        break;
                    case '1':
                        for (int i = 0; i < tab1.GetLength(0); i++)
                            Console.Write(tab1[2, i]);
                        break;
                    case '2':
                        for (int i = 0; i < tab2.GetLength(0); i++)
                            Console.Write(tab2[2, i]);
                        break;
                    case '3':
                        for (int i = 0; i < tab3.GetLength(0); i++)
                            Console.Write(tab3[2, i]);
                        break;
                    case '4':
                        for (int i = 0; i < tab4.GetLength(0); i++)
                            Console.Write(tab4[2, i]);
                        break;
                    case '5':
                        for (int i = 0; i < tab5.GetLength(0); i++)
                            Console.Write(tab5[2, i]);
                        break;
                    case '6':
                        for (int i = 0; i < tab6.GetLength(0); i++)
                            Console.Write(tab6[2, i]);
                        break;
                    case '7':
                        for (int i = 0; i < tab7.GetLength(0); i++)
                            Console.Write(tab7[2, i]);
                        break;
                    case '8':
                        for (int i = 0; i < tab8.GetLength(0); i++)
                            Console.Write(tab8[2, i]);
                        break;
                    case '9':
                        for (int i = 0; i < tab9.GetLength(0); i++)
                            Console.Write(tab9[2, i]);
                        break;
                }

            }

        }
    }
}
