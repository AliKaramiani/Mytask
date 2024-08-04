using Microsoft.AspNetCore.Mvc;

[Route("[action]")]
[ApiController]
public class JobController : Controller
{
    private readonly context db;
    private readonly IWebHostEnvironment _env;

    public JobController(context _db, IWebHostEnvironment env)
    {
        db = _db;
        _env = env;
    }

    private readonly List<string> jobs = new List<string> { "شغل 1", "شغل 2", "شغل 3", "شغل 4", "شغل 5", "شغل 6" };

    [HttpGet] // مشخص کردن متد HTTP  
    public IActionResult SelectJob()
    {
        return View(jobs);
    }

    [HttpPost]
    public IActionResult PersonalInfo(string selectedJob)
    {
        var model = new userinfo { SelectedJob = selectedJob };
        return View(model);
    }

    [HttpPost]
    public IActionResult SubmitApplication(userinfo application)
    {
        // کد برای ذخیره اطلاعات در دیتابیس یا انجام کارهای دیگر  
        return RedirectToAction("Success");
    }

    [HttpGet] // اضافه کردن مشخصه HTTP به متد Success  
    public IActionResult Success()
    {
        return View();
    }
}