namespace MovieManager_DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RAP_CHIEU_PHIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RAP_CHIEU_PHIM()
        {
            PHIM = new HashSet<PHIM>();
        }

        public int ID { get; set; }

        public int? ID_CUM_RAP_CHIEU_PHIM { get; set; }

        public string Ten { get; set; }

        public string Dia_chi { get; set; }

        public virtual CUM_RAP_CHIEU_PHIM CUM_RAP_CHIEU_PHIM { get; set; }

        public virtual KHUYEN_MAI KHUYEN_MAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIM> PHIM { get; set; }
    }
}
