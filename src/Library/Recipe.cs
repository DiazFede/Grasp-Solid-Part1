//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private List<Step> steps = new List<Step>();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public IEnumerable<Step> GetSteps()
        {
            return this.steps;
        }

        public void PrintRecipeWithCost()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.GetSteps())
        {
            Console.WriteLine($"{step.QuantityInKilograms}kg de '{step.Input.Description}' " +
            $"usando '{step.Equipment.Description}' durante {step.TimeInMinutes} minutos");
        }
            ProductionCostCalculator calculator = new ProductionCostCalculator();
            double totalCost = calculator.CalculateTotalProductionCost(this);
            Console.WriteLine($"Costo total de producción: ${totalCost}");
        }
    }
}