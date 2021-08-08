using System;

namespace Ecommerce.Entities.Abstract.ICreatedEntity
{
    public interface ICreatedUser 
    {
        public int CreatedUserId { get; set; }
        public DateTime CreatedUserDate { get; set; }
    }
}
