using Microsoft.AspNetCore.Mvc;
using DataAccess;
using BusinessLogic;
using DataAccess.Models.DTO;

namespace FifaCards.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class CardsController
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
			return new NoContentResult();
		}
	}
}
