using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Think.Erp.Api.Data.Transaction;
using Think.Erp.Api.Domain.Handlers;
using Think.Erp.Api.Domain.Repositories;
using Think.Erp.Api.Domain.Commands;


namespace Think.Erp.Api.Controllers
{

    [AllowAnonymous]
    public class EntityController : BaseController
    {
        private readonly IEntityRepository _repository;
        private readonly EntityCommandHandler _handler;

        public EntityController(IUnitOfWork uow, IEntityRepository repository, EntityCommandHandler handler) : base(uow)
        {
            _repository = repository;
            _handler = handler;
        }

        [HttpGet]
        [Route("v1/entities/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.Get(id));
        }

         [HttpGet]
        [Route("v1/entities/")]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }


        [HttpPost]
        [Route("v1/entities")]

        public IActionResult Save([FromBody]RegisterEntityCommand command)
        {
            _handler.Handle(command);
            return Response(command, "Entidade cadastrado com sucesso!", "Falha ao registrar", _handler.Notifications);
        }


        [Route("v1/entities")]
        [HttpPut]
        public IActionResult Update([FromBody] UpdateEntityCommand command)
        {
            _handler.Handle(command);
            return Response(command, "Entidade atualizado com sucesso!", "Falha ao registrar", _handler.Notifications);
        }


        [Route("v1/entities/getbynickname/{nickname}")]
        [HttpGet]
        public IActionResult GetByNickName(string nickName)
        {
            return Ok(_repository.GetByNickName(x => x.Nickname == nickName));
        }

        [Route("v1/entities/delete/{id}")]
        [HttpDelete]

        public IActionResult Delete(DeleteEntityCommand command)
        {
            _handler.Handle(command);
            return Response(command, "Entidade removida com sucesso!", "Falha ao registrar", _handler.Notifications);

        }

    }
}