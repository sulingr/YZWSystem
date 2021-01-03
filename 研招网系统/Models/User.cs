namespace 研招网系统.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User:BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Answer = new HashSet<Answer>();
            Answer1 = new HashSet<Answer>();
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int? Sex { get; set; }

        public Guid? SchoolId { get; set; }

        [StringLength(50)]
        public string Major { get; set; }

        [StringLength(50)]
        public string Colleges { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        public virtual School School { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answer1 { get; set; }

    }
}
