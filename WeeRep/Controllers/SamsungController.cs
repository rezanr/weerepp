using Core.Entities;
using Core.Entities.Samsung;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WeeRep.ViewModels;

namespace WeeRep.Controllers
{
    public class SamsungController : Controller
    {
        private IUnitOfWork<Images_Tabel> _Images;
        private IUnitOfWork<Galaxy_A_Serien> _Galaxy_A_Serien;
        private IUnitOfWork<Galaxy_J_Serien> _Galaxy_J_Serien;
        private IUnitOfWork<Galaxy_S_Serien> _Galaxy_S_Serien;
        private IUnitOfWork<GalaxyNoteSerien> _GalaxyNoteSerien;
        private IUnitOfWork<Galaxy_Xcover_Serien> _Galaxy_Xcover_Serien;

        public SamsungController(
                IUnitOfWork<Galaxy_A_Serien> Galaxy_A_Serien,
                IUnitOfWork<Galaxy_J_Serien> Galaxy_J_Serien,
                IUnitOfWork<Galaxy_S_Serien> Galaxy_S_Serien,
                IUnitOfWork<GalaxyNoteSerien> GalaxyNoteSerien,
                IUnitOfWork<Galaxy_Xcover_Serien> Galaxy_Xcover_Serien,
                IUnitOfWork<Images_Tabel> Images

                )
        {
            _Images = Images;
            _Galaxy_A_Serien = Galaxy_A_Serien;
            _Galaxy_J_Serien = Galaxy_J_Serien;
            _Galaxy_S_Serien = Galaxy_S_Serien;
            _GalaxyNoteSerien = GalaxyNoteSerien;
            _Galaxy_Xcover_Serien = Galaxy_Xcover_Serien;
        }
        public IActionResult Samsung()
        {
            HomeViweModel model = new HomeViweModel()
            {
                Images = _Images.Entity.GetAll().ToList(),
            };
            return View(model);
        }
        public IActionResult Galaxy_S()
        {
            HomeViweModel S_model = new HomeViweModel()
            {
                Galaxy_S_Serien = _Galaxy_S_Serien.Entity.GetAll().ToList(),
            };
            return View(S_model);
        }
        public IActionResult Galaxy_Note()
        {
            HomeViweModel Note_model = new HomeViweModel()
            {
                GalaxyNoteSerien = _GalaxyNoteSerien.Entity.GetAll().ToList(),
            };
            return View(Note_model);
        }
        public IActionResult Galaxy_A()
        {
            HomeViweModel A_model = new HomeViweModel()
            {
                Galaxy_A_Serien = _Galaxy_A_Serien.Entity.GetAll().ToList(),
            };
            return View(A_model);
        }
        public IActionResult Galaxy_J()
        {
            HomeViweModel J_model = new HomeViweModel()
            {
                Galaxy_J_Serien = _Galaxy_J_Serien.Entity.GetAll().ToList(),
            };
            return View(J_model);
        }
        public IActionResult X_Conver()
        {
            HomeViweModel X_model = new HomeViweModel()
            {
                Galaxy_Xcover_Serien = _Galaxy_Xcover_Serien.Entity.GetAll().ToList(),
            };
            return View(X_model);
        }
    }
}
