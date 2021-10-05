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
        public IViewModel viewModel;
        public NavItem(string display, Control view, IViewModel viewModel)
        {
            item = new NavItemStyle(display);            
            this.display = display;
            this.view = view;
            this.viewModel = viewModel;
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
            var ReturnBook = new ReturnBookView();

            navItems.Add(new NavItem("Muợn sách", BorrowBook, new BorrowBookViewModel(BorrowBook)));
            navItems.Add(new NavItem("Lập thẻ", CreateCard, new CreateCardViewModel(CreateCard)));
            navItems.Add(new NavItem("Trả sách",ReturnBook, new ReturnBookViewModel(ReturnBook)));

            foreach(var ni in navItems)
            {
                ni.item.Click += new EventHandler(delegate
                {
                    TabManager.OpenTab(new Tab(ni.display, ni.view, ni.viewModel));
                });
                Nav.Controls.Add(ni.item);
            }
        }
    }
}
