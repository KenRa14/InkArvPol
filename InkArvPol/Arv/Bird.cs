using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Arv
{
    internal class Bird : Animal
    {
        public float WingSpan { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Bird");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Wing span: {WingSpan:N2}";
        }
    }
}
