namespace MathWeb.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongBao")]
    public partial class ThongBao
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string TieuDe { get; set; }

        [StringLength(500)]
        public string NoiDung { get; set; }
    }
}
