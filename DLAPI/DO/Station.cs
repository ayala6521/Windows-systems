using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class Station
    {
        public int Code { get; set; } //code of the station
        public string Name { get; set; } // name of the station
        public double Longitude { get; set; } //longitude
        public double Latitude { get; set; } //lattitude
        public string Address { get; set; } //address of station
        public bool DisabledAccess { get; set; } //access to disabled
        public bool IsDeleted { get; set; } //check if the station has deleted

    }
}
