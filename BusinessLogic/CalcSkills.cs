using DataAccess;
using DataAccess.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public static class CalcSkills 
	{
		public static void SetSkillFromSkillsDTO(ref Skills skills, SkillsDTO skillsDTO) 
		{
			skills.Dribling = skillsDTO.Dribling;
			skills.Defence = skillsDTO.Defence;
			skills.HeadGame = skillsDTO.HeadGame;
			skills.Pace = skillsDTO.Pace;
			skills.Pas = skillsDTO.Pas;
			skills.Shoot = skillsDTO.Shoot;
			CalcOverall(ref skills);
		}
		public static void SetSkillFromSkillsDTO(ref Skills skills, SkillsDTO skillsDTO, int id)
		{
			skills.CardId = id;
			skills.Dribling = skillsDTO.Dribling;
			skills.Defence = skillsDTO.Defence;
			skills.HeadGame = skillsDTO.HeadGame;
			skills.Pace = skillsDTO.Pace;
			skills.Pas = skillsDTO.Pas;
			skills.Shoot = skillsDTO.Shoot;
			CalcOverall(ref skills);
		}
		public static void CalcOverall(ref Skills _skills) 
		{
			int SumOfSkills = _skills.Pace + _skills.HeadGame + _skills.Pas + _skills.Defence + _skills.Dribling + _skills.Shoot;
			_skills.Overall = (int) Math.Round(SumOfSkills / 5.5);
		}
	}
	
}

/*public int Pace { get; set; }
public int Shoot { get; set; }
public int Pas { get; set; }
public int Dribling { get; set; }
public int Defence { get; set; }
public int HeadGame { get; set; }*/
