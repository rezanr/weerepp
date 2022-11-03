using Core.Entities;
using Core.Entities.Motorola;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeRep.ViewModels;

namespace WeeRep.Controllers
{
    public class MotorolaController : Controller
    {
        private IUnitOfWork<Images_Tabel> _Images;
        private IUnitOfWork<Motorola_E_Serien> _Motorola_E_Serien;
        private IUnitOfWork<Motorola_G_Serien> _Motorola_G_Serien;
        private IUnitOfWork<MotorolaEdge_Serien> _MotorolaEdge_Serien;
        private IUnitOfWork<MotorolaOne_Serien> _MotorolaOne_Serien;

        public MotorolaController(
                IUnitOfWork<Motorola_E_Serien> Motorola_E_Serien,
                IUnitOfWork<Motorola_G_Serien> Motorola_G_Serien,
                IUnitOfWork<MotorolaEdge_Serien> MotorolaEdge_Serien,
                IUnitOfWork<MotorolaOne_Serien> MotorolaOne_Serien,
                 IUnitOfWork<Images_Tabel> Images
                )
        {
            _Images = Images;
            _Motorola_E_Serien = Motorola_E_Serien;
            _Motorola_G_Serien = Motorola_G_Serien;
            _MotorolaEdge_Serien = MotorolaEdge_Serien;
            _MotorolaOne_Serien = MotorolaOne_Serien;
        }
        public IActionResult Motorola()
        {
            HomeViweModel model = new HomeViweModel()
            {
                Images = _Images.Entity.GetAll().ToList(),
            };
            return View(model);
        }
        public IActionResult Motorola_E()
        {
            HomeViweModel S_model = new HomeViweModel()
            {
                Motorola_E_Serien = _Motorola_E_Serien.Entity.GetAll().ToList(),
            };
            return View(S_model);
        }
        public IActionResult Motorola_G()
        {
            HomeViweModel S_model = new HomeViweModel()
            {
                Motorola_G_Serien = _Motorola_G_Serien.Entity.GetAll().ToList(),
            };
            return View(S_model);
        }
        public IActionResult MotorolaEdge()
        {
            HomeViweModel S_model = new HomeViweModel()
            {
                MotorolaEdge_Serien = _MotorolaEdge_Serien.Entity.GetAll().ToList(),
            };
            return View(S_model);
        }
        public IActionResult MotorolaOne()
        {
            HomeViweModel S_model = new HomeViweModel()
            {
                MotorolaOne_Serien = _MotorolaOne_Serien.Entity.GetAll().ToList(),
            };
            return View(S_model);
        }
    }
}
