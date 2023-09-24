using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Arv
{
    internal class Dog : Animal
    {
        public bool HasBasicComputerSkills { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Dog");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Basic computer skills: {HasBasicComputerSkills}";
        }

        public string WriteNovel()
        {
            if (HasBasicComputerSkills)
                return $"Novels be novels by {Name}: ...";
            else
                return $"...";
            
        }
    }
}
