using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    // Teacher repository implementation it is also inheriting the base generic repository class
    // to do all the repetetive crud tasks inside the database ..
    internal class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        
        public TeacherRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
        }

        public void CreateTeacher(Teacher teacher)
        {
            Create(teacher);
        }

        public void DeleteTeacher(int id)
        {
            throw new NotImplementedException();
        }

       
        public async Task<IEnumerable<Teacher>> GetAllTeachersAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<IEnumerable<Teacher>> GetTeacherByRollNumber(int rollNumber)
        {
            return await GetByCondition(x => x.RollNumber == rollNumber).ToListAsync();
        }

        public void UpdateTeacher(Teacher teacher)
        {
            Update(teacher);
        }
    }
}
