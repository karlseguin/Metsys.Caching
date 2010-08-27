using System;
using System.Web.Caching;

namespace Metsys.Caching
{
   public interface ICache
   {
      T Get<T>(string key, params object[] keyArgs);

      T Fetch<T>(string key, Func<T> callIfGetReturnsNull, params object[] keyArgs);
      T Fetch<T>(string key, Func<T> callIfGetReturnsNull, DateTime absoluteExpiration, params object[] keyArgs);
      T Fetch<T>(string key, Func<T> callIfGetReturnsNull, TimeSpan slidingExpiration, params object[] keyArgs);
      T Fetch<T>(string key, Func<T> callIfGetReturnsNull, CacheDependency dependencies, params object[] keyArgs);
      T Fetch<T>(string key, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, params object[] keyArgs);
      T Fetch<T>(string key, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback, params object[] keyArgs);

      T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, params object[] keyArgs);
      T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, DateTime absoluteExpiration, params object[] keyArgs);
      T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, TimeSpan slidingExpiration, params object[] keyArgs);
      T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, CacheDependency dependencies, params object[] keyArgs);
      T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, params object[] keyArgs);
      T Fetch<T>(string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback, params object[] keyArgs);


      void Insert(string key, object data, params object[] keyArgs);
      void Insert(string key, object data, DateTime absoluteExpiration, params object[] keyArgs);
      void Insert(string key, object data, TimeSpan slidingExpiration, params object[] keyArgs);
      void Insert(string key, object data, CacheDependency dependencies, params object[] keyArgs);
      void Insert(string key, object data, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, params object[] keyArgs);
      void Insert(string key, object data, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback, params object[] keyArgs);

      void Remove(string key, params object[] keyArgs);

      void RemoveAll();

      int Count();
   }
}