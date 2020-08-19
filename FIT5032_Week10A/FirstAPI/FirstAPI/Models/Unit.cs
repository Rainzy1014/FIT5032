using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Models
{
    public class Unit
    {
        private string unitId;
        private string unitCode;
        private string unitName;

        

        public string UnitId { get => unitId; set => unitId = value; }
        public string UnitCode { get => unitCode; set => unitCode = value; }
        public string UnitName { get => unitName; set => unitName = value; }
    }
}
