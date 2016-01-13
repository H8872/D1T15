using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1T15
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku, valil=0;
            Console.Write("Anna Luku > ");
            luku = int.Parse(Console.ReadLine());
            valil = luku - 3;
            for(int i=luku; i>=3; i--)
            {
                for(int j=i-3; j>0; j--)
                {
                    Console.Write(" ");
                }
                for(int k = luku-3; k>0; k--)
                {
                    Console.Write("**");
                }
                Console.WriteLine("*");

                luku--;
            }


            if (luku == 2)
            {
                for(int i = valil; i > 0; i--)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("*");
                luku--;
            }
            if(luku == 1)
            {
                for (int i = valil; i > 0; i--)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("*");
            }
            else
            {
                Console.WriteLine("-");
            }

            Console.ReadLine();
        }
    }
}
