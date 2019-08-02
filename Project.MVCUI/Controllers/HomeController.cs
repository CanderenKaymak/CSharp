using Project.BLL.ConcreteRepository;
using Project.DAL.Context;
using Project.MODEL;
using Project.TOOLS.CustomTools;
using System;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        UserRepository ur = new UserRepository();
        UserProfileRepository urp = new UserProfileRepository();

        MyContext db = new MyContext();
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }
        // GET: Home
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register([Bind(Prefix ="item1")]User item1,[Bind(Prefix ="item2")]UserProfile item2)
        {
            if (ur.Any(x=>x.UserName == item1.UserName))
            {
                ViewBag.ZatenVar = "Bu kullanıcı ismi başka bir kullanıcı tarafından kullanılmaktadır.";
                return View();
            }
            string gonderilecekMail = " Tebrikler Hesabınız oluşturulmuştur. Hesabınızı aktive etmek için http://localhost:62176/Home/Aktivasyon" + item1.ActivationCode + "linkine tıklayabilirsiniz..";

            MailSender.Send(item1.Email, password: "1234567899876543210.", body: gonderilecekMail, subject: "Yemek @WEB ailesine hoşgeldiniz. Afiyetler Dileriz!");
            ur.Add(item1);
            item2.ID = item1.ID;
            urp.Add(item2);

            return View("RegisterOK");

        }

        public ActionResult Aktivasyon(Guid id)
        {
            if (ur.Any(x=>x.ActivationCode==id))
            {
                ur.Default(x => x.ActivationCode == id).IsActive = true;
                TempData["HesapAktif"] = "Hesabınız Aktif Edilmiştir";
                if (Session["bekleyenUrun"]!= null)
                {
                    Session["scart"] = CreateCart.KeepProduct(Session["bekleyenUrun"]);
                }
                RedirectToAction("Index", "Member");
            }
            TempData["HesapAktif"] = "Aktif Edilecek Hesap Bulunamadı";
            return RedirectToAction("Register");
        }

        public ActionResult RegisterOK()
        {
            User girecekOlan = CheckCookie();
            if (girecekOlan==null)
            {
                return View();
            }

            return View(girecekOlan);
        }

        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(User item,string Hatirla)
        {
            if (ur.Any(x=>x.Email==item.Email && x.Password==item.Password && x.Status != MODEL.Enum.DataStatus.Deleted && x.UserRole== MODEL.Enum.Role.Admin))
            {
                User girisYapanAdmin = ur.Default(x => (x.Email == item.Email) && x.Password == item.Password && x.Status != MODEL.Enum.DataStatus.Deleted && x.UserRole == MODEL.Enum.Role.Admin);
                bool sonuc = Crypto.VerifyHashedPassword(girisYapanAdmin.Password, item.Password);
                if (sonuc)
                {
                    HatirlaKontrol(item, Hatirla);
                    Session["admin"] = girisYapanAdmin;
                    return RedirectToAction("CategoryList", "Category", new { area = "Admin" });
                }
                

                return RedirectToAction("");
            }
            else if (ur.Any(x => x.Email == item.Email && x.Password == item.Password && x.Status != MODEL.Enum.DataStatus.Deleted && x.UserRole == MODEL.Enum.Role.Customer))
            {
                User girisYapanUye = ur.Default(x => x.Email == item.Email && x.Password == item.Password && x.Status != MODEL.Enum.DataStatus.Deleted && x.UserRole == MODEL.Enum.Role.Customer);

                bool sonuc = Crypto.VerifyHashedPassword(girisYapanUye.Password, item.Password);
                if (sonuc)
                {
                    HatirlaKontrol(item, Hatirla);
                    Session["customer"] = girisYapanUye;
                    if (Session["bekleyenUrun"] != null)
                    {
                        Session["scart"] = CreateCart.KeepProduct(Session["bekleyenUrun"]);

                    }

                }               
                
                return RedirectToAction("Index","Member");
            }
            ViewBag.UserCannotFound = "Böyle bir kullanıcı yoktur!";
            return View();
        }
        #region BeniHatirla


        private void HatirlaKontrol(User item, string Hatirla)
        {
            //Burada kullanıcı cookie'de var mı bu kontrol edilecek

            if (Hatirla == "true")
            {
                HttpCookie girisIsim = new HttpCookie("userName"); //Cookie olusturduk
                girisIsim.Expires = DateTime.Now.AddMinutes(5);
                girisIsim.Value = item.UserName;
                //Cookie eklemek icin Response'lara bir ekleme yapmalıyız

                Response.Cookies.Add(girisIsim);

                HttpCookie girisSifre = new HttpCookie("password");
                girisSifre.Expires = DateTime.Now.AddMinutes(5);
                girisSifre.Value = item.Password;
                Response.Cookies.Add(girisSifre);
            }
        }




        //Cookie client side bir durum yönetimidir.
        //Cookie'de saklanan bir degeri yakalayabilmek icin Request property'sini kullanırız.

        private User CheckCookie()
        {
            string userName = string.Empty, password = string.Empty;

            User cookiedeSaklanan = null;


            if (Request.Cookies["userName"] != null && Request.Cookies["password"] != null)
            {
                userName = Request.Cookies["userName"].Value;
                password = Request.Cookies["password"].Value;
            }

            //Client Side validation icin bu kontrole cok gerek yok
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                cookiedeSaklanan = new User
                {
                    UserName = userName,
                    Password = password
                };
            }
            return cookiedeSaklanan;

        }


        #endregion
        //todo Username veya email ile giriş için denenecek 
        /*[HttpPost]
[AllowAnonymous]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
{
    ViewData["ReturnUrl"] = returnUrl;
    if (model.Email.IndexOf('@') > -1)
    {
        //Validate email format
        string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                               @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        Regex re = new Regex(emailRegex);
        if (!re.IsMatch(model.Email))
        {
            ModelState.AddModelError("Email", "Email is not valid");
        }
    }
    else
    {
        //validate Username format
        string emailRegex = @"^[a-zA-Z0-9]*$";
        Regex re = new Regex(emailRegex);
        if (!re.IsMatch(model.Email))
        {
            ModelState.AddModelError("Email", "Username is not valid");
        }
    }
 
    if (ModelState.IsValid)
    {
        var userName = model.Email;
        if (userName.IndexOf('@') > -1)
        {
            var user =  await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(model);
            }
            else
            {
                userName = user.UserName;
            }
        }
        var result = await _signInManager.PasswordSignInAsync(userName, model.Password, model.RememberMe, lockoutOnFailure: false);
*/

    }
}