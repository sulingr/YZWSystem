using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace 研招网系统.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}