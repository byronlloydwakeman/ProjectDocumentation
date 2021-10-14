using ProjectDocumentation.Library.Conversion;
using ProjectDocumentation.Library.Models;
using ProjectDocumentation.Library.Models.UIFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDocumentation.Library.DataAccess
{
    public static class ProjectFormatData
    {
        public static void InsertIngredient(IngredientDBModel ingredientDBModel)
        {
            SqlDataAccess.SaveData("spInsertIngredient", ingredientDBModel);
        }

        public static void InsertCrafting(CraftingUIModel craftingUIModel)
        {
            //The database wants a DBModel so we need to convert the UI model into a DBModel
            SqlDataAccess.SaveData("spInsertCrafting", ConvertModel.ConvertUIModelToDBModel(craftingUIModel));
        }
        
        public static void InsertProblemAndSolution(ProblemAndSolutionDBModel problemAndSolutionDBModel)
        {
            SqlDataAccess.SaveData("spInsertProblemAndSolution", problemAndSolutionDBModel);
        }

        public static void InsertProjectFormat(ProjectFormatDBModel projectFormatDBModel)
        {
            SqlDataAccess.SaveData("spINsertProjectFormat", projectFormatDBModel);
        }
    }
}
