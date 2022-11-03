using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Apple;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using WeeRep.Models.AplePortFolioModel;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.ApplePortFolioItems
{
    [Authorize]

    public class ImacPortFolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<ImacReparation> _ImacReparation;
        [Obsolete]
        public ImacPortFolioController(IUnitOfWork<ImacReparation> ImacReparation, IHostingEnvironment hosting)
        {
            _ImacReparation = ImacReparation;
            _hosting = hosting;

        }

        // GET: ImacPortFolio
        public IActionResult Index()
        {
            return View(_ImacReparation.Entity.GetAll());
        }

        // GET: ImacPortFolio/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imacReparation = _ImacReparation.Entity.GetById(id);

            if (imacReparation == null)
            {
                return NotFound();
            }

            return View(imacReparation);
        }

        // GET: ImacPortFolio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ImacPortFolio/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ImacPortFoliModel model)
        {
            if (ModelState.IsValid)
            {
                //Create File
                string ImageUrl = UploadFile(model.File);
                if (ImageUrl == null)
                {
                    return View();

                }
                ImacReparation imacReparation = new ImacReparation()
                {

                    PhoneName = model.PhoneName,
                    ImageName = ImageUrl,

                    Bagglas_Ramme = model.Bagglas_Ramme,
                    P_Bagglas_Ramme = model.P_Bagglas_Ramme,
                    front_Kamera = model.front_Kamera,
                    P_front_Kamera = model.P_front_Kamera,
                    Batteri = model.Batteri,
                    P_Batteri = model.P_Batteri,
                    Bagglas = model.Bagglas,
                    P_Bagglas = model.P_Bagglas,
                    Skærm = model.Skærm,
                    P_Skærm = model.P_Skærm,
                    Bakkamera = model.Bakkamera,
                    P_Bakkamera = model.P_Bakkamera,
                    Fejlfinding = model.Fejlfinding,
                    P_Fejlfinding = model.P_Fejlfinding,
                    Volume_Lydløs = model.Volume_Lydløs,
                    P_Volume_Lydløs = model.P_Volume_Lydløs,
                    Højtale = model.Højtale,
                    P_Højtale = model.P_Højtale,
                    Ladestik = model.Ladestik,
                    P_Ladestik = model.P_Ladestik,
                    Skærm_B = model.Skærm_B,
                    P_Skærm_B = model.P_Skærm_B,
                    Vibrator = model.Vibrator,
                    P_Vibrator = model.P_Vibrator,
                    Tænd_Sluk = model.Tænd_Sluk,
                    P_Tænd_Sluk = model.P_Tænd_Sluk,
                    ØreHøjtale = model.ØreHøjtale,
                    P_ØreHøjtale = model.P_ØreHøjtale

                };
                _ImacReparation.Entity.Insert(imacReparation);
                _ImacReparation.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: ImacPortFolio/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imacReparation = _ImacReparation.Entity.GetById(id);
            if (imacReparation == null)
            {
                return NotFound();
            }
            ImacPortFoliModel ImacPortFoliModel = new ImacPortFoliModel()
            {
                ID = imacReparation.ID,
                PhoneName = imacReparation.PhoneName,
                ImageName = imacReparation.ImageName,
                Bagglas_Ramme = imacReparation.Bagglas_Ramme,
                P_Bagglas_Ramme = imacReparation.P_Bagglas_Ramme,
                front_Kamera = imacReparation.front_Kamera,
                P_front_Kamera = imacReparation.P_front_Kamera,
                Batteri = imacReparation.Batteri,
                P_Batteri = imacReparation.P_Batteri,
                Bagglas = imacReparation.Bagglas,
                P_Bagglas = imacReparation.P_Bagglas,
                Skærm = imacReparation.Skærm,
                P_Skærm = imacReparation.P_Skærm,
                Bakkamera = imacReparation.Bakkamera,
                P_Bakkamera = imacReparation.P_Bakkamera,
                Fejlfinding = imacReparation.Fejlfinding,
                P_Fejlfinding = imacReparation.P_Fejlfinding,
                Volume_Lydløs = imacReparation.Volume_Lydløs,
                P_Volume_Lydløs = imacReparation.P_Volume_Lydløs,
                Højtale = imacReparation.Højtale,
                P_Højtale = imacReparation.P_Højtale,
                Ladestik = imacReparation.Ladestik,
                P_Ladestik = imacReparation.P_Ladestik,
                Skærm_B = imacReparation.Skærm_B,
                P_Skærm_B = imacReparation.P_Skærm_B,
                Vibrator = imacReparation.Vibrator,
                P_Vibrator = imacReparation.P_Vibrator,
                Tænd_Sluk = imacReparation.Tænd_Sluk,
                P_Tænd_Sluk = imacReparation.P_Tænd_Sluk,
                ØreHøjtale = imacReparation.ØreHøjtale,
                P_ØreHøjtale = imacReparation.P_ØreHøjtale

            };
            return View(ImacPortFoliModel);
        }

        // POST: ImacPortFolio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ImacPortFoliModel model)
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
                    ImacReparation imacRepartion = new ImacReparation()
                    {
                        ID = model.ID,
                        PhoneName = model.PhoneName,
                        ImageName = ImageUrl,
                        Bagglas_Ramme = model.Bagglas_Ramme,
                        P_Bagglas_Ramme = model.P_Bagglas_Ramme,
                        front_Kamera = model.front_Kamera,
                        P_front_Kamera = model.P_front_Kamera,
                        Batteri = model.Batteri,
                        P_Batteri = model.P_Batteri,
                        Bagglas = model.Bagglas,
                        P_Bagglas = model.P_Bagglas,
                        Skærm = model.Skærm,
                        P_Skærm = model.P_Skærm,
                        Bakkamera = model.Bakkamera,
                        P_Bakkamera = model.P_Bakkamera,
                        Fejlfinding = model.Fejlfinding,
                        P_Fejlfinding = model.P_Fejlfinding,
                        Volume_Lydløs = model.Volume_Lydløs,
                        P_Volume_Lydløs = model.P_Volume_Lydløs,
                        Højtale = model.Højtale,
                        P_Højtale = model.P_Højtale,
                        Ladestik = model.Ladestik,
                        P_Ladestik = model.P_Ladestik,
                        Skærm_B = model.Skærm_B,
                        P_Skærm_B = model.P_Skærm_B,
                        Vibrator = model.Vibrator,
                        P_Vibrator = model.P_Vibrator,
                        Tænd_Sluk = model.Tænd_Sluk,
                        P_Tænd_Sluk = model.P_Tænd_Sluk,
                        ØreHøjtale = model.ØreHøjtale,
                        P_ØreHøjtale = model.P_ØreHøjtale
                    };
                    _ImacReparation.Entity.Update(imacRepartion);
                    _ImacReparation.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImacReparationExists(model.ID))
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

        // GET: ImacPortFolio/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imacReparation = _ImacReparation.Entity.GetById(id);

            if (imacReparation == null)
            {
                return NotFound();
            }

            return View(imacReparation);
        }

        // POST: ImacPortFolio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _ImacReparation.Entity.Delete(id);
            _ImacReparation.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool ImacReparationExists(int id)
        {
            return _ImacReparation.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Apple\Imac");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Apple\Imac");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Apple\Imac\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
