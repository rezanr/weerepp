using Core.Entities;
using Core.Entities.Sony;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeRep.ViewModels;

namespace WeeRep.Controllers
{
    public class SonyController : Controller
    {
        private IUnitOfWork<Images_Tabel> _Images;
        private IUnitOfWork<Xperia_X_Serien> _Xperia_X_Serien;
        private IUnitOfWork<Xperia_Z_Serien> _Xperia_Z_Serien;
        private IUnitOfWork<XperiaTopModeller> _XperiaTopModeller;
 

        public SonyController(
                IUnitOfWork<Xperia_X_Serien> Xperia_X_Serien,
                IUnitOfWork<Xperia_Z_Serien> Xperia_Z_Serien,
                IUnitOfWork<XperiaTopModeller> XperiaTopModeller,
                IUnitOfWork<Images_Tabel> Images

                )
        {
            _Images = Images;
            _Xperia_X_Serien = Xperia_X_Serien;
            _Xperia_Z_Serien = Xperia_Z_Serien;
            _XperiaTopModeller = XperiaTopModeller;
        }
        public IActionResult Sony()
        {
            HomeViweModel model = new HomeViweModel()
            {
                Images = _Images.Entity.GetAll().ToList(),
            };
            return View(model);
        }

        public IActionResult SonyXperia_X()
        {
            HomeViweModel model = new HomeViweModel()
            {
                Xperia_X_Serien = _Xperia_X_Serien.Entity.GetAll().ToList(),
            };
            return View(model);
        }

        public IActionResult SonyXperia_Z()
        {
            HomeViweModel model = new HomeViweModel()
            {
                Xperia_Z_Serien = _Xperia_Z_Serien.Entity.GetAll().ToList(),
            };
            return View(model);
        }

        public IActionResult SonyXperia_Top()
        {
            HomeViweModel model = new HomeViweModel()
            {
                XperiaTopModeller = _XperiaTopModeller.Entity.GetAll().ToList(),
            };
            return View(model);
        }
    }
}
