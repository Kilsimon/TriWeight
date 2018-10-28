using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wishlist
{
    public partial class BrowserForm : Form
    {
        public BrowserForm(string url)
        {
            InitializeComponent();
            wbShop.Navigate(url);
        }
    }
}
