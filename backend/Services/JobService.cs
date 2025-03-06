using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class JobService
{
    private readonly AppDbContext _context;

    public JobService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Job>> GetJobsAsync(string title, string location, string level)
    {
        var query = _context.Jobs.AsQueryable();

        if (!string.IsNullOrEmpty(title))
            query = query.Where(j => j.Title.Contains(title));

        if (!string.IsNullOrEmpty(location))
            query = query.Where(j => j.Location.Contains(location));

        if (!string.IsNullOrEmpty(level))
            query = query.Where(j => j.Level == level);

        return await query.ToListAsync();
    }

    public async Task<bool> ApplyAsync(Application application)
    {
        if (string.IsNullOrEmpty(application.ApplicantName) || string.IsNullOrEmpty(application.ApplicantEmail))
            return false;

        await _context.Applications.AddAsync(application);
        await _context.SaveChangesAsync();
        return true;
    }
}
