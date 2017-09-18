namespace jijia.zexam.domain.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_CharpterQuestion
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string TestPagerId { get; set; }

        [StringLength(4000)]
        public string QusName { get; set; }

        [StringLength(200)]
        public string QusType { get; set; }

        [StringLength(200)]
        public string QusCategary { get; set; }

        [StringLength(200)]
        public string QusSubject { get; set; }

        public int? IsDelete { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateUser { get; set; }

        public int? UpdateUser { get; set; }
    }
}
