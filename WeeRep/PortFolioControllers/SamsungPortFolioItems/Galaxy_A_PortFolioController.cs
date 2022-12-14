using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Samsung;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using System.IO;
using WeeRep.Models.SamsungPortFolioModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.SamsungPortFolioItems
{
    [Authorize]

    public class Galaxy_A_PortFolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<Galaxy_A_Serien> _Galaxy_A_Serien;
        [Obsolete]
        public Galaxy_A_PortFolioController(IUnitOfWork<Galaxy_A_Serien> Galaxy_A_Serien, IHostingEnvironment hosting)
        {
            _Galaxy_A_Serien = Galaxy_A_Serien;
            _hosting = hosting;

        }

        // GET: Galaxy_A
        public IActionResult Index()
        {
            return View(_Galaxy_A_Serien.Entity.GetAll());
        }

        // GET: Galaxy_A/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Galaxy_A_Serien = _Galaxy_A_Serien.Entity.GetById(id);

            if (Galaxy_A_Serien == null)
            {
                return NotFound();
            }

            return View(Galaxy_A_Serien);
        }

        // GET: Galaxy_A/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Galaxy_A/Create
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Galaxy_A_PortFolioModel model)
        {
            if (ModelState.IsValid)
            {
       
                //Create File
                string ImageUrl = UploadFile(model.File);
                if (ImageUrl == null)
                {
                    return View();

                }
                Galaxy_A_Serien Galaxy_A_Serien = new Galaxy_A_Serien()
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
                _Galaxy_A_Serien.Entity.Insert(Galaxy_A_Serien);
                _Galaxy_A_Serien.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: Galaxy_A/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Galaxy_A_Serien = _Galaxy_A_Serien.Entity.GetById(id);
            if (Galaxy_A_Serien == null)
            {
                return NotFound();
            }
            Galaxy_A_PortFolioModel Galaxy_A_PortFolioModel = new Galaxy_A_PortFolioModel()
            {
                ID = Galaxy_A_Serien.ID,
                PhoneName = Galaxy_A_Serien.PhoneName,
                ImageName = Galaxy_A_Serien.ImageName,
                Skærm = Galaxy_A_Serien.Skærm,
                P_Skærm = Galaxy_A_Serien.P_Skærm,
                UV = Galaxy_A_Serien.UV,
                P_UV = Galaxy_A_Serien.P_UV,
                Batteri = Galaxy_A_Serien.Batteri,
                P_Batteri = Galaxy_A_Serien.P_Batteri,
                Bagglas = Galaxy_A_Serien.Bagglas,
                P_Bagglas = Galaxy_A_Serien.P_Bagglas,            
                Bagkamera = Galaxy_A_Serien.Bagkamera,
                P_Bagkamera = Galaxy_A_Serien.P_Bagkamera,
                Fejlfinding = Galaxy_A_Serien.Fejlfinding,
                P_Fejlfinding = Galaxy_A_Serien.P_Fejlfinding,
                Volume_Lydløs = Galaxy_A_Serien.Volume_Lydløs,
                P_Volume_Lydløs = Galaxy_A_Serien.P_Volume_Lydløs,
                Højtale = Galaxy_A_Serien.Højtale,
                P_Højtale = Galaxy_A_Serien.P_Højtale,
                Ladestik = Galaxy_A_Serien.Ladestik,
                P_Ladestik = Galaxy_A_Serien.P_Ladestik,
                FrontKamera = Galaxy_A_Serien.FrontKamera,
                P_FrontKamera = Galaxy_A_Serien.P_FrontKamera,
                Vibrator = Galaxy_A_Serien.Vibrator,
                P_Vibrator = Galaxy_A_Serien.P_Vibrator,
                Tænd_Sluk = Galaxy_A_Serien.Tænd_Sluk,
                P_Tænd_Sluk = Galaxy_A_Serien.P_Tænd_Sluk,
                Ørehøjtaler = Galaxy_A_Serien.Ørehøjtaler,
                P_Ørehøjtaler = Galaxy_A_Serien.P_Ørehøjtaler

            };
            return View(Galaxy_A_PortFolioModel);
        }

        // POST: Galaxy_A/Edit/5
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Galaxy_A_PortFolioModel model)
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
                    Galaxy_A_Serien imacRepartion = new Galaxy_A_Serien()
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
                    _Galaxy_A_Serien.Entity.Update(imacRepartion);
                    _Galaxy_A_Serien.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Galaxy_A_SerienExists(model.ID))
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

        // GET: Galaxy_A/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Galaxy_A_Serien = _Galaxy_A_Serien.Entity.GetById(id);

            if (Galaxy_A_Serien == null)
            {
                return NotFound();
            }

            return View(Galaxy_A_Serien);
        }

        // POST: Galaxy_A/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _Galaxy_A_Serien.Entity.Delete(id);
            _Galaxy_A_Serien.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool Galaxy_A_SerienExists(int id)
        {
            return _Galaxy_A_Serien.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Samsung\Galaxy_A");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Samsung\Galaxy_A");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Samsung\Galaxy_A\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
