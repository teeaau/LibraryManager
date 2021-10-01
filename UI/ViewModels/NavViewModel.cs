using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Styles;
using UI.Views;
namespace UI.ViewModels
{
    public class NavItem
    {
        public NavItemStyle item;
        public string display;
        public Control view;
        public NavItem(string display, Control view)
        {
            item = new NavItemStyle(display);            
            this.display = display;
            this.view = view;
        }
    }
    public class NavViewModel
    {
        Control Nav;
        List<NavItem> navItems = new List<NavItem>();
        public NavViewModel(Control Nav)
        {
            this.Nav = Nav;
            Initilizer();
        }
        void Initilizer()
        {
            var BorrowBook = new BorrowBookView();
            var CreateCard = new CreateCardView();
            var ReceiveBook = new ReceiveBookView();
            var ReturnBook = new ReturnBookView();

            new BorrowBookViewModel(BorrowBook);
            new CreateCardViewModel(CreateCard);
            new ReceiveBookViewModel(ReceiveBook);
            new ReturnBookViewModel(ReturnBook);

            navItems.Add(new NavItem("Muợn sách", BorrowBook));
            navItems.Add(new NavItem("Lập thẻ", CreateCard));
            navItems.Add(new NavItem("Nhận sách", ReceiveBook));
            navItems.Add(new NavItem("Trả sách",ReturnBook));

            foreach(var ni in navItems)
            {
                ni.item.Click += new EventHandler(delegate
                {
                    TabManager.OpenTab(new Tab(ni.display, ni.view));
                });
                Nav.Controls.Add(ni.item);
            }
        }
    }
}
