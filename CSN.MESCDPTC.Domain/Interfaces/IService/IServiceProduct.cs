using CSN.MESCDPTC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSN.MESCDPTC.Domain.Interfaces.IService
{
   public interface IServiceProduct
    {
        IEnumerable<Product> ListProduct();
        Product GetProductId(int id);
        int AddProduct(Product product);

        void Update(Product product);

        void Delete(Product product);
    }
}
