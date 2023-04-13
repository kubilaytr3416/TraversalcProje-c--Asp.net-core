namespace TRAVEL.CQRS.Commands.DestinationCommands
{
    public class UpdateDestinationCommand
    {
        public int id { get; set; }
        public string city { get; set; }
        public double price { get; set; }
        public int capacity { get; set; }
        public string daynight { get; set; }

    }
}
