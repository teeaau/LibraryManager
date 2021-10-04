using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DocGia
    {
        [MaxLength(20)]
        [Key]
        public string idDocGia { get; set; }
        [MaxLength(50)]
        public string tenDocGia { get; set; }
        [MaxLength(15)]
        public string soDienThoai { get; set; }
        [MaxLength(20)]
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        [MaxLength(10)]
        public string GioiTinh { get; set; }
        public byte[] anhDaiDien { get; set; }
    }
}
