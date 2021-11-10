using System;
using System.Collections.Generic;

namespace Netzwelt.Models.Response
{

    public class TerritoryResponseDataModel
    {
        public List<TerritoryResponseModel> data { get; set; }
    
        public TerritoryResponseDataModel()
        {
            data = new List<TerritoryResponseModel>();
        }
    }

    public class TerritoryResponseModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public int parent { get; set; }
    }
}
