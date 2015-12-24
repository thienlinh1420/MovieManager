namespace MovieManager_DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAI_NGUOI_DUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_NGUOI_DUNG()
        {
            NGUOI_DUNG = new HashSet<NGUOI_DUNG>();
        }

        public int ID { get; set; }

        [StringLength(20)]
        public string Ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOI_DUNG> NGUOI_DUNG { get; set; }
    }
}
