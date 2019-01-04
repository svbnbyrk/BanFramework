using BanFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramework.Core.DataAccess.EntityFramework
{
    public class EfQueryablaRepository<T> : IQueryableReporsitory<T> where T : class, IEntity, new()
    {
        private DbContext _context;
        private IDbSet<T> _entities;
        public EfQueryablaRepository(DbContext context)
        {
            _context = context;
        }

        //public IQueryable<T> Table
        //{
        //    get
        //    {
        //        return this.Entities;;
        //    }
        //} expression body
        public IQueryable<T> Table => this.Entities;
        protected virtual IDbSet<T> Entities
        {
            //get
            //{
            //    if (_entities == null)
            //    {
            //        _entities = _context.Set<T>();
            //    }
            //    return _entities;

            //}
            get { return _entities ?? (_entities = _context.Set<T>()); }
        }
    }
}
