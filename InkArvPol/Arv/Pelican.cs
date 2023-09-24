using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Arv
{
    internal class Pelican: Bird
    {
        public string PelicanProperty { get; set; }
        public override string Stats()
        {
            return $"{base.Stats()}, Pelican propery: {PelicanProperty}";
        }
    }
}
