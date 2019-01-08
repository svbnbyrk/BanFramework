using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching

namespace BanFramework.Core.CrossCuttingConcerns.Caching.Microsoft
{
     public class MemoryCacheManager:ICacheManager
     {
         protected ObjectCache Cache => MemoryCache.Default;
      
         
        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void Add(string key, object data, int cacheDuration)
        {
            throw new NotImplementedException();
        }

        public bool IsAdd(string key)
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(string pattern)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }

}
