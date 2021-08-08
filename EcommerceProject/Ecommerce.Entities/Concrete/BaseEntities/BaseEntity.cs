using Ecommerce.Entities.Abstract;

namespace Ecommerce.Entities.Concrete.BaseEntities
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
