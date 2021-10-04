using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Repository;
using UI.Styles;

namespace UI.ViewModels
{
    public class CreateCardViewModel : BaseViewModel
    {
        DocGiaRepository docGiaRepository;
        List<DocGia> docGias;
        public CreateCardViewModel(Control view) : base(view)
        {
        }

        public async override void Load()
        {
            docGiaRepository = new DocGiaRepository();
            var data = await docGiaRepository.GetAllAsync();
            docGias = new List<DocGia>(data);
            FillTable();
        }
        #region Function
        void FillTable()
        {
            var pnl = ControlManager.Get<Panel>(view, "pnlTable");
            var header = new string[]
            {
                "Mã thẻ",
                "Tên độc giả",
                "Số điện thoại",
                "CMND",
                "Giới tính",
                "Địa chỉ"
            };
            var data = new List<string[]>();
            foreach(var docGia in docGias)
            {
                var arr = new string[]
                {
                    docGia.idDocGia,
                    docGia.tenDocGia,
                    docGia.soDienThoai,
                    docGia.CMND,
                    docGia.GioiTinh,
                    docGia.DiaChi
                };
                data.Add(arr);
            }
            TableStyle table = new TableStyle(header, data);
            pnl.Controls.Add(table.display);
        }
        #endregion
    }
}
