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
    public class XperiaTopPortFolilController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<XperiaTopModeller> _XperiaTopModeller;
        [Obsolete]
        public XperiaTopPortFolilController(IUnitOfWork<XperiaTopModeller> XperiaTopModeller, IHostingEnvironment hosting)
        {
            _XperiaTopModeller = XperiaTopModeller;
            _hosting = hosting;

        }

        // GET: -
        public IActionResult Index()
        {
            return View(_XperiaTopModeller.Entity.GetAll());
        }

        // GET: -/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var XperiaTopModeller = _XperiaTopModeller.Entity.GetById(id);

            if (XperiaTopModeller == null)
            {
                return NotFound();
            }

            return View(XperiaTopModeller);
        }

        // GET: Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(XperiaTopPortFilioModel model)
        {
            if (ModelState.IsValid)
            {
                //Create File
                string ImageUrl = UploadFile(model.File) ;
                if (ImageUrl == null)
                {
                    return View();

                }
                XperiaTopModeller XperiaTopModeller = new XperiaTopModeller()
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
                _XperiaTopModeller.Entity.Insert(XperiaTopModeller);
                _XperiaTopModeller.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: /Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var XperiaTopModeller = _XperiaTopModeller.Entity.GetById(id);
            if (XperiaTopModeller == null)
            {
                return NotFound();
            }
            XperiaTopPortFilioModel XperiaTopPortFilioModel = new XperiaTopPortFilioModel()
            {
                ID = XperiaTopModeller.ID,
                PhoneName = XperiaTopModeller.PhoneName,
                ImageName = XperiaTopModeller.ImageName,
                Skærm = XperiaTopModeller.Skærm,
                P_Skærm = XperiaTopModeller.P_Skærm,
                Bagglas_Ramme = XperiaTopModeller.Bagglas_Ramme,
                P_Bagglas_Ramme = XperiaTopModeller.P_Bagglas_Ramme,
                Batteri = XperiaTopModeller.Batteri,
                P_Batteri = XperiaTopModeller.P_Batteri,
                Bagglas = XperiaTopModeller.Bagglas,
                P_Bagglas = XperiaTopModeller.P_Bagglas,
                Bagkamera = XperiaTopModeller.Bagkamera,
                P_Bagkamera = XperiaTopModeller.P_Bagkamera,
                Fejlfinding = XperiaTopModeller.Fejlfinding,
                P_Fejlfinding = XperiaTopModeller.P_Fejlfinding,
                Volume_Lydløs = XperiaTopModeller.Volume_Lydløs,
                P_Volume_Lydløs = XperiaTopModeller.P_Volume_Lydløs,
                Højtale = XperiaTopModeller.Højtale,
                P_Højtale = XperiaTopModeller.P_Højtale,
                Ladestik = XperiaTopModeller.Ladestik,
                P_Ladestik = XperiaTopModeller.P_Ladestik,
                FrontKamera = XperiaTopModeller.FrontKamera,
                P_FrontKamera = XperiaTopModeller.P_FrontKamera,
                Vibrator = XperiaTopModeller.Vibrator,
                P_Vibrator = XperiaTopModeller.P_Vibrator,
                Tænd_Sluk = XperiaTopModeller.Tænd_Sluk,
                P_Tænd_Sluk = XperiaTopModeller.P_Tænd_Sluk,
                Ørehøjtaler = XperiaTopModeller.Ørehøjtaler,
                P_Ørehøjtaler = XperiaTopModeller.P_Ørehøjtaler

            };
            return View(XperiaTopPortFilioModel);
        }

        // POST: Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, XperiaTopPortFilioModel model)
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

                    XperiaTopModeller imacRepartion = new XperiaTopModeller()
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
                    _XperiaTopModeller.Entity.Update(imacRepartion);
                    _XperiaTopModeller.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!XperiaTopModellerExists(model.ID))
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

        // GET: -/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var XperiaTopModeller = _XperiaTopModeller.Entity.GetById(id);

            if (XperiaTopModeller == null)
            {
                return NotFound();
            }

            return View(XperiaTopModeller);
        }

        // POST: -/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _XperiaTopModeller.Entity.Delete(id);
            _XperiaTopModeller.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool XperiaTopModellerExists(int id)
        {
            return _XperiaTopModeller.Entity.GetAll().Any(e => e.ID == id);
        }

        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Sony\Xperia_Top");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Sony\Xperia_Top");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Sony\Xperia_Top\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
