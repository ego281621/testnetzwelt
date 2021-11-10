using System;
using System.Collections.Generic;

namespace Netzwelt.Models
{
    public class ProvinceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<MunicipalityModel> Municipalities { get; set; }

        public ProvinceModel()
        {
            Municipalities = new List<MunicipalityModel>();
        }
    } 
}
