using KarateDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaratePresentationLayer
{
    public partial class FormDeleteInstructors : Form
    {
        clsPeople _Person;
        clsInstructor _Instructor;
        public FormDeleteInstructors()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            _Person = clsPeople.Find(Convert.ToInt32(txtPersonID.Text));
            _Instructor = clsInstructor.Find(Convert.ToInt32(txtPersonID.Text));

            if (_Person == null || _Instructor == null)
            {
                MessageBox.Show("this form will be closed because No Instructor with ID  = " + txtPersonID.Text);

                this.Close();

                return;

            }

            lblIsFound.Text = "Found";
            lblIsFound.Visible = true;
            btnClose.Visible = true;
            btnDelete.Visible = true;



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Instructor [" + txtPersonID.Text + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsInstructor.Delete(Convert.ToInt32(txtPersonID.Text)))
                {
                    if (clsPeople.Delete(Convert.ToInt32(txtPersonID.Text)))
                    {
                        MessageBox.Show("Instructor Deleted Successfully.");
                    }
                }
            }
        }
    }
}
