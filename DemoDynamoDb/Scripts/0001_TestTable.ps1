aws dynamodb create-table `
    --table-name TestTable `
    --attribute-definitions `
        AttributeName=UserName,AttributeType=S `
    --key-schema `
        AttributeName=UserName,KeyType=HASH `
    --provisioned-throughput `
        ReadCapacityUnits=1,WriteCapacityUnits=1 `
    --table-class STANDARD `
    --region ap-southeast-2