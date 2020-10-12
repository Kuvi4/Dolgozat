using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] t = new int[100];
            int osszeg = 0;
            int s = 0;
            int k = 0;
            int[] j = new int[100];
            int h = 0;
            for (int i = 0; i < t.Length; i++)
             
            {
                t[i] = rnd.Next(1000, 9999);

                
                
                
                    
                


                Console.Write(t[i] + ",");

                osszeg = t[i] + osszeg;
                if ( 4000< t[i] && t[i] < 5000)
                {
                    s = t[i] + s;
                    k++;
                }


                if( t[i] == 3)
                {
                    h++;
                }
            }
            Console.WriteLine(" " );
            Console.WriteLine("A tömb elemeinek összege : " + osszeg);
            Console.WriteLine("Az 4000-nél nagyobb de 5000-nél kissebb számok átlaga : " + s / k) ;
            int x = 0;
            Console.WriteLine("Kerek 100-as számok : ");
            for (int g = 0; g < t.Length; g++)
            {
                if (t[g] % 100 == 0 )
                {
                    j[g] = t[g];                   
                }
                if (j[g] > 0)
                {
                    Console.Write(j[g] + ", ");
                }
                
            }


            Console.ReadKey();
            
        }
    }
}
