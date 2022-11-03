using Core.Entities.Oneplus;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeRep.ViewModels;

namespace WeeRep.Controllers
{
    public class OneplusController : Controller
    {
        private IUnitOfWork<OneplusReparation> _OneplusReparation;

        public OneplusController(IUnitOfWork<OneplusReparation> OneplusReparation)
        {
            _OneplusReparation = OneplusReparation;
        }
        public IActionResult Oneplus()
        {
            HomeViweModel model = new HomeViweModel()
            {
                OneplusReparation = _OneplusReparation.Entity.GetAll().ToList(),
            };
            return View(model);
        }
    }
}
