
using KodlamaIOWorkshop.Business.Concretes;
using KodlamaIOWorkshop.Business.Dtos.Requests;
using KodlamaIOWorkshop.DataAccess.Concretes.InMemory;
using KodlamaIOWorkshop.Entities;

Teacher teacher1 = new Teacher(4, "Engin", "Demiroğ", "asdksakdklsl");

Category category1 = new Category(4, "Proglama");

Course course1 = new Course(4, ".NET", "yeni başlayanlar için .NET", "dslkdlkslf", true);

course1.category = category1;

Console.WriteLine(course1.Name);
CourseManager courseManager = new CourseManager(new ImCourseDal());
Console.WriteLine(courseManager.GetById(2).Name);
courseManager.Add(new CreateCourseRequest() {Id=4,Name="Python",Description="Yeni",ImageURL="asd",IsFree=true });

foreach (var item in courseManager.GetAll())
{
    Console.WriteLine(item.Name);
}

Console.WriteLine("------------------------Delete 1");
//courseManager.DeleteById(4);
courseManager.Delete(new DeleteCourseRequest() { Id = 4 });

Console.WriteLine("--------------------------------");

foreach (var item in courseManager.GetAll())
{
    Console.WriteLine(item.Name);
}