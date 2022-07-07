using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace DemoDynamoDb.Repositories
{
    public interface IRepositoryTable
    {
        Task UpdateRecordAsync(string userName, List<string> favouriteColours);
    }

    public class RepositoryTable : IRepositoryTable
    {
        IAmazonDynamoDB _amazonDynamoDB;
        public RepositoryTable(IAmazonDynamoDB amazonDynamoDB)
        {
            _amazonDynamoDB = amazonDynamoDB;
        }

        public async Task UpdateRecordAsync(string userName, List<string> favouriteColours)
        {
            var updateItemRequest = new UpdateItemRequest
            {
                TableName = "TestTable",
                Key = new Dictionary<string, AttributeValue> {
                    {
                        "UserName",
                        new AttributeValue { S = userName }
                    } 
                },
                ExpressionAttributeNames = new Dictionary<string, string>()
                {
                    {"#FavouriteColours", "FavouriteColours"}
                },
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>()
                {
                    {":FavouriteColours", new AttributeValue{SS = favouriteColours } }
                },
                UpdateExpression = "ADD #FavouriteColours :FavouriteColours",
            };

            var response = await _amazonDynamoDB.UpdateItemAsync(updateItemRequest);
        }
    }
}
