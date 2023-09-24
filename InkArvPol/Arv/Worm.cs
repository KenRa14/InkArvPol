using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Arv
{
    internal class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Worm");
        }
    }
}
