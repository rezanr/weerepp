using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Samsung;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using WeeRep.Models.SamsungPortFolioModel;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.SamsungPortFolioItems
{
    [Authorize]

    public class GalaxyNotePortFolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<GalaxyNoteSerien> _GalaxyNoteSerien;
        [Obsolete]
        public GalaxyNotePortFolioController(IUnitOfWork<GalaxyNoteSerien> GalaxyNoteSerien, IHostingEnvironment hosting)
        {
            _GalaxyNoteSerien = GalaxyNoteSerien;
            _hosting = hosting;

        }

        // GET: GalaxyNote
        public IActionResult Index()
        {
            return View(_GalaxyNoteSerien.Entity.GetAll());
        }

        // GET: GalaxyNote/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var GalaxyNoteSerien = _GalaxyNoteSerien.Entity.GetById(id);

            if (GalaxyNoteSerien == null)
            {
                return NotFound();
            }

            return View(GalaxyNoteSerien);
        }

        // GET: GalaxyNote/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GalaxyNote/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Galaxy_Note_PortFolioModel model)
        {
            if (ModelState.IsValid)
            {
        
                //Create File
                string ImageUrl = UploadFile(model.File) ;
                if (ImageUrl == null)
                {
                    return View();

                }
                GalaxyNoteSerien GalaxyNoteSerien = new GalaxyNoteSerien()
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
                _GalaxyNoteSerien.Entity.Insert(GalaxyNoteSerien);
                _GalaxyNoteSerien.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }
        // GET: GalaxyNote/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var GalaxyNoteSerien = _GalaxyNoteSerien.Entity.GetById(id);
            if (GalaxyNoteSerien == null)
            {
                return NotFound();
            }
            Galaxy_Note_PortFolioModel Galaxy_Note_PortFolioModel = new Galaxy_Note_PortFolioModel()
            {
                ID = GalaxyNoteSerien.ID,
                PhoneName = GalaxyNoteSerien.PhoneName,
                ImageName = GalaxyNoteSerien.ImageName,
                Skærm = GalaxyNoteSerien.Skærm,
                P_Skærm = GalaxyNoteSerien.P_Skærm,
                UV = GalaxyNoteSerien.UV,
                P_UV = GalaxyNoteSerien.P_UV,
                Batteri = GalaxyNoteSerien.Batteri,
                P_Batteri = GalaxyNoteSerien.P_Batteri,
                Bagglas = GalaxyNoteSerien.Bagglas,
                P_Bagglas = GalaxyNoteSerien.P_Bagglas,
                Bagkamera = GalaxyNoteSerien.Bagkamera,
                P_Bagkamera = GalaxyNoteSerien.P_Bagkamera,
                Fejlfinding = GalaxyNoteSerien.Fejlfinding,
                P_Fejlfinding = GalaxyNoteSerien.P_Fejlfinding,
                Volume_Lydløs = GalaxyNoteSerien.Volume_Lydløs,
                P_Volume_Lydløs = GalaxyNoteSerien.P_Volume_Lydløs,
                Højtale = GalaxyNoteSerien.Højtale,
                P_Højtale = GalaxyNoteSerien.P_Højtale,
                Ladestik = GalaxyNoteSerien.Ladestik,
                P_Ladestik = GalaxyNoteSerien.P_Ladestik,
                FrontKamera = GalaxyNoteSerien.FrontKamera,
                P_FrontKamera = GalaxyNoteSerien.P_FrontKamera,
                Vibrator = GalaxyNoteSerien.Vibrator,
                P_Vibrator = GalaxyNoteSerien.P_Vibrator,
                Tænd_Sluk = GalaxyNoteSerien.Tænd_Sluk,
                P_Tænd_Sluk = GalaxyNoteSerien.P_Tænd_Sluk,
                Ørehøjtaler = GalaxyNoteSerien.Ørehøjtaler,
                P_Ørehøjtaler = GalaxyNoteSerien.P_Ørehøjtaler

            };
            return View(Galaxy_Note_PortFolioModel);
        }

        // POST: GalaxyNote/Edit/5
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Galaxy_Note_PortFolioModel model)
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

                    GalaxyNoteSerien imacRepartion = new GalaxyNoteSerien()
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
                    _GalaxyNoteSerien.Entity.Update(imacRepartion);
                    _GalaxyNoteSerien.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GalaxyNoteSerienExists(model.ID))
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

        // GET: GalaxyNote/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var GalaxyNoteSerien = _GalaxyNoteSerien.Entity.GetById(id);

            if (GalaxyNoteSerien == null)
            {
                return NotFound();
            }

            return View(GalaxyNoteSerien);
        }

        // POST: GalaxyNote/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _GalaxyNoteSerien.Entity.Delete(id);
            _GalaxyNoteSerien.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool GalaxyNoteSerienExists(int id)
        {
            return _GalaxyNoteSerien.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Samsung\Galaxy_Note");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Samsung\Galaxy_Note");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Samsung\Galaxy_Note\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
