using Ecommerce.DataAccess.Repositories;
using Ecommerce.Entities.Concrete;
using Ecommerce.Entities.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Abstract
{
   public interface IBookDal : IBaseRepository<Book>
    {
    }
}
