using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenVoBinhSon_05_ThiCSharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            String hovaten = "Nguyễn Võ Bình Sơn";
            String msvv = "1223360089";
            String monthi = "Thi CSharp";

            lblinfo.Text = "Họ và tên:" + hovaten;
            lblinfo.Text += "\nMSVV: " + msvv;
            lblinfo.Text += "\nNgày thi: " + System.DateTime.Now.ToString();
            lblinfo.Text += "\nMôn thi: " + monthi;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Định_Dạng gpt = new Định_Dạng();
            gpt.Show();


        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nguyen Vo Binh Son Dep Trai Sieu Cap", "-Chuong Trinh Oach Xa Lach -");
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPhuongTrinhBac2 gpt = new GiaiPhuongTrinhBac2();
            gpt.Show();
        }
    }
}
