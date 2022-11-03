using Core.Entities.Computer;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeRep.ViewModels;

namespace WeeRep.Controllers
{
    public class ComputerController : Controller
    {
        private IUnitOfWork<CpmputerReparationPrice> _CpmputerReparationPrice;
        public ComputerController(IUnitOfWork<CpmputerReparationPrice> CpmputerReparationPrice)
        {
            _CpmputerReparationPrice = CpmputerReparationPrice;
     
        }

        public IActionResult Computer()
        {
            HomeViweModel model = new HomeViweModel()
            {
                CpmputerReparationPrice = _CpmputerReparationPrice.Entity.GetAll().ToList(),
            };
            return View(model);
        }
    }
}
