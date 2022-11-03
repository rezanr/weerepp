using Core.Entities.Nokia;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeRep.ViewModels;

namespace WeeRep.Controllers
{
    public class NokiaController : Controller
    {
        private IUnitOfWork<NokiaRepartionPrice> _NokiaRepartionPrice;

        public NokiaController(IUnitOfWork<NokiaRepartionPrice> NokiaRepartionPrice)
        {
            _NokiaRepartionPrice = NokiaRepartionPrice;
        }
        public IActionResult Nokia()
        {
            HomeViweModel model = new HomeViweModel()
            {
                NokiaRepartionPrice = _NokiaRepartionPrice.Entity.GetAll().ToList(),
            };
            return View(model);
        }
    }
}
