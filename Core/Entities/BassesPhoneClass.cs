using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
   public class BassesPhoneClass
    {
        public int ID { get; set; }
        public string PhoneName { get; set; }
        public string ImageName { get; set; }
    }
}
