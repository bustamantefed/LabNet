using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.Ef.Logic
{
    interface IABM<T>
    {
        List<T> GetAll();

        void Add(T AddNew);

        void Delete(int id);

        void Update(T updateT);

        List<T> Filter(string a);
    }
}
