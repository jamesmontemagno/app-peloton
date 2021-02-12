using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Models
{
    public class FinishedWorkout
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
        public string ActivityType { get; set; }
        public string FinishedDate { get; set; }
        public string AiredDate { get; set; }
        public string RideLocation { get; set; }
    }
}
