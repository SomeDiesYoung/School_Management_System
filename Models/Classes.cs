using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Models;

public class Classes
{
    public int Id { get; set; }
    public string Room {  get; set; }
    public int TeacherId { get; set; }
    public int GroupId { get; set; }
}
