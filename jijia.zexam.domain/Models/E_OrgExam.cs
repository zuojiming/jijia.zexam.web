namespace jijia.zexam.domain.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class E_OrgExam
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string TestPagerId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public DateTime? BeginDate { get; set; }

        public int? TimeLength { get; set; }

        public int? PassScore { get; set; }

        public int? ExamType { get; set; }

        public int? ExamStatue { get; set; }

        public int? Year { get; set; }

        public bool? IsPublish { get; set; }

        public int? IsDelete { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateUser { get; set; }

        public int? UpdateUser { get; set; }
    }
}
