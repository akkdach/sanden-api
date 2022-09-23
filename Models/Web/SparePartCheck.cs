using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BevProFSServiceAPI.Models.Entity
{
    public class SparePartCheck
    {
        public SparePartCheckHeader header { get; set; }
        public List<SparePartCheckItem> item { get; set; }
        public AspNetUsers employee { get; set; }
        public List<MaterialCostMaster> costMaster { get; set; }
        public string imgPath { get; set; }
    }

    public class SparePartCheckHeader
    {
        [Key]
        public int DocNo { get; set; }
        public int DocType { get;set; }
        public string WK_CTR { get; set; }
        public string STGE_LOC { get; set; }
        public string PLANT { get; set; }
        [DataType(DataType.Date)]
        public DateTime createDate { get; set; }
        public string confirmBy { get; set; }
        public string approveBy { get; set; }
        public DateTime? approveDate { get; set; }
    }
    public class SparePartCheckItem
    {
        [Key]
        public int row { get; set; }
        public int DocNo { get; set; }
        public string material { get; set; }
        public string materialDescription { get; set; }
        public decimal quantity { get; set; }
        public decimal remaining { get; set; }
        public decimal counts { get; set; }
        public decimal diff { get; set; }
    }
}
