public class SocialMedia
{
    private List<string> _privateMessage = new();

    public void SendMessage(string message)
    {
        if(!string.IsNullOrEmpty(message))
        {
            _privateMessage.Add(message);
        }
    }

    public List<string> ShowMessage()
    {
        return new List<string>(_privateMessage);
    }

}