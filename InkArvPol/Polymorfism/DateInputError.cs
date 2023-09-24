using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkArvPol.Polymorfism
{
    internal class DateInputError : UserError
    {
        public override string UEMessage()
        {
            return "Input does not match exptected format \"DD/MM/YYYY\". This fired an error!";
        }
    }
}
