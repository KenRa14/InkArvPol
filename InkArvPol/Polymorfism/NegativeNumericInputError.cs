using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Polymorfism
{
    internal class NegativeNumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a negative numeric input, but only equal or greater than 0 are accepted. This fired an error!";
        }
    }
}
