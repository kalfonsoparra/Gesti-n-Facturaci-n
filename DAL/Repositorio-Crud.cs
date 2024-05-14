using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  interface Repositorio_Crud<T>
    {
            
            string Create(T t);
            List<T> Reading();
            string Update(List<T> NewList);
            void Delete(string Date);
            T Maping(string Date);
            T Searching(string Date);
    }
}
