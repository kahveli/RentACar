using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Core.DataAccess.EntityFramework;
using Core.Entity;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
    }
}
