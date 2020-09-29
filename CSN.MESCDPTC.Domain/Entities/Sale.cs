using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSN.MESCDPTC.Domain.Entities
{
    public class Sale
    {
        public virtual int Id { get; set; }

        public virtual User Client { get; set; }

        public virtual IList<Product> Produts { get; set; }

        public Sale()
        {
            this.Produts = new List<Product>();
        }
    }
}
