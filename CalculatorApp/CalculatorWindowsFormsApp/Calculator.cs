using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNilaiA.Text); // proses casting
            var b = Convert.ToInt32(txtNilaiB.Text); // proses casting

            lstHasil.Items.Clear();
            lstHasil.Items.Add("Hasil Penambahan" + a + " + " + b + " = " + Penambahan(a, b));
            lstHasil.Items.Add(string.Format("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b)));
        }
    }
}
