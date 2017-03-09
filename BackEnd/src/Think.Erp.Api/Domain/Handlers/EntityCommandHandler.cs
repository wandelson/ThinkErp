

using Think.Erp.Api.Domain.Entities;
using Think.Erp.Api.Domain.Repositories;
using Think.Erp.Api.Validation;
using Think.Erp.Api.Domain.Commands;

namespace Think.Erp.Api.Domain.Handlers
{
    public class EntityCommandHandler : Validatable, ICommandHandler<RegisterEntityCommand>
    {
        private readonly IEntityRepository _repository;

        public EntityCommandHandler(IEntityRepository repository)
        {
            _repository = repository;
        }

        public void Handle(RegisterEntityCommand command)
        {
            var customer = new Entity(command.FirstName, command.LastName, command.FullName, command.Nickname, command.Abbreviation);

            var validationResult = new RegisterEntityCommandValidation().Validate(command);

            if (validationResult.IsValid) _repository.Save(customer);

            AddNotification(validationResult.Errors);
        }

        public void Handle(UpdateEntityCommand command)
        {
            var customer = new Entity(command.Id, command.FirstName, command.LastName, command.FullName, command.Nickname, command.Abbreviation);

            var validationResult = new UpdateEntityCommandValidation().Validate(command);

            if (validationResult.IsValid) _repository.Save(customer);

            AddNotification(validationResult.Errors);
        }

        public void Handle(DeleteEntityCommand command)
        {
            _repository.Delete(command.Id);

        }

    }
}