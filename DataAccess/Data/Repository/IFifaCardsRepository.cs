using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Repository
{
	public interface IFifaCardsRepository
	{
		Task CreateAsync(FifaCard card, CancellationToken cancellationToken = default);
		Task<FifaCard?> GetById(int id, CancellationToken cancellationToken = default);
	}
}
