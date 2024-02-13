using KodlamaIOWorkshop.Business.Dtos.Requests;
using KodlamaIOWorkshop.Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWorkshop.Business.Abstracts
{
    public interface ITeacherService

    {
        public void Add(CreateTeacherRequest createTeacherRequest);
        public void Update(UpdateTeacherRequest updateTeacherRequest);
        public void Delete(DeleteTeacherRequest deleteTeacherRequest);
        public List<GetAllTeacherResponse> GetAll();
        public GetByIdTeacherResponse GetById(int id);
    }
}
