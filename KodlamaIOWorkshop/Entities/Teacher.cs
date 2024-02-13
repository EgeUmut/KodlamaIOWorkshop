using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWorkshop.Entities;

public class Teacher
{
    public Teacher()
    {
        
    }
    public Teacher(int ıd, string firstName, string lastName, string ımageURL)
    {
        Id = ıd;
        ImageURL = ımageURL;
        FirstName = firstName;
        LastName = lastName;
    }

    public int Id { get; set; }
    public string ImageURL { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
}
