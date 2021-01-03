namespace 研招网系统.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question:BaseEntity
    {

        public Guid? UserId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
