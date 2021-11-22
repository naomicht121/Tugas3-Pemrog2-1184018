using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_4_1184018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            string group = "";
            string jadwal = "";

            if (rbJadwal1.Checked)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (rbJadwal2.Checked)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (rbJadwal3.Checked)
            {
                jadwal = "Jumat & Sabtu, 10.00 - 12.00";
            }
            else if (rbJadwal4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }

            if (Suju.Checked)
            {
                group = group + "Super Junior, ";
            }
            if (Snsd.Checked)
            {
                group = group + "Girls Generation, ";
            }
            if (shinee.Checked)
            {
                group = group + "SHINee, ";
            }
            if (fx.Checked)
            {
                group = group + "F(x), ";
            }
            if (exo.Checked)
            {
                group = group + "EXO, ";
            }
            if (redvelvet.Checked)
            {
                group = group + "Red Velvet, ";
            }
            if (nct.Checked)
            {
                group = group + "NCT, ";
            }
            if (aespa.Checked)
            {
                group = group + "Aespa, ";
            }
            if (group == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan Group", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show
                ("Nama : " + tbNama.Text +
                "\nJenis Kelamin : " + cbJK.Text +
                "\nTanggal Lahir: " + dtpTTL.Text +
                "\nPilihan Group : " + group +
                "\nPilihan Jadwal: " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
