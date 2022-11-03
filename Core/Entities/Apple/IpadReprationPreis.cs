using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Apple
{
     public class IpadReprationPreis : BassesPhoneClass
    {
       

        public string Skærm { get; set; }
        public string P_Skærm { get; set; }

        public string SkærmLcd { get; set; }
        public string P_SkærmLcd { get; set; } 
        
        public string Panserglas { get; set; }
        public string P_Panserglas { get; set; }

        public string Batteri { get; set; }
        public string P_Batteri { get; set; }

        public string Tænd_Sluk  { get; set; }
        public string P_Tænd_Sluk  { get; set; }


        public string SIM_KORT { get; set; }
        public string P_SIM_KORT { get; set; }

        public string FrontKamera { get; set; }
        public string P_FrontKamera { get; set; } 
        
        public string Bagcover { get; set; }
        public string P_Bagcover { get; set; }  
        
        public string Kamera_Glas { get; set; }
        public string P_Kamera_Glas { get; set; }

        public string Bagkamera { get; set; }
        public string P_Bagkamera { get; set; }

        public string Home_Knap { get; set; }
        public string P_Home_Knap { get; set; }

        public string Højtale { get; set; }
        public string P_Højtale { get; set; }

        public string Ladestik { get; set; }
        public string P_Ladestik { get; set; }

        public string WIFI_Antenne { get; set; }
        public string P_WIFI_Antenne { get; set; }

        public string Antenne { get; set; }
        public string P_Antenne { get; set; }

        public string Fejlfinding { get; set; }
        public string P_Fejlfinding { get; set; }

      
    }
}
