using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Styles;
namespace UI.ViewModels
{
    public class Tab
    {
        public TabStyle tabHeader = new TabStyle();
        public Control tabView = new Control();
        public string title;
        public Tab(string title, Control view)
        {
            this.title = title;
            ControlManager.Get<Button>(tabHeader, "btnTabTitle").Text = title;
            tabView = view;
            tabView.Dock = DockStyle.Fill;
            ControlManager.Get<Button>(tabHeader, "btnTabClose").Click +=
                new EventHandler(delegate
                {
                    TabManager.CloseTab(this);
                });
            ControlManager.Get<Button>(tabHeader, "btnTabTitle").Click +=
                new EventHandler(delegate
                {
                    TabManager.FocusTab(this);
                });
        }
               
    }
    public static class TabManager
    {
        static Control Header, View;
        static List<Tab> tabs = new List<Tab>();
        public static void Inittilizer(Control header, Control view)
        {
            Header = header;
            View = view;
        }
        public static void OpenTab(Tab tab)
        {
            var tb = tabs.FirstOrDefault(t => t.title == tab.title);
            if(tb != null)
            {
                FocusTab(tb);
                return;
            }
            tab.tabHeader.Location = new Point(tabs.Count * 150, 0);
            tabs.Add(tab);
            Header.Controls.Add(tab.tabHeader);
            View.Controls.Add(tab.tabView);
            FocusTab(tab);
        }
        public static void FocusTab(Tab tab)
        {
            foreach(var t in tabs)
            {
                t.tabView.Visible = false;
                t.tabHeader.BackColor = Color.Transparent;
            }
            tab.tabHeader.BackColor = Color.FromArgb(255, 146, 146);
            tab.tabView.Visible = true;
        }
        public static void CloseTab(Tab tab)
        {
            Header.Controls.Remove(tab.tabHeader);
            View.Controls.Remove(tab.tabView);
            var idx = tabs.IndexOf(tab);
            tabs.Remove(tab);
            if (tabs.Count == 0)
                return;
            FocusTab(tabs[Math.Min(idx, tabs.Count - 1)]);
            Reload();
        }
        static void Reload()
        {
            for(int i = 0; i < tabs.Count; ++i)
            {
                tabs[i].tabHeader.Location = new Point(i * 150, 0);
            }
        }
    }
}
