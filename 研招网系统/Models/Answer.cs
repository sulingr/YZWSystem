namespace 研招网系统.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Answer")]
    public partial class Answer:BaseEntity
    { 

        public Guid UserId { get; set; }

        public string Content { get; set; }

        [StringLength(50)]
        public string Way { get; set; }

        public Guid Qid { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
