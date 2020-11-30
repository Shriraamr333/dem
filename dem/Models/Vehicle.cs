using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dem.Models
{
    public class Vehicle
    {
        public int EntryId { get; set; }
        public string vechicletype { get; set; }
        public int vechiclecapacity { get; set; }
        public string vechicledetails { get; set; }
    }
    public class VehicleList 
    {
        public List<Vehicle> vehicles { get; set; } = null;
    }
}