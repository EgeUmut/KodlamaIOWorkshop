using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWorkshop.Business.Dtos.Requests;

public class DeleteCourseRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsFree { get; set; }
    public string ImageURL { get; set; }
}
