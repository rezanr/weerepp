
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace WeeRep.Models.ComputerPortFolio

{
    public class CpmputerPortFolioModel 
    {
        public int ID { get; set; }
        [Required]

        public string PhoneName { get; set; }
        public string ImageName { get; set; }
        public IFormFile File { get; set; }

        public string Ydelse_A { get; set; }
        public string Pris_A { get; set; }

        public string Ydelse_B { get; set; }
        public string Pris_B { get; set; }

        public string Ydelse_C { get; set; }
        public string Pris_C { get; set; }

        public string Ydelse_D { get; set; }
        public string Pris_D { get; set; }

        public string Ydelse_E { get; set; }
        public string Pris_E { get; set; }

        public string Ydelse_F { get; set; }
        public string Pris_F { get; set; }

        public string Ydelse_G { get; set; }
        public string Pris_G { get; set; }

        public string Ydelse_H { get; set; }
        public string Pris_H { get; set; }

        public string Ydelse_I { get; set; }
        public string Pris_I { get; set; }

        public string Ydelse_K { get; set; }
        public string Pris_K { get; set; }

        public string Ydelse_L { get; set; }
        public string Pris_L { get; set; }

        public string Ydelse_M { get; set; }
        public string Pris_M { get; set; }



    }
}
