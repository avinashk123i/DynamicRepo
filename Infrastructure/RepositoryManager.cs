using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    // This class is basically using facade design pattern here to achieve higher level of isolation
    // we are also taking advantage of lazy class initialization to achieve lazy loading for the classes.
    // class is intended to be accessed by the main project it is marked as public.
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<ITeacherRepository> _repository;
        private readonly Lazy<IUnitOfWork> _unitOfWork;

        public RepositoryManager(ApplicationDBContext dBContext)
        {
            // Lazy loading of different repository implementation 
            _repository = new Lazy<ITeacherRepository>(() => new TeacherRepository(dBContext));
            _unitOfWork = new Lazy<IUnitOfWork>(() => new  UnitOfWork(dBContext));
        }
        public ITeacherRepository teacherRepository => _repository.Value;
        public IUnitOfWork unitOfWork => _unitOfWork.Value;
    }
}
