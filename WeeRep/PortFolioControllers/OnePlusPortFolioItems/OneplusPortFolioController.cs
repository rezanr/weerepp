using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Oneplus;
using Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using WeeRep.Models.OneplusPortFolio;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.OnePlusPortFolioItems
{
    [Authorize]

    public class OneplusPortFolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<OneplusReparation> _OneplusReparation;
        [Obsolete]
        public OneplusPortFolioController(IUnitOfWork<OneplusReparation> OneplusReparation, IHostingEnvironment hosting)
        {
            _OneplusReparation = OneplusReparation;
            _hosting = hosting;

        }

        // GET: Oneplus
        public IActionResult Index()
        {
            return View(_OneplusReparation.Entity.GetAll());
        }

        // GET: Oneplus/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var OneplusReparation = _OneplusReparation.Entity.GetById(id);

            if (OneplusReparation == null)
            {
                return NotFound();
            }

            return View(OneplusReparation);
        }

        // GET: Oneplus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Oneplus/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OnePlusPortFolioModel model)
        {
            if (ModelState.IsValid)
            {
                
                //Create File
                string ImageUrl = UploadFile(model.File) ;
                if (ImageUrl == null)
                {
                    return View();

                }
                OneplusReparation OneplusReparation = new OneplusReparation()
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
                _OneplusReparation.Entity.Insert(OneplusReparation);
                _OneplusReparation.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: Oneplus/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var OneplusReparation = _OneplusReparation.Entity.GetById(id);
            if (OneplusReparation == null)
            {
                return NotFound();
            }
            OnePlusPortFolioModel OnePlusPortFolioModel = new OnePlusPortFolioModel()
            {
                ID = OneplusReparation.ID,
                PhoneName = OneplusReparation.PhoneName,
                ImageName = OneplusReparation.ImageName,
                Skærm = OneplusReparation.Skærm,
                P_Skærm = OneplusReparation.P_Skærm,
                UV = OneplusReparation.UV,
                P_UV = OneplusReparation.P_UV,
                Batteri = OneplusReparation.Batteri,
                P_Batteri = OneplusReparation.P_Batteri,
                Bagglas = OneplusReparation.Bagglas,
                P_Bagglas = OneplusReparation.P_Bagglas,
                Bagkamera = OneplusReparation.Bagkamera,
                P_Bagkamera = OneplusReparation.P_Bagkamera,
                Fejlfinding = OneplusReparation.Fejlfinding,
                P_Fejlfinding = OneplusReparation.P_Fejlfinding,
                Volume_Lydløs = OneplusReparation.Volume_Lydløs,
                P_Volume_Lydløs = OneplusReparation.P_Volume_Lydløs,
                Højtale = OneplusReparation.Højtale,
                P_Højtale = OneplusReparation.P_Højtale,
                Ladestik = OneplusReparation.Ladestik,
                P_Ladestik = OneplusReparation.P_Ladestik,
                FrontKamera = OneplusReparation.FrontKamera,
                P_FrontKamera = OneplusReparation.P_FrontKamera,
                Vibrator = OneplusReparation.Vibrator,
                P_Vibrator = OneplusReparation.P_Vibrator,
                Tænd_Sluk = OneplusReparation.Tænd_Sluk,
                P_Tænd_Sluk = OneplusReparation.P_Tænd_Sluk,
                Ørehøjtaler = OneplusReparation.Ørehøjtaler,
                P_Ørehøjtaler = OneplusReparation.P_Ørehøjtaler

            };
            return View(OnePlusPortFolioModel);
        }

        // POST: Oneplus/Edit/5
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, OnePlusPortFolioModel model)
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
                    OneplusReparation imacRepartion = new OneplusReparation()
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
                    _OneplusReparation.Entity.Update(imacRepartion);
                    _OneplusReparation.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OneplusReparationExists(model.ID))
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

        // GET: Oneplus/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var OneplusReparation = _OneplusReparation.Entity.GetById(id);

            if (OneplusReparation == null)
            {
                return NotFound();
            }

            return View(OneplusReparation);
        }

        // POST: Oneplus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _OneplusReparation.Entity.Delete(id);
            _OneplusReparation.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool OneplusReparationExists(int id)
        {
            return _OneplusReparation.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Oneplus");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Oneplus");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Oneplus\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
