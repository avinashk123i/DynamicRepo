using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface ITeacherService 
    {

        Task<List<TeacherDTO>> GetTeachers();

        Task CreateTeacher(TeacherDTO teacher);

    }
}
