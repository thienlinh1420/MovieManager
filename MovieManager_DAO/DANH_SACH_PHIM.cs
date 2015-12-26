namespace MovieManager_DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_SACH_PHIM
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_RAP_CHIEU_PHIM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PHIM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string ID_SUAT_CHIEU { get; set; }

        public virtual PHIM PHIM { get; set; }

        public virtual RAP_CHIEU_PHIM RAP_CHIEU_PHIM { get; set; }

        public virtual SUAT_CHIEU SUAT_CHIEU { get; set; }
    }
}
