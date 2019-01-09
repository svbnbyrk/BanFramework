using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BanFramework.Core.CrossCuttingConcerns.Caching;
using PostSharp.Aspects;

namespace BanFramework.Core.Aspects.PostSharp.CacheAspects
{
    [Serializable]
    public class CacheRemoveAspect:OnMethodBoundaryAspect
    {
        private string _pattern;
        private readonly Type _cacheType;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(Type cacheType)
        {
            _cacheType = cacheType;
        }

        public CacheRemoveAspect(string pattern, Type cachetYType)
        {
            _pattern = pattern;
            _cacheType = cachetYType;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType) == false)
            {
                throw new Exception("wrong cache manager");
            }

            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType); //memory cache manager ornegi olusturur

            base.RuntimeInitialize(method);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            if (args.Method.ReflectedType != null)
                _cacheManager.RemoveById(string.IsNullOrEmpty(_pattern)
                    ? $"{args.Method.ReflectedType.Namespace}.{args.Method.ReflectedType.Name}.*"
                    : _pattern);
        }
    }
}
