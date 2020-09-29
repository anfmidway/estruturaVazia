using System.Collections.Generic;

namespace CSN.MESCDPTC.Domain.Entities
{
    public class Category
    {
        public virtual int Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual IList<Product> Produts { get; set; }
    }
}