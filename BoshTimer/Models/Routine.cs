using System;
using System.ComponentModel.DataAnnotations;

namespace BoshTimer.Models
{
    public class Routine
    {
        public int Id { get; set; }

        public string RoutineName { get; set; }

        public int WorkTime { get; set; }

        public int RestTime { get; set; }

        public int NumberRounds { get; set; }
    }
}
