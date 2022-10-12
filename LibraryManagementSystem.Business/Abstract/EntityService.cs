
using LibraryManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Abstract
{
    public interface EntityService<IEntity>
    {
        List<IEntity> GetAll();
        IEntity GetById(int id);
        IEntity Add(IEntity entity);
        void Delete(IEntity entity);
        IEntity Update(IEntity entity);
    }
}
