using System;
using System.Collections.Generic;

namespace Projecttitle.Models;

public class Customer
{
    public int CustomerID { get; set; } 

    public string Name { get; set; } 

    public string? Age { get; set; }

    public DateOnly? DateBD { get; set; }

    public DateOnly? DateTime { get; set; }

   
}