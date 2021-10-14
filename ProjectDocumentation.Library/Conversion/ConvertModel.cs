using ProjectDocumentation.Library.Models;
using ProjectDocumentation.Library.Models.UIFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDocumentation.Library.Conversion
{
    public static class ConvertModel
    {
        public static CraftingUIModel ConvertCraftingDBToUIModel(CraftingDBModel craftingDBModel)
        {
            CraftingUIModel modelToReturn = new CraftingUIModel();
            //Map all like properties over
            modelToReturn.CraftingName = craftingDBModel.CraftingName;
            modelToReturn.CraftingURL = craftingDBModel.CraftingURL;
            modelToReturn.ResultName = craftingDBModel.ResultName;
            modelToReturn.ResultURL = craftingDBModel.ResultURL;

            //Loop through each character in the list of the ListOfIngredients, once we get a ';' this means the 
            //ingredient name has ended and should be added to the list

            //Initialize list
            modelToReturn.ListOfIngredientName = new List<string>();

            //Temp variable to store the letters which aren't ';'
            string temp = "";
            //Loop through each character in the string
            foreach (var letter in craftingDBModel.ListOfIngredientName)
            {
                //If its not a ';' add the character to the temp string variable
                if (letter != ';')
                {
                    temp += letter;
                }
                else
                {
                    //Add created string to the list
                    modelToReturn.ListOfIngredientName.Add(temp);
                    //Clear the temp variable
                    temp = "";
                }
            }

            return modelToReturn;
        }

        public static CraftingDBModel ConvertUIModelToDBModel(CraftingUIModel craftingUIModel)
        {
            //Create and instance of the DBModel
            CraftingDBModel modelToReturn = new CraftingDBModel();

            //Map over like properties
            modelToReturn.CraftingName = craftingUIModel.CraftingName;
            modelToReturn.CraftingURL = craftingUIModel.CraftingURL;
            modelToReturn.ResultName = craftingUIModel.ResultName;
            modelToReturn.ResultURL = craftingUIModel.ResultURL;

            //Loop through list, through each increment add the string item followed by a ';'
            foreach (var item in craftingUIModel.ListOfIngredientName)
            {
                modelToReturn.ListOfIngredientName += item;
                modelToReturn.ListOfIngredientName +=  ';';
            }

            return modelToReturn;
        }
    }
}
