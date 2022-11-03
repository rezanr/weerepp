using Core.Entities;
using Core.Entities.Huawei;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeRep.ViewModels;

namespace WeeRep.Controllers
{
    public class HuaweiController : Controller
    {
        private IUnitOfWork<Images_Tabel> _Images;
        private IUnitOfWork<Huawei_P_Serien> _Huawei_P_Serien;
        private IUnitOfWork<Huawei_Mate_Serien> _Huawei_Mate_Serien;
        public HuaweiController(
            IUnitOfWork<Huawei_P_Serien> Huawei_P_Serien,
            IUnitOfWork<Huawei_Mate_Serien> Huawei_Mate_Serien,
            IUnitOfWork<Images_Tabel> Images
       )
        {
            _Images = Images;
            _Huawei_P_Serien = Huawei_P_Serien;
            _Huawei_Mate_Serien = Huawei_Mate_Serien;
        }
        public IActionResult Huawei()
        {
            HomeViweModel model = new HomeViweModel()
            {
                Images = _Images.Entity.GetAll().ToList(),
            };
            return View(model);
        }
        public IActionResult Huawei_P()
        {
            HomeViweModel model = new HomeViweModel()
            {
                Huawei_P_Serien = _Huawei_P_Serien.Entity.GetAll().ToList(),
            };
            return View(model);
        }
        public IActionResult Huawei_Mate()
        {
            HomeViweModel model = new HomeViweModel()
            {
                Huawei_Mate_Serien = _Huawei_Mate_Serien.Entity.GetAll().ToList(),
            };
            return View(model);
        }
    }
}
