using Ecommerce.DataAccess.Abstract;
using Ecommerce.DataAccess.Concrete.Contexts;
using Ecommerce.Entities.Concrete;

namespace Ecommerce.DataAccess.Concrete.EntityFramework
{
    public class EFAuthorDal : EfBaseRepository<Author, ECommerceContext>, IAuthorDal
    {
    }
}
