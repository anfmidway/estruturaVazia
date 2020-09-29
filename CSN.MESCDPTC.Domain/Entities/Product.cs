 

namespace CSN.MESCDPTC.Domain.Entities
{
    public class Product
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual double Price { get; set; }

        public virtual Category Category { get; set; }
    }
}
