using Microsoft.EntityFrameworkCore;
using Projecttitle.Data;
using Projecttitle.Models;

namespace Projecttitle.Services;

public interface ICustomerService
{
    Task<Patient[]> GetPatientAsync();
  Task<Patient?> GetPatientByIdAsync(string id);
}

public class CustomerService : ICustomerService
{
    private readonly ApplicationDbContext _context;
    private readonly MyApplicationDbContext _mycontext;

   
    public CustomerService(ApplicationDbContext context,MyApplicationDbContext mycontext)
    {
        _context = context;
        _mycontext = mycontext;
    }
    
    public async Task<Patient[]> GetPatientAsync()
    {
        return await _context.Patients
            .AsNoTracking()
            .Take(100)
            .ToArrayAsync();
    }

    public async Task<Patient?> GetPatientByIdAsync(string hn)
{
    return await _context.Patients
        .AsNoTracking()
        .FirstOrDefaultAsync(p => p.Cid == hn);
}





}

