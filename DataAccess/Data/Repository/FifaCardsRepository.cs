using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Repository
{
	internal class FifaCardsRepository(FifaContext context) : IFifaCardsRepository
	{
		
		/*public FifaCardsRepository(FifaContext context) 
		{
			_context = context;
		}*/
		public async Task CreateAsync(FifaCard card, CancellationToken cancellationToken = default)
		{
			await context.Cards.AddAsync(card, cancellationToken);
			await context.SaveChangesAsync(cancellationToken);
		}

		public async Task<FifaCard?> GetById(int id, CancellationToken cancellationToken = default)
		{
			var Card = await context.Cards.FirstOrDefaultAsync(x => x.Id == id);

			return Card;
		}
	}
}
