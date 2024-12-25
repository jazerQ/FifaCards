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
			Skills skills1 = new Skills();
			CalcSkills.SetSkillFromSkillsDTO(ref skills1, skills);
			Console.WriteLine($"ID - {skills1.Id}\nCardId - {skills1.CardId}\nOverall - {skills1.Overall}\nPace - {skills1.Pace}\nPas - {skills1.Pas}");
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
			var card = await GetByIdAsync(id, cancellationToken);
			if (card == null) 
			{
				throw new Exception("Card NOT found!");
			}
			card.Name = fifaCard.Name;
			card.Position = fifaCard.Position;
			if (card.Skills != null) 
			{
				var skill = card.Skills;
				CalcSkills.SetSkillFromSkillsDTO(ref skill, skills);
				card.Skills = skill;
			}
			else
			{
				var skill = new Skills();
				CalcSkills.SetSkillFromSkillsDTO(ref skill, skills, id);
				card.Skills = skill;
			}
			await _cardsRepository.UpdateAsync(card, cancellationToken);
		}
		public async Task DeleteAsync(int id, CancellationToken cancellationToken) 
		{
			var card = await GetByIdAsync(id, cancellationToken);
			if(card == null) 
			{
				throw new Exception("Card not Found!");
			}
			await _cardsRepository.DeleteAsync(card, cancellationToken);
		}
	}
}
