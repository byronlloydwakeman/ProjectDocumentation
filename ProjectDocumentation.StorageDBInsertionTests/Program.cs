using ProjectDocumentation.Library.DataAccess;
using ProjectDocumentation.Library.Models;
using ProjectDocumentation.Library.Models.UIFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDocumentation.StorageDBInsertionTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Insert Crafting Test
            ProjectFormatData.InsertCrafting(new CraftingUIModel()
            {
                ResultName = "Power Generation",
                ResultURL = "https://localhost:44350/WindTurbine/PowerGeneration",
                CraftingName = "",
                CraftingURL = "",
                ListOfIngredientName = new List<string>()
                {

                }
            });

            //Insert Ingredient Tests
            //ProjectFormatData.InsertIngredient(new IngredientDBModel() { IngredientName = "Full Bridge Rectifier", IngredientURL = "https://localhost:44350/WindTurbine/FullBridgeRectifier" });
            //ProjectFormatData.InsertIngredient(new IngredientDBModel() { IngredientName = "Power Generation", IngredientURL = "https://localhost:44350/WindTurbine/PowerGeneration" });
       
        }
    }
}
