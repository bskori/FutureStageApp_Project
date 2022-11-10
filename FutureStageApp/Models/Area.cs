﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("AreaTbl")]
    public class Area
    {
        [Key]
        public Int64 AreaID { get; set; }
        public string AreaName { get; set; }
       [ForeignKey("City")]
        public Int64 CityID { get; set; }
        public virtual City City { get; set; }
        public virtual List<School> Schools { get; set; }
    }
}
