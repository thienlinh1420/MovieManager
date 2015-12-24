namespace MovieManager_DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUAT_CHIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUAT_CHIEU()
        {
            VE = new HashSet<VE>();
            PHIM = new HashSet<PHIM>();
        }

        [StringLength(20)]
        public string ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngay_chieu { get; set; }

        public TimeSpan? Gio_chieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE> VE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIM> PHIM { get; set; }
    }
}
