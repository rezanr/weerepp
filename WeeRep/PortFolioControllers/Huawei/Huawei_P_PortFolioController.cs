using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Huawei;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using WeeRep.Models.Huawei;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.Huawei
{
    [Authorize]
    public class Huawei_P_PortFolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<Huawei_P_Serien> _Huawei_P_Serien;
        [Obsolete]
        public Huawei_P_PortFolioController(IUnitOfWork<Huawei_P_Serien> Huawei_P_Serien, IHostingEnvironment hosting)
        {
            _Huawei_P_Serien = Huawei_P_Serien;
            _hosting = hosting;

        }

        // GET: Huawei_P
        public IActionResult Index()
        {
            return View(_Huawei_P_Serien.Entity.GetAll());
        }

        // GET: Huawei_P/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Huawei_P_Serien = _Huawei_P_Serien.Entity.GetById(id);

            if (Huawei_P_Serien == null)
            {
                return NotFound();
            }

            return View(Huawei_P_Serien);
        }

        // GET: Huawei_P/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Huawei_P/Create
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Huawei_P_PortFolioModel model)
        {
            if (ModelState.IsValid)
            {
                //Create File
                string ImageUrl = UploadFile(model.File);
                if (ImageUrl == null)
                {
                    return View();

                }
                Huawei_P_Serien Huawei_P_Serien = new Huawei_P_Serien()
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
                _Huawei_P_Serien.Entity.Insert(Huawei_P_Serien);
                _Huawei_P_Serien.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: Huawei_P/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Huawei_P_Serien = _Huawei_P_Serien.Entity.GetById(id);
            if (Huawei_P_Serien == null)
            {
                return NotFound();
            }
            Huawei_P_PortFolioModel Huawei_P_PortFolioModel = new Huawei_P_PortFolioModel()
            {
                ID = Huawei_P_Serien.ID,
                PhoneName = Huawei_P_Serien.PhoneName,
                ImageName = Huawei_P_Serien.ImageName,
                Skærm = Huawei_P_Serien.Skærm,
                P_Skærm = Huawei_P_Serien.P_Skærm,
                UV = Huawei_P_Serien.UV,
                P_UV = Huawei_P_Serien.P_UV,
                Batteri = Huawei_P_Serien.Batteri,
                P_Batteri = Huawei_P_Serien.P_Batteri,
                Bagglas = Huawei_P_Serien.Bagglas,
                P_Bagglas = Huawei_P_Serien.P_Bagglas,
                Bagkamera = Huawei_P_Serien.Bagkamera,
                P_Bagkamera = Huawei_P_Serien.P_Bagkamera,
                Fejlfinding = Huawei_P_Serien.Fejlfinding,
                P_Fejlfinding = Huawei_P_Serien.P_Fejlfinding,
                Volume_Lydløs = Huawei_P_Serien.Volume_Lydløs,
                P_Volume_Lydløs = Huawei_P_Serien.P_Volume_Lydløs,
                Højtale = Huawei_P_Serien.Højtale,
                P_Højtale = Huawei_P_Serien.P_Højtale,
                Ladestik = Huawei_P_Serien.Ladestik,
                P_Ladestik = Huawei_P_Serien.P_Ladestik,
                FrontKamera = Huawei_P_Serien.FrontKamera,
                P_FrontKamera = Huawei_P_Serien.P_FrontKamera,
                Vibrator = Huawei_P_Serien.Vibrator,
                P_Vibrator = Huawei_P_Serien.P_Vibrator,
                Tænd_Sluk = Huawei_P_Serien.Tænd_Sluk,
                P_Tænd_Sluk = Huawei_P_Serien.P_Tænd_Sluk,
                Ørehøjtaler = Huawei_P_Serien.Ørehøjtaler,
                P_Ørehøjtaler = Huawei_P_Serien.P_Ørehøjtaler

            };
            return View(Huawei_P_PortFolioModel);
        }

        // POST: Huawei_P/Edit/5
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Huawei_P_PortFolioModel model)
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
                    Huawei_P_Serien imacRepartion = new Huawei_P_Serien()
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
                    _Huawei_P_Serien.Entity.Update(imacRepartion);
                    _Huawei_P_Serien.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Huawei_P_SerienExists(model.ID))
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

        // GET: Huawei_P/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Huawei_P_Serien = _Huawei_P_Serien.Entity.GetById(id);

            if (Huawei_P_Serien == null)
            {
                return NotFound();
            }

            return View(Huawei_P_Serien);
        }

        // POST: Huawei_P/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _Huawei_P_Serien.Entity.Delete(id);
            _Huawei_P_Serien.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool Huawei_P_SerienExists(int id)
        {
            return _Huawei_P_Serien.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Huawei\Huawei_p");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Huawei\Huawei_p");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Huawei\Huawei_p\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
