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
    public partial class FormDeleteSubscriptionPeriod : Form
    {
        clsSubscriptionPeriod _SubscriptionPeriod;
        clsMember _Member;
        public FormDeleteSubscriptionPeriod()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _SubscriptionPeriod = clsSubscriptionPeriod.Find(Convert.ToInt32(txtPersonID.Text));

            if ( _SubscriptionPeriod == null)
            {
                MessageBox.Show("this form will be closed because No SubscriptionPeriod with ID  = " + txtPersonID.Text);

                this.Close();

                return;
            }
            _Member = clsMember.Find(Convert.ToInt32(txtPersonID.Text));

            lblIsFound.Text = "Found";
            lblIsFound.Visible = true;
            btnClose.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Subscription Period [" + txtPersonID.Text + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsSubscriptionPeriod.Delete(Convert.ToInt32(_Member.MemberID)))
                {
                        MessageBox.Show("SubscriptionPeriod Deleted Successfully.");
                }
            }
        }
    }
}
