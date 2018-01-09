namespace BlogProje.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yorum")]
    public partial class Yorum
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YorumId { get; set; }

        public string İcerik { get; set; }

        public int? UyeId { get; set; }

        public int? MakaleId { get; set; }

        public DateTime? Tarih { get; set; }

        public virtual Makale Makale { get; set; }

        public virtual Uye Uye { get; set; }
    }
}
