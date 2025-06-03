﻿using System;
using System.Collections.Generic;

namespace CRUD.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int CategoryId { get; set; }
}
