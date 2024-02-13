using KodlamaIOWorkshop.Business.Abstracts;
using KodlamaIOWorkshop.Business.Dtos.Requests;
using KodlamaIOWorkshop.Business.Dtos.Responses;
using KodlamaIOWorkshop.DataAccess.Abstracts;
using KodlamaIOWorkshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWorkshop.Business.Concretes;

public class TeacherManager : ITeacherService
{
    ITeacherDal _teacherDal;

    public TeacherManager(ITeacherDal teacherDal)
    {
        _teacherDal = teacherDal;
    }

    public void Add(CreateTeacherRequest createTeacherRequest)
    {
        Teacher teacher = new Teacher();
        teacher.FirstName = createTeacherRequest.FirstName;
        teacher.Id = createTeacherRequest.Id;
        teacher.LastName = createTeacherRequest.LastName;
        teacher.ImageURL = createTeacherRequest.ImageURL;
        _teacherDal.Add(teacher);
    }

    public void Delete(DeleteTeacherRequest deleteTeacherRequest)
    {
        Teacher teacher = new Teacher();
        teacher.FirstName = deleteTeacherRequest.FirstName;
        teacher.Id = deleteTeacherRequest.Id;
        teacher.LastName = deleteTeacherRequest.LastName;
        teacher.ImageURL = deleteTeacherRequest.ImageURL;

        _teacherDal.Delete(teacher);
    }

    public void Update(UpdateTeacherRequest updateTeacherRequest)
    {
        Teacher teacher = new Teacher();
        teacher.FirstName = updateTeacherRequest.FirstName;
        teacher.Id = updateTeacherRequest.Id;
        teacher.LastName = updateTeacherRequest.LastName;
        teacher.ImageURL = updateTeacherRequest.ImageURL;
        _teacherDal.Update(teacher);
    }
    public List<GetAllTeacherResponse> GetAll()
    {
        List<GetAllTeacherResponse> teacher = new List<GetAllTeacherResponse>();
        foreach (var item in _teacherDal.GetAll())
        {
            GetAllTeacherResponse getAllTeacherResponse = new GetAllTeacherResponse();
            getAllTeacherResponse.FirstName = item.FirstName;
            getAllTeacherResponse.Id = item.Id;
            getAllTeacherResponse.LastName = item.LastName;
            getAllTeacherResponse.ImageUrl = item.ImageURL;

            teacher.Add(getAllTeacherResponse);

        }

        return teacher;
    }

    public GetByIdTeacherResponse GetById(int id)
    {
        Teacher teacher = _teacherDal.GetById(id);

        GetByIdTeacherResponse getByIdTeacherResponse = new GetByIdTeacherResponse();
        getByIdTeacherResponse.FirstName = teacher.FirstName;
        getByIdTeacherResponse.Id = teacher.Id;
        getByIdTeacherResponse.LastName = teacher.LastName;
        getByIdTeacherResponse.ImageUrl = teacher.ImageURL;

        return getByIdTeacherResponse;

    }
}
