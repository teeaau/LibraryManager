using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sach
    {
        [Key]
        public int idSach { get; set; }
        [MaxLength(200)]
        public string tenSach { get; set; }
        [MaxLength(50)]
        public string tacGia { get; set; }
        public byte[] anhSach { get; set; }
    }
}
