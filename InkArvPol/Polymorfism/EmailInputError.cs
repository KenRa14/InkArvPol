using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Polymorfism
{
    internal class EmailInputError : UserError
    {
        public override string UEMessage()
        {
            return "Input doesn't seem to be an email. This fired an error!";
        }
    }
}
