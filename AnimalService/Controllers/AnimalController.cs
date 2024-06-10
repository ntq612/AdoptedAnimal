using AnimalService.Context;
using AnimalService.DTOs;
using AutoMapper;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace AnimalService.Controllers;



[Route("api/[controller]")]
public class AnimalController : Controller
{
    private readonly AnimalDbContext _context;
    private readonly IMapper _mapper;
    private readonly IPublishEndpoint _publishEndpoint;

    public AnimalController(AnimalDbContext context, IMapper mapper, IPublishEndpoint publishEndpoint)
    {
        _context = context;
        _mapper = mapper;
        _publishEndpoint = publishEndpoint;
    }

    [HttpGet]
    public async Task<ActionResult<List<AnimalDto>>> GetAllAnimals()
    {
        List<AnimalDto> listResult = new List<AnimalDto>();
        //var result = await 



        return listResult;
    }
}
