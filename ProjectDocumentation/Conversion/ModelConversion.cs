using ProjectDocumentation.Library.Models;
using ProjectDocumentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDocumentation.Conversion
{
    public static class ModelConversion
    {
        public static ElectronicComponentModel ElectronicComponentDBToUIModel(ElectronicComponentDBModel electronicComponentDBModel)
        {
            ElectronicComponentModel electronicComponentModel = new ElectronicComponentModel();

            electronicComponentModel.Name = electronicComponentDBModel.Name;
            electronicComponentModel.Location = electronicComponentDBModel.Location;
            electronicComponentModel.Quantity = electronicComponentDBModel.Quantity;
            electronicComponentModel.Specifications = electronicComponentDBModel.Specification;

            return electronicComponentModel;
        }
    }
}