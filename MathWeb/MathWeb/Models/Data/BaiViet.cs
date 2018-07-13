namespace MathWeb.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiViet")]
    public partial class BaiViet
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string TenBaiViet { get; set; }

        [StringLength(100)]
        public string Data { get; set; }

        [StringLength(500)]
        public string LinkVideo { get; set; }

        public int? IDDeMuc { get; set; }

        public virtual DeMucLop DeMucLop { get; set; }
    }
}
