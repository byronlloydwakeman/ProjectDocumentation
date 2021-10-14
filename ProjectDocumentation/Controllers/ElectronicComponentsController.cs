using ProjectDocumentation.Conversion;
using ProjectDocumentation.Library.DataAccess;
using ProjectDocumentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDocumentation.Controllers
{
    public class ElectronicComponentsController : Controller
    {
        public ActionResult Index()
        { 
            //Uses a class in the class library to access the stored procedure to get all of the electronic components
            var listOfAllComponents = ElectronicComponentsData.GetListOfAllComponents();
            
            //Creating an empty list of UIModels to put the converted DB models into
            List<ElectronicComponentModel> listOfUIModel = new List<ElectronicComponentModel>();

            //Looping through the elements in the DB model list and converting them into UI models with each iteration
            foreach (var model in listOfAllComponents)
            {
                listOfUIModel.Add(ModelConversion.ElectronicComponentDBToUIModel(model));
            }

            return View(listOfUIModel);
        }

        public ActionResult Search(string id)
        {
            var listOfGivenComponents = ElectronicComponentsData.GetListOfComponentsByName(id);

            List<ElectronicComponentModel> listOfUIModel = new List<ElectronicComponentModel>();

            foreach (var model in listOfGivenComponents)
            {
                listOfUIModel.Add(ModelConversion.ElectronicComponentDBToUIModel(model));
            }

            return View(listOfUIModel);
        }

        public ActionResult SchottkyDiode()
        {
            //Access a class in ProjectDocumentation.Library which calls a stored procedure finding electronic components based
            //on a name, where "Schottky diode is a parameter"
            var listOfDBModels = ElectronicComponentsData.GetListOfComponentsByName("Schottky Diode");

            //Creating an empty list of UIModels to put the converted DB models into
            List<ElectronicComponentModel> listOfUIModel = new List<ElectronicComponentModel>();

            //Looping through the elements in the DB model list and converting them into UI models with each iteration
            foreach (var model in listOfDBModels)
            {
                listOfUIModel.Add(ModelConversion.ElectronicComponentDBToUIModel(model));
            }

            return View(listOfUIModel);
        }
    }
}