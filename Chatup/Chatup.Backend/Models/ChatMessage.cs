public class ChatMessage
{
    public string Id { get; set; }
    public string Sender { get; set; }
    public string Receiver { get; set; }
    public string MessageContent { get; set; }
    public DateTime Timestamp { get; set; }
}