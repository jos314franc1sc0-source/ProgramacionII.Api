using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using School.Infrastructure.Context;
using School.Infrastructure.Interfaces;

namespace School.Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SchoolContext _context;

        public CourseRepository(SchoolContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            return await _context.Courses.ToListAsync();
        }
    }
}