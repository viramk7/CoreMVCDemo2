using CoreMVCDemo2.Repositories;
using CoreMVCDemo2.Repositories.StudentRepository;
using System.Collections.Generic;

namespace CoreMVCDemo2.Services.Student
{
    public class StudentService : EntityService<Models.Student>, IStudentService
    {
        private readonly IStudentRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public StudentService(IStudentRepository repository,
                              IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Models.Student GetById(long id)
        {
            return _repository.GetById(id);
        }
    }
}
