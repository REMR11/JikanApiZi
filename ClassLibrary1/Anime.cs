using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Anime
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Column("MalId")]
        [Required (ErrorMessage ="PENDEJO")]
        [RegularExpression("//")]
        public int MalId { get; set; }

        [Column("Rank")]
        public int? Rank { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Score")]
        public double Score { get; set; }
    }
}
