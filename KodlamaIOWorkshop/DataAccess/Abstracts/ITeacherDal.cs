using KodlamaIOWorkshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWorkshop.DataAccess.Abstracts;

public interface ITeacherDal
{
    public void Add(Teacher teacher);
    public void Delete(Teacher teacher);
    public void Update(Teacher teacher);
    public List<Teacher> GetAll();
    public Teacher GetById(int id);
}
