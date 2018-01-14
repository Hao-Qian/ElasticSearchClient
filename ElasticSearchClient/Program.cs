using ElasticSearchClient.Model;
using Nest;
using System;

namespace ElasticSearchClient
{
    class Program
    {
        static string ElasticSearchUrl = "http://localhost:9200";
        static string DefaultIndexName = "Demo";
        static IElasticSearchClientWrapper _elasticSearchWrapper;
        static void Main(string[] args)
        {
            SetUpElasticSearchClient();
            //IndexEmployeeData();
        }

        static void SetUpElasticSearchClient()
        {
            var settings = new ConnectionSettings(new Uri(ElasticSearchUrl)).DefaultIndex(DefaultIndexName);
            var client = new ElasticClient(settings);
            _elasticSearchWrapper = new ElasticSearchClientWrapper(client);
        }

        static void IndexEmployeeData()
        {
            var employee1 = new Employee
            {
                EmployeeId = 1,
                EmployeeName = "lala",
                Address = "lala2"
            };
            _elasticSearchWrapper.Index(employee1);
        }
    }
}
