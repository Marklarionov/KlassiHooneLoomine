using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHooneLoomine
{
    class Program
    {
        static void Main(string[] args)
        {
            EraMaja majake = new EraMaja();
            Inimene mees = new Inimene("Mark");
            majake.uks = new Uks("Pruun");
            mees.hoone = majake;
            mees.NaitaInfo();
            Console.ReadLine();
        }
    }
}
