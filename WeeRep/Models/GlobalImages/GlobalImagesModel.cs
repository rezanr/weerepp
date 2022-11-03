using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeeRep.Models.GlobalImages
{
    public class GlobalImagesModel
    {
        public int ID { get; set; }
        [Required]
        public string ImageName { get; set; }
        public IFormFile File { get; set; }

    }
}
