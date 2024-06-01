using KafkaConsumer;

internal class Program
{
    private static void Main(string[] args)
    {
        ConsumeMessage consumeMessage = new ConsumeMessage();
        consumeMessage.ReadMessage();
    }
}