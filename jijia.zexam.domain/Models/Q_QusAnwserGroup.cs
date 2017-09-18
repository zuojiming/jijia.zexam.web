namespace jijia.zexam.domain.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Q_QusAnwserGroup
    {
        public int Id { get; set; }

        public int? QuestionId { get; set; }

        [StringLength(200)]
        public string D_AnwserType { get; set; }

        public int? ParentGroup { get; set; }

        [StringLength(1)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Prompt { get; set; }

        public double? Score { get; set; }

        [StringLength(2000)]
        public string Desc { get; set; }

        public int? IsDelete { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateUser { get; set; }

        public int? UpdateUser { get; set; }
    }
}
