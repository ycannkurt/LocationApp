﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Data.Dto
{
    [DataContract]
    public class DepartmentDto
    {
        [DataMember]
        public int DepartmentID { get; set; }
        [DataMember]
        public int SubUnitID { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Other { get; set; }
    }
}
