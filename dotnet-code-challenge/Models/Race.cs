using System;
using System.Collections.Generic;

namespace dotnet_code_challenge.Models
{
    public class Race
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public string Track { get; set; }
        
        private List<Horse> Horses { get; set; }
    }
}