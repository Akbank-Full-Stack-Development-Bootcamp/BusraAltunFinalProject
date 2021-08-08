using System;

namespace Ecommerce.Entities.Abstract.IUpdatedEntity
{
    public interface IUpdatedUser
    {
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedUserDate { get; set; }
    }
}
