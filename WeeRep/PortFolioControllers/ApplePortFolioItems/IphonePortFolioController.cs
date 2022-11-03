using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Core.Entities.Apple;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Core.Interfaces;
using System.Threading.Tasks;
using WeeRep.Models.AplePortFolioModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.ApplePortFolio
{
    [Authorize]

    public class IphonePortFolioController : Controller
    {
        [Obsolete]
        private readonly IHostingEnvironment _hosting;
        private readonly IUnitOfWork<IphoneReprationPreis> _IphoneRepration;

        [Obsolete]
        public IphonePortFolioController(IUnitOfWork<IphoneReprationPreis> IphoneRepration, IHostingEnvironment hosting)
        {
            _IphoneRepration = IphoneRepration;
            _hosting = hosting;

        }

        // GET: IphonePortFolio
        public IActionResult Index()
        {
            return View(_IphoneRepration.Entity.GetAll());
        }

        // GET: IphonePortFolio/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iphoneRepration = _IphoneRepration.Entity.GetById(id);
                
            if (iphoneRepration == null)
            {
                return NotFound();
            }

            return View(iphoneRepration);
        }

        // GET: IphonePortFolio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IphonePortFolio/Create
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IphonePortFolioModel model)
        {
            if (ModelState.IsValid)
            {
                //Create File
                string ImageUrl = UploadFile(model.File) ;
                if (ImageUrl == null)
                {
                    return View();

                }
                IphoneReprationPreis iphoneRepration = new IphoneReprationPreis()
                {

                    PhoneName = model.PhoneName,
                    ImageName = ImageUrl,
                    SkærmOEM = model.SkærmOEM,
                    P_SkærmOEM = model.P_SkærmOEM,
                    SkærmOrgnal = model.SkærmOrgnal,
                    P_SkærmOrgnal = model.P_SkærmOrgnal,
                    Batteri = model.Batteri,
                    P_Batteri = model.P_Batteri,
                    Bagglas = model.Bagglas,
                    P_Bagglas = model.P_Bagglas,
                    BagglasOgRamme = model.BagglasOgRamme,
                    P_BagglasOgRamme = model.P_BagglasOgRamme,
                    Bagkamera = model.Bagkamera,
                    P_Bagkamera = model.P_Bagkamera,
                    Fejlfinding = model.Fejlfinding,
                    P_Fejlfinding = model.P_Fejlfinding,
                    FrontKameraNærhedsensor = model.FrontKameraNærhedsensor,
                    P_FrontKameraNærhedsensor = model.P_FrontKameraNærhedsensor,
                    Højtale = model.Højtale,
                    P_Højtale = model.P_Højtale,
                    Ladestik = model.Ladestik,
                    P_Ladestik = model.P_Ladestik,
                    TændSluk = model.TændSluk,
                    P_TændSluk = model.P_TændSluk,
                    Vibrator = model.Vibrator,
                    P_Vibrator = model.P_Vibrator,
                    VolumeLydløs = model.VolumeLydløs,
                    P_VolumeLydløs = model.P_VolumeLydløs,
                    Ørehøjtaler = model.Ørehøjtaler,
                    P_Ørehøjtaler = model.P_Ørehøjtaler

                };
                _IphoneRepration.Entity.Insert(iphoneRepration);
                _IphoneRepration.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
                
            }
        }

        // GET: IphonePortFolio/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iphoneRepration = _IphoneRepration.Entity.GetById(id);
            if (iphoneRepration == null)
            {
                return NotFound();
            }
            IphonePortFolioModel IphonePortFolioModel = new IphonePortFolioModel()
            {
                ID = iphoneRepration.ID,
                PhoneName = iphoneRepration.PhoneName,
                ImageName = iphoneRepration.ImageName,
                SkærmOEM = iphoneRepration.SkærmOEM,
                P_SkærmOEM = iphoneRepration.P_SkærmOEM,
                SkærmOrgnal = iphoneRepration.SkærmOrgnal,
                P_SkærmOrgnal = iphoneRepration.P_SkærmOrgnal,
                Batteri = iphoneRepration.Batteri,
                P_Batteri = iphoneRepration.P_Batteri,
                Bagglas = iphoneRepration.Bagglas,
                P_Bagglas = iphoneRepration.P_Bagglas,
                BagglasOgRamme = iphoneRepration.BagglasOgRamme,
                P_BagglasOgRamme = iphoneRepration.P_BagglasOgRamme,
                Bagkamera = iphoneRepration.Bagkamera,
                P_Bagkamera = iphoneRepration.P_Bagkamera,
                Fejlfinding = iphoneRepration.Fejlfinding,
                P_Fejlfinding = iphoneRepration.P_Fejlfinding,
                FrontKameraNærhedsensor = iphoneRepration.FrontKameraNærhedsensor,
                P_FrontKameraNærhedsensor = iphoneRepration.P_FrontKameraNærhedsensor,
                Højtale = iphoneRepration.Højtale,
                P_Højtale = iphoneRepration.P_Højtale,
                Ladestik = iphoneRepration.Ladestik,
                P_Ladestik = iphoneRepration.P_Ladestik,
                TændSluk = iphoneRepration.TændSluk,
                P_TændSluk = iphoneRepration.P_TændSluk,
                Vibrator = iphoneRepration.Vibrator,
                P_Vibrator = iphoneRepration.P_Vibrator,
                VolumeLydløs = iphoneRepration.VolumeLydløs,
                P_VolumeLydløs = iphoneRepration.P_VolumeLydløs,
                Ørehøjtaler = iphoneRepration.Ørehøjtaler,
                P_Ørehøjtaler = iphoneRepration.P_Ørehøjtaler
            };
            return View(IphonePortFolioModel);
        }


        // POST: IphonePortFolio/Edit/5
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IphonePortFolioModel model)
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

                    IphoneReprationPreis iphoneRepration = new IphoneReprationPreis()
                    {

                        ID = model.ID,
                        PhoneName = model.PhoneName,
                        ImageName = ImageUrl,
                        SkærmOEM = model.SkærmOEM,
                        P_SkærmOEM = model.P_SkærmOEM,
                        SkærmOrgnal = model.SkærmOrgnal,
                        P_SkærmOrgnal = model.P_SkærmOrgnal,
                        Batteri = model.Batteri,
                        P_Batteri = model.P_Batteri,
                        Bagglas = model.Bagglas,
                        P_Bagglas = model.P_Bagglas,
                        BagglasOgRamme = model.BagglasOgRamme,
                        P_BagglasOgRamme = model.P_BagglasOgRamme,
                        Bagkamera = model.Bagkamera,
                        P_Bagkamera = model.P_Bagkamera,
                        Fejlfinding = model.Fejlfinding,
                        P_Fejlfinding = model.P_Fejlfinding,
                        FrontKameraNærhedsensor = model.FrontKameraNærhedsensor,
                        P_FrontKameraNærhedsensor = model.P_FrontKameraNærhedsensor,
                        Højtale = model.Højtale,
                        P_Højtale = model.P_Højtale,
                        Ladestik = model.Ladestik,
                        P_Ladestik = model.P_Ladestik,
                        TændSluk = model.TændSluk,
                        P_TændSluk = model.P_TændSluk,
                        Vibrator = model.Vibrator,
                        P_Vibrator = model.P_Vibrator,
                        VolumeLydløs = model.VolumeLydløs,
                        P_VolumeLydløs = model.P_VolumeLydløs,
                        Ørehøjtaler = model.Ørehøjtaler,
                        P_Ørehøjtaler = model.P_Ørehøjtaler
                    };
                    _IphoneRepration.Entity.Update(iphoneRepration);
                    _IphoneRepration.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IphonExists(model.ID))
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

        // GET: IphonePortFolio/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iphoneRepration = _IphoneRepration.Entity.GetById(id);
                
            if (iphoneRepration == null)
            {
                return NotFound();
            }

            return View(iphoneRepration);
        }

        // POST: IphonePortFolio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _IphoneRepration.Entity.Delete(id);
            _IphoneRepration.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool IphonExists(int id)
        {
            return _IphoneRepration.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Apple\Iphone");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Apple\Iphone");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Apple\Iphone\{currentImage}");
                 
                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }

}
