namespace MovieManager_DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CUM_RAP_CHIEU_PHIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUM_RAP_CHIEU_PHIM()
        {
            RAP_CHIEU_PHIM = new HashSet<RAP_CHIEU_PHIM>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RAP_CHIEU_PHIM> RAP_CHIEU_PHIM { get; set; }
    }
}
