using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHooneLoomine
{
    public class Hoone
    {
        public int Pindala { get; set; }
        public Uks uks;
        public Hoone(int pindala = 200)
        {
            Pindala = pindala;
        }
        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");
            Console.WriteLine($"Mina maja suurus on {Suurus}");
        }
        public Uks GetUks()
        {
            return uks;
        }
    }
}
