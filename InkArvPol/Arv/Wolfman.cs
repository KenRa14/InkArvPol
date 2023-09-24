using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Arv
{
    internal class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("I'm a wolfman");
        }
    }
}
