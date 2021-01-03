namespace 研招网系统.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Policy")]
    public partial class Policy:BaseEntity
    {

        public Guid? CategoryId { get; set; }

        public TimeSpan? PulishTime { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public string Content { get; set; }

        public virtual Category Category { get; set; }
    }
}
