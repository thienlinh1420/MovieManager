namespace MovieManager_DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHUYEN_MAI
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_RAP_CHIEU_PHIM { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        public string Chi_tiet { get; set; }

        public string Dieu_kien { get; set; }

        public virtual RAP_CHIEU_PHIM RAP_CHIEU_PHIM { get; set; }
    }
}
