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

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    public void Add(CreateCategoryRequest createCategoryRequest)
    {
        Category category = new Category();
        category.Name = createCategoryRequest.Name;
        category.Id = createCategoryRequest.Id;
        _categoryDal.Add(category);
    }

    public void Delete(DeleteCategoryRequest deleteCategoryRequest)
    {
        Category category = new Category();
        category.Name = deleteCategoryRequest.Name;
        category.Id = deleteCategoryRequest.Id;

        _categoryDal.Delete(category);
    }

    public void Update(UpdateCategoryRequest updateCategoryRequest)
    {
        Category category = new Category();
        category.Name = updateCategoryRequest.Name;
        category.Id = updateCategoryRequest.Id;

        _categoryDal.Update(category);
    }
    public List<GetAllCategoryResponse> GetAll()
    {
        List<GetAllCategoryResponse> category = new List<GetAllCategoryResponse>();
        foreach (var item in _categoryDal.GetAll())
        {
            GetAllCategoryResponse getAllCategoryResponse = new GetAllCategoryResponse();
            getAllCategoryResponse.Name = item.Name;
            getAllCategoryResponse.Id = item.Id;
            category.Add(getAllCategoryResponse);
        }

        return category;
    }

    public GetByIdCategoryResponse GetById(int id)
    {
        Category category = _categoryDal.GetById(id);
        GetByIdCategoryResponse getByIdCategoryResponse = new GetByIdCategoryResponse();

        getByIdCategoryResponse.Name = category.Name;
        getByIdCategoryResponse.Id = category.Id;

        return getByIdCategoryResponse;

    }


}
