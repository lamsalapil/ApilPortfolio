using ApilPortfolio.Data;
using ApilPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;

namespace ApilPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PortfolioDbContext _context;

        public HomeController(ILogger<HomeController> logger, PortfolioDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                var result = _context.Contact.AddAsync(contact);

#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'
                if (result == null)
                {
                    ModelState.AddModelError(string.Empty, "Surver error.");
                }
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

                try
                {
                    MailMessage mail = new MailMessage();

                    //you need to enter mail address
                    mail.From = new MailAddress(contact.Email);

                    //to email addresss. you need to enter your to email address
                    mail.To.Add("everestdogg@gmail.com");

                    /*//you can specify also cc and bcc
                    mail.CC.Add("");
                    mail.Bcc.Add("");*/


                    mail.IsBodyHtml = true;
                    string content = "Name: " + contact.Name;
                    content += "<br/> Massage: " + contact.Massages;

                    mail.Body = content;

                    //create smtp instant
                    //you need to pass mail server address and you can also specify the port number if you required
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                    //create network credential and you to give from address and password
                   /* NetworkCredential networkCredential = new NetworkCredential("everestdogg@gmail.com", "9804116597");*/
                    smtpClient.UseDefaultCredentials = false;
                   /* smtpClient.Credentials = networkCredential;*/
                    smtpClient.Port = 576;
                    smtpClient.EnableSsl = false;
                    smtpClient.Send(mail);


                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = ex.Message;
                }


                _context.SaveChangesAsync();
                ViewBag.massage = contact.Name + "Adding Succesfully.";




            }
           
           
           
            return RedirectToAction("Index");

            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}