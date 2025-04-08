using System;
using System.Collections.Generic;

namespace firstproject.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public int Price { get; set; }
}
