using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_3_1184018
{
    public partial class Percobaan1 : Form
    {
        public Percobaan1()
        {
            InitializeComponent();
        }

        private void tbsMouse_Click(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah Mouse";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar mouse";
            }
        }

        private void tbMonitor_Click(object sender, EventArgs e)
        {
            if (rbMonitor.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah Monitor";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar monitor";
            }
        }

        private void tbPrinter_Click(object sender, EventArgs e)
        {
            if (rbPrinter.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah Printer";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar printer";
            }
        }

        private void tbKeyboard_Click(object sender, EventArgs e)
        {
            if (rbKeyboard.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah Keyboard";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar keyboard";
            }
        }

        private void tbScanner_Click(object sender, EventArgs e)
        {
            if (rbScanner.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah Scanner";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar scanner";
            }
        }
    }
}
