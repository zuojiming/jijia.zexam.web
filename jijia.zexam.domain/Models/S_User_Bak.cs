namespace jijia.zexam.domain.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_User_Bak
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string IsEnabled { get; set; }

        public DateTime? LoginBeginDate { get; set; }

        public DateTime? LoginEndDate { get; set; }

        [StringLength(50)]
        public string ClassId { get; set; }

        public DateTime? StudyDate { get; set; }

        public int? IsDelete { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateUser { get; set; }

        public int? UpdateUser { get; set; }
    }
}
