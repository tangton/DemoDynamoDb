DemoDynamoDb
=================

Simple C# console application using DynamoDb SDK.

Application demostrates the UpdateItemAsync with the String set data type.
 
After calling

	repository.UpdateRecordAsync("Tony", new List<string> { "Blue" }).Wait();
	repository.UpdateRecordAsync("Tony", new List<string> { "Blue" }).Wait();
	repository.UpdateRecordAsync("Tony", new List<string> { "Red", "Blue" }).Wait();
	repository.UpdateRecordAsync("Tony", new List<string> { "Purple", "Red" }).Wait();
	repository.UpdateRecordAsync("Tony", new List<string> { "Red" }).Wait();

The final result in the database table is {"Blue","Green","Purple","Red"}

This shows the DynamoDb has duplicate handling logic with the String set data type.