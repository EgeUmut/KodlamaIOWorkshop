using KodlamaIOWorkshop.Business.Dtos.Requests;
using KodlamaIOWorkshop.Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWorkshop.Business.Abstracts
{
    public interface ICourseService

    {
        public void Add(CreateCourseRequest createCourseRequest);
        public void Update(UpdateCourseRequest updateCourseRequest);
        public void Delete(DeleteCourseRequest deleteCourseRequest);
        public void DeleteById(int id);
        public List<GetAllCourseResponse> GetAll();
        public GetByIdCourseResponse GetById(int id);
    }
}
