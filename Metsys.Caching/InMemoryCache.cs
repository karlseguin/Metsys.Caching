using System;
using System.Web;
using System.Web.Caching;

namespace Metsys.Caching
{
   public sealed class InMemoryCache : ICache
   {
      #region ICache Members

      public T Get<T>(string key, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Get<T>(key, keyArgs);
      }

      public T Fetch<T>(string key, Func<T> callIfGetReturnsNull, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Fetch(key, callIfGetReturnsNull, keyArgs);
      }

      public T Fetch<T>(string key, Func<T> callIfGetReturnsNull, DateTime absoluteExpiration, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Fetch(key, callIfGetReturnsNull, absoluteExpiration, keyArgs);
      }

      public T Fetch<T>(string key, Func<T> callIfGetReturnsNull, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Fetch(key, callIfGetReturnsNull, slidingExpiration, keyArgs);
      }

      public T Fetch<T>(string key, Func<T> callIfGetReturnsNull, CacheDependency dependencies, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Fetch(key, callIfGetReturnsNull, dependencies, keyArgs);
      }

      public T Fetch<T>(string key, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Fetch(key, callIfGetReturnsNull, dependencies, absoluteExpiration, slidingExpiration, keyArgs);
      }

      public T Fetch<T>(string key, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Fetch(key, callIfGetReturnsNull, dependencies, absoluteExpiration, slidingExpiration, priority, onRemoveCallback, keyArgs);
      }

      public T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Fetch(key, callIfGetReturnsValue, callIfGetReturnsNull, keyArgs);
      }

      public T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, DateTime absoluteExpiration, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Fetch(key, callIfGetReturnsValue, callIfGetReturnsNull, absoluteExpiration, keyArgs);
      }

      public T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Fetch(key, callIfGetReturnsValue, callIfGetReturnsNull, slidingExpiration, keyArgs);
      }

      public T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, CacheDependency dependencies, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Fetch(key, callIfGetReturnsValue, callIfGetReturnsNull, dependencies, keyArgs);
      }

      public T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Fetch(key, callIfGetReturnsValue, callIfGetReturnsNull, dependencies, absoluteExpiration, slidingExpiration, keyArgs);
      }

      public T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback, params object[] keyArgs)
      {
         return HttpRuntime.Cache.Fetch(key, callIfGetReturnsValue, callIfGetReturnsNull, dependencies, absoluteExpiration, slidingExpiration, priority, onRemoveCallback, keyArgs);
      }

      public void Insert(string key, object data, params object[] keyArgs)
      {
         HttpRuntime.Cache.Insert(key, data, keyArgs);
      }

      public void Insert(string key, object data, DateTime absoluteExpiration, params object[] keyArgs)
      {
         HttpRuntime.Cache.Insert(key, data, absoluteExpiration, keyArgs);
      }

      public void Insert(string key, object data, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         HttpRuntime.Cache.Insert(key, data, slidingExpiration, keyArgs);
      }

      public void Insert(string key, object data, CacheDependency dependencies, params object[] keyArgs)
      {
         HttpRuntime.Cache.Insert(key, data, dependencies, keyArgs);
      }

      public void Insert(string key, object data, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         HttpRuntime.Cache.Insert(key, data, dependencies, absoluteExpiration, slidingExpiration, keyArgs);
      }

      public void Insert(string key, object data, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback, params object[] keyArgs)
      {
         HttpRuntime.Cache.Insert(key, data, dependencies, absoluteExpiration, slidingExpiration, priority, onRemoveCallback, keyArgs);
      }

      public void Remove(string key, params object[] keyArgs)
      {
         HttpRuntime.Cache.Remove(key, keyArgs);
      }

      public void RemoveAll()
      {
         HttpRuntime.Cache.RemoveAll();
      }

      public int Count()
      {
         return HttpRuntime.Cache.Count;
      }

      #endregion
   }
}