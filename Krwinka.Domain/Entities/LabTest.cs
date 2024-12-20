﻿namespace Krwinka.Domain.Entities;

public class LabTest
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public string Description { get; set; } = default!;
    public string Type { get; set; } = default!;
    public bool External { get; set; }
    public bool Stability { get; set; }

}
