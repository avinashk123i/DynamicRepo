using Domain;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ITeacherService> _teacherService; 
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _teacherService = new Lazy<ITeacherService>(() => new TeacherService(repositoryManager));
        }
        public ITeacherService teacherService => _teacherService.Value;
    }
}
