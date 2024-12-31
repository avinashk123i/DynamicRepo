using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ITeacherRepository : IBaseRepository<Teacher>
    {
        Task<IEnumerable<Teacher>> GetAllTeachersAsync();
        Task<IEnumerable<Teacher>> GetTeacherByRollNumber(int rollNumber);

        void CreateTeacher(Teacher teacher);

        void UpdateTeacher(Teacher teacher);    

        void DeleteTeacher (int id);
         
    }
}
