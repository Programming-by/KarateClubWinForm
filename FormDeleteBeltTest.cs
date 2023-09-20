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
    public partial class FormDeleteBeltTest : Form
    {
        clsBeltTest _BeltTest;
        clsMember _Member;
        public FormDeleteBeltTest()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {


            _BeltTest = clsBeltTest.Find(Convert.ToInt32(txtPersonID.Text));


            if (_BeltTest == null)
            {
                MessageBox.Show("this form will be closed because No Member with ID  = " + txtPersonID.Text);

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

            _Member = clsMember.Find(Convert.ToInt32(txtPersonID.Text));

            if (_Member == null)
            {
                MessageBox.Show("No Member Found");
                this.Close();
            }


            if (MessageBox.Show("Are you sure you want to delete Belt Test  [" + txtPersonID.Text + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (clsBeltTest.Delete(Convert.ToInt32(_Member.MemberID)))
                {
                    MessageBox.Show("Belt Test Deleted Successfully.");
                }
            }
        }

    }
}
