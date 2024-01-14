using Microsoft.AspNetCore.Mvc;


public class AccountController : Controller
{
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Login(string username, string password)
    {
        // Логіка перевірки логіну та пароля

        if (IsValidLogin(username, password))
        {
            // Якщо логін і пароль вірні, перенаправте на іншу сторінку
            return RedirectToAction("Dashboard", "Home");
        }

        // Якщо логін або пароль невірні, поверніть користувача на ту ж саму сторінку з помилкою
        ModelState.AddModelError(string.Empty, "Invalid login attempt");
        return View();
    }

    private bool IsValidLogin(string username, string password)
    {
        // Логіка перевірки логіну та пароля
        return true; // Змініть логіку відповідно до своїх потреб
    }
}
