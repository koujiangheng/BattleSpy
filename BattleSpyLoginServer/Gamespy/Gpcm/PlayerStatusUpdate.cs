namespace Server
{
    public class PlayerStatusUpdate
    {
        public GpcmClient Client { get; protected set; }

        public LoginStatus Status { get; protected set; }

        public PlayerStatusUpdate(GpcmClient client, LoginStatus status)
        {
            this.Client = client;
            this.Status = status;
        }
    }
}