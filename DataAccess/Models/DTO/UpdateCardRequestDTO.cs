using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.DTO
{
	public class UpdateCardRequestDTO
	{
		public int Id { get; set; }
		public FifaCardDTO FifaCard { get; set; }
		public SkillsDTO skills { get; set; }
	}
}
