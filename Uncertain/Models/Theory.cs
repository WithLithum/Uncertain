namespace Uncertain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Theory
{
    public int Id { get; set; }
    public string Name { get; set; } = "Unnamed Theory";
    public string Description { get; set; } = "";
    public DateTime LastSave { get; set; } = DateTime.MinValue;

    public override string ToString()
    {
        return $"{Name} ({LastSave})";
    }
}
