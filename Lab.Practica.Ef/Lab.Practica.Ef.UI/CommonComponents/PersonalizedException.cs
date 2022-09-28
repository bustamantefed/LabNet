using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.Ef.UI
{
    class PersonalizedException : Exception
    {
        public PersonalizedException(string message) : base( message)
        {

        }
    }
}
