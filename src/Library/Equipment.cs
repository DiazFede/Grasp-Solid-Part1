//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
public class Equipment
{
    public Equipment(string description, double costPerMinute)
    {
        this.Description = description;
        this.CostPerMinute = costPerMinute;
    }

    public string Description { get; set; }

    public double CostPerMinute { get; set; } 
}
