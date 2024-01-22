
using System.Collections;
using System.Runtime.Intrinsics.X86;

class Program
{

    static void Main(string[] args)
    {

        int[] arrayNumero = { 1, 2, 3, 4, 5, 6, 7, 8, };
    

        ArrayList arrayProvincias = new ArrayList() { "Sevilla", "Cadiz", "Huelva", "Cordoba", "Jaen", "Almeria", "Malaga", "Granada"};

        arrayProvincias.Sort();

        for (int i = 0; i < arrayProvincias.Count; i++)
        {

            Console.WriteLine(arrayProvincias[i]);
        }
        /*
        arrayProvincias.Insert(0, arrayNumero[0]);

        for (int i = 0; i < arrayProvincias.Count; i++)
        {

            Console.WriteLine(arrayProvincias[i]);
        }
        */


        ArrayList[] nombres = new ArrayList[16];
        ArrayList a = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };


        for(int i = 1; i < nombres.Length; i++)
        {
            

            if(i % 2 == 0)
            {
                int aux = 1;
                aux++;
                nombres[i].Insert(i, arrayProvincias[aux]);
                
                

            }

            else {
                int aux01 = 2;
                aux01++;
                nombres[i].Insert(i, arrayNumero[aux01]);
                

            }

            int aux03 = 0;


            Console.WriteLine(nombres[aux03]);
            aux03++;



        }












    }



}
