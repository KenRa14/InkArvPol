using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Arv
{
    internal class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Hedgehog");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Number of spikes: {NrOfSpikes}";
        }
    }
}
