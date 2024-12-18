using Microsoft.AspNetCore.Mvc;
using DataAccess;
using BusinessLogic;
using DataAccess.Models.DTO;


namespace FifaCards.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class CardsController : ControllerBase
	{
		private readonly IFifaCardService _fifaService;
		public CardsController(IFifaCardService fifaService)
		{
			_fifaService = fifaService;
		}
		[HttpPost]
		public async Task<IActionResult> CreateAsync([FromBody] CreateCardRequest createCardRequest) 
		{
			await _fifaService.CreateAsync(createCardRequest.FifaCard, createCardRequest.skills);
			return NoContent();
		}
		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetCardAsync(int id) 
		{
			try
			{
				var card = await _fifaService.GetByIdAsync(id);
				return Ok(card);
			}catch(Exception ex) 
			{
				return BadRequest("we have some Problems -> " + ex.Message);
			}
		}
	}
}
