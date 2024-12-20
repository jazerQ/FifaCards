using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Data.Repository;
using DataAccess.Models.DTO;

namespace BusinessLogic
{
	internal class FifaCardService : IFifaCardService
	{
		private readonly IFifaCardsRepository _cardsRepository;
		public FifaCardService(IFifaCardsRepository fifaCardsRepository) 
		{
			_cardsRepository = fifaCardsRepository;
		}
		public async Task CreateAsync(FifaCardDTO FifaCard, SkillsDTO skills, CancellationToken cancellationToken = default)
		{
			Skills skills1 = new Skills(skills);
			CalcSkills calcSkills = new CalcSkills(skills1);
			calcSkills.CalcOverall();
			var fifaCard = new FifaCard { Name = FifaCard.Name, Position = FifaCard.Position, Skills = skills1 };
			
			await _cardsRepository.CreateAsync(fifaCard, cancellationToken);
		}

		public async Task<FifaCard> GetByIdAsync(int id, CancellationToken cancellationToken = default)
		{
			var card = await _cardsRepository.GetById(id, cancellationToken);
			if (card is null) 
			{
				throw new Exception("oops, card not found!");
			}
			return card;
		}

		public async Task UpdateAsync(int id, FifaCardDTO fifaCard, SkillsDTO skills, CancellationToken cancellationToken = default)
		{
			Skills skills1 = new Skills(skills);
			FifaCard card = await GetByIdAsync(id, cancellationToken);
			if (card is null) 
			{
				throw new Exception("oops, card not found!");
			}
			card.Name = fifaCard.Name;
			card.Position = fifaCard.Position;
			card.Skills = skills1;
			await _cardsRepository.UpdateAsync(card, cancellationToken);
		}
	}
}
