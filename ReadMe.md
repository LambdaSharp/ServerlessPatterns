# Serverless .NET Patterns

This repository contains modules use for the Serverless .NET Patterns presentations.

## Bitcoin.Topic

The _Bitcoin.Topic_ module creates a Lambda function that publishes the most recent bitcoin price on an SNS topic. The SNS topic is exported from the CloudFormation stack so that other stacks can subscribe to it.

## Bitcoin.Table

The _Bitcoin.Table_ module creates a Lambda function that subscribes to the SNS topic from the _BitcoinTopic_ stack and stores the received value in a DynamoDB table. Stored values are automatically forgotten after 15 minutes to minimize the number of stored rows. The DynamoDB table is exported for other stacks to query against.

## Bitcoin.Event

The _Bitcoin.Event_ module published the price from the SNS topic to the default EventBridge eventbus.

## Deploy

```bash
lash deploy \
    Bitcoin.Topic:1.0@serverlesspatterns \
    Bitcoin.Table:1.0@serverlesspatterns \
    Bitcoin.Event:1.0@serverlesspatterns
```