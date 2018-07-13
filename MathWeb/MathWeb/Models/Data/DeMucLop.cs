namespace MathWeb.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeMucLop")]
    public partial class DeMucLop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeMucLop()
        {
            BaiViets = new HashSet<BaiViet>();
        }

        public int ID { get; set; }

        [StringLength(500)]
        public string TenDeMuc { get; set; }

        public int? IDLop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiViet> BaiViets { get; set; }

        public virtual NhomLop NhomLop { get; set; }
    }
}
