using ElasticSearchClient.Model;
using Nest;
using System;

namespace ElasticSearchClient
{
    public class ElasticSearchClientWrapper : IElasticSearchClientWrapper
    {
        private readonly IElasticClient _client;

        public ElasticSearchClientWrapper(IElasticClient client)
        {
            _client = client;
        }

        public IIndexResponse Index<T>(T @object, Func<IndexDescriptor<T>, IndexDescriptor<T>> indexSelector = null) where T : class
        {
            return _client.Index(@object, indexSelector);
        }

    }
}
