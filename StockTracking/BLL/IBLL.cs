using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.BLL
{
    interface IBLL<T,K> where T : class where K : class
    {
        bool Insert(T item);
        bool Update(T item);
        bool Delete(T item);
        K Select();
        bool GetBack(T entity);
    }
}
