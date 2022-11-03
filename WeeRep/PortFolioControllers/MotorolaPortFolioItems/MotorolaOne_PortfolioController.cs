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

    public class MotorolaOne_PortfolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<MotorolaOne_Serien> _MotorolaOne_Serien;
        [Obsolete]
        public MotorolaOne_PortfolioController(IUnitOfWork<MotorolaOne_Serien> MotorolaOne_Serien, IHostingEnvironment hosting)
        {
            _MotorolaOne_Serien = MotorolaOne_Serien;
            _hosting = hosting;

        }

        // GET: Motorola_One
        public IActionResult Index()
        {
            return View(_MotorolaOne_Serien.Entity.GetAll());
        }

        // GET: Motorola_One/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MotorolaOne_Serien = _MotorolaOne_Serien.Entity.GetById(id);

            if (MotorolaOne_Serien == null)
            {
                return NotFound();
            }

            return View(MotorolaOne_Serien);
        }

        // GET: Motorola_One/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Motorola_One/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Motorola_One_PortFolioModel model)
        {
            if (ModelState.IsValid)
            {
         
                //Create File
                string ImageUrl = UploadFile(model.File);
                if (ImageUrl == null)
                {
                    return View();

                }
                MotorolaOne_Serien MotorolaOne_Serien = new MotorolaOne_Serien()
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
                _MotorolaOne_Serien.Entity.Insert(MotorolaOne_Serien);
                _MotorolaOne_Serien.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: Motorola_One/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MotorolaOne_Serien = _MotorolaOne_Serien.Entity.GetById(id);
            if (MotorolaOne_Serien == null)
            {
                return NotFound();
            }
            Motorola_One_PortFolioModel Motorola_One_PortFolioModel = new Motorola_One_PortFolioModel()
            {
                ID = MotorolaOne_Serien.ID,
                PhoneName = MotorolaOne_Serien.PhoneName,
                ImageName = MotorolaOne_Serien.ImageName,
                Skærm = MotorolaOne_Serien.Skærm,
                P_Skærm = MotorolaOne_Serien.P_Skærm,
                Bagglas_Ramme = MotorolaOne_Serien.Bagglas_Ramme,
                P_Bagglas_Ramme = MotorolaOne_Serien.P_Bagglas_Ramme,
                Batteri = MotorolaOne_Serien.Batteri,
                P_Batteri = MotorolaOne_Serien.P_Batteri,
                Bagglas = MotorolaOne_Serien.Bagglas,
                P_Bagglas = MotorolaOne_Serien.P_Bagglas,
                Bagkamera = MotorolaOne_Serien.Bagkamera,
                P_Bagkamera = MotorolaOne_Serien.P_Bagkamera,
                Fejlfinding = MotorolaOne_Serien.Fejlfinding,
                P_Fejlfinding = MotorolaOne_Serien.P_Fejlfinding,
                Volume_Lydløs = MotorolaOne_Serien.Volume_Lydløs,
                P_Volume_Lydløs = MotorolaOne_Serien.P_Volume_Lydløs,
                Højtale = MotorolaOne_Serien.Højtale,
                P_Højtale = MotorolaOne_Serien.P_Højtale,
                Ladestik = MotorolaOne_Serien.Ladestik,
                P_Ladestik = MotorolaOne_Serien.P_Ladestik,
                FrontKamera = MotorolaOne_Serien.FrontKamera,
                P_FrontKamera = MotorolaOne_Serien.P_FrontKamera,
                Vibrator = MotorolaOne_Serien.Vibrator,
                P_Vibrator = MotorolaOne_Serien.P_Vibrator,
                Tænd_Sluk = MotorolaOne_Serien.Tænd_Sluk,
                P_Tænd_Sluk = MotorolaOne_Serien.P_Tænd_Sluk,
                Ørehøjtaler = MotorolaOne_Serien.Ørehøjtaler,
                P_Ørehøjtaler = MotorolaOne_Serien.P_Ørehøjtaler,
                Skærm_B = MotorolaOne_Serien.Skærm_B,
                P_Skærm_B = MotorolaOne_Serien.P_Skærm_B,

            };
            return View(Motorola_One_PortFolioModel);
        }

        // POST: Motorola_One/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Motorola_One_PortFolioModel model)
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
                    MotorolaOne_Serien imacRepartion = new MotorolaOne_Serien()
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
                    _MotorolaOne_Serien.Entity.Update(imacRepartion);
                    _MotorolaOne_Serien.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotorolaOne_SerienExists(model.ID))
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

        // GET: Motorola_One/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MotorolaOne_Serien = _MotorolaOne_Serien.Entity.GetById(id);

            if (MotorolaOne_Serien == null)
            {
                return NotFound();
            }

            return View(MotorolaOne_Serien);
        }

        // POST: Motorola_One/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _MotorolaOne_Serien.Entity.Delete(id);
            _MotorolaOne_Serien.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool MotorolaOne_SerienExists(int id)
        {
            return _MotorolaOne_Serien.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Motorola\Motorola_One");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Motorola\Motorola_One");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Motorola\Motorola_One\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
