using Contracts;
using Domain;
using Services.Abstractions;

namespace Service
{
    internal sealed class TeacherService : ITeacherService
    {
      private  IRepositoryManager _repositoryManager;

        public TeacherService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task CreateTeacher(TeacherDTO teacher)
        {

            _repositoryManager.teacherRepository.Create(new Teacher()
            {
                Name = teacher?.TeacherName ?? string.Empty
            });

          _ =  await _repositoryManager.unitOfWork.SaveChangesAsync();
        }

        public async Task<List<TeacherDTO>> GetTeachers()
        {
          var teachers = await _repositoryManager.teacherRepository.GetAllTeachersAsync();

            return teachers.Select(x => new TeacherDTO()
            {
                TeacherName = x.Name,
            }).ToList();
        }
    }
}
