using LibraryManagamentSystem.Core.CrossCuttingConcerns.Caching;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamentSystem.Core.Aspects.CacheAspects
{
    [Serializable]
    public class CacheRemoveAspect:OnMethodBoundaryAspect
    {
        private Type _cacheType;
        private ICacheManager _cacheManager;
        private string _pattern;
        public CacheRemoveAspect(Type cacheType)
        {
            _cacheType = cacheType; 

        }
        public CacheRemoveAspect(string pattern,Type cacheType) 
        {
          
            _cacheType=cacheType;   
            _pattern = pattern; 
        }
        public override void RuntimeInitialize(MethodBase method)
        {
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType) == false)
            {
                throw new Exception("wrong cache manager");
            }
            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);
            base.RuntimeInitialize(method);
        }
        public override void OnSuccess(MethodExecutionArgs args)
        {
            _cacheManager.RemoveByPattern(string.IsNullOrEmpty(_pattern) ? String.Format("{0}.{1}.*",
                args.Method.ReflectedType.Namespace,
                args.Method.ReflectedType.Name) : _pattern);
           
        }
    }
}
