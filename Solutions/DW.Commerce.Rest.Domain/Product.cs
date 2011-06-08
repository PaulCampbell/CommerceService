namespace DW.Commerce.Rest.Domain
{
    using SharpArch.Domain.DomainModel;

    public class Product : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string ImageUrl { get; set; }
        
    }
}