using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracking.DAL.DTO;
using StockTracking.DAL.DAO;
using StockTracking.DAL;

namespace StockTracking.BLL
{
    class SalesBLL : IBLL<SalesDetailDTO, SalesDTO>
    {
        SalesDAO dao=new SalesDAO();
        ProductDAO productdao=new ProductDAO();
        CategoryDAO categorydao=new CategoryDAO();
        CustomerDAO customerdao=new CustomerDAO();
        public bool Delete(SalesDetailDTO item)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(SalesDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SalesDetailDTO entity)
        {
            SALE sale= new SALE();
            sale.CategoryID = entity.CategoryID;
            sale.ProductID = entity.ProductID;
            sale.CustomerID = entity.CustomerID;
            sale.ProductSalesPrice = entity.Price;
            sale.ProductSalesAmout = entity.SalesAmount;
            sale.SaleDate = entity.SaleDate;
            dao.Insert(sale);
            PRODUCT product=new PRODUCT();
            product.ID = entity.ProductID;
            int temp = entity.StockAmount - entity.SalesAmount;
            product.StockAmount = temp;
            productdao.Update(product);
            return true;
        }

        public SalesDTO Select()
        {
            SalesDTO dto= new SalesDTO();
            dto.Products = productdao.Select();
            dto.Customers = customerdao.Select();
            dto.Categories = categorydao.Select();
            dto.Sales = dao.Select();
            return dto; 

        }

        public bool Update(SalesDetailDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
