//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

public class Product
{
    public Product(string description, double costPerKilogram)
    {
        this.Description = description;
        this.CostPerKilogram = costPerKilogram;
    }

    public string Description { get; set; }

    public double CostPerKilogram { get; set; } 
}
