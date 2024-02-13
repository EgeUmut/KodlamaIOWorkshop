using KodlamaIOWorkshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWorkshop.DataAccess.Abstracts;

public interface ICourseDal
{
    public void Add(Course teacher);
    public void Delete(Course teacher);
    //public void DeleteById(int id);
    public void Update(Course teacher);
    public List<Course> GetAll();
    public Course GetById(int id);
}
