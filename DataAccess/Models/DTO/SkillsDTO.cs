using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.DTO
{
	public class SkillsDTO
	{
		public int Overall { get; set; }
		public int Pace { get; set; }
		public int Shoot { get; set; }
		public int Pas { get; set; }
		public int Dribling { get; set; }
		public int Defence { get; set; }
		public int HeadGame { get; set; }
		public FifaCardDTO Card { get; set; } = null!;
	}
}
