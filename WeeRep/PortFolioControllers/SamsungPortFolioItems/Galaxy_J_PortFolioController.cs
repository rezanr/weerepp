using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Samsung;
using Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using WeeRep.Models.SamsungPortFolioModel;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.SamsungPortFolioItems
{
    [Authorize]

    public class Galaxy_J_PortFolioController : Controller
    {
       [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<Galaxy_J_Serien> _Galaxy_J_Serien;
        [Obsolete]
        public Galaxy_J_PortFolioController(IUnitOfWork<Galaxy_J_Serien> Galaxy_J_Serien, IHostingEnvironment hosting)
        {
            _Galaxy_J_Serien = Galaxy_J_Serien;
            _hosting = hosting;

        }

        // GET: Galaxy_J
        public IActionResult Index()
        {
            return View(_Galaxy_J_Serien.Entity.GetAll());
        }

        // GET: Galaxy_J/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Galaxy_J_Serien = _Galaxy_J_Serien.Entity.GetById(id);

            if (Galaxy_J_Serien == null)
            {
                return NotFound();
            }

            return View(Galaxy_J_Serien);
        }

        // GET: Galaxy_J/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Galaxy_J/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Galaxy_J_PortFolioModel model)
        {
            if (ModelState.IsValid)
            {

                //Create File
                string ImageUrl = UploadFile(model.File);
                if (ImageUrl == null)
                {
                    return View();

                }
                Galaxy_J_Serien Galaxy_J_Serien = new Galaxy_J_Serien()
                {

                    PhoneName = model.PhoneName,
                    ImageName = ImageUrl,
                    Skærm = model.Skærm,
                    P_Skærm = model.P_Skærm,
                    Batteri = model.Batteri,
                    P_Batteri = model.P_Batteri,
                    Bagglas = model.Bagglas,
                    P_Bagglas = model.P_Bagglas,
                    UV = model.UV,
                    P_UV = model.P_UV,
                    Bagkamera = model.Bagkamera,
                    P_Bagkamera = model.P_Bagkamera,
                    Fejlfinding = model.Fejlfinding,
                    P_Fejlfinding = model.P_Fejlfinding,
                    Volume_Lydløs = model.Volume_Lydløs,
                    P_Volume_Lydløs = model.P_Volume_Lydløs,
                    Højtale = model.Højtale,
                    P_Højtale = model.P_Højtale,
                    Ladestik = model.Ladestik,
                    P_Ladestik = model.P_Ladestik,
                    FrontKamera = model.FrontKamera,
                    P_FrontKamera = model.P_FrontKamera,
                    Vibrator = model.Vibrator,
                    P_Vibrator = model.P_Vibrator,
                    Tænd_Sluk = model.Tænd_Sluk,
                    P_Tænd_Sluk = model.P_Tænd_Sluk,
                    Ørehøjtaler = model.Ørehøjtaler,
                    P_Ørehøjtaler = model.P_Ørehøjtaler,


                };
                _Galaxy_J_Serien.Entity.Insert(Galaxy_J_Serien);
                _Galaxy_J_Serien.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: Galaxy_J/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Galaxy_J_Serien = _Galaxy_J_Serien.Entity.GetById(id);
            if (Galaxy_J_Serien == null)
            {
                return NotFound();
            }
            Galaxy_J_PortFolioModel Galaxy_J_PortFolioModel = new Galaxy_J_PortFolioModel()
            {
                ID = Galaxy_J_Serien.ID,
                PhoneName = Galaxy_J_Serien.PhoneName,
                ImageName = Galaxy_J_Serien.ImageName,
                Skærm = Galaxy_J_Serien.Skærm,
                P_Skærm = Galaxy_J_Serien.P_Skærm,
                UV = Galaxy_J_Serien.UV,
                P_UV = Galaxy_J_Serien.P_UV,
                Batteri = Galaxy_J_Serien.Batteri,
                P_Batteri = Galaxy_J_Serien.P_Batteri,
                Bagglas = Galaxy_J_Serien.Bagglas,
                P_Bagglas = Galaxy_J_Serien.P_Bagglas,
                Bagkamera = Galaxy_J_Serien.Bagkamera,
                P_Bagkamera = Galaxy_J_Serien.P_Bagkamera,
                Fejlfinding = Galaxy_J_Serien.Fejlfinding,
                P_Fejlfinding = Galaxy_J_Serien.P_Fejlfinding,
                Volume_Lydløs = Galaxy_J_Serien.Volume_Lydløs,
                P_Volume_Lydløs = Galaxy_J_Serien.P_Volume_Lydløs,
                Højtale = Galaxy_J_Serien.Højtale,
                P_Højtale = Galaxy_J_Serien.P_Højtale,
                Ladestik = Galaxy_J_Serien.Ladestik,
                P_Ladestik = Galaxy_J_Serien.P_Ladestik,
                FrontKamera = Galaxy_J_Serien.FrontKamera,
                P_FrontKamera = Galaxy_J_Serien.P_FrontKamera,
                Vibrator = Galaxy_J_Serien.Vibrator,
                P_Vibrator = Galaxy_J_Serien.P_Vibrator,
                Tænd_Sluk = Galaxy_J_Serien.Tænd_Sluk,
                P_Tænd_Sluk = Galaxy_J_Serien.P_Tænd_Sluk,
                Ørehøjtaler = Galaxy_J_Serien.Ørehøjtaler,
                P_Ørehøjtaler = Galaxy_J_Serien.P_Ørehøjtaler

            };
            return View(Galaxy_J_PortFolioModel);
        }

        // POST: Galaxy_J/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Galaxy_J_PortFolioModel model)
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
                    Galaxy_J_Serien imacRepartion = new Galaxy_J_Serien()
                    {
                        ID = model.ID,
                        PhoneName = model.PhoneName,
                        ImageName = ImageUrl,
                        Skærm = model.Skærm,
                        P_Skærm = model.P_Skærm,
                        UV = model.UV,
                        P_UV = model.P_UV,
                        Batteri = model.Batteri,
                        P_Batteri = model.P_Batteri,
                        Bagglas = model.Bagglas,
                        P_Bagglas = model.P_Bagglas,
                        Bagkamera = model.Bagkamera,
                        P_Bagkamera = model.P_Bagkamera,
                        Fejlfinding = model.Fejlfinding,
                        P_Fejlfinding = model.P_Fejlfinding,
                        Volume_Lydløs = model.Volume_Lydløs,
                        P_Volume_Lydløs = model.P_Volume_Lydløs,
                        Højtale = model.Højtale,
                        P_Højtale = model.P_Højtale,
                        Ladestik = model.Ladestik,
                        P_Ladestik = model.P_Ladestik,
                        FrontKamera = model.FrontKamera,
                        P_FrontKamera = model.P_FrontKamera,
                        Vibrator = model.Vibrator,
                        P_Vibrator = model.P_Vibrator,
                        Tænd_Sluk = model.Tænd_Sluk,
                        P_Tænd_Sluk = model.P_Tænd_Sluk,
                        Ørehøjtaler = model.Ørehøjtaler,
                        P_Ørehøjtaler = model.P_Ørehøjtaler
                    };
                    _Galaxy_J_Serien.Entity.Update(imacRepartion);
                    _Galaxy_J_Serien.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Galaxy_J_SerienExists(model.ID))
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

        // GET: Galaxy_J/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Galaxy_J_Serien = _Galaxy_J_Serien.Entity.GetById(id);

            if (Galaxy_J_Serien == null)
            {
                return NotFound();
            }

            return View(Galaxy_J_Serien);
        }

        // POST: Galaxy_J/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _Galaxy_J_Serien.Entity.Delete(id);
            _Galaxy_J_Serien.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool Galaxy_J_SerienExists(int id)
        {
            return _Galaxy_J_Serien.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Samsung\Galaxy_J");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Samsung\Galaxy_J");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Samsung\Galaxy_J\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}

