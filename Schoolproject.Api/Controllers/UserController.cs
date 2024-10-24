﻿namespace Schoolproject.Api.Controllers;

public class UserController(
    IMediator mediator)
    : AppController(mediator)
{
    [HttpGet]
    [Route(Router.UserRouter.GetById)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> GetById(
        int id)
    {
        if (id <= 0) return BadRequest();
        var IsCreated = await mediator.Send(new GetUserById(id));
        return NewRsponse(IsCreated);
    }

    [HttpGet]
    [Route(Router.UserRouter.GetUsers)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [Authorize]
    public async Task<ActionResult> Get()
    {
        var IsCreated = await mediator.Send(new GetUsers());

        return NewRsponse(IsCreated);
    }

    [HttpPost]
    [Route(Router.UserRouter.AddNewUser)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult> Create(
        AddUser addUser)
    {
        //if (addUser is null) return BadRequest();
        var IsCreated = await mediator.Send(new AddNewUser(addUser));
        return NewRsponse(IsCreated);
    }

    [HttpPost]
    [Route(Router.UserRouter.AddRoleToUser)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> AddRoleToUser(
        AddRoleToUser command)
    {
        var IsCreated = await mediator.Send(command);

        return NewRsponse(IsCreated);
    }
}