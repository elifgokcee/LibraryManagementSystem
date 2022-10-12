using LibraryManagementSystem.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.DataAccess.EntityFramework
{
    public class EFIQueryableRepository
       <T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private DbContext _context;
        private IDbSet<T> _entitites;
        public EFIQueryableRepository(DbContext context)
        {
            _context = context;

        }
        public IQueryable<T> Table => this._entitites;

        protected virtual IDbSet<T> Entities
        {
            get
            {
                return _entitites ?? _context.Set<T>();

            }
        }
        public IQueryable<T> Get { get; }
    }
}

