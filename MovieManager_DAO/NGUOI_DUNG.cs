namespace MovieManager_DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NGUOI_DUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOI_DUNG()
        {
            DANH_GIA_VA_BINH_LUAN = new HashSet<DANH_GIA_VA_BINH_LUAN>();
        }

        [Key]
        [StringLength(20)]
        public string Tai_khoan { get; set; }

        [StringLength(20)]
        public string Mat_khau { get; set; }

        [StringLength(50)]
        public string Ho_ten { get; set; }

        [StringLength(50)]
        public string Dia_chi { get; set; }

        public DateTime? Ngay_sinh { get; set; }

        [StringLength(15)]
        public string So_dien_thoai { get; set; }

        [StringLength(15)]
        public string CMND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_GIA_VA_BINH_LUAN> DANH_GIA_VA_BINH_LUAN { get; set; }
    }
}
