using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWorkshop.Entities;

public class Course
{
    public Course()
    {

    }

    public Course(int ıd, string name, string description, string ımageURL, bool IsFree)
    {
        Id = ıd;
        ImageURL = ımageURL;
        Name = name;
        Description = description;
        this.IsFree = IsFree;
    }

    public int Id { get; set; }
    public string ImageURL { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsFree { get; set; }
    public double Duration { get; set; }
    public Category category { get; set; }
    public List<Teacher> Teacher { get; set; }
}
