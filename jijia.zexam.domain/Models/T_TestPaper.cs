namespace jijia.zexam.domain.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_TestPaper
    {
        public int Id { get; set; }

        public double? TotalScore { get; set; }

        public double? PassScore { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Desc { get; set; }

        public int? IsDelete { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateUser { get; set; }

        public int? UpdateUser { get; set; }
    }
}
