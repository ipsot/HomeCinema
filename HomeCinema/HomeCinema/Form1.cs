using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeCinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void homeCinemaSpecificationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.homeCinemaSpecificationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.homeCinemaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeCinemaDataSet.HomeCinemaManufacturer". При необходимости она может быть перемещена или удалена.
            this.homeCinemaManufacturerTableAdapter.Fill(this.homeCinemaDataSet.HomeCinemaManufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeCinemaDataSet.HomeCinemaSpecification". При необходимости она может быть перемещена или удалена.
            this.homeCinemaSpecificationTableAdapter.Fill(this.homeCinemaDataSet.HomeCinemaSpecification);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int i = homeCinemaSpecificationDataGridView.CurrentRow.Index;
            int currentId = Convert.ToInt32(homeCinemaSpecificationDataGridView[0, i].Value.ToString());

            this.homeCinemaDataSet.HomeCinemaSpecification.FindByid(currentId).Delete();
            this.homeCinemaSpecificationTableAdapter.Update(this.homeCinemaDataSet.HomeCinemaSpecification);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var row = this.homeCinemaDataSet.HomeCinemaManufacturer.FindByid(Convert.ToInt32(idManufacturerTextBox.Text));
            this.homeCinemaDataSet.HomeCinemaSpecification.AddHomeCinemaSpecificationRow(row, permissionTextBox.Text, Convert.ToInt32(brightnessTextBox.Text), Convert.ToInt32(contrastTextBox.Text));
            this.homeCinemaSpecificationTableAdapter.Update(this.homeCinemaDataSet.HomeCinemaSpecification);
            idManufacturerTextBox.Clear();
            permissionTextBox.Clear();
            brightnessTextBox.Clear();
            contrastTextBox.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int i = homeCinemaSpecificationDataGridView.CurrentRow.Index;
            int currentId = Convert.ToInt32(homeCinemaSpecificationDataGridView[0, i].Value.ToString());
            this.homeCinemaDataSet.HomeCinemaSpecification.FindByid(currentId);
            this.homeCinemaSpecificationTableAdapter.Update(this.homeCinemaDataSet.HomeCinemaSpecification);
            idManufacturerTextBox.Text = homeCinemaSpecificationDataGridView[1, i].Value.ToString();
            permissionTextBox.Text = homeCinemaSpecificationDataGridView[2, i].Value.ToString();
            brightnessTextBox.Text = homeCinemaSpecificationDataGridView[3, i].Value.ToString();
            contrastTextBox.Text = homeCinemaSpecificationDataGridView[4, i].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var row = this.homeCinemaDataSet.HomeCinemaManufacturer.FindByid(Convert.ToInt32(idManufacturerTextBox.Text));

            this.homeCinemaSpecificationTableAdapter.Update(this.homeCinemaDataSet.HomeCinemaSpecification);
            this.homeCinemaDataSet.HomeCinemaSpecification.AcceptChanges();
            idManufacturerTextBox.Clear();
            permissionTextBox.Clear();
            brightnessTextBox.Clear();
            contrastTextBox.Clear();
        }
    }
}
