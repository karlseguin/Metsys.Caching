using System;
using System.Web.Caching;

namespace Metsys.Caching
{
   public class NoCache : ICache
   {
      #region ICache Members

      public T Get<T>(string key, params object[] keyArgs)
      {
         return default(T);
      }

      public T Fetch<T>(string key, Func<T> callIfGetReturnsNull, params object[] keyArgs)
      {
         return callIfGetReturnsNull();
      }

      public T Fetch<T>(string key, Func<T> callIfGetReturnsNull, DateTime absoluteExpiration, params object[] keyArgs)
      {
         return callIfGetReturnsNull();
      }

      public T Fetch<T>(string key, Func<T> callIfGetReturnsNull, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         return callIfGetReturnsNull();
      }

      public T Fetch<T>(string key, Func<T> callIfGetReturnsNull, CacheDependency dependencies, params object[] keyArgs)
      {
         return callIfGetReturnsNull();
      }

      public T Fetch<T>(string key, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         return callIfGetReturnsNull();
      }

      public T Fetch<T>(string key, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback, params object[] keyArgs)
      {
         return callIfGetReturnsNull();
      }

      public T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, params object[] keyArgs)
      {
         var r = callIfGetReturnsNull();
         return r == null ? callIfGetReturnsNull() : r;
      }

      public T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, DateTime absoluteExpiration, params object[] keyArgs)
      {
         var r = callIfGetReturnsNull();
         return r == null ? callIfGetReturnsNull() : r;
      }

      public T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         var r = callIfGetReturnsNull();
         return r == null ? callIfGetReturnsNull() : r;
      }

      public T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, CacheDependency dependencies, params object[] keyArgs)
      {
         var r = callIfGetReturnsNull();
         return r == null ? callIfGetReturnsNull() : r;
      }

      public T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         var r = callIfGetReturnsNull();
         return r == null ? callIfGetReturnsNull() : r;
      }

      public T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback, params object[] keyArgs)
      {
         var r = callIfGetReturnsNull();
         return r == null ? callIfGetReturnsNull() : r;
      }

      public void Insert(string key, object data, params object[] keyArgs)
      {
      }

      public void Insert(string key, object data, DateTime absoluteExpiration, params object[] keyArgs)
      {
      }

      public void Insert(string key, object data, TimeSpan slidingExpiration, params object[] keyArgs)
      {
      }

      public void Insert(string key, object data, CacheDependency dependencies, params object[] keyArgs)
      {
      }

      public void Insert(string key, object data, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, params object[] keyArgs)
      {
      }

      public void Insert(string key, object data, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback, params object[] keyArgs)
      {
      }

      public void Remove(string key, params object[] keyArgs)
      {
      }

      public void RemoveAll()
      {
      }

      public int Count()
      {
         return 0;
      }

      #endregion
   }
}