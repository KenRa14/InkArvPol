using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Arv
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public float Weight { get; set; }

        public int Age { get; set; }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}";
        }

        public Animal()
        {
            
        }
    }
}
