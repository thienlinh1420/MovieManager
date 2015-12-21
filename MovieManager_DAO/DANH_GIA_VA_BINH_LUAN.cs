namespace MovieManager_DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_GIA_VA_BINH_LUAN
    {
        public int ID { get; set; }

        public int? ID_PHIM { get; set; }

        [StringLength(20)]
        public string ID_NGUOI_DUNG { get; set; }

        public int? Diem_danh_gia { get; set; }

        public string Binh_luan { get; set; }

        public DateTime? Thoi_gian { get; set; }

        public virtual NGUOI_DUNG NGUOI_DUNG { get; set; }

        public virtual PHIM PHIM { get; set; }
    }
}
