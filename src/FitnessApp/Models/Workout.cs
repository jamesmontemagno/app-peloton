using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Models
{
    public class Workout
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public bool Bookmarked { get; set; }
    }

    public class WorkoutGroup
    {
        public WorkoutGroup(List<Workout> workouts)
        {
            Workouts = workouts;
        }
        public List<Workout> Workouts { get; set; }
    }
}
