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

    public class MotorolaEdge_PortfolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<MotorolaEdge_Serien > _MotorolaEdge_Serien ;
        [Obsolete]
        public MotorolaEdge_PortfolioController(IUnitOfWork<MotorolaEdge_Serien > MotorolaEdge_Serien , IHostingEnvironment hosting)
        {
            _MotorolaEdge_Serien  = MotorolaEdge_Serien ;
            _hosting = hosting;

        }

        // GET: MotorolaEdge
        public IActionResult Index()
        {
            return View(_MotorolaEdge_Serien .Entity.GetAll());
        }

        // GET: MotorolaEdge/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MotorolaEdge_Serien  = _MotorolaEdge_Serien .Entity.GetById(id);

            if (MotorolaEdge_Serien  == null)
            {
                return NotFound();
            }

            return View(MotorolaEdge_Serien );
        }

        // GET: MotorolaEdge/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MotorolaEdge/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Motorola_Edge_PortFolioModel model)
        {
            if (ModelState.IsValid)
            {
                //Create File
                string ImageUrl = UploadFile(model.File) ;
                if (ImageUrl == null)
                {
                    return View();

                }
                MotorolaEdge_Serien  MotorolaEdge_Serien  = new MotorolaEdge_Serien ()
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
                _MotorolaEdge_Serien .Entity.Insert(MotorolaEdge_Serien );
                _MotorolaEdge_Serien .Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: MotorolaEdge/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MotorolaEdge_Serien  = _MotorolaEdge_Serien .Entity.GetById(id);
            if (MotorolaEdge_Serien  == null)
            {
                return NotFound();
            }
            Motorola_Edge_PortFolioModel Motorola_Edge_PortFolioModel = new Motorola_Edge_PortFolioModel()
            {
                ID = MotorolaEdge_Serien.ID,
                PhoneName = MotorolaEdge_Serien .PhoneName,
                ImageName = MotorolaEdge_Serien .ImageName,
                Skærm = MotorolaEdge_Serien .Skærm,
                P_Skærm = MotorolaEdge_Serien .P_Skærm,
                Bagglas_Ramme = MotorolaEdge_Serien .Bagglas_Ramme,
                P_Bagglas_Ramme = MotorolaEdge_Serien .P_Bagglas_Ramme,
                Batteri = MotorolaEdge_Serien .Batteri,
                P_Batteri = MotorolaEdge_Serien .P_Batteri,
                Bagglas = MotorolaEdge_Serien .Bagglas,
                P_Bagglas = MotorolaEdge_Serien .P_Bagglas,
                Bagkamera = MotorolaEdge_Serien .Bagkamera,
                P_Bagkamera = MotorolaEdge_Serien .P_Bagkamera,
                Fejlfinding = MotorolaEdge_Serien .Fejlfinding,
                P_Fejlfinding = MotorolaEdge_Serien .P_Fejlfinding,
                Volume_Lydløs = MotorolaEdge_Serien .Volume_Lydløs,
                P_Volume_Lydløs = MotorolaEdge_Serien .P_Volume_Lydløs,
                Højtale = MotorolaEdge_Serien .Højtale,
                P_Højtale = MotorolaEdge_Serien .P_Højtale,
                Ladestik = MotorolaEdge_Serien .Ladestik,
                P_Ladestik = MotorolaEdge_Serien .P_Ladestik,
                FrontKamera = MotorolaEdge_Serien .FrontKamera,
                P_FrontKamera = MotorolaEdge_Serien .P_FrontKamera,
                Vibrator = MotorolaEdge_Serien .Vibrator,
                P_Vibrator = MotorolaEdge_Serien .P_Vibrator,
                Tænd_Sluk = MotorolaEdge_Serien .Tænd_Sluk,
                P_Tænd_Sluk = MotorolaEdge_Serien .P_Tænd_Sluk,
                Ørehøjtaler = MotorolaEdge_Serien .Ørehøjtaler,
                P_Ørehøjtaler = MotorolaEdge_Serien .P_Ørehøjtaler,
                Skærm_B = MotorolaEdge_Serien .Skærm_B,
                P_Skærm_B = MotorolaEdge_Serien .P_Skærm_B,

            };
            return View(Motorola_Edge_PortFolioModel);
        }

        // POST: MotorolaEdge/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Motorola_Edge_PortFolioModel model)
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
                    MotorolaEdge_Serien  imacRepartion = new MotorolaEdge_Serien ()
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
                    _MotorolaEdge_Serien .Entity.Update(imacRepartion);
                    _MotorolaEdge_Serien .Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotorolaEdge_SerienExists(model.ID))
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

        // GET: MotorolaEdge/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MotorolaEdge_Serien  = _MotorolaEdge_Serien .Entity.GetById(id);

            if (MotorolaEdge_Serien  == null)
            {
                return NotFound();
            }

            return View(MotorolaEdge_Serien );
        }

        // POST: MotorolaEdge/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _MotorolaEdge_Serien .Entity.Delete(id);
            _MotorolaEdge_Serien .Save();
            return RedirectToAction(nameof(Index));
        }

        private bool MotorolaEdge_SerienExists(int id)
        {
            return _MotorolaEdge_Serien .Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Motorola\Motorola_Edge");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Motorola\Motorola_Edge");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Motorola\Motorola_Edge\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
