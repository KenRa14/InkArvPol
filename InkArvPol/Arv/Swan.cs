using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Arv
{
    internal class Swan: Bird
    {
        public string SwanProperty { get; set; }
        public override string Stats()
        {
            return $"{base.Stats()}, Swan propery: {SwanProperty}";
        }
    }
}
