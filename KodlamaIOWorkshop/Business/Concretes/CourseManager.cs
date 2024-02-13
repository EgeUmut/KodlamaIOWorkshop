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

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public void Add(CreateCourseRequest createCourseRequest)
    {
        Course course = new Course();
        course.Name = createCourseRequest.Name;
        course.Id = createCourseRequest.Id;
        course.Description = createCourseRequest.Description;
        course.IsFree = createCourseRequest.IsFree;
        course.ImageURL = createCourseRequest.ImageURL;
        _courseDal.Add(course);
    }

    public void Delete(DeleteCourseRequest deleteCourseRequest)
    {
        var item = _courseDal.GetById(deleteCourseRequest.Id);

        if (item != null)
        {
        _courseDal.Delete(item);
        }
    }

    public void DeleteById(int id) 
    {
        var item = _courseDal.GetById(id);
        
        if (item != null)
        {
            _courseDal.Delete(item);
        }
    }

    public void Update(UpdateCourseRequest updateCourseRequest)
    {
        Course course = new Course();
        course.Name = updateCourseRequest.Name;
        course.Id = updateCourseRequest.Id;
        course.Description = updateCourseRequest.Description;
        course.IsFree = updateCourseRequest.IsFree;
        course.ImageURL = updateCourseRequest.ImageURL;
        _courseDal.Update(course);
    }
    public List<GetAllCourseResponse> GetAll()
    {
        List<GetAllCourseResponse> course = new List<GetAllCourseResponse>();
        foreach (var item in _courseDal.GetAll())
        {
            GetAllCourseResponse getAllCourseResponse = new GetAllCourseResponse();
            getAllCourseResponse.Name = item.Name;
            getAllCourseResponse.Id = item.Id;
            getAllCourseResponse.Description = item.Description;
            getAllCourseResponse.IsFree = item.IsFree;
            getAllCourseResponse.PictureUrl = item.ImageURL;
            course.Add(getAllCourseResponse);

        }

        return course;
    }

    public GetByIdCourseResponse GetById(int id)
    {
        Course Course = _courseDal.GetById(id);

        GetByIdCourseResponse getByIdCourseResponse = new GetByIdCourseResponse();
        getByIdCourseResponse.Name = Course.Name;
        getByIdCourseResponse.Id = Course.Id;
        getByIdCourseResponse.IsFree = Course.IsFree;
        getByIdCourseResponse.Description = Course.Description;
        getByIdCourseResponse.PictureUrl = Course.ImageURL;

        return getByIdCourseResponse;

    }


}