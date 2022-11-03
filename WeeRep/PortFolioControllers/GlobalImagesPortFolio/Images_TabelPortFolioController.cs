using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using System.IO;
using Core.Entities;
using WeeRep.Models.GlobalImages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.GlobalImagesPortFolio
{
    [Authorize]

    public class Images_TabelPortFolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<Images_Tabel> _Images_Tabel;
        [Obsolete]
        public Images_TabelPortFolioController(IUnitOfWork<Images_Tabel> Images_Tabel, IHostingEnvironment hosting)
        {
            _Images_Tabel = Images_Tabel;
            _hosting = hosting;

        }

        // GET: ImacPortFolio
        public IActionResult Index()
        {
            return View(_Images_Tabel.Entity.GetAll());
        }

        // GET: ImacPortFolio/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Images_Tabel = _Images_Tabel.Entity.GetById(id);
            if (Images_Tabel == null)
            {
                return NotFound();
            }
            GlobalImagesModel GlobalImagesModel = new GlobalImagesModel()
            {
                ID = Images_Tabel.ID,
                ImageName = Images_Tabel.ImageName,

            };
            return View(GlobalImagesModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, GlobalImagesModel model)
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
                    Images_Tabel imacRepartion = new Images_Tabel()
                    {
                        ID = model.ID,
                        ImageName = ImageUrl,
                    };
                    _Images_Tabel.Entity.Update(imacRepartion);
                    _Images_Tabel.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Images_TabelExists(model.ID))
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

        private bool Images_TabelExists(int id)
        {
            return _Images_Tabel.Entity.GetAll().Any(e => e.ID == id);
        }
        //Uplod File from file and Database
        string SaveImageFile(IFormFile imageFile, string currentImage)
        {
            if (imageFile != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\GlaobalImages");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

               
                return fileName;
            }
            return currentImage;

        }
    }
}
