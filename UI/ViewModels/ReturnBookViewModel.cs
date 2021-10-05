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
    public class ReturnBookViewModel : BaseViewModel, IViewModel
    {
        MuonSachRepository muonSachRepository;
        DocGiaRepository docGiaRepository;
        List<MuonSach> muonSaches;
        List<DocGia> docGias;
        DocGia docGia;
        List<MuonSach> muons = new List<MuonSach>();
        List<BookLayoutStyle> books = new List<BookLayoutStyle>();
        List<Sach> saches = new List<Sach>();
        public ReturnBookViewModel(Control view) : base(view)
        {
        }

        public async override void Load()
        {
            muonSachRepository = new MuonSachRepository();
            docGiaRepository = new DocGiaRepository();
            muonSaches = await muonSachRepository.GetAllAsync();
            docGias = await docGiaRepository.GetAllAsync();
            LoadEvent();
        }
        void LoadEvent()
        {
            var cbbMaThe = ControlManager.Get<ComboBox>(view, "cbbMaThe");
            var cbbTenDG = ControlManager.Get<ComboBox>(view, "cbbTenDG");
            var btnReturn = ControlManager.Get<Button>(view, "btnReturn");
            cbbMaThe.Items.Clear();
            cbbMaThe.Items.AddRange(docGias.ConvertAll(d => d.idDocGia).ToArray());
            cbbMaThe.TextChanged += CbbMaThe_TextChanged;
            cbbTenDG.Items.Clear();
            cbbTenDG.Items.AddRange(docGias.ConvertAll(d => d.tenDocGia).ToArray());
            cbbTenDG.TextChanged += CbbTenDG_TextChanged;
            btnReturn.Click += BtnReturn_Click;
        }

        private async void BtnReturn_Click(object sender, EventArgs e)
        {
            if (docGia == null)
            {
                return;
            }
            for (int i = 0; i < books.Count; i++)
            {
                var chb = ControlManager.Get<CheckBox>(books[i], "chbBorrow");
                if (chb.Checked)
                {
                    var index = muonSaches.IndexOf(muons[i]);
                    muonSaches[index].ngayTra = muons[i].ngayTra = DateTime.Now;
                    muonSachRepository.AddOrUpdate(muons[i]);
                    await muonSachRepository.SaveAsync();
                }
            }
            ClearAll();
        }

        private void CbbTenDG_TextChanged(object sender, EventArgs e)
        {
            var cbb = sender as ComboBox;
            docGia = docGias.FirstOrDefault(d => d.tenDocGia == cbb.Text);
            if (docGia != null)
            {
                ControlManager.Get<ComboBox>(view, "cbbMaThe").Text = docGia.idDocGia;
                muons = muonSaches.Where(m => m.idDocGia == docGia.idDocGia && m.ngayTra == null).ToList();
                saches = muons.ConvertAll(m => m.Sach);
                LayoutBook();
            }
        }

        private void CbbMaThe_TextChanged(object sender, EventArgs e)
        {
            var cbb = sender as ComboBox;
            docGia = docGias.FirstOrDefault(d => d.idDocGia == cbb.Text);
            if (docGia != null)
            {
                ControlManager.Get<ComboBox>(view, "cbbTenDG").Text = docGia.tenDocGia;
                saches = muonSaches.Where(m => m.idDocGia == docGia.idDocGia && m.ngayTra == null).ToList().ConvertAll(m => m.Sach);
                LayoutBook();
            }
        }
        void ClearAll()
        {
            docGia = null;
            muons.Clear();
            saches.Clear();
            ControlManager.Get<ComboBox>(view, "cbbMaThe").Text = null;
            ControlManager.Get<ComboBox>(view, "cbbTenDG").Text = null;
            ControlManager.Get<Panel>(view, "pnlSach").Controls.Clear();
        }
        void LayoutBook()
        {
            var pnlSach = ControlManager.Get<Panel>(view, "pnlSach");
            pnlSach.Controls.Clear();
            books.Clear();
            for (int i = 0, j = 0; i < saches.Count; i++, j = i / 5)
            {
                var stream = new MemoryStream(saches[i].anhSach);
                var book = new BookLayoutStyle();
                book.lblBookName.Text = saches[i].tenSach;
                book.ptbImage.BackgroundImage = Image.FromStream(stream);
                book.ptbImage.BackgroundImageLayout = ImageLayout.Stretch;
                book.Location = new Point(200 * (i % 5), 300 * j);
                ControlManager.Get<CheckBox>(book, "chbBorrow").Text = "Trả sách";
                books.Add(book);
                pnlSach.Controls.Add(book);
            }
        }
    }
}
