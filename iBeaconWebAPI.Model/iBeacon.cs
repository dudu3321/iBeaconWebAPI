namespace iBeaconWebAPI.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("iBeacon")]
    public partial class iBeacon
    {
        [Key]
        [Column(Order = 0)]
        public int SerialNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string UUID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Major { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Minor { get; set; }

        [StringLength(100)]
        public string APIUrl { get; set; }
    }
}
