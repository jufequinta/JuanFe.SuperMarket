using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace JuanFe.Supermarket.Product.Solution.Infrastructure.Helpers
{
    public static class ServiceBusHelper
    {
        private static string connectionPrimary = string.Empty;
        private static string connectionSecundary = string.Empty;
        private static ServiceBusClient client;
        private static ServiceBusSender sender;
        private static IConfiguration config;
        public static void Initialize(IConfiguration Configuration)
        {
            config = Configuration;
        }
        public static async Task SendMessageTopic(string topicName, string message)
        {
            if (string.IsNullOrEmpty(connectionPrimary))
            {
                client = new ServiceBusClient(ServiceBusConnectionStringPrimary());
            }
            else
            {
                client = new ServiceBusClient(ServiceBusConnectionStringSecundary());
            }

            sender = client.CreateSender(GetTopic(topicName));

            using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();
            if (!messageBatch.TryAddMessage(new ServiceBusMessage(message)))
            {
                throw new Exception($"The message is too large to fit in the batch.");
            }

            try
            {
                await sender.SendMessagesAsync(messageBatch);
            }
            finally
            {
                await sender.DisposeAsync();
                await client.DisposeAsync();
            }
        }

        public static string GetTopic(string topicName)
        {
            switch (topicName)
            {
                case "ProductTopic":
                    return config.GetValue<string>("Topics:ProductTopic");
                default:
                    return string.Empty;
            }
        }

        public static string ServiceBusConnectionStringPrimary()
        {
            if (string.IsNullOrWhiteSpace(connectionPrimary))
            {
                connectionPrimary = GetServiceBusConnectionString(1);
            }

            return connectionPrimary;
        }

        public static string ServiceBusConnectionStringSecundary()
        {
            if (string.IsNullOrWhiteSpace(connectionSecundary))
            {
                connectionSecundary = GetServiceBusConnectionString(2);
            }

            return connectionSecundary;
        }

        private static string GetServiceBusConnectionString(int servicesBusConnection)
        {
            switch (servicesBusConnection)
            {
                case 1:
                    return config.GetValue<string>("ConnectionString:ServiceBusConnectionPrimary");
                case 2:
                    return config.GetValue<string>("ConnectionString:ServiceBusConnectionSecundary");
                default:
                    return String.Empty;
            }
        }
    }
}
