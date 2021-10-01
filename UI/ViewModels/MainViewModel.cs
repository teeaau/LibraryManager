using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Views;
namespace UI.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(Control view) : base(view)
        {
        }
        public override void Load()
        {
            HeaderEvent();
            TabEvent();
            NavEvent();
        }
        #region Event
        void HeaderEvent()
        {
            var mainView = view as Form;
            var btnClose = ControlManager.Get<Button>(view, "btnClose");
            btnClose.Click += new EventHandler(delegate
            {
                (mainView).Close();
            });

            var btnResize = ControlManager.Get<Button>(view, "btnResize");
            btnResize.Click += new EventHandler(delegate
            {
                if (mainView.WindowState == FormWindowState.Normal)
                    mainView.WindowState = FormWindowState.Maximized;
                else
                    mainView.WindowState = FormWindowState.Normal;
            });

            var btnMinimize = ControlManager.Get<Button>(view, "btnMinimize");
            btnMinimize.Click += new EventHandler(delegate
            {
                mainView.WindowState = FormWindowState.Minimized;
            });

            var pnlHeader = ControlManager.Get<Panel>(view, "pnlHeader");
            pnlHeader.MouseDown += PnlHeader_MouseDown;
            pnlHeader.MouseMove += PnlHeader_MouseMove;
            pnlHeader.MouseUp += PnlHeader_MouseUp;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = view.Location;
        }
        private void PnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                view.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void PnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void TabEvent()
        {
            var tabHeader = ControlManager.Get<Panel>(view, "pnlTabHeader");
            var tabView = ControlManager.Get<Panel>(view, "pnlTabView");
            TabManager.Inittilizer(tabHeader, tabView);
        }

        private void NavEvent()
        {
            var Nav = ControlManager.Get<Panel>(view, "pnlNav");
            new NavViewModel(Nav);
        }
        #endregion
    }
}
