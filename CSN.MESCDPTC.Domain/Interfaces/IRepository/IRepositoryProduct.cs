using CSN.MESCDPTC.Domain.Entities;
using System.Collections.Generic;

namespace CSN.MESCDPTC.Domain.Interfaces.IRepository
{
    public   interface IRepositoryProduct
    {
        IEnumerable<Product> ListProduct();
        Product   GetProductId(int id);
        int AddProduct(Product product);

        void Update(Product product);

        void Delete(Product product);
    }
}
