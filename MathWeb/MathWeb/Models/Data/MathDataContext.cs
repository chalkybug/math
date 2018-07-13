namespace MathWeb.Models.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MathDataContext : DbContext
    {
        public MathDataContext()
            : base("name=MathDataContext")
        {
        }

        public virtual DbSet<BaiViet> BaiViets { get; set; }
        public virtual DbSet<DeMucLop> DeMucLops { get; set; }
        public virtual DbSet<NhomLop> NhomLops { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThongBao> ThongBaos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaiViet>()
                .Property(e => e.LinkVideo)
                .IsFixedLength();

            modelBuilder.Entity<DeMucLop>()
                .HasMany(e => e.BaiViets)
                .WithOptional(e => e.DeMucLop)
                .HasForeignKey(e => e.IDDeMuc);

            modelBuilder.Entity<NhomLop>()
                .HasMany(e => e.DeMucLops)
                .WithOptional(e => e.NhomLop)
                .HasForeignKey(e => e.IDLop);

            modelBuilder.Entity<PhanQuyen>()
                .HasMany(e => e.TaiKhoans)
                .WithOptional(e => e.PhanQuyen)
                .HasForeignKey(e => e.QuyenSuDung);
        }
    }
}
