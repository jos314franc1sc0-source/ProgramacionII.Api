using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using School.Infrastructure.Context;
using School.Infrastructure.Interfaces;

namespace School.Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly SchoolContext _context;

        public DepartmentRepository(SchoolContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> GetAll()
        {
            return await _context.Departments.ToListAsync();
        }
    }
}