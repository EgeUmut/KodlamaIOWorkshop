using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWorkshop.Business.Dtos.Requests;

public class DeleteCategoryRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
}
