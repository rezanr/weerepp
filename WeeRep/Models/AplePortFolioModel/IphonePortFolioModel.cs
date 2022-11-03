using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeeRep.Models.AplePortFolioModel
{
    public class IphonePortFolioModel
    {
        public int ID { get; set; }
        [Required]

        public string PhoneName { get; set; }
        public string ImageName { get; set; }
        public IFormFile File { get; set; }

        public string SkærmOEM { get; set; }
        public string P_SkærmOEM { get; set; }

        public string SkærmOrgnal { get; set; }
        public string P_SkærmOrgnal { get; set; }

        public string Batteri { get; set; }
        public string P_Batteri { get; set; }

        public string Bagglas { get; set; }
        public string P_Bagglas { get; set; }

        public string BagglasOgRamme { get; set; }
        public string P_BagglasOgRamme { get; set; }

        public string Ørehøjtaler { get; set; }
        public string P_Ørehøjtaler { get; set; }

        public string FrontKameraNærhedsensor { get; set; }
        public string P_FrontKameraNærhedsensor { get; set; }

        public string Bagkamera { get; set; }
        public string P_Bagkamera { get; set; }

        public string Ladestik { get; set; }
        public string P_Ladestik { get; set; }

        public string Højtale { get; set; }
        public string P_Højtale { get; set; }

        public string Vibrator { get; set; }
        public string P_Vibrator { get; set; }

        public string TændSluk { get; set; }
        public string P_TændSluk { get; set; }

        public string VolumeLydløs { get; set; }
        public string P_VolumeLydløs { get; set; }

        public string Fejlfinding { get; set; }
        public string P_Fejlfinding { get; set; }
    }
}
