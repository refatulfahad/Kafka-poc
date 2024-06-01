using KafkaProducer;

internal class Program
{
    private static void Main(string[] args)
    {
        ProduceMessage produceMessage = new ProduceMessage();
        produceMessage.CreateMessage().Wait();
    }
}