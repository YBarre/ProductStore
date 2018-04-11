
// This is a Data Transfer Object(DTO) class. This is sent/received in REST requests/responses.
// Read about DTOS here: https://docs.microsoft.com/en-us/aspnet/web-api/overview/data/using-web-api-with-entity-framework/part-5

using System.ComponentModel.DataAnnotations;
namespace ProductStores.Models
{
    // Entity class for Azure table
    using Microsoft.WindowsAzure.Storage.Table;

    namespace ProductStore.Models
    {

        public class ProductEntity : TableEntity
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Category { get; set; }

            public ProductEntity(string partitionKey, string productID)
            {
                PartitionKey = partitionKey;
                RowKey = productID;
            }

            public ProductEntity() { }

        }
    }
}
