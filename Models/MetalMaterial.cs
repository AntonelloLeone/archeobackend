﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class MetalMaterial
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
