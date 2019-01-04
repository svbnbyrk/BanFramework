using BanFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramework.Core.DataAccess
{
    public interface IQueryableReporsitory<T> where T:class , IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
