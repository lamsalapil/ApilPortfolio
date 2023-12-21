
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApilPortfolio.Data;
using ApilPortfolio.Models.AdminModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;

namespace ApilPortfolio.Controllers
{
    
    public class AdminController : Controller
    {
        private readonly PortfolioDbContext _context;

        public AdminController(PortfolioDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index() 
        {
           /* try
            {
                if (HttpContext.Session.GetString("Id") != null)
                {
                    return RedirectToAction("Login");
                }
                else
                {

                }
            }
            catch
            {
                return RedirectToAction("Login");
            }*/
            return View();
        }


       public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            /*using (var context = _context)
            {*/
                var user = await _context.LoginModel.FirstOrDefaultAsync(u => u.Name == model.Name && u.Password == model.Password );

                if (user != null)
                {
                   

                    
                        

                    /*TempData["success"] = "Login successfully!!";*/
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    TempData["Msg"] = "Invalid Name/Password";
                }

                return View(model);
            /*}*/
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return View("Login");
        }
    }
}

/*

if (user != null)
{
    var claim = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.Name)
                    };
    var identity = new ClaimsIdentity(
        claim, CookieAuthenticationDefaults.AuthenticationScheme);
    var principal = new ClaimsPrincipal(identity);
    var props = new AuthenticationProperties();

    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();


    *//*TempData["success"] = "Login successfully!!";*//*
    return RedirectToAction("Index", "Admin");
}
else
{
    TempData["Msg"] = "Invalid Name/Password";
}

return View(model);
            }*/