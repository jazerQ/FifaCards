using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.DTO
{
    public class CreateCardRequest
    {
        public FifaCardDTO FifaCard { get; set; }
        public SkillsDTO skills { get; set; }
    }
}
