using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeeRep.Models.AplePortFolioModel
{
    public class MacbookPortFolioModel
    {
        public int ID { get; set; }
        [Required]

        public string PhoneName { get; set; }
        public string ImageName { get; set; }
        public IFormFile File { get; set; }

        public string Skærm { get; set; }
        public string P_Skærm { get; set; }

        public string Tastetur { get; set; }
        public string P_Tastetur { get; set; }

        public string Batteri { get; set; }
        public string P_Batteri { get; set; }

        public string Styresystem { get; set; }
        public string P_Styresystem { get; set; }

        public string TrackPad { get; set; }
        public string P_TrackPad { get; set; }

        public string Højtale { get; set; }
        public string P_Højtale { get; set; }

        public string Blæser { get; set; }
        public string P_Blæser { get; set; }

        public string Ladestik { get; set; }
        public string P_Ladestik { get; set; }

        public string Bundplade { get; set; }
        public string P_Bundplade { get; set; }

        public string Fejlfinding { get; set; }
        public string P_Fejlfinding { get; set; }
    }
}
