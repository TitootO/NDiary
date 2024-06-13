using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NDiary.Models;
using System.Security.Claims;
using NDiary.Data;
using NDiary.Model;

namespace NDiary.Controllers
{
    public class AccountController : Controller
    {
        private Database _database;
        public AccountController(Database database)
        {
            _database = database;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _database.Users
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Login == model.Login && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(user); // аутентификация
                    if (user.Role.Name == "admin")
                    {

                        return RedirectToAction("Admin", "Home");
                    }
                    else if (user.Role.Name == "student")
                    {
                        return RedirectToAction("Student", "Home");
                    }
                    else if (user.Role.Name == "teacher")
                    {
                        return RedirectToAction("Teacher", "Home");
                    }
                    else if (user.Role.Name == "parent")
                    {
                        return RedirectToAction("Parent", "Home");
                    }
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        public IActionResult Register()
        {
            List<Role> data = _database.Roles.ToList();
            ViewBag.role = data;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model, string role)
        {
            if (ModelState.IsValid)
            {
                User user = await _database.Users.FirstOrDefaultAsync(u => u.Login == model.Login);
                if (user == null)
                {
                    // добавляем пользователя в бд
                    user = new User { Login = model.Login, Password = model.Password/*, Role = model.Role*/ };
                    Role adminRole = await _database.Roles.FirstOrDefaultAsync(r => r.Name == role);
                    Role studentRole = await _database.Roles.FirstOrDefaultAsync(r => r.Name == role);
                    if (adminRole != null)
                    {
                        user.Role = adminRole;
                    }
                    //if(role != null)
                    //{
                    //	user.Role = model.
                    //}
                    //Role studentRole = await _database.Roles.FirstOrDefaultAsync(r => r.Name == "Student");
                    //if (studentRole != null)
                    //	user.Role = studentRole;
                    //if(role != null)
                    //{
                    //	user.Role = role;
                    //}
                    _database.Users.Add(user);
                    await _database.SaveChangesAsync();

                    await Authenticate(user); // аутентификация

                    return RedirectToAction("Admin", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        //}
        private async Task Authenticate(User user)
        {
            //User.Identity.Name
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name),
                new Claim("UserId", user.Id.ToString())

				//new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Student.Name),

				//new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Student.Surname),

				//new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Student.Phone),
				//new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Student.Email)

			};
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
