using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDocumentation.Library.Models.UIFolder
{
    public class CraftingUIModel
    {
        public string ResultName { get; set; }
        public string ResultURL { get; set; }
        public List<string> ListOfIngredientName { get; set; }
        public string CraftingName { get; set; }
        public string CraftingURL { get; set; }
    }
}
