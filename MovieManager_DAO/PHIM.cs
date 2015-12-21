namespace MovieManager_DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIM")]
    public partial class PHIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIM()
        {
            DANH_GIA_VA_BINH_LUAN = new HashSet<DANH_GIA_VA_BINH_LUAN>();
            RAP_CHIEU_PHIM = new HashSet<RAP_CHIEU_PHIM>();
            SUAT_CHIEU = new HashSet<SUAT_CHIEU>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        public int? Nam_san_xuat { get; set; }

        public bool? Tinh_trang { get; set; }

        public double? IMDb { get; set; }

        public string Tom_tat { get; set; }

        [StringLength(50)]
        public string Duong_dan_Poster { get; set; }

        public string Trailer { get; set; }

        public int? Thoi_luong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_GIA_VA_BINH_LUAN> DANH_GIA_VA_BINH_LUAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RAP_CHIEU_PHIM> RAP_CHIEU_PHIM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUAT_CHIEU> SUAT_CHIEU { get; set; }
    }
}
