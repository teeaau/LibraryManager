using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MuonSach
    {
        [Key]
        public int id { get; set; }
        [MaxLength(20)]
        [ForeignKey("DocGia")]
        public string idDocGia { get; set; }
        [ForeignKey("Sach")]
        public int idSach { get; set; }
        public DateTime ngayMuon { get; set; }
        public DateTime? ngayTra { get; set; }
        public DocGia DocGia { get; set; }
        public Sach Sach { get; set; }

    }
}
