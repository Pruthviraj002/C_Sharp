using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infoDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void informationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.informationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.information' table. You can move, or remove it, as needed.
            this.informationTableAdapter.Fill(this.modelDataSet.information);

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void addresssLabel_Click(object sender, EventArgs e)
        {

        }

        private void informationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {
            if (genderCheckBox.CheckState == CheckState.Checked)
                genderCheckBox.Text = "Male";
            else if (genderCheckBox.CheckState == CheckState.Checked)
                genderCheckBox.Text = "Female";
            else
                genderCheckBox.Text = "??";
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
