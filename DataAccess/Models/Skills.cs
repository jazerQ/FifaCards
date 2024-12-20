using DataAccess.Models.DTO;
using System.Text.Json.Serialization;

namespace DataAccess
{
	public class Skills
	{
		public Skills(SkillsDTO skills) 
		{
			this.Dribling = skills.Dribling;
			this.Defence = skills.Defence;
			this.HeadGame = skills.HeadGame;
			this.Pace = skills.Pace;
			this.Pas = skills.Pas;
			this.Shoot = skills.Shoot;
		}
		public int Id { get; set; }
		public int CardId { get; set; }
		public int Overall { get; set; }
		public int Pace { get; set; }
		public int Shoot { get; set; }
		public int Pas { get; set; }
		public int Dribling { get; set; }
		public int Defence { get; set; }
		public int HeadGame { get; set; }
		public FifaCard Card { get; set; } = null!;
	}
}
