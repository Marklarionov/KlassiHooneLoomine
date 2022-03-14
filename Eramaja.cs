using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHooneLoomine
{
    public class EraMaja : Hoone
    {
        public EraMaja(int pindala = 50) : base(pindala)
        {
        }
        public string Suurus
        {
            get
            {
                var suurus = "";
                if (Pindala <= 20)  
                {
                    Console.WriteLine("vaike");
                }
                else if (Pindala >= 20 && Pindala <=40)
                {
                    Console.WriteLine("keskmine");
                }
                else if (Pindala >=40 && Pindala <=60)
                {
                    Console.WriteLine("suur");
                }
                else
                {
                    Console.WriteLine("liiga suur");
                }
                return suurus;
            }
        }
    }
}
