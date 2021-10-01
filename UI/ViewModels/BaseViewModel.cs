using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.ViewModels
{
    public abstract class BaseViewModel
    {
        protected Control view;
        public BaseViewModel(Control view)
        {
            this.view = view;
            Load();
        }
        public abstract void Load();
    }
}
