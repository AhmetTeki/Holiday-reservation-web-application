namespace TraversalRezervasyonApp.CQRS.Commands.DestinationCommands
{
    public class RemoveDestinationCommand
    {
        public RemoveDestinationCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
