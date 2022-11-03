using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace WeeRep.Models.AplePortFolioModel
{
    public class AppleWatchPortFolioModel
    {
        public int ID { get; set; }
        [Required]
        public string PhoneName { get; set; }
        public string ImageName { get; set; }
        public IFormFile File { get; set; }
        public string Skærm_A { get; set; }
        public string P_Skærm_A { get; set; }

        public string Skærm_B { get; set; }
        public string P_Skærm_B { get; set; }

        public string Skærm_C { get; set; }
        public string P_Skærm_C { get; set; }

        public string Skærm_D { get; set; }
        public string P_Skærm_D { get; set; }

        public string Batteri_A { get; set; }
        public string P_Batteri_A { get; set; }

        public string Batteri_B { get; set; }
        public string P_Batteri_B { get; set; }

        public string Fejlfinding { get; set; }
        public string p_Fejlfinding { get; set; }
    }
}
