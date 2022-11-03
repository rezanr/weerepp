using Core.EmailsModel;
using Core.Entities;
using Core.Entities.Apple;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WeeRep.Models;
using WeeRep.ViewModels;

namespace WeeRep.Controllers
{

    public class HomeController : Controller
    {
        private EmailAddress FromAndToEmailAddress;
        private IEmailService EmailService;
        private IUnitOfWork<Images_Tabel> _Images;

        public HomeController(EmailAddress _fromAddress,
            IEmailService _emailService,
            IUnitOfWork<Images_Tabel> Images)
        {
            _Images = Images;
            FromAndToEmailAddress = _fromAddress;
            EmailService = _emailService;
        }
        public IActionResult Index()
        {
            HomeViweModel model = new HomeViweModel()
            {
                Images = _Images.Entity.GetAll().ToList(),
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ManufacturesrsReparation()
        {
            return View();
        }
        [HttpGet]
        public ViewResult BestilReparation()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult BestilReparation(BestilReparationForm model)
        {
            if (ModelState.IsValid)
            {
                EmailMessage msgToSend = new EmailMessage
                {
                    FromAddresses = new List<EmailAddress> { FromAndToEmailAddress },
                    ToAddresses = new List<EmailAddress> { FromAndToEmailAddress },

                    Content = "<h5> Navn :" + $"{model.Name}" + "<h5>" +
                                "<h5> Email :" + $"{model.Email}" + "<h5>" +
                                "<h5>Mobil Nummer :" + $"{model.Mobil}" + "<h5>" +
                                "<h5>Mobil Model :" + $"{model.PhonModel}" + "<h5>" +
                                "<h5>Reparations Dag :" + $"{model.Dag}" + " - " + " Reparations Tid :" + $"{model.TimeFrom}" + " -  Reparations Tid :" + $"{model.TimeEnd}" + "<h5>" +
                                "<h5> kommentar :" + $"{model.Message}" + "<h5>",

                    Subject = "Bestilng Reparation",
                };
                EmailService.Send(msgToSend);
                return RedirectToAction("BestilReparation");
            }
            //else if (ModelState.IsValid == false )
            //{
            //    return BestilReparation();
            //}
            return View("BestilReparation", model);
        }
        //Contact----------------

        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Contact(ContactForm model)
        {
            if (ModelState.IsValid )
            {
                EmailMessage msgToSend = new EmailMessage
                {
                    FromAddresses = new List<EmailAddress> { FromAndToEmailAddress },
                    ToAddresses = new List<EmailAddress> { FromAndToEmailAddress },

                    Content = "<h5> Navn :" + $"{model.Name}" + "<h5>" +
                                "<h5> Email :" + $"{model.Email}" + "<h5>" +
                                "<h5>Mobil Nummer :" + $"{model.Mobil}" + "<h5>" +
                                "<h5> kommentar :" + $"{model.Message}" + "<h5>",

                    Subject = "Contakt Os",

                };

                EmailService.Send(msgToSend);
                return RedirectToAction("Contact");
            }
            //else if (ModelState.IsValid == false )
            //{
            //    return Contact();
            //}
            return View("Contact", model);
        }
  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
