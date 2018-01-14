using Nest;
using System;

namespace ElasticSearchClient
{
    public interface IElasticSearchClientWrapper
    {
         IIndexResponse Index<T>(T @object, Func<IndexDescriptor<T>, IndexDescriptor<T>> indexSelector = null) where T : class;
        

    }
}