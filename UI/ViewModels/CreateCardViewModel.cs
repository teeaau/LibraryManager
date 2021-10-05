using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Repository;
using UI.Styles;

namespace UI.ViewModels
{
    public class CreateCardViewModel : BaseViewModel, IViewModel
    {
        DocGiaRepository docGiaRepository;
        List<DocGia> docGias;
        DocGia docGia;
        public CreateCardViewModel(Control view) : base(view)
        {
        }

        public async override void Load()
        {
            docGiaRepository = new DocGiaRepository();
            docGias = await docGiaRepository.GetAllAsync();
            FillTable();
            LoadEvent();
        }

        private void LoadEvent()
        {
            ClearAll();
            var txbName = ControlManager.Get<TextBox>(view, "txbName");
            var txbPhone = ControlManager.Get<TextBox>(view, "txbPhone");
            var txbAddress = ControlManager.Get<TextBox>(view, "txbAddress");
            var txbCMND = ControlManager.Get<TextBox>(view, "txbCMND");
            var btnSelectImage = ControlManager.Get<Button>(view, "btnSelectImage");
            var btnCreateCard = ControlManager.Get<Button>(view, "btnCreateCard");
            var cbbSex = ControlManager.Get<ComboBox>(view, "cbbSex");
            txbName.TextChanged += TxbName_TextChanged;
            txbCMND.TextChanged += TxbCMND_TextChanged;
            txbPhone.TextChanged += TxbPhone_TextChanged;
            txbAddress.TextChanged += TxbAddress_TextChanged;
            cbbSex.SelectionChangeCommitted += CbbSex_SelectionChangeCommitted;
            btnSelectImage.Click += BtnSelectImage_Click;
            btnCreateCard.Click += BtnCreateCard_Click;
        }

        private void CbbSex_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cbb = sender as ComboBox;
            ControlManager.Get<Label>(view, "lblCardSex").Text = cbb.Text;
            docGia.GioiTinh = cbb.Text;
        }

        private void TxbAddress_TextChanged(object sender, EventArgs e)
        {
            var txb = sender as TextBox;
            docGia.DiaChi = txb.Text;
        }

        private void TxbPhone_TextChanged(object sender, EventArgs e)
        {
            var txb = sender as TextBox;
            docGia.soDienThoai = txb.Text;
        }

        private void BtnCreateCard_Click(object sender, EventArgs e)
        {
            if (docGia.tenDocGia == null || docGia.soDienThoai == null || 
                docGia.GioiTinh == null || docGia.DiaChi == null || 
                docGia.anhDaiDien == null || docGia.CMND == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin độc giả");
                return;
            }
            docGias.Add(docGia);
            docGiaRepository.AddOrUpdate(docGia);
            docGiaRepository.SaveAsync();
            ClearAll();
            FillTable();
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var image = new Bitmap(open.FileName);
                ControlManager.Get<PictureBox>(view, "ptbImage").BackgroundImage = image;
                ControlManager.Get<PictureBox>(view, "ptbCardImage").BackgroundImage = image;
                docGia.anhDaiDien = File.ReadAllBytes(open.FileName);
            }
        }

        private void TxbCMND_TextChanged(object sender, EventArgs e)
        {
            var txb = sender as TextBox;
            ControlManager.Get<Label>(view, "lblCardCMND").Text = txb.Text;
            docGia.CMND = txb.Text;
        }

        private void TxbName_TextChanged(object sender, EventArgs e)
        {
            var txb = sender as TextBox;
            ControlManager.Get<Label>(view, "lblCardName").Text = txb.Text;
            docGia.tenDocGia = txb.Text;
        }

        async void FillTable()
        {
            var pnl = ControlManager.Get<Panel>(view, "pnlTable");
            pnl.Controls.Clear();
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
            TableStyle table = new TableStyle(header, data, false, false);
            pnl.Controls.Add(table.display);
        }
        void ClearAll()
        {
            docGia = new DocGia()
            {
                idDocGia = DateTime.Now.ToString("yyyyMMddhhmmss")
            };
            ControlManager.Get<Label>(view, "lblCardId").Text = docGia.idDocGia;
            ControlManager.Get<TextBox>(view, "txbName").Text = null;
            ControlManager.Get<TextBox>(view, "txbPhone").Text = null;
            ControlManager.Get<TextBox>(view, "txbAddress").Text = null;
            ControlManager.Get<TextBox>(view, "txbCMND").Text = null;
            ControlManager.Get<ComboBox>(view, "cbbSex").SelectedItem = null;
            ControlManager.Get<PictureBox>(view, "ptbImage").BackgroundImage = null;
            ControlManager.Get<Label>(view, "lblCardId").Text = docGia.idDocGia;
            ControlManager.Get<Label>(view, "lblCardCMND").Text = null;
            ControlManager.Get<Label>(view, "lblCardName").Text = null;
            ControlManager.Get<Label>(view, "lblCardSex").Text = null;
            ControlManager.Get<PictureBox>(view, "ptbCardImage").BackgroundImage = null;
        }
    }
}
