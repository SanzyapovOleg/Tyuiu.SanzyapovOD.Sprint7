﻿using System;
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
    public partial class FormEdit : Form
    {
        FormMain fmain;
        public FormEdit(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }
        public void buttonEdit_SOD_Click(object sender, EventArgs e)
        {

            if ((comboBoxKids_SOD.Text == "") || (comboBoxDebt_SOD.Text == ""))
            {
                MessageBox.Show("Введите обязательные характеристики", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int a = fmain.dataGridViewBase_SOD.CurrentRow.Index;
                fmain.dataGridViewBase_SOD.Rows[a].Cells[0].Value = textBoxPadik_SOD.Text;
                fmain.dataGridViewBase_SOD.Rows[a].Cells[1].Value = textBoxAppartament_SOD.Text;
                fmain.dataGridViewBase_SOD.Rows[a].Cells[2].Value = textBoxRooms_SOD.Text;
                fmain.dataGridViewBase_SOD.Rows[a].Cells[3].Value = textBoxTotalArea_SOD.Text;
                fmain.dataGridViewBase_SOD.Rows[a].Cells[4].Value = comboBoxKids_SOD.Text;
                fmain.dataGridViewBase_SOD.Rows[a].Cells[5].Value = comboBoxDebt_SOD.Text;
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
