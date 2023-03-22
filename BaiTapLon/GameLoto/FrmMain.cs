using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLoto
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            FrmGameMode formGameMode = new FrmGameMode();
            formGameMode.ShowDialog();
            InitializeComponent();
        }
    }
}
