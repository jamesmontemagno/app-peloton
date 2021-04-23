using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Models
{
    public class ProgramCollection
    {
        public string Image { get; set; }
        public string Instructor { get; set; }
        public string Type { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string MoreInstructors { get; set; }
        public bool HasMoreInstructors { get; set; }
    }
}
