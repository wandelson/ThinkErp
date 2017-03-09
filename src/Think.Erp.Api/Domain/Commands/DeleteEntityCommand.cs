namespace Think.Erp.Api.Domain.Commands
{
    public class DeleteEntityCommand : ICommand
    {
        public int Id { get; set; }
    }

}