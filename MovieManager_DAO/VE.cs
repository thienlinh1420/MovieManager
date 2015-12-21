namespace MovieManager_DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VE")]
    public partial class VE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VE()
        {
            SUAT_CHIEU = new HashSet<SUAT_CHIEU>();
        }

        [StringLength(20)]
        public string ID { get; set; }

        [StringLength(20)]
        public string ID_GHE { get; set; }

        public double? Gia_ve { get; set; }

        public bool? Tinh_trang { get; set; }

        public virtual GHE GHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUAT_CHIEU> SUAT_CHIEU { get; set; }
    }
}
