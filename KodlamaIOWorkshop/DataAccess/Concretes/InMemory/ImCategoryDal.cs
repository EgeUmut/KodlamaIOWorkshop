using KodlamaIOWorkshop.DataAccess.Abstracts;
using KodlamaIOWorkshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWorkshop.DataAccess.Concretes.InMemory;

public class ImCategoryDal : ICategoryDal
{
    List<Category> _categories = new List<Category>();

    public ImCategoryDal()
    {
        _categories.Add(new Category(1, "programlama"));
        _categories.Add(new Category(2, "yazılım"));
        _categories.Add(new Category(3, "front-end"));
    }
    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(Category category)
    {
        var item = _categories.Find(p => p.Id == category.Id);
        if (item != null)
        {
            _categories.Remove(item);
        }
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category GetById(int id)
    {
        return _categories.FirstOrDefault(p => p.Id == id);
    }

    public void Update(Category category)
    {
        Category categoryToUpdate = _categories.FirstOrDefault(c => c.Id == category.Id);
        if (categoryToUpdate != null)
        {
            categoryToUpdate.Name = category.Name;
        }
    }
}
