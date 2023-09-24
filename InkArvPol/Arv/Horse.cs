using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Arv
{
    internal class Horse : Animal
    {
        public string CoatColor { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Horse");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Coat color: {CoatColor}";
        }
    }
}
