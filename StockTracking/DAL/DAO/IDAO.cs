using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.DAO
{
    interface IDAO<T,K> where T : class where K : class
    {
        List<K> Select();
        bool Insert (T item);
        bool Update (T item);   
        bool Delete (T item);
        bool GetBack(int ID);

    }
}
