namespace jijia.zexam.domain.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class C_TestStatis
    {
        public int Id { get; set; }

        public int? TestId { get; set; }

        public int? MaxUserId { get; set; }

        public double? MaxScore { get; set; }

        public int? ClassId { get; set; }

        public int? MinUserId { get; set; }

        public double? MinScore { get; set; }

        public double? AvgScore { get; set; }

        public int? PassUserCount { get; set; }

        public int? FailUserCount { get; set; }

        public int? IsDelete { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateUser { get; set; }

        public int? UpdateUser { get; set; }
    }
}
