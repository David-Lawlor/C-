using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1Asp.Models
{
    public enum EngineType
    {
        Petrol, Diesel, Hybrid
    }

    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int EngineSize { get; set; }

        public EngineType EngineType { get; set; }

    }
}