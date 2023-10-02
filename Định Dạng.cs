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
    public partial class Định_Dạng : Form
    {
        public Định_Dạng()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Định_Dạng_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            radGreen.Checked = true;
            radBlue.Checked = true;
            radBlack.Checked = true;
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Text = txtNhapTen.Text;
            lblLapTrinh.Text = txtNhapTen.Text;

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    lblLapTrinh.ForeColor = Color.Red;
                    txtNhapTen.ForeColor = Color.Red;
                    txtLapTrinh.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    lblLapTrinh.ForeColor = Color.Green;
                    txtNhapTen.ForeColor = Color.Green;
                    txtLapTrinh.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    txtLapTrinh.ForeColor = Color.Blue;
                    lblLapTrinh.ForeColor = Color.Blue;
                    txtNhapTen.ForeColor = Color.Blue;
                    break;
                case "radBlack":
                    txtLapTrinh.ForeColor = Color.Black;
                    lblLapTrinh.ForeColor = Color.Black;
                    txtNhapTen.ForeColor = Color.Black;
                    break;
            }
        }

        private void txtLapTrinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBlod_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox r = (CheckBox)sender;
            switch (r.Name)
            {
                case "chkBold":
                    lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Bold);
                    break;
                case "chkNghieng":
                    lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Italic);
                    break;
                case "chkUnderline":
                    lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Underline);
                    break;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
    }

