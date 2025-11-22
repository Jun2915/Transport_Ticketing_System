using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASS_WMS.Controllers;

public class AccountController(DB db, Helper hp) : Controller
{
    //GET: Account/Login

    //POST: Account/Login

    //GET: Account/Logout

    //GET: Account/AccessDenied

    //GET: Account/Register
    public IActionResult Register()
    {
        return View();
    }

    //POST: Account/Register
    [HttpPost]
    public IActionResult Register(RegisterVM vm)
    {
        if(ModelState.IsValid("Email") && db.Customers.Any(u => u.Email == vm.Email))
        {
            ModelState.AddModelError("Email", "Duplicated Email.");
        }

        if(ModelState.IsValid("Photo"))
        {
            var err = hp.ValidatePhoto(vm.Photo);
            if (err != "") ModelState.AddModelError("Photo", err);
        }

        if (ModelState.IsValid)
        {
            db.Customers.Add(new()
            {
                Id = vm.Id,
                Name = vm.Name,
                Email = vm.Email,
                Password = vm.Password,
                PhoneNumber = vm.PhoneNumber,
                PhotoURL = hp.SavePhoto(vm.Photo, "userPhoto"),
            });
            db.SaveChanges();

            TempData["Info"] = "Register Successfully. Please go try login.";
            return RedirectToAction("Login");
        }

        return View(vm);
    }

    //GET: Account/UpdatePassword

    //POST: Account/UpdatePassword

    //GET: Account/UpdateProfile

    //POST: Account/UpdateProfile

    //GET: Account/ResetPassword

    //POST: Account/ResetPassword
}