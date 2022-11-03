
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Apple;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using WeeRep.Models.AplePortFolioModel;
using System.IO;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.ApplePortFolioItems
{
    [Authorize]

    public class AppleWatchPortFolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<AppleWatchReprationPreis> _AppleWatchReprationPreis;

        [Obsolete]
        public AppleWatchPortFolioController(IUnitOfWork<AppleWatchReprationPreis> AppleWatchReprationPreis, IHostingEnvironment hosting)
        {
            _AppleWatchReprationPreis = AppleWatchReprationPreis;
            _hosting = hosting;
        }
        // GET: AppleWatchPortFolio
        public IActionResult Index()
        {
            return View(_AppleWatchReprationPreis.Entity.GetAll());
        }

        // GET: AppleWatchPortFolio/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var AppleWatchReprationPreis = _AppleWatchReprationPreis.Entity.GetById(id);

            if (AppleWatchReprationPreis == null)
            {
                return NotFound();
            }

            return View(AppleWatchReprationPreis);
        }

        // GET: AppleWatchPortFolio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppleWatchPortFolio/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AppleWatchPortFolioModel model)
        {
            if (ModelState.IsValid)
            {

                //Create File
                string ImageUrl = UploadFile(model.File);
                if (ImageUrl == null)
                {
                    return View();

                }

                AppleWatchReprationPreis AppleWatchReprationPreis = new AppleWatchReprationPreis()
                {

                    PhoneName = model.PhoneName,
                    ImageName = ImageUrl,

                    Skærm_A = model.Skærm_A,
                    P_Skærm_A = model.P_Skærm_A,

                    Skærm_B = model.Skærm_B,
                    P_Skærm_B = model.P_Skærm_B,

                    Skærm_C = model.Skærm_C,
                    P_Skærm_C = model.P_Skærm_C,

                    Skærm_D = model.Skærm_D,
                    P_Skærm_D = model.P_Skærm_D,
               
                    Batteri_A = model.Batteri_A,
                    P_Batteri_A = model.P_Batteri_A,

                    Fejlfinding = model.Fejlfinding,
                    p_Fejlfinding = model.p_Fejlfinding,

                    Batteri_B = model.Batteri_B,
                    P_Batteri_B = model.P_Batteri_B,
                    
             

                };
                _AppleWatchReprationPreis.Entity.Insert(AppleWatchReprationPreis);
                _AppleWatchReprationPreis.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);

            }
        }

        // GET: AppleWatchPortFolio/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var AppleWatchReprationPreis = _AppleWatchReprationPreis.Entity.GetById(id);
            if (AppleWatchReprationPreis == null)
            {
                return NotFound();
            }
            AppleWatchPortFolioModel AppleWatchPortFolioModel = new AppleWatchPortFolioModel()
            {
                ID = AppleWatchReprationPreis.ID,
                PhoneName = AppleWatchReprationPreis.PhoneName,
                ImageName = AppleWatchReprationPreis.ImageName,

                Skærm_A = AppleWatchReprationPreis.Skærm_A,
                P_Skærm_A = AppleWatchReprationPreis.P_Skærm_A,

                Skærm_B = AppleWatchReprationPreis.Skærm_B,
                P_Skærm_B = AppleWatchReprationPreis.P_Skærm_B,

                Skærm_C = AppleWatchReprationPreis.Skærm_C,
                P_Skærm_C = AppleWatchReprationPreis.P_Skærm_C,

                Skærm_D = AppleWatchReprationPreis.Skærm_D,
                P_Skærm_D = AppleWatchReprationPreis.P_Skærm_D, 
                
                Batteri_A = AppleWatchReprationPreis.Batteri_A,
                P_Batteri_A = AppleWatchReprationPreis.P_Batteri_A,

                Fejlfinding = AppleWatchReprationPreis.Fejlfinding,
                p_Fejlfinding = AppleWatchReprationPreis.p_Fejlfinding,

                Batteri_B = AppleWatchReprationPreis.Batteri_B,
                P_Batteri_B = AppleWatchReprationPreis.P_Batteri_B,
                


            };
            return View(AppleWatchPortFolioModel);
        }

        // POST: AppleWatchPortFolio/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, AppleWatchPortFolioModel model)
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
                    AppleWatchReprationPreis AppleWatchRepration = new AppleWatchReprationPreis()
                    {
                        ID = model.ID,
                        PhoneName = model.PhoneName,
                        ImageName = ImageUrl,

                        Skærm_A = model.Skærm_A,
                        P_Skærm_A = model.P_Skærm_A,

                        Skærm_B = model.Skærm_B,
                        P_Skærm_B = model.P_Skærm_B,

                        Skærm_D = model.Skærm_D,
                        P_Skærm_D = model.P_Skærm_D,

                        Batteri_A = model.Batteri_A,
                        P_Batteri_A = model.P_Batteri_A,

                        Fejlfinding = model.Fejlfinding,
                        p_Fejlfinding = model.p_Fejlfinding,

                        Batteri_B = model.Batteri_B,
                        P_Batteri_B = model.P_Batteri_B,

                        Skærm_C = model.Skærm_C,
                        P_Skærm_C = model.P_Skærm_C,
                      

                    };
                    _AppleWatchReprationPreis.Entity.Update(AppleWatchRepration);
                    _AppleWatchReprationPreis.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppleWatchReprationPreisExists(model.ID))
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

        // GET: AppleWatchPortFolio/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var AppleWatchReprationPreis = _AppleWatchReprationPreis.Entity.GetById(id);

            if (AppleWatchReprationPreis == null)
            {
                return NotFound();
            }

            return View(AppleWatchReprationPreis);
        }

        // POST: AppleWatchPortFolio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _AppleWatchReprationPreis.Entity.Delete(id);
            _AppleWatchReprationPreis.Save();
            return RedirectToAction(nameof(Index));
        }


        private bool AppleWatchReprationPreisExists(int id)
        {
            return _AppleWatchReprationPreis.Entity.GetAll().Any(e => e.ID == id);
        }

        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Apple\Apple Watch");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Apple\Apple Watch");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Apple\Apple Watch\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
