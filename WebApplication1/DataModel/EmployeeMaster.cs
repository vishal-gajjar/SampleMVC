namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeMaster")]
    public partial class EmployeeMaster
    {
        [Key]
        public int EmployeeId { get; set; }

        [StringLength(50)]
        public string EmployeeName { get; set; }
    }
}
