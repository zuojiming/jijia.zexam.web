namespace jijia.zexam.domain.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Dic_Item
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Code { get; set; }

        public bool? IsDefault { get; set; }

        public int? DicId { get; set; }

        [StringLength(200)]
        public string Value { get; set; }

        public int? IsDelete { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateUser { get; set; }

        public int? UpdateUser { get; set; }
    }
}
