namespace jijia.zexam.domain.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class C_TestQuestionStatis
    {
        public int Id { get; set; }

        public int? TestId { get; set; }

        public int? QuestionId1 { get; set; }

        public int? QuestionFailCount1 { get; set; }

        public int? QuestionId3 { get; set; }

        public int? QuestionFailCount3 { get; set; }

        public int? QuestionId2 { get; set; }

        public int? QuestionId10 { get; set; }

        public int? QuestionFailCount10 { get; set; }

        public int? QuestionId9 { get; set; }

        public int? QuestionFailCount9 { get; set; }

        public int? QuestionId8 { get; set; }

        public int? QuestionFailCount8 { get; set; }

        public int? QuestionId7 { get; set; }

        public int? QuestionFailCount7 { get; set; }

        public int? QuestionId6 { get; set; }

        public int? QuestionFailCount6 { get; set; }

        public int? QuestionId5 { get; set; }

        public int? QuestionFailCount5 { get; set; }

        public int? QuestionFailCount2 { get; set; }

        public int? QuestionId4 { get; set; }

        public int? QuestionFailCount4 { get; set; }

        public int? IsDelete { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateUser { get; set; }

        public int? UpdateUser { get; set; }
    }
}
