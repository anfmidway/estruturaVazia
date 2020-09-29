using CSN.MESCDPTC.Domain.Entities;
using CSN.MESCDPTC.Domain.Interfaces.IRepository;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSN.MESCDPPTC.DataAccess.Repository
{
    public class RepositoryProduct : IRepositoryProduct
    {
        private readonly ISession isession;
        public RepositoryProduct(ISession session)
        {
            this.isession = session;
        }

        public Product GetProductId(int id)
        {
            return this.isession.Get<Product>(id);
        }

        public IEnumerable<Product> ListProduct()
        {
            IQuery query = isession.CreateQuery("from Product");
            return query.List<Product>();
        }

        public int AddProduct(Product product)
        {
            return (int)isession.Save(product);
        }

        public void Delete(Product product)
        {
            isession.Delete(product);
        }
          
        public void Update(Product product)
        {
            this.isession.Update(product);
        }

       
    }
}
