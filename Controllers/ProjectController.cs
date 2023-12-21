using ApilPortfolio.Data;
using ApilPortfolio.Models;

using Microsoft.AspNetCore.Mvc;
using ApilPortfolio.Models.AdminModels;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace ApilPortfolio.Controllers
{
/*
    [Authorize]*/
    public class ProjectController : Controller
    {
        private readonly PortfolioDbContext Context;
        private readonly IWebHostEnvironment WebHost;

        public ProjectController(PortfolioDbContext context, IWebHostEnvironment webHost)
        {
            Context = context;
            WebHost = webHost;
        }

        [HttpGet]
        public IActionResult Create()
        {
            /*  List<ProjectModel> projects = GetProjectsFromDataSource();*/
           /* try
            {
                if(HttpContext.Session.GetString("Id") != null)
                {
                    return RedirectToAction("Login","Admin");
                }
                else
                {

                }
            }
            catch
            {
                return RedirectToAction("Login", "Admin");
            }*/
            return View();
            
        }

        /*private List<ProjectModel> GetProjectsFromDataSource()
        {
            var data = new List<ProjectModel>();
            {
                
            }
            return
        }*/

        [HttpPost]
        public IActionResult Create(ProjectModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImagePath != null && model.ImagePath.Length > 0)
                {
                    string uniqueFileName = UploadImage(model.ImagePath);
                    model.Image = uniqueFileName;

                    Context.Projects.Add(model);
                    Context.SaveChanges();

                    return RedirectToAction("Create");
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Model is not valid");
                return View(model);
            }

           
            var details = Context.Projects.ToList();
            return View(details);

        }

        private string UploadImage(IFormFile imageFile)
        {
            string uniqueFileName = string.Empty;
            if (imageFile != null)
            {
                string uploadFolder = Path.Combine(WebHost.WebRootPath, "ProjectImg/");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }


      
    }
}
