using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramework.Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        void Add(string key, object data, int cacheDuration);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveById(string pattern);
        void Clear();
    }
}
