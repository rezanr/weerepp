using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Computer;
using Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using WeeRep.Models.ComputerPortFolio;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.ComputerPortFolioItem
{
    [Authorize]

    public class CpmputerPortFolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<CpmputerReparationPrice> _CpmputerReparationPrice;
        [Obsolete]
        public CpmputerPortFolioController(IUnitOfWork<CpmputerReparationPrice> CpmputerReparationPrice, IHostingEnvironment hosting)
        {
            _CpmputerReparationPrice = CpmputerReparationPrice;
            _hosting = hosting;

        }

        // GET: CpmputerReparation
        public IActionResult Index()
        {
            return View(_CpmputerReparationPrice.Entity.GetAll());
        }

        // GET: CpmputerReparation/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CpmputerReparationPrice = _CpmputerReparationPrice.Entity.GetById(id);

            if (CpmputerReparationPrice == null)
            {
                return NotFound();
            }

            return View(CpmputerReparationPrice);
        }

        // GET: CpmputerReparation/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CpmputerReparation/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CpmputerPortFolioModel model)
        {
            if (ModelState.IsValid)
            {
                //Create File
                string ImageUrl = UploadFile(model.File);
                if (ImageUrl == null)
                {
                    return View();

                }

                CpmputerReparationPrice CpmputerReparationPrice = new CpmputerReparationPrice()
                {

                    PhoneName = model.PhoneName,
                    ImageName = ImageUrl,
                    Ydelse_A = model.Ydelse_A,
                    Pris_A = model.Pris_A,
                    Ydelse_C = model.Ydelse_C,
                    Pris_C = model.Pris_C,
                    Ydelse_D = model.Ydelse_D,
                    Pris_D = model.Pris_D,
                    Ydelse_B = model.Ydelse_B,
                     Pris_B = model. Pris_B,
                    Ydelse_E = model.Ydelse_E,
                    Pris_E = model.Pris_E,
                    Ydelse_F = model.Ydelse_F,
                    Pris_F = model.Pris_F,
                    Ydelse_G = model.Ydelse_G,
                    Pris_G = model.Pris_G,
                    Ydelse_H = model.Ydelse_H,
                    Pris_H = model.Pris_H,
                    Ydelse_I = model.Ydelse_I,
                    Pris_I = model.Pris_I,
                    Ydelse_K = model.Ydelse_K,
                    Pris_K = model.Pris_K,
                    Ydelse_L = model.Ydelse_L,
                    Pris_L = model.Pris_L,
                    Ydelse_M = model.Ydelse_M,
                    Pris_M = model.Pris_M,
 
                };
                _CpmputerReparationPrice.Entity.Insert(CpmputerReparationPrice);
                _CpmputerReparationPrice.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: CpmputerReparation/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CpmputerReparationPrice = _CpmputerReparationPrice.Entity.GetById(id);
            if (CpmputerReparationPrice == null)
            {
                return NotFound();
            }
            CpmputerPortFolioModel CpmputerPortFolioModel = new CpmputerPortFolioModel()
            {
                ID = CpmputerReparationPrice.ID,
                PhoneName = CpmputerReparationPrice.PhoneName,
                ImageName = CpmputerReparationPrice.ImageName,
                Ydelse_A = CpmputerReparationPrice.Ydelse_A,
                Pris_A = CpmputerReparationPrice.Pris_A,
                Ydelse_B = CpmputerReparationPrice.Ydelse_B,
                 Pris_B = CpmputerReparationPrice. Pris_B,
                Ydelse_C = CpmputerReparationPrice.Ydelse_C,
                Pris_C = CpmputerReparationPrice.Pris_C,
                Ydelse_D = CpmputerReparationPrice.Ydelse_D,
                Pris_D = CpmputerReparationPrice.Pris_D,
                Ydelse_E = CpmputerReparationPrice.Ydelse_E,
                Pris_E = CpmputerReparationPrice.Pris_E,
                Ydelse_F = CpmputerReparationPrice.Ydelse_F,
                Pris_F = CpmputerReparationPrice.Pris_F,
                Ydelse_G = CpmputerReparationPrice.Ydelse_G,
                Pris_G = CpmputerReparationPrice.Pris_G,
                Ydelse_H = CpmputerReparationPrice.Ydelse_H,
                Pris_H = CpmputerReparationPrice.Pris_H,
                Ydelse_I = CpmputerReparationPrice.Ydelse_I,
                Pris_I = CpmputerReparationPrice.Pris_I,
                Ydelse_K = CpmputerReparationPrice.Ydelse_K,
                Pris_K = CpmputerReparationPrice.Pris_K,
                Ydelse_L = CpmputerReparationPrice.Ydelse_L,
                Pris_L = CpmputerReparationPrice.Pris_L,
                Ydelse_M = CpmputerReparationPrice.Ydelse_M,
                Pris_M = CpmputerReparationPrice.Pris_M,
           
            };
            return View(CpmputerPortFolioModel);
        }

        // POST: CpmputerReparation/Edit/5
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, CpmputerPortFolioModel model)
        {
            if (id != model.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //Creat File
                    string ImageUrl = SaveImageFile(model.File, model.ImageName);
                    CpmputerReparationPrice imacRepartion = new CpmputerReparationPrice()
                    {
                        ID = model.ID,
                        PhoneName = model.PhoneName,
                        ImageName = ImageUrl,
                        Ydelse_A = model.Ydelse_A,
                        Pris_A = model.Pris_A,
                        Ydelse_B = model.Ydelse_B,
                         Pris_B = model. Pris_B,
                        Ydelse_C = model.Ydelse_C,
                        Pris_C = model.Pris_C,
                        Ydelse_D = model.Ydelse_D,
                        Pris_D = model.Pris_D,
                        Ydelse_E = model.Ydelse_E,
                        Pris_E = model.Pris_E,
                        Ydelse_F = model.Ydelse_F,
                        Pris_F = model.Pris_F,
                        Ydelse_G = model.Ydelse_G,
                        Pris_G = model.Pris_G,
                        Ydelse_H = model.Ydelse_H,
                        Pris_H = model.Pris_H,
                        Ydelse_I = model.Ydelse_I,
                        Pris_I = model.Pris_I,
                        Ydelse_K = model.Ydelse_K,
                        Pris_K = model.Pris_K,
                        Ydelse_L = model.Ydelse_L,
                        Pris_L = model.Pris_L,
                        Ydelse_M = model.Ydelse_M,
                        Pris_M = model.Pris_M,
                       
                    };
                    _CpmputerReparationPrice.Entity.Update(imacRepartion);
                    _CpmputerReparationPrice.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CpmputerReparationPriceExists(model.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: CpmputerReparation/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CpmputerReparationPrice = _CpmputerReparationPrice.Entity.GetById(id);

            if (CpmputerReparationPrice == null)
            {
                return NotFound();
            }

            return View(CpmputerReparationPrice);
        }

        // POST: CpmputerReparation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _CpmputerReparationPrice.Entity.Delete(id);
            _CpmputerReparationPrice.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool CpmputerReparationPriceExists(int id)
        {
            return _CpmputerReparationPrice.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Computer");
                string fileName = Guid.NewGuid().ToString() + "-" + file.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                file.CopyTo(new FileStream(fullPath, FileMode.Create));

                return fileName;
            }

            return null;
        }

        //Uplod File from file and Database
        string SaveImageFile(IFormFile imageFile, string currentImage)
        {
            if (imageFile != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Computer");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Computer\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
