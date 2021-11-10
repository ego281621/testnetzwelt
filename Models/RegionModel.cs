using System;
using System.Collections.Generic;

namespace Netzwelt.Models
{
    public class RegionModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<ProvinceModel> Provinces { get; set; }

        public RegionModel()
        {
            Provinces = new List<ProvinceModel>();
        }
    } 
}
