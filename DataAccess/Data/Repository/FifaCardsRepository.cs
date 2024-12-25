using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Repository
{
	internal class FifaCardsRepository(FifaContext _context) : IFifaCardsRepository
	{
		
		/*public FifaCardsRepository(FifaContext context) 
		{
			_context = context;
		}*/
		public async Task CreateAsync(FifaCard card, CancellationToken cancellationToken = default)
		{
			await _context.Cards.AddAsync(card, cancellationToken);
			await _context.SaveChangesAsync(cancellationToken);
		}

		public async Task<FifaCard?> GetById(int id, CancellationToken cancellationToken = default)
		{
			var Card = await _context.Cards.Include(c => c.Skills).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

			return Card;
		}

		public async Task UpdateAsync(FifaCard card, CancellationToken cancellationToken = default)
		{
			Console.WriteLine($"{card.Skills.Id}   {card.Skills.CardId}   {card.Skills.Overall}  {card.Skills.Dribling} {card.Skills.Defence}");
			_context.Cards.Update(card);
			await _context.SaveChangesAsync(cancellationToken);
		}
		public async Task DeleteAsync(FifaCard card, CancellationToken cancellationToken = default) 
		{
			_context.Cards.Remove(card);
			await _context.SaveChangesAsync(cancellationToken);
		}
	}
}
