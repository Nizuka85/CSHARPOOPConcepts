using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracking.DAL.DTO;
using StockTracking.DAL;

namespace StockTracking.DAL.DAO
{
    class SalesDAO : StockContext, IDAO<SALE, SalesDetailDTO>
    {
        public bool Delete(SALE item)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SALE entity)
        {
            try
            {
                db.SALES.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<SalesDetailDTO> Select()
        {
            try
            {
                List<SalesDetailDTO> sale = new List<SalesDetailDTO>();
                var list=(from s in db.SALES
                          join p in db.PRODUCTs on s.ProductID equals p.ID
                          join c in db.CUSTOMERs on s.CustomerID equals c.ID
                          join category in db.CATEGORies on s.CategoryID equals category.ID
                          select new
                          {
                              productname= p.ProductName,
                              customername= c.CustomerName,
                              categoryname= category.CategoryName,
                              productID= s.ProductID,
                              customerID= s.CustomerID,
                              salesID= s.ID,
                              categoryID= category.ID,
                              saleprice= s.ProductSalesPrice,
                              saleAmout= s.ProductSalesAmout,
                              saledate= s.SaleDate,
                          }).OrderBy(x => x.saledate).ToList();
                foreach (var item in list)
                {
                    SalesDetailDTO dto= new SalesDetailDTO();
                    dto.ProductName = item.productname;
                    dto.CustomerName = item.customername;
                    dto.CategoryName = item.categoryname;
                    dto.ProductID = item.productID;
                    dto.CustomerID = item.customerID;
                    dto.CategoryID = item.categoryID;
                    dto.SaleID = item.salesID;
                    dto.Price = item.saleprice;
                    dto.SalesAmount = item.saleAmout;
                    dto.SaleDate = item.saledate;
                    sale.Add(dto);
                }
                return sale;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(SALE item)
        {
            throw new NotImplementedException();
        }
    }
}
