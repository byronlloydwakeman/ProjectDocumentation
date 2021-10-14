using ProjectDocumentation.Library.Conversion;
using ProjectDocumentation.Library.Models;
using ProjectDocumentation.Library.Models.UIFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjectDocumentation.Library.UnitTests.Conversion
{
    public class ConvertModelTests
    {
        /// <summary>
        /// Testing the method in the class ConvertModel, for any logic problems
        /// </summary>
        /// <param name="listOfIngredients">The list of ingredients stored as a single string</param>
        /// <param name="expected1">The first ingredient we expect</param>
        /// <param name="expected2">The second ingredient we expect</param>
        [Theory]
        [InlineData("hello;goodbye;", "hello", "goodbye")]
        public void ConvertCraftingDBToUIModelShouldWork(string listOfIngredients, string expected1, string expected2)
        {
            var actualModel = ConvertModel.ConvertCraftingDBToUIModel(new CraftingDBModel() { ListOfIngredientName = listOfIngredients, 
                CraftingName = "", CraftingURL = "", ResultName = "", ResultURL = ""});

            //Making a list of the expected items
            CraftingUIModel expectedModel = new CraftingUIModel();
            expectedModel.ListOfIngredientName = new List<string>() { expected1, expected2 };

            //Checking if the expected and actual are equal
            Assert.Equal(expectedModel.ListOfIngredientName, actualModel.ListOfIngredientName);
        }

        [Theory]
        [InlineData("hello", "goodbye", "hello;goodbye;")]
        public void ConvertCraftingUIModelToDBModel(string ingredient1, string ingredient2, string expected)
        {
            CraftingDBModel model = ConvertModel.ConvertUIModelToDBModel(new CraftingUIModel()
            {
                ListOfIngredientName = new List<string>() { ingredient1, ingredient2 },
                CraftingName = "",
                CraftingURL = "",
                ResultName = "",
                ResultURL = ""
            });

            //Checking if strings are equal
            Assert.Equal(expected, model.ListOfIngredientName);
        }

        [Theory]
        [InlineData("hello", "goodbye")]
        public void UItoDBtoUI(string ingredient1, string ingredient2)
        {
            CraftingDBModel model = ConvertModel.ConvertUIModelToDBModel(new CraftingUIModel()
            {
                ListOfIngredientName = new List<string>() { ingredient1, ingredient2 },
                CraftingName = "",
                CraftingURL = "",
                ResultName = "",
                ResultURL = ""
            });

            CraftingUIModel actual = ConvertModel.ConvertCraftingDBToUIModel(new CraftingDBModel() { ListOfIngredientName = model.ListOfIngredientName,
                CraftingName = "",
                CraftingURL = "",
                ResultName = "",
                ResultURL = ""
            });

            Assert.Equal(new List<string>() { ingredient1, ingredient2 }, actual.ListOfIngredientName);

        }
    }
}
