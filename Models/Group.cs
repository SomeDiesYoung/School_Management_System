using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Models;

public class Group
{
    public int Id { get; set; }
    public List<int> studentIds { get; set; }
    public string Name { get; set; }
}
