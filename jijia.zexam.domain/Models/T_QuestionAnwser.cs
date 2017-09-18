namespace jijia.zexam.domain.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_QuestionAnwser
    {
        public int Id { get; set; }

        [StringLength(1)]
        public string Title { get; set; }

        [StringLength(1)]
        public string Anwser { get; set; }

        public int? GroupId { get; set; }

        public double? Score { get; set; }

        public bool? IsTrue { get; set; }

        public int? IsDelete { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateUser { get; set; }

        public int? UpdateUser { get; set; }
    }
}
