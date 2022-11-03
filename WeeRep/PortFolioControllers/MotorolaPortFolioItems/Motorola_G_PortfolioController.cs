using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using System.IO;
using Core.Entities.Motorola;
using WeeRep.Models.Motorola;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.MotorolaPortFolioItems
{
    [Authorize]

    public class Motorola_G_PortFolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<Motorola_G_Serien> _Motorola_G_Serien;
        [Obsolete]
        public Motorola_G_PortFolioController(IUnitOfWork<Motorola_G_Serien> Motorola_G_Serien, IHostingEnvironment hosting)
        {
            _Motorola_G_Serien = Motorola_G_Serien;
            _hosting = hosting;

        }

        // GET: Motorola_G
        public IActionResult Index()
        {
            return View(_Motorola_G_Serien.Entity.GetAll());
        }

        // GET: Motorola_G/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Motorola_G_Serien = _Motorola_G_Serien.Entity.GetById(id);

            if (Motorola_G_Serien == null)
            {
                return NotFound();
            }

            return View(Motorola_G_Serien);
        }

        // GET: Motorola_G/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Motorola_G/Create
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Motorola_G_PortFolioModel model)
        {
            if (ModelState.IsValid)
            {
                //Create File
                string ImageUrl = UploadFile(model.File);
                if (ImageUrl == null)
                {
                    return View();

                }
                Motorola_G_Serien Motorola_G_Serien = new Motorola_G_Serien()
                {

                    PhoneName = model.PhoneName,
                    ImageName = ImageUrl,
                    Skærm = model.Skærm,
                    P_Skærm = model.P_Skærm,
                    Batteri = model.Batteri,
                    P_Batteri = model.P_Batteri,
                    Bagglas = model.Bagglas,
                    P_Bagglas = model.P_Bagglas,
                    Bagglas_Ramme = model.Bagglas_Ramme,
                    P_Bagglas_Ramme = model.P_Bagglas_Ramme,
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
                    Skærm_B = model.Skærm_B,
                    P_Skærm_B = model.P_Skærm_B,

                };
                _Motorola_G_Serien.Entity.Insert(Motorola_G_Serien);
                _Motorola_G_Serien.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: Motorola_G/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Motorola_G_Serien = _Motorola_G_Serien.Entity.GetById(id);
            if (Motorola_G_Serien == null)
            {
                return NotFound();
            }
            Motorola_G_PortFolioModel Motorola_G_PortFolioModel = new Motorola_G_PortFolioModel()
            {
                ID = Motorola_G_Serien.ID,
                PhoneName = Motorola_G_Serien.PhoneName,
                ImageName = Motorola_G_Serien.ImageName,
                Skærm = Motorola_G_Serien.Skærm,
                P_Skærm = Motorola_G_Serien.P_Skærm,
                Bagglas_Ramme = Motorola_G_Serien.Bagglas_Ramme,
                P_Bagglas_Ramme = Motorola_G_Serien.P_Bagglas_Ramme,
                Batteri = Motorola_G_Serien.Batteri,
                P_Batteri = Motorola_G_Serien.P_Batteri,
                Bagglas = Motorola_G_Serien.Bagglas,
                P_Bagglas = Motorola_G_Serien.P_Bagglas,
                Bagkamera = Motorola_G_Serien.Bagkamera,
                P_Bagkamera = Motorola_G_Serien.P_Bagkamera,
                Fejlfinding = Motorola_G_Serien.Fejlfinding,
                P_Fejlfinding = Motorola_G_Serien.P_Fejlfinding,
                Volume_Lydløs = Motorola_G_Serien.Volume_Lydløs,
                P_Volume_Lydløs = Motorola_G_Serien.P_Volume_Lydløs,
                Højtale = Motorola_G_Serien.Højtale,
                P_Højtale = Motorola_G_Serien.P_Højtale,
                Ladestik = Motorola_G_Serien.Ladestik,
                P_Ladestik = Motorola_G_Serien.P_Ladestik,
                FrontKamera = Motorola_G_Serien.FrontKamera,
                P_FrontKamera = Motorola_G_Serien.P_FrontKamera,
                Vibrator = Motorola_G_Serien.Vibrator,
                P_Vibrator = Motorola_G_Serien.P_Vibrator,
                Tænd_Sluk = Motorola_G_Serien.Tænd_Sluk,
                P_Tænd_Sluk = Motorola_G_Serien.P_Tænd_Sluk,
                Ørehøjtaler = Motorola_G_Serien.Ørehøjtaler,
                P_Ørehøjtaler = Motorola_G_Serien.P_Ørehøjtaler,
                Skærm_B = Motorola_G_Serien.Skærm_B,
                P_Skærm_B = Motorola_G_Serien.P_Skærm_B,

            };
            return View(Motorola_G_PortFolioModel);
        }

        // POST: Motorola_G/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Motorola_G_PortFolioModel model)
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
                    Motorola_G_Serien imacRepartion = new Motorola_G_Serien()
                    {
                        ID = model.ID,
                        PhoneName = model.PhoneName,
                        ImageName = ImageUrl,
                        Skærm = model.Skærm,
                        P_Skærm = model.P_Skærm,
                        Bagglas_Ramme = model.Bagglas_Ramme,
                        P_Bagglas_Ramme = model.P_Bagglas_Ramme,
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
                        P_Ørehøjtaler = model.P_Ørehøjtaler,
                        Skærm_B = model.Skærm_B,
                        P_Skærm_B = model.P_Skærm_B,

                    };
                    _Motorola_G_Serien.Entity.Update(imacRepartion);
                    _Motorola_G_Serien.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Motorola_G_SerienExists(model.ID))
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

        // GET: Motorola_G/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Motorola_G_Serien = _Motorola_G_Serien.Entity.GetById(id);

            if (Motorola_G_Serien == null)
            {
                return NotFound();
            }

            return View(Motorola_G_Serien);
        }

        // POST: Motorola_G/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _Motorola_G_Serien.Entity.Delete(id);
            _Motorola_G_Serien.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool Motorola_G_SerienExists(int id)
        {
            return _Motorola_G_Serien.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Motorola\Motorola_G");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Motorola\Motorola_G");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Motorola\Motorola_G\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
