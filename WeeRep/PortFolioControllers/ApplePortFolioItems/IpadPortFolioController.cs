using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Apple;
using Infrastructure;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Core.Interfaces;
using WeeRep.Models.AplePortFolioModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WeeRep.PortFolioControllers.ApplePortFolioItems
{
    [Authorize]

    public class IpadPortFolioController : Controller
    {
        private readonly IUnitOfWork<IpadReprationPreis> _IpadRepration;
     
        private readonly IHostingEnvironment _hosting;
   
        public IpadPortFolioController(IUnitOfWork<IpadReprationPreis> IpadRepration, IHostingEnvironment hosting)
        {
            _IpadRepration = IpadRepration;
            _hosting = hosting;
        }

        // GET: IpadPortFolio
        public IActionResult Index()
        {
            return View(_IpadRepration.Entity.GetAll());
        }

        // GET: IpadPortFolio/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ipadReprationPreis = _IpadRepration.Entity.GetById(id);
              
            if (ipadReprationPreis == null)
            {
                return NotFound();
            }

            return View(ipadReprationPreis);
        }

        // GET: IpadPortFolio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IpadPortFolio/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IpadPortFolioModel model)
        {
            if (ModelState.IsValid)
            {

                //Create File
                string ImageUrl = UploadFile(model.File);
                if (ImageUrl == null)
                {
                    return View();

                }
                IpadReprationPreis ipadReprationPreis = new IpadReprationPreis()
                {
                    
                    PhoneName = model.PhoneName,
                    ImageName = ImageUrl,
                    FrontKamera = model.FrontKamera,
                    P_FrontKamera = model.P_FrontKamera,
                    Skærm = model.Skærm,
                    P_Skærm = model.P_Skærm,
                    Batteri = model.Batteri,
                    P_Batteri = model.P_Batteri,
                    SkærmLcd = model.SkærmLcd,
                    P_SkærmLcd = model.P_SkærmLcd,
                    Bagcover = model.Bagcover,
                    P_Bagcover = model.P_Bagcover,
                    Bagkamera = model.Bagkamera,
                    P_Bagkamera = model.P_Bagkamera,
                    Fejlfinding = model.Fejlfinding,
                    P_Fejlfinding = model.P_Fejlfinding,
                    Kamera_Glas = model.Kamera_Glas,
                    P_Kamera_Glas = model.P_Kamera_Glas,
                    Højtale = model.Højtale,
                    P_Højtale = model.P_Højtale,
                    Ladestik = model.Ladestik,
                    P_Ladestik = model.P_Ladestik,
                    Panserglas = model.Panserglas,
                    P_Panserglas = model.P_Panserglas,
                    Home_Knap = model.Home_Knap,
                    P_Home_Knap = model.P_Home_Knap,
                    SIM_KORT = model.SIM_KORT,
                    P_SIM_KORT = model.P_SIM_KORT,
                    Tænd_Sluk = model.Tænd_Sluk,
                    P_Tænd_Sluk = model.P_Tænd_Sluk,
                    Antenne = model.Antenne,
                    P_Antenne = model.P_Antenne,
                    WIFI_Antenne = model.WIFI_Antenne,
                    P_WIFI_Antenne = model.P_WIFI_Antenne,
                };
                _IpadRepration.Entity.Insert(ipadReprationPreis);
                _IpadRepration.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: IpadPortFolio/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ipadReprationPreis = _IpadRepration.Entity.GetById(id);
            if (ipadReprationPreis == null)
            {
                return NotFound();
            }
        
            IpadPortFolioModel IpadPortFolioModel = new IpadPortFolioModel()
            {
                ID = ipadReprationPreis.ID,
                PhoneName = ipadReprationPreis.PhoneName,
                ImageName = ipadReprationPreis.ImageName,
                FrontKamera = ipadReprationPreis.FrontKamera,
                P_FrontKamera = ipadReprationPreis.P_FrontKamera,
                Skærm = ipadReprationPreis.Skærm,
                P_Skærm = ipadReprationPreis.P_Skærm,
                Batteri = ipadReprationPreis.Batteri,
                P_Batteri = ipadReprationPreis.P_Batteri,
                SkærmLcd = ipadReprationPreis.SkærmLcd,
                P_SkærmLcd = ipadReprationPreis.P_SkærmLcd,
                Bagcover = ipadReprationPreis.Bagcover,
                P_Bagcover = ipadReprationPreis.P_Bagcover,
                Bagkamera = ipadReprationPreis.Bagkamera,
                P_Bagkamera = ipadReprationPreis.P_Bagkamera,
                Fejlfinding = ipadReprationPreis.Fejlfinding,
                P_Fejlfinding = ipadReprationPreis.P_Fejlfinding,
                Kamera_Glas = ipadReprationPreis.Kamera_Glas,
                P_Kamera_Glas = ipadReprationPreis.P_Kamera_Glas,
                Højtale = ipadReprationPreis.Højtale,
                P_Højtale = ipadReprationPreis.P_Højtale,
                Ladestik = ipadReprationPreis.Ladestik,
                P_Ladestik = ipadReprationPreis.P_Ladestik,
                Panserglas = ipadReprationPreis.Panserglas,
                P_Panserglas = ipadReprationPreis.P_Panserglas,
                Home_Knap = ipadReprationPreis.Home_Knap,
                P_Home_Knap = ipadReprationPreis.P_Home_Knap,
                SIM_KORT = ipadReprationPreis.SIM_KORT,
                P_SIM_KORT = ipadReprationPreis.P_SIM_KORT,
                Tænd_Sluk = ipadReprationPreis.Tænd_Sluk,
                P_Tænd_Sluk = ipadReprationPreis.P_Tænd_Sluk,
                Antenne = ipadReprationPreis.Antenne,
                P_Antenne = ipadReprationPreis.P_Antenne,
                WIFI_Antenne = ipadReprationPreis.WIFI_Antenne,
                P_WIFI_Antenne = ipadReprationPreis.P_WIFI_Antenne,
            };
            return View(IpadPortFolioModel);
        }

 
        // POST: IpadPortFolio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IpadPortFolioModel model)
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
                    IpadReprationPreis ipadRepration = new IpadReprationPreis()
                    {
                        ID = model.ID,
                        PhoneName = model.PhoneName,
                        ImageName = ImageUrl,
                        FrontKamera = model.FrontKamera,
                        P_FrontKamera = model.P_FrontKamera,
                        Skærm = model.Skærm,
                        P_Skærm = model.P_Skærm,
                        Batteri = model.Batteri,
                        P_Batteri = model.P_Batteri,
                        SkærmLcd = model.SkærmLcd,
                        P_SkærmLcd = model.P_SkærmLcd,
                        Bagcover = model.Bagcover,
                        P_Bagcover = model.P_Bagcover,
                        Bagkamera = model.Bagkamera,
                        P_Bagkamera = model.P_Bagkamera,
                        Fejlfinding = model.Fejlfinding,
                        P_Fejlfinding = model.P_Fejlfinding,
                        Kamera_Glas = model.Kamera_Glas,
                        P_Kamera_Glas = model.P_Kamera_Glas,
                        Højtale = model.Højtale,
                        P_Højtale = model.P_Højtale,
                        Ladestik = model.Ladestik,
                        P_Ladestik = model.P_Ladestik,
                        Panserglas = model.Panserglas,
                        P_Panserglas = model.P_Panserglas,
                        Home_Knap = model.Home_Knap,
                        P_Home_Knap = model.P_Home_Knap,
                        SIM_KORT = model.SIM_KORT,
                        P_SIM_KORT = model.P_SIM_KORT,
                        Tænd_Sluk = model.Tænd_Sluk,
                        P_Tænd_Sluk = model.P_Tænd_Sluk,
                        Antenne = model.Antenne,
                        P_Antenne = model.P_Antenne,
                        WIFI_Antenne = model.WIFI_Antenne,
                        P_WIFI_Antenne = model.P_WIFI_Antenne,
                    };
                    _IpadRepration.Entity.Update(ipadRepration);
                    _IpadRepration.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IpadReprationPreisExists(model.ID))
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

        // GET: IpadPortFolio/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ipadReprationPreis = _IpadRepration.Entity.GetById(id);
              
            if (ipadReprationPreis == null)
            {
                return NotFound();
            }

            return View(ipadReprationPreis);
        }

        // POST: IpadPortFolio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _IpadRepration.Entity.Delete(id);
            _IpadRepration.Save();        
            return RedirectToAction(nameof(Index));
        }

        private bool IpadReprationPreisExists(int id)
        {
            return _IpadRepration.Entity.GetAll().Any(e => e.ID == id);
        }
        //Creat File from IFormFile
        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Apple\Ipad");
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
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\Apple\Ipad");
                string fileName = Guid.NewGuid().ToString() + "-" + imageFile.FileName;
                string fullPath = Path.Combine(uploads, fileName);
                imageFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (fullPath != currentImage)
                {
                    string oldfilpath = Path.Combine(_hosting.WebRootPath, @$"img\Apple\Ipad\{currentImage}");

                    System.IO.File.Delete(oldfilpath);
                }
                return fileName;
            }
            return currentImage;

        }
    }
}
