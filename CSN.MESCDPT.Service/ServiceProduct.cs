using CSN.MESCDPPTC.DataAccess.Repository;
using CSN.MESCDPTC.Domain.Entities;
using CSN.MESCDPTC.Domain.Interfaces.IRepository;
using CSN.MESCDPTC.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSN.MESCDPT.Service
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly RepositoryProduct _repositoryProduct;
        public ServiceProduct(RepositoryProduct repositoryProduct)
        {
            this._repositoryProduct = repositoryProduct;
        }

        public ServiceProduct()
        {
        }

        public IEnumerable<Product> ListProduct()
        {
            return _repositoryProduct.ListProduct();
        }

        public Product GetProductId(int id)
        {
            return _repositoryProduct.GetProductId(id);
        }

        public int AddProduct(Product product)
        {
            return _repositoryProduct.AddProduct(product);
        }

        public void Delete(Product product)
        {
            _repositoryProduct.Delete(product);
        }
          
        public void Update(Product product)
        {
            _repositoryProduct.Update(product);
        }
    }
}
