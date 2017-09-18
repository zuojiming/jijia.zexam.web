namespace jijia.zexam.domain.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Charpter
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [StringLength(50)]
        public string CharpterName { get; set; }

        public int? SortNo { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? StudyDate { get; set; }

        public int? CreateUser { get; set; }

        public int? UpdateUser { get; set; }

        public int? IsDelete { get; set; }
    }
}
