using ProjectDocumentation.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDocumentation.Library.DataAccess
{
    public static class ElectronicComponentsData
    {
        public static List<ElectronicComponentDBModel> GetListOfComponentsByName(string name)
        {
            return SqlDataAccess.LoadData<ElectronicComponentDBModel, dynamic>("spGetComponentWithName", new { Name = name });
        }

        public static List<ElectronicComponentDBModel> GetListOfAllComponents()
        {
            return SqlDataAccess.LoadData<ElectronicComponentDBModel, dynamic>("spGetAllElectricalComponents", new { });
        }
    }
}
