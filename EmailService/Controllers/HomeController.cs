using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmailService.Models;

namespace EmailService.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
          // Generate a password reset token for the user
                var token = Guid.NewGuid().ToString();

                // Store the token in the password resets table with the user's email
                // var passwordReset = new PasswordReset
                // {
                //     Email = forget.Email,
                //     Token = token
                // };
                // _CiPlatformContext.PasswordResets.Add(passwordReset);
                // _CiPlatformContext.SaveChanges();

                // Send an email with the password reset link to the user's email address
                // UriBuilder builder = new UriBuilder();
                // builder.Scheme = "https";
                // builder.Host = "localhost";
                // builder.Port = 44345;
                // builder.Path = "/User/Reset";
                // builder.Query = "token=" + token + "&email=" + forget.Email;
                // var resetLink = builder.ToString();
                // Send email to user with reset password link
                // ...
                var fromAddress = new mailto:mailaddress("randomKirtan7@gmail.com", "MVC APP");
                var toAddress = new MailAddress(kirtankp1902@gmail.com);
                var subject = "Password reset request";
                var body = $"Hi,<br /><br />Please click on the following link to reset your password:<br /><br />";
                var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                var smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    UseDefaultCredentials = false,
                    Credentials = new mailto:networkcredential("randomKirtan7@gmail.com", "yxit wqjh kbqr yvnv "),
                    EnableSsl = true
                };
                smtpClient.Send(message);

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
