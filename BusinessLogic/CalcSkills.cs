using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class CalcSkills 
	{
		private Skills _skills { get; set; }
		public CalcSkills(Skills skills) 
		{
			_skills = skills;
		}
		public void CalcOverall() 
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
