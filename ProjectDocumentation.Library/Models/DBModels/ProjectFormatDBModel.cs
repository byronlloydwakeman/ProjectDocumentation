using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDocumentation.Library.Models
{
    public class ProjectFormatDBModel
    {
        public bool Complete { get; set; }
        public string ResultName { get; set; }
        public string Trivia { get; set; }
        public string Log { get; set; }
        public string NextToDo { get; set; }
        public int ListOfProblemName { get; set; }
    }
}
