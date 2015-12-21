namespace MovieManager_DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GHE")]
    public partial class GHE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GHE()
        {
            VE = new HashSet<VE>();
        }

        [StringLength(20)]
        public string ID { get; set; }

        [StringLength(20)]
        public string Vi_tri_ghe { get; set; }

        [StringLength(20)]
        public string Loai_ghe { get; set; }

        [StringLength(5)]
        public string Phong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE> VE { get; set; }
    }
}
