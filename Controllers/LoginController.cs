using Microsoft.AspNetCore.Mvc;

namespace RiaanCarelse_ST10065550_POEPart1.Controllers
{
    public class LoginController : Controller
    {

        private readonly LoginModel login;

        public LoginController()
        {
            login = new LoginModel();
        }

        [HttpPost]
        public ActionResult Privacy(string email, string name)
        {
            var loginModel = new LoginModel();
            int userID = loginModel.SelectUser(email, name);
            if (userID != -1)
            {
                // Store userID in session
                HttpContext.Session.SetInt32("UserID", userID);

                // User found, proceed with login logic (e.g., set authentication cookie)
                // For demonstration, redirecting to a dummy page
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // User not found, handle accordingly (e.g., show error message)
                return View("LoginFailed");
            }
        }
    }
}
