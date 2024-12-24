using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SanzyapovOD.Sprint7.Project.V7
{
    public partial class FormAdd : Form
    {
        FormMain fmain;
        public FormAdd(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonAdd_SOD_Click(object sender, EventArgs e)
        {
            if ((comboBoxKids_SOD.Text == "") || (comboBoxDebt_SOD.Text == ""))
            {
                MessageBox.Show("Введите обязательные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fmain.dataGridViewBase_SOD.Rows.Add(textBoxPadik_SOD.Text, textBoxAppartament_SOD.Text, textBoxRooms_SOD.Text, textBoxTotalArea_SOD.Text, comboBoxKids_SOD.Text, comboBoxDebt_SOD.Text);
                this.Close();
            }
        }

        private void textBoxPadik_SOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxAppartament_SOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxRooms_SOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxTotalArea_SOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
