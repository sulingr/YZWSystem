namespace 研招网系统.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Information:BaseEntity
    {

        public Guid? CategoryId { get; set; }

        public Guid? SchoolId { get; set; }

        public TimeSpan? PulishTime { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public string Content { get; set; }

        public virtual Category Category { get; set; }

        public virtual School School { get; set; }
    }
}
