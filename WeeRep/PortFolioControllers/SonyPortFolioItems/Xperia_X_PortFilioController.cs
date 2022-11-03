using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using System.IO;
using Core.Entities.Sony;
using WeeRep.Models.SonyPortFolioModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.SonyPortFolioItems
{
    [Authorize]

    public class Xperia_X_PortFilioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<Xperia_X_Serien> _Xperia_X_Serien;
        [Obsolete]
        public Xperia_X_PortFilioController(IUnitOfWork<Xperia_X_Serien> Xperia_X_Serien, IHostingEnvironment hosting)
        {
            _Xperia_X_Serien = Xperia_X_Serien;
            _hosting = hosting;

        }

        // GET: Xperia_X
        public IActionResult Index()
        {
            return View(_Xperia_X_Serien.Entity.GetAll());
        }

        // GET: Xperia_X/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Xperia_X_Serien = _Xperia_X_Serien.Entity.GetById(id);

            if (Xperia_X_Serien == null)
            {
                return NotFound();
            }

            return View(Xperia_X_Serien);
        }

        // GET: Xperia_X/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Xperia_X/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Xperia_X_PortFlioModel model)
        {
            if (ModelState.IsValid)
            {
                //Create File
                string ImageUrl = UploadFile(model.File) ;
                if (ImageUrl == null)
                {
                    return View();

                }
                Xperia_X_Serien Xperia_X_Serien = new Xperia_X_Serien()
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

                };
                _Xperia_X_Serien.Entity.Insert(Xperia_X_Serien);
                _Xperia_X_Serien.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: Xperia_X/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Xperia_X_Serien = _Xperia_X_Serien.Entity.GetById(id);
            if (Xperia_X_Serien == null)
            {
                return NotFound();
            }
            Xperia_X_PortFlioModel Xperia_X_PortFlioModel = new Xperia_X_PortFlioModel()
            {
                ID = Xperia_X_Serien.ID,
                PhoneName = Xperia_X_Serien.PhoneName,
                ImageName = Xperia_X_Serien.ImageName,
                Skærm = Xperia_X_Serien.Skærm,
                P_Skærm = Xperia_X_Serien.P_Skærm,
                Bagglas_Ramme = Xperia_X_Serien.Bagglas_Ramme,
                P_Bagglas_Ramme = Xperia_X_Serien.P_Bagglas_Ramme,
                Batteri = Xperia_X_Serien.Batteri,
                P_Batteri = Xperia_X_Serien.P_Batteri,
                Bagglas = Xperia_X_Serien.Bagglas,
                P_Bagglas = Xperia_X_Serien.P_Bagglas,
                Bagkamera = Xperia_X_Serien.Bagkamera,
                P_Bagkamera = Xperia_X_Serien.P_Bagkamera,
                Fejlfinding = Xperia_X_Serien.Fejlfinding,
                P_Fejlfinding = Xperia_X_Serien.P_Fejlfinding,
                Volume_Lydløs = Xperia_X_Serien.Volume_Lydløs,
                P_Volume_Lydløs = Xperia_X_Serien.P_Volume_Lydløs,
                Højtale = Xperia_X_Serien.Højtale,
                P_Højtale = Xperia_X_Serien.P_Højtale,
                Ladestik = Xperia_X_Serien.Ladestik,
                P_Ladestik = Xperia_X_Serien.P_Ladestik,
                FrontKamera = Xperia_X_Serien.FrontKamera,
                P_FrontKamera = Xperia_X_Serien.P_FrontKamera,
                Vibrator = Xperia_X_Serien.Vibrator,
                P_Vibrator = Xperia_X_Serien.P_Vibrator,
                Tænd_Sluk = Xperia_X_Serien.Tænd_Sluk,
                P_Tænd_Sluk = Xperia_X_Serien.P_Tænd_Sluk,
                Ørehøjtaler = Xperia_X_Serien.Ørehøjtaler,
                P_Ørehøjtaler = Xperia_X_Serien.P_Ørehøjtaler

            };
            return View(Xperia_X_PortFlioModel);
        }

        // POST: Xperia_X/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Xperia_X_PortFlioModel model)
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
                    Xperia_X_Serien imacRepartion = new Xperia_X_Serien()
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
                        P_Ørehøjtaler = model.P_Ørehøjtaler
                    };
                    _Xperia_X_Serien.Entity.Update(imacRepartion);
                    _Xperia_X_Serien.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Xperia_X_SerienExists(model.ID))
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

        // GET: Xperia_X/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Xperia_X_Serien = _Xperia_X_Serien.Entity.GetById(id);

            if (Xperia_X_Serien == null)
            {
                return NotFound();
            }

            return View(Xperia_X_Serien);
        }

        // POST: Xperia_X/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _Xperia_X_Serien.Entity.Delete(id);
            _Xperia_X_Serien.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool Xperia_X_SerienExists(int id)
        {
            return _Xperia_X_Serien.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Sony\Xperia_X");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Sony\Xperia_X");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Sony\Xperia_X\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
