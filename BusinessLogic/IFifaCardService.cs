using DataAccess;
using DataAccess.Models.DTO;

namespace BusinessLogic
{
	public interface IFifaCardService
	{
		Task CreateAsync(FifaCardDTO FifaCard, SkillsDTO skills, CancellationToken cancellationToken = default);
		Task<FifaCard> GetByIdAsync(int id, CancellationToken cancellationToken = default);
		Task UpdateAsync(int id, FifaCardDTO fifaCard, SkillsDTO skills, CancellationToken cancellationToken = default);
	}
}
