using Core.Entities;
using Core.Entities.Apple;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeRep.ViewModels;

namespace WeeRep.Controllers
{
    public class AppleController : Controller
    {
        private IUnitOfWork<Images_Tabel> _Images;
        private IUnitOfWork<IphoneReprationPreis> _IphoneReprationPreic;
        private IUnitOfWork<AppleWatchReprationPreis> _AppleWatchReprationPreis;
        private IUnitOfWork<MacbookReparation> _MacbookReparation;
        private IUnitOfWork<ImacReparation> _ImacReparation;
        private IUnitOfWork<IpadReprationPreis> _IpadReprationPreis;

        public AppleController(
            IUnitOfWork<IphoneReprationPreis> IphoneReprationPreis,
            IUnitOfWork<AppleWatchReprationPreis> AppleWatchReprationPreis,
            IUnitOfWork<ImacReparation> ImacReparation,
            IUnitOfWork<MacbookReparation> MacbookReparation,
            IUnitOfWork<IpadReprationPreis> IpadReprationPreis,
            IUnitOfWork<Images_Tabel> Images)
        {
            _Images = Images;
            _IphoneReprationPreic = IphoneReprationPreis;
            _AppleWatchReprationPreis = AppleWatchReprationPreis;
            _ImacReparation = ImacReparation;
            _MacbookReparation = MacbookReparation;
            _IpadReprationPreis = IpadReprationPreis;

        }

        public IActionResult Apple()
        {
            HomeViweModel model = new HomeViweModel()
            {
                Images = _Images.Entity.GetAll().ToList(),
            };
            return View(model);
        }

        public IActionResult IphoneReparationPric()
        {
            HomeViweModel Iphonemodel = new HomeViweModel()
            {
                IphoneReprationPreis = _IphoneReprationPreic.Entity.GetAll().ToList(),
            };
            return View(Iphonemodel);
        }

        public IActionResult AppleWatchReparationPric()
        {
            HomeViweModel Watchmodel = new HomeViweModel()
            {
                AppleWatchReprationPreis = _AppleWatchReprationPreis.Entity.GetAll().ToList(),
            };
            return View(Watchmodel);
        }

        public IActionResult IpadReparationPrisc()
        {
            HomeViweModel Ipadmodel = new HomeViweModel()
            {
                IpadReprationPreis = _IpadReprationPreis.Entity.GetAll().ToList(),
            };
            return View(Ipadmodel);
        }

        public IActionResult MacBookReparationPrisc()
        {
            HomeViweModel Macbmodel = new HomeViweModel()
            {
                MacbookReparation = _MacbookReparation.Entity.GetAll().ToList(),
            };
            return View(Macbmodel);
        }

        public IActionResult ImacReparationPrisc()
        {
            HomeViweModel Imacmodel = new HomeViweModel()
            {
                ImacReparation = _ImacReparation.Entity.GetAll().ToList(),
            };
            return View(Imacmodel);
        }


    }
}
