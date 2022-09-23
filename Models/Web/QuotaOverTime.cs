using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BevProFSServiceAPI.Models.Entity
{
    public class QuotaOverTime
    {
        [Key]
        public int id { get; set; }
        public string zone { get; set; }
        public string subArea { get; set; }
        public string descriptionProject { get; set; }
        public string supervisorLeaderCode { get; set; }
        public string serviceOrderType { get; set; }
        public string year { get; set; }
        public int  target { get; set; }
        public decimal OEJan { get; set; }
        public decimal OEFeb { get; set; }
        public decimal OEMar { get; set; }
        public decimal OEApr { get; set; }
        public decimal OEMay { get; set; }
        public decimal OEJun { get; set; }
        public decimal OEJul { get; set; }
        public decimal OEAug { get; set; }
        public decimal OESep { get; set; }
        public decimal OEOct { get; set; }
        public decimal OENov { get; set; }
        public decimal OEDec { get; set; }
        public decimal OOBJan { get; set; }
        public decimal OOBFeb { get; set; }
        public decimal OOBMar { get; set; }
        public decimal OOBApr { get; set; }
        public decimal OOBMay { get; set; }
        public decimal OOBJun { get; set; }
        public decimal OOBJul { get; set; }
        public decimal OOBAug { get; set; }
        public decimal OOBSep { get; set; }
        public decimal OOBOct { get; set; }
        public decimal OOBNov { get; set; }
        public decimal OOBDec { get; set; }
        public decimal TOJan { get; set; }
        public decimal TOFeb { get; set; }
        public decimal TOMar { get; set; }
        public decimal TOApr { get; set; }
        public decimal TOMay { get; set; }
        public decimal TOJun { get; set; }
        public decimal TOJul { get; set; }
        public decimal TOAug { get; set; }
        public decimal TOSep { get; set; }
        public decimal TOOct { get; set; }
        public decimal TONov { get; set; }
        public decimal TODec { get; set; }

    }

    public class otDetail { 
        public string title { get; set; }
        public decimal quota { get; set; }
        public decimal actual { get; set; }
        public decimal balance { get; set; }
    }


}
