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
    public class BorrowBookViewModel : BaseViewModel, IViewModel
    {
        SachRepository sachRepository;
        MuonSachRepository muonSachRepository;
        DocGiaRepository docGiaRepository;
        List<Sach> saches;
        List<DocGia> docGias;
        DocGia docGia;
        List<BookLayoutStyle> books = new List<BookLayoutStyle>();
        public BorrowBookViewModel(Control view) : base(view)
        {
        }

        public async override void Load()
        {
            sachRepository = new SachRepository();
            muonSachRepository = new MuonSachRepository();
            docGiaRepository = new DocGiaRepository();
            saches = await sachRepository.GetAllAsync();
            docGias = await docGiaRepository.GetAllAsync();
            LayoutBook();
            LoadEvent();
        }
        void LayoutBook()
        {
            var pnlSach = ControlManager.Get<Panel>(view, "pnlSach");
            for (int i = 0, j = 0; i < saches.Count; i++, j = i / 5)
            {
                var stream = new MemoryStream(saches[i].anhSach);
                var book = new BookLayoutStyle();
                book.lblBookName.Text = saches[i].tenSach;
                book.ptbImage.BackgroundImage = Image.FromStream(stream);
                book.ptbImage.BackgroundImageLayout = ImageLayout.Stretch;
                book.Location = new Point(200 * (i % 5), 300 * j);
                books.Add(book);
                pnlSach.Controls.Add(book);
            }
        }
        void LoadEvent()
        {
            var cbbMaThe = ControlManager.Get<ComboBox>(view, "cbbMaThe");
            var cbbTenDG = ControlManager.Get<ComboBox>(view, "cbbTenDG");
            var btnBorrow = ControlManager.Get<Button>(view, "btnBorrow");
            cbbMaThe.Items.Clear();
            cbbMaThe.Items.AddRange(docGias.ConvertAll(d => d.idDocGia).ToArray());
            cbbMaThe.TextChanged += CbbMaThe_TextChanged;
            cbbTenDG.Items.Clear();
            cbbTenDG.Items.AddRange(docGias.ConvertAll(d => d.tenDocGia).ToArray());
            cbbTenDG.TextChanged += CbbTenDG_TextChanged;
            btnBorrow.Click += BtnBorrow_Click;
        }

        private async void BtnBorrow_Click(object sender, EventArgs e)
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
                    var ms = new MuonSach()
                    {
                        idDocGia = docGia.idDocGia,
                        ngayMuon = DateTime.Now,
                        idSach = saches[i].idSach
                    };
                    muonSachRepository.AddOrUpdate(ms);
                }
            }
            await muonSachRepository.SaveAsync();
            ClearAll();
        }

        private void CbbTenDG_TextChanged(object sender, EventArgs e)
        {
            var cbb = sender as ComboBox;
            docGia = docGias.FirstOrDefault(d => d.tenDocGia == cbb.Text);
            if (docGia != null)
            {
                ControlManager.Get<ComboBox>(view, "cbbMaThe").Text = docGia.idDocGia;
            }
        }

        private void CbbMaThe_TextChanged(object sender, EventArgs e)
        {
            var cbb = sender as ComboBox;
            docGia = docGias.FirstOrDefault(d => d.idDocGia == cbb.Text);
            if (docGia != null)
            {
                ControlManager.Get<ComboBox>(view, "cbbTenDG").Text = docGia.tenDocGia;
            }
        }
        void ClearAll()
        {
            docGia = null;
            ControlManager.Get<ComboBox>(view, "cbbMaThe").Text = null;
            ControlManager.Get<ComboBox>(view, "cbbTenDG").Text = null;
            foreach (var b in books)
            {
                ControlManager.Get<CheckBox>(b, "chbBorrow").Checked = false;
            }
        }
    }
}
