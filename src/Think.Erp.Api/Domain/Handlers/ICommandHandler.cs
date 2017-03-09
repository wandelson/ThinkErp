
using Think.Erp.Api.Domain.Commands;

namespace Think.Erp.Api.Domain.Handlers
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Handle(T command);
    }
}