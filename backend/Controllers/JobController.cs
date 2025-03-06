using Microsoft.AspNetCore.Mvc;

[Route("api/jobs")]
[ApiController]
public class JobsController : ControllerBase
{
    private readonly AppDbContext _context;

    public JobsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetJobs([FromQuery] string title, [FromQuery] string location, [FromQuery] string level)
    {
        var jobs = _context.Jobs.AsQueryable();

        if (!string.IsNullOrEmpty(title))
            jobs = jobs.Where(j => j.Title.Contains(title));
        if (!string.IsNullOrEmpty(location))
            jobs = jobs.Where(j => j.Location.Contains(location));
        if (!string.IsNullOrEmpty(level))
            jobs = jobs.Where(j => j.Level == level);

        return Ok(jobs.ToList());
    }

    [HttpPost("apply")]
    public IActionResult Apply([FromBody] Application application)
    {
        _context.Applications.Add(application);
        _context.SaveChanges();
        return Ok(new { message = "Application submitted successfully!" });
    }
}
