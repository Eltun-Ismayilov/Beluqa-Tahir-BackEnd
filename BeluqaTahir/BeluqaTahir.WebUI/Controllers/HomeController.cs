using BeluqaTahir.Applications.ContactModules;
using BeluqaTahir.Applications.Core.Extension;
using BeluqaTahir.Applications.HappyClientss;
using BeluqaTahir.Domain.Model.DataContexts;
using BeluqaTahir.Domain.Model.Entity;
using BeluqaTahir.Domain.Model.Entity.Membership;
using BeluqaTahir.Domain.Model.FormModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BeluqaTahir.WebUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {

        readonly IMediator db;
        readonly BeluqaTahirDbContext bt;
        readonly IConfiguration configuration;
        readonly UserManager<BeluqaUser> userManager;
        readonly SignInManager<BeluqaUser> signInManager;

        public HomeController(IMediator db, BeluqaTahirDbContext bt, IConfiguration configuration, UserManager<BeluqaUser> userManager, SignInManager<BeluqaUser> signInManager)
        {
            this.db = db;
            this.bt = bt;
            this.configuration = configuration;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            Request.Cookies.TryGetValue("basket", out string basketJson1);
            if (basketJson1?.Length > 0)
            {
                string[] arr = basketJson1.Split(',');
                ViewBag.ms = arr.Length / 2;
            }
            else
            {
                ViewBag.ms = 0;
            }
            return View();
        }
        public async Task<IActionResult> About(AboutPagedQuery query)
        {

            var respons = await db.Send(query);
            Request.Cookies.TryGetValue("basket", out string basketJson1);
            if (basketJson1?.Length > 0)
            {
                string[] arr = basketJson1.Split(',');
                ViewBag.ms = arr.Length / 2;
            }
            else
            {
                ViewBag.ms = 0;
            }
            return View(respons);
        }
        [HttpGet]
        public IActionResult Contact()
        {
            Request.Cookies.TryGetValue("basket", out string basketJson1);
            if (basketJson1?.Length > 0)
            {
                string[] arr = basketJson1.Split(',');
                ViewBag.ms = arr.Length / 2;
            }
            else
            {
                ViewBag.ms = 0;
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(ContactCreateCommand query)
        {
            Request.Cookies.TryGetValue("basket", out string basketJson1);
            if (basketJson1?.Length > 0)
            {
                string[] arr = basketJson1.Split(',');
                ViewBag.ms = arr.Length / 2;
            }
            else
            {
                ViewBag.ms = 0;
            }
            var respons = await db.Send(query);
            return Json(respons);
        }
        [HttpGet]
        public IActionResult Register()
        {
            //Eger giris edibse routda myaccount/sing yazanda o seyfe acilmasin homa tulaasin
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "Home");

            }
            Request.Cookies.TryGetValue("basket", out string basketJson1);
            if (basketJson1?.Length > 0)
            {
                string[] arr = basketJson1.Split(',');
                ViewBag.message = arr.Length / 2;
            }
            else
            {
                ViewBag.message = 0;
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel register)
        {
            Request.Cookies.TryGetValue("basket", out string basketJson1);
            if (basketJson1?.Length > 0)
            {
                string[] arr = basketJson1.Split(',');
                ViewBag.message = arr.Length / 2;
            }
            else
            {
                ViewBag.message = 0;
            }
            //Eger giris edibse routda myaccount/sing yazanda o seyfe acilmasin homa tulaasin
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "Home");

            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            //Yeni user yaradiriq.
            BeluqaUser user = new BeluqaUser
            {

                UserName = register.UserName,
                Email = register.Email,
                Activates = true,
                NewPassword="1"
            };



            string token = $"subscribetoken-{register.UserName}-{DateTime.Now:yyyyMMddHHmmss}"; // token yeni id goturuk

            token = token.Encrypt("");

            string path = $"{Request.Scheme}://{Request.Host}/subscribe-confirmm?token={token}"; // path duzeldirik



            var mailSended = configuration.SendEmail(user.Email, "BeluqaTahir", $"Zehmet olmasa <a href={path}>Link</a> vasitesile abuneliyi tamamlayin");


            var person = await userManager.FindByNameAsync(user.UserName);


            if (person == null)
            {
                //Burda biz userManager vasitesile user ve RegistirVM passwword yoxluyuruq.(yaradiriq)
                var identityRuselt = await userManager.CreateAsync(user, register.Password);


                //Startupda yazdigimiz qanunlara uymursa Configure<IdentityOptions> onda error qaytariq summary ile.;
                if (!identityRuselt.Succeeded)
                {
                    foreach (var error in identityRuselt.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

                //Yratdigimiz user ilk yarananda user rolu verik.

                await userManager.AddToRoleAsync(user, "User");

                return RedirectToAction("Signin", "Home");

            }


            if (person.UserName != null)
            {
                ViewBag.ms = "Bu username evvelceden qeydiyyatdan kecib";

                return View(register);
            }
            return null;

        }
        public IActionResult Signin()
        {
            //Eger giris edibse routda myaccount/sing yazanda o seyfe acilmasin homa tulaasin
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "Home");

            }
            Request.Cookies.TryGetValue("basket", out string basketJson1);
            if (basketJson1?.Length > 0)
            {
                string[] arr = basketJson1.Split(',');
                ViewBag.message = arr.Length / 2;
            }
            else
            {
                ViewBag.message = 0;
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signin(LoginFormModel user)
        {
            Request.Cookies.TryGetValue("basket", out string basketJson1);
            if (basketJson1?.Length > 0)
            {
                string[] arr = basketJson1.Split(',');
                ViewBag.message = arr.Length / 2;
            }
            else
            {
                ViewBag.message = 0;
            }

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "Home");

            }

            if (ModelState.IsValid)
            {

                BeluqaUser founderUser = null;

                if (user.UserName.IsEmail())
                {
                    founderUser = await userManager.FindByEmailAsync(user.UserName); //Eger Isdifadeci email gore giris edibse onu yoxlayir 
                }
                else
                {
                    founderUser = await userManager.FindByNameAsync(user.UserName); //YOX EGER USERNAME GORE GIRIBSE ONU AXTARIS EDIR.

                }

                if (founderUser == null) //Eger login ola bilmirse gonderir view gonderir yeni isdifadeci tapilmiyanda
                {
                    ViewBag.Ms = "Your Email and Password IsInvalid";
                    return View(user);

                }

                if (founderUser.EmailConfirmed == false)
                {
                    ViewBag.Ms = "Place confirmed your Email";
                    return View(user);
                }

                //Eger database isdifadeci user deyilse onda gire bilmez.

                if (!await userManager.IsInRoleAsync(founderUser, "User"))
                {
                    ViewBag.Ms = "Your Email and Password IsInvalid";
                    return View(user);
                }




                if (founderUser.Activates == false)
                {
                    ViewBag.ms = "You have been banned by Admin";
                    return View(user);
                }

                if (founderUser.Activates == true)
                {
                    var sRuselt = await signInManager.PasswordSignInAsync(founderUser, user.Password, true, true); //Burda giwi edirik.

                    if (sRuselt.Succeeded != true) // Eger giriw zamani ugurlu deyilse yeni gire bilmirse 
                    {
                        ViewBag.Ms = "Your Email and Password IsInvalid";
                        return View(user);

                    }
                    var redirectUrl = Request.Query["ReturnUrl"];

                    if (!string.IsNullOrWhiteSpace(redirectUrl))
                    {
                        return Redirect(redirectUrl);
                    }

                    return RedirectToAction("Index", "Home");

                }
            }

            ViewBag.Ms = "Email and Password is required";
            return View(user);
        }
        public async Task<IActionResult> Logout()
        {

            await signInManager.SignOutAsync();
            return RedirectToAction(nameof(Signin));

        }
        [HttpPost]
        [Route("/Subscrice.html")]
        public IActionResult Subscrice([Bind("Email")] Subscrice model)
        {

            if (ModelState.IsValid)
            {
                var current = bt.subscrices.FirstOrDefault(s => s.Email.Equals(model.Email));
                if (current != null && current.EmailConfirmed == true)
                {
                    return Json(new
                    {

                        error = true,
                        massege = "This email is already in our database!"

                    });
                }
                else if (current != null && (current.EmailConfirmed ?? false == false))
                {
                    return Json(new
                    {

                        error = true,
                        massege = "This email is already in our database!"

                    });
                }


                bt.subscrices.Add(model);
                bt.SaveChanges();


                string token = $"subscribetoken-{model.Id}-{DateTime.Now:yyyyMMddHHmmss}"; // token yeni id goturuk

                token = token.Encrypt("");

                string path = $"{Request.Scheme}://{Request.Host}/subscribe-confirm?token={token}"; // path duzeldirik



                var mailSended = configuration.SendEmail(model.Email, "BeluqaTahir", $"Siz yeni melumatlardan xederdar olacaqsiniz");
                if (mailSended == false)
                {
                    bt.Database.RollbackTransaction();

                    return Json(new
                    {
                        error = false,
                        massege = "This email is already in our database!"

                    });
                }

                return Json(new
                {

                    error = false,
                    massege = "Your request was successfully accepted!"

                });
            }



            return Json(new
            {

                error = true,
                massege = "This email is already in our database!"

            });
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("subscribe-confirmm")]
        public IActionResult SubscibeConfirm(string token)
        {


            token = token.Decrypte("");

            Match match = Regex.Match(token, @"subscribetoken-(?<id>[a-zA-Z0-9]*)(.*)-(?<timeStampt>\d{14})");

            if (match.Success)
            {
                string id = match.Groups["id"].Value;
                string executeTimeStamp = match.Groups["executeTimeStamp"].Value;

                var subsc = bt.Users.FirstOrDefault(s => s.UserName == id);

                if (subsc == null)
                {
                    ViewBag.ms = Tuple.Create(true, "Token error");
                    goto end;
                }
                if (subsc.EmailConfirmed == true)
                {
                    ViewBag.ms = Tuple.Create(true, "Your email is already confirmed");
                    goto end;
                }
                subsc.EmailConfirmed = true;
                bt.SaveChanges();

                ViewBag.ms = Tuple.Create(false, "Your email is confirmed");

            }
        end:
            return View();
        }
        public IActionResult Accessdenied()
        {
            return View();
        }
        public IActionResult RessetPassword()
        {

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]  
        public async Task<IActionResult> RessetPassword([Bind("Id", "Email")] BeluqaUser users)
        {
            BeluqaUser user1 = await userManager.FindByEmailAsync(users.Email);

            if (user1 == null)
            {
                ViewBag.ms = "Email and not Database";
                return View(users);
            }


            if (ModelState.IsValid)
            {


                BeluqaUser user = await userManager.FindByEmailAsync(users.Email);

                if (user == null)
                {
                    ViewBag.ms = "Email and not Database";
                    return View(users);
                }

                string token = $"subscribetoken-{user.Id}-{DateTime.Now:yyyyMMddHHmmss}"; // token yeni id goturuk

                token = token.Encrypt("");

                string path = $"{Request.Scheme}://{Request.Host}/subscribes-confirm?token={token}"; // path duzeldirik



                var mailSended = configuration.SendEmail(users.Email, "BeluqaTahir", $"Zehmet olmasa <a href={path}>Link</a> vasitesile Yeni Password Qeyd edin");




                return Json(new
                {
                    // error yoxdusa bura dusur
                    error = false,
                    message = "Successfully"
                });
                    


            }
            if (ModelState.IsValid)
            {
                return Json(new
                {

                    // error varsa bura dusur
                    error = true,
                    message = "Error"
                });
            }
           

            return RedirectToAction(nameof(Index));

        }

        [AllowAnonymous]
        [HttpGet]
        [Route("subscribes-confirm")]
        public IActionResult SubscibeConfirms(string token)
        {
            return View();
        }

        [HttpPost]
        [Route("subscribes-confirm")]
        [AllowAnonymous]
        public async Task<IActionResult> SubscibeConfirms(BeluqaUser users,string NewPassword)
        {
           
            BeluqaUser user = await userManager.FindByEmailAsync(users.Email);

            if (user == null)
            {
                return NotFound();

            }

            string token = await userManager.GeneratePasswordResetTokenAsync(user);
            var identityResult = await userManager.ResetPasswordAsync(user, token, NewPassword);
            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(user);
            }

            return RedirectToAction(nameof(Signin));
        }
    }
}
