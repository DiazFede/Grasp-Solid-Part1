//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using Full_GRASP_And_SOLID.Library;

public class Step
{
    public Step(Product input, double quantityInKilograms, Equipment equipment, int timeInMinutes)
    {
        this.QuantityInKilograms = quantityInKilograms;
        this.Input = input;
        this.TimeInMinutes = timeInMinutes;
        this.Equipment = equipment;
    }

    public Product Input { get; set; }

    public double QuantityInKilograms { get; set; }

    public int TimeInMinutes { get; set; }
    public Equipment Equipment { get; set; }
}
