using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracking.DAL.DAO;
using StockTracking.DAL;
using StockTracking.DAL.DTO;


namespace StockTracking.DAL.DAO
{
    public class CustomerDAO : StockContext, IDAO<CUSTOMER, CustomerDetailDTO>
    {
        public bool Delete(CUSTOMER item)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CUSTOMER entity)
        {
            try
            {
                db.CUSTOMERs.Add(entity);
                db.SaveChanges();
                return true;
                
            }
            catch ( Exception ex)
            {

                throw ex;
            }
        }

        public List<CustomerDetailDTO> Select()
        {
            try
            {
                List<CustomerDetailDTO> customers = new List<CustomerDetailDTO>();
                var list= db.CUSTOMERs;
                foreach ( var item in list )
                {
                    CustomerDetailDTO dto = new CustomerDetailDTO
                    {
                        CustomerName = item.CustomerName,
                        ID = item.ID
                    };
                    customers.Add(dto);
                }
                return customers;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(CUSTOMER item)
        {
            throw new NotImplementedException();
        }
    }
}
