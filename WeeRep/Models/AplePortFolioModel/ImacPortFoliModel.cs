using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeeRep.Models.AplePortFolioModel
{
    public class ImacPortFoliModel
    {
        public int ID { get; set; }
        [Required]

        public string PhoneName { get; set; }
        public string ImageName { get; set; }
        public IFormFile File { get; set; }

        public string Skærm { get; set; }
        public string P_Skærm { get; set; }

        public string Skærm_B { get; set; }
        public string P_Skærm_B { get; set; }

        public string Batteri { get; set; }
        public string P_Batteri { get; set; }

        public string Bagglas { get; set; }
        public string P_Bagglas { get; set; }

        public string Bagglas_Ramme { get; set; }
        public string P_Bagglas_Ramme { get; set; }

        public string ØreHøjtale { get; set; }
        public string P_ØreHøjtale { get; set; }

        public string front_Kamera { get; set; }
        public string P_front_Kamera { get; set; }

        public string Bakkamera { get; set; }
        public string P_Bakkamera { get; set; }

        public string Ladestik { get; set; }
        public string P_Ladestik { get; set; }

        public string Vibrator { get; set; }
        public string P_Vibrator { get; set; }

        public string Højtale { get; set; }
        public string P_Højtale { get; set; }

        public string Tænd_Sluk { get; set; }
        public string P_Tænd_Sluk { get; set; }

        public string Volume_Lydløs { get; set; }
        public string P_Volume_Lydløs { get; set; }

        public string Fejlfinding { get; set; }
        public string P_Fejlfinding { get; set; }
    }
}
