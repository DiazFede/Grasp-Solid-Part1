//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        private static List<Product> productCatalog = new List<Product>();
        private static List<Equipment> equipmentCatalog = new List<Equipment>();

        public static void Main(string[] args)
        {
            PopulateCatalogs();

            Recipe recipe = CreateRecipe();
            recipe.PrintRecipeWithCost(); 
        }

        private static void PopulateCatalogs()
        {
            AddProductToCatalog("Café", 0.1);
            AddProductToCatalog("Leche", 0.2);
            AddProductToCatalog("Café con leche", 0.3);

            AddEquipmentToCatalog("Cafetera", 10);
            AddEquipmentToCatalog("Hervidor", 20);
        }

        private static void AddProductToCatalog(string description, double unitCost)
        {
            productCatalog.Add(new Product(description, unitCost));
        }

        private static void AddEquipmentToCatalog(string description, double minuteCost)
        {
            equipmentCatalog.Add(new Equipment(description, minuteCost));
        }

        private static Product GetProduct(string description)
        {
            return productCatalog.Find(product => product.Description == description);
        }

        private static Equipment GetEquipment(string description)
        {
            return equipmentCatalog.Find(equipment => equipment.Description == description);
        }

        private static Recipe CreateRecipe()
        {
            Recipe recipe = new Recipe();
            recipe.FinalProduct = GetProduct("Café con leche");
            recipe.AddStep(new Step(GetProduct("Café"), 0.1, GetEquipment("Cafetera"), 12));
            recipe.AddStep(new Step(GetProduct("Leche"), 0.2, GetEquipment("Hervidor"), 6));
            return recipe;
        }
    }
}
