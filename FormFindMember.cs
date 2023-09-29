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
    public partial class FormFindMember : Form
    {
        public FormFindMember()
        {
            InitializeComponent();
        }

        private void ChangeVisibility(bool Visibility)
        {

            lblName.Visible = Visibility;
            lblContactInfo.Visible = Visibility;
            lblAddress.Visible = Visibility;
            lblEmergencyContactInfo.Visible = Visibility;
            lblLastBeltRank.Visible = Visibility;
            lblIsActive.Visible = Visibility;


            lblNameText.Visible = Visibility;
            lblContactInfoText.Visible = Visibility;
            lblAddressText.Visible = Visibility;
            lblEmergencyContactInfoText.Visible = Visibility;
            lblLastBeltRankText.Visible = Visibility;
            lblIsActiveText.Visible = Visibility;


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            clsPeople Person = clsPeople.Find(Convert.ToInt32(txtID.Text));
            clsMember Member = clsMember.Find(Convert.ToInt32(txtID.Text));


            if (Person == null || Member == null)
            {

                MessageBox.Show("this ID [" + txtID.Text + "] is not Found");
                ChangeVisibility(false);
                return;

            }

                lblNameText.Text = Person.Name;
                lblContactInfoText.Text = Person.ContactInfo;
                lblAddressText.Text = Person.Address;
                lblEmergencyContactInfoText.Text = Member.EmergencyContactInfo;
                lblLastBeltRankText.Text = Member.LastBeltRank.ToString();
                lblIsActiveText.Text = Member.IsActive.ToString();

                ChangeVisibility(true);

        }

    }
}
