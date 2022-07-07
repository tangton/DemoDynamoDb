using Amazon;
using Amazon.DynamoDBv2;
using DemoDynamoDb.Repositories;
using System;

namespace DemoDynamoDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repository = new RepositoryTable(new AmazonDynamoDBClient(RegionEndpoint.APSoutheast2));
            
            repository.UpdateRecordAsync("Tony", new List<string> { "Blue" }).Wait();
            repository.UpdateRecordAsync("Tony", new List<string> { "Blue" }).Wait();
            repository.UpdateRecordAsync("Tony", new List<string> { "Red", "Blue" }).Wait();
            repository.UpdateRecordAsync("Tony", new List<string> { "Purple", "Red" }).Wait();
            repository.UpdateRecordAsync("Tony", new List<string> { "Red" }).Wait();
        }
    }
}