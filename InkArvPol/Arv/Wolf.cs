using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Arv
{
    internal class Wolf : Animal
    {
        public string EmotionalState { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Wolf");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Emotional state: {EmotionalState}";
        }
    }
}
