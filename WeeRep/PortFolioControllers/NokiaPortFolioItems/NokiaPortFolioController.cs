using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using System.IO;
using Core.Entities.Nokia;
using WeeRep.Models.NokiaPortFolio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.NokiaPortFolioItems
{
    [Authorize]

    public class NokiaPortFolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<NokiaRepartionPrice> _NokiaRepartionPrice;
        [Obsolete]
        public NokiaPortFolioController(IUnitOfWork<NokiaRepartionPrice> NokiaRepartionPrice, IHostingEnvironment hosting)
        {
            _NokiaRepartionPrice = NokiaRepartionPrice;
            _hosting = hosting;

        }

        // GET: NokiaRepartion
        public IActionResult Index()
        {
            return View(_NokiaRepartionPrice.Entity.GetAll());
        }

        // GET: NokiaRepartion/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var NokiaRepartionPrice = _NokiaRepartionPrice.Entity.GetById(id);

            if (NokiaRepartionPrice == null)
            {
                return NotFound();
            }

            return View(NokiaRepartionPrice);
        }

        // GET: NokiaRepartion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NokiaRepartion/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NokiaPortfolioModel model)
        {
            if (ModelState.IsValid)
            {
                //Create File
                string ImageUrl = UploadFile(model.File);
                if (ImageUrl == null)
                {
                    return View();

                }

                NokiaRepartionPrice NokiaRepartionPrice = new NokiaRepartionPrice()
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
                _NokiaRepartionPrice.Entity.Insert(NokiaRepartionPrice);
                _NokiaRepartionPrice.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: NokiaRepartion/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var NokiaRepartionPrice = _NokiaRepartionPrice.Entity.GetById(id);
            if (NokiaRepartionPrice == null)
            {
                return NotFound();
            }
            NokiaPortfolioModel NokiaPortfolioModel = new NokiaPortfolioModel()
            {
                ID = NokiaRepartionPrice.ID,
                PhoneName = NokiaRepartionPrice.PhoneName,
                ImageName = NokiaRepartionPrice.ImageName,
                Skærm = NokiaRepartionPrice.Skærm,
                P_Skærm = NokiaRepartionPrice.P_Skærm,
                Bagglas_Ramme = NokiaRepartionPrice.Bagglas_Ramme,
                P_Bagglas_Ramme = NokiaRepartionPrice.P_Bagglas_Ramme,
                Batteri = NokiaRepartionPrice.Batteri,
                P_Batteri = NokiaRepartionPrice.P_Batteri,
                Bagglas = NokiaRepartionPrice.Bagglas,
                P_Bagglas = NokiaRepartionPrice.P_Bagglas,
                Bagkamera = NokiaRepartionPrice.Bagkamera,
                P_Bagkamera = NokiaRepartionPrice.P_Bagkamera,
                Fejlfinding = NokiaRepartionPrice.Fejlfinding,
                P_Fejlfinding = NokiaRepartionPrice.P_Fejlfinding,
                Volume_Lydløs = NokiaRepartionPrice.Volume_Lydløs,
                P_Volume_Lydløs = NokiaRepartionPrice.P_Volume_Lydløs,
                Højtale = NokiaRepartionPrice.Højtale,
                P_Højtale = NokiaRepartionPrice.P_Højtale,
                Ladestik = NokiaRepartionPrice.Ladestik,
                P_Ladestik = NokiaRepartionPrice.P_Ladestik,
                FrontKamera = NokiaRepartionPrice.FrontKamera,
                P_FrontKamera = NokiaRepartionPrice.P_FrontKamera,
                Vibrator = NokiaRepartionPrice.Vibrator,
                P_Vibrator = NokiaRepartionPrice.P_Vibrator,
                Tænd_Sluk = NokiaRepartionPrice.Tænd_Sluk,
                P_Tænd_Sluk = NokiaRepartionPrice.P_Tænd_Sluk,
                Ørehøjtaler = NokiaRepartionPrice.Ørehøjtaler,
                P_Ørehøjtaler = NokiaRepartionPrice.P_Ørehøjtaler,
                Skærm_B = NokiaRepartionPrice.Skærm_B,
                P_Skærm_B = NokiaRepartionPrice.P_Skærm_B,

            };
            return View(NokiaPortfolioModel);
        }

        // POST: NokiaRepartion/Edit/5
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, NokiaPortfolioModel model)
        {
            if (id != model.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try { 
   
                    //Creat File
                    string ImageUrl = SaveImageFile(model.File, model.ImageName);
                    NokiaRepartionPrice imacRepartion = new NokiaRepartionPrice()
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
                    _NokiaRepartionPrice.Entity.Update(imacRepartion);
                    _NokiaRepartionPrice.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NokiaRepartionPriceExists(model.ID))
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

        // GET: NokiaRepartion/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var NokiaRepartionPrice = _NokiaRepartionPrice.Entity.GetById(id);

            if (NokiaRepartionPrice == null)
            {
                return NotFound();
            }

            return View(NokiaRepartionPrice);
        }

        // POST: NokiaRepartion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _NokiaRepartionPrice.Entity.Delete(id);
            _NokiaRepartionPrice.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool NokiaRepartionPriceExists(int id)
        {
            return _NokiaRepartionPrice.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Nokia");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Nokia");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Nokia\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }

}
