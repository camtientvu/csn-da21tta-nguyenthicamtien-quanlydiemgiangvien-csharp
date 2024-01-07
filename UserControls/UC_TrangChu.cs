using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterAndPower.UserControls
{
    public partial class UC_TrangChu : UserControl
    {
        public UC_TrangChu(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
            InitializeComponent();
        }
    }
}
