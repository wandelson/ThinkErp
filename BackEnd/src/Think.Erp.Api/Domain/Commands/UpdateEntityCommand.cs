namespace Think.Erp.Api.Domain.Commands
{
    public class UpdateEntityCommand : ICommand
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Nickname { get; set; }
        public string Abbreviation { get; set; }
    }

}