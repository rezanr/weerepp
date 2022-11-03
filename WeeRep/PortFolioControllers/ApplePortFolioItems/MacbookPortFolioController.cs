using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Apple;
using Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using System.IO;
using WeeRep.Models.AplePortFolioModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.ApplePortFolioItems
{
    [Authorize]

    public class MacbookPortFolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<MacbookReparation> _MacbookReparation;

        [Obsolete]
        public MacbookPortFolioController(IUnitOfWork<MacbookReparation> MacbookReparation, IHostingEnvironment hosting)
        {
            _MacbookReparation = MacbookReparation;
            _hosting = hosting;

        }

        // GET:  MacbookPortFoli
        public IActionResult Index()
        {
            return View(_MacbookReparation.Entity.GetAll());
        }

        // GET:  MacbookPortFoli/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MacbookReparation = _MacbookReparation.Entity.GetById(id);

            if (MacbookReparation == null)
            {
                return NotFound();
            }

            return View(MacbookReparation);
        }

        // GET:  MacbookPortFoli/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST:  MacbookPortFoli/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MacbookPortFolioModel model)
        {
            if (ModelState.IsValid)
            {

                //Create File
                string ImageUrl = UploadFile(model.File);
                if (ImageUrl == null)
                {
                    return View();

                }
                MacbookReparation MacbookReparation = new MacbookReparation()
                {

                    PhoneName = model.PhoneName,
                    ImageName = ImageUrl,
                    Tastetur = model.Tastetur,
                    P_Tastetur = model.P_Tastetur,
                    Styresystem = model.Styresystem,
                    P_Styresystem = model.P_Styresystem,
                    Batteri = model.Batteri,
                    P_Batteri = model.P_Batteri,
                    TrackPad = model.TrackPad,
                    P_TrackPad = model.P_TrackPad,
                    Skærm = model.Skærm,
                    P_Skærm = model.P_Skærm,
                    Blæser = model.Blæser,
                    P_Blæser = model.P_Blæser,
                    Fejlfinding = model.Fejlfinding,
                    P_Fejlfinding = model.P_Fejlfinding,
                    Bundplade = model.Bundplade,
                    P_Bundplade = model.P_Bundplade,
                    Højtale = model.Højtale,
                    P_Højtale = model.P_Højtale,
                    Ladestik = model.Ladestik,
                    P_Ladestik = model.P_Ladestik,            

                };
                _MacbookReparation.Entity.Insert(MacbookReparation);
                _MacbookReparation.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }

        // GET:  MacbookPortFoli/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MacbookReparation = _MacbookReparation.Entity.GetById(id);
            if (MacbookReparation == null)
            {
                return NotFound();
            }
            MacbookPortFolioModel MacbookPortFolioModel = new MacbookPortFolioModel()
            {
                ID = MacbookReparation.ID,
                PhoneName = MacbookReparation.PhoneName,
                ImageName = MacbookReparation.ImageName,
                Tastetur = MacbookReparation.Tastetur,
                P_Tastetur = MacbookReparation.P_Tastetur,
                Styresystem = MacbookReparation.Styresystem,
                P_Styresystem = MacbookReparation.P_Styresystem,
                Batteri = MacbookReparation.Batteri,
                P_Batteri = MacbookReparation.P_Batteri,
                TrackPad = MacbookReparation.TrackPad,
                P_TrackPad = MacbookReparation.P_TrackPad,
                Skærm = MacbookReparation.Skærm,
                P_Skærm = MacbookReparation.P_Skærm,
                Blæser = MacbookReparation.Blæser,
                P_Blæser = MacbookReparation.P_Blæser,
                Fejlfinding = MacbookReparation.Fejlfinding,
                P_Fejlfinding = MacbookReparation.P_Fejlfinding,
                Bundplade = MacbookReparation.Bundplade,
                P_Bundplade = MacbookReparation.P_Bundplade,
                Højtale = MacbookReparation.Højtale,
                P_Højtale = MacbookReparation.P_Højtale,
                Ladestik = MacbookReparation.Ladestik,
                P_Ladestik = MacbookReparation.P_Ladestik,
          
            };
            return View(MacbookPortFolioModel);
        }

        // POST:  MacbookPortFoli/Edit/5
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, MacbookPortFolioModel model)
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
                    MacbookReparation imacRepartion = new MacbookReparation()
                    {
                        ID = model.ID,
                        PhoneName = model.PhoneName,
                        ImageName = ImageUrl,
                        Tastetur = model.Tastetur,
                        P_Tastetur = model.P_Tastetur,
                        Styresystem = model.Styresystem,
                        P_Styresystem = model.P_Styresystem,
                        Batteri = model.Batteri,
                        P_Batteri = model.P_Batteri,
                        TrackPad = model.TrackPad,
                        P_TrackPad = model.P_TrackPad,
                        Skærm = model.Skærm,
                        P_Skærm = model.P_Skærm,
                        Blæser = model.Blæser,
                        P_Blæser = model.P_Blæser,
                        Fejlfinding = model.Fejlfinding,
                        P_Fejlfinding = model.P_Fejlfinding,
                        Bundplade = model.Bundplade,
                        P_Bundplade = model.P_Bundplade,
                        Højtale = model.Højtale,
                        P_Højtale = model.P_Højtale,
                        Ladestik = model.Ladestik,
                        P_Ladestik = model.P_Ladestik,
                      
                    };
                    _MacbookReparation.Entity.Update(imacRepartion);
                    _MacbookReparation.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MacbookReparationExists(model.ID))
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

        // GET:  MacbookPortFoli/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MacbookReparation = _MacbookReparation.Entity.GetById(id);

            if (MacbookReparation == null)
            {
                return NotFound();
            }

            return View(MacbookReparation);
        }

        // POST:  MacbookPortFoli/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _MacbookReparation.Entity.Delete(id);
            _MacbookReparation.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool MacbookReparationExists(int id)
        {
            return _MacbookReparation.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Apple\MacBook");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Apple\MacBook");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Apple\MacBook\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
