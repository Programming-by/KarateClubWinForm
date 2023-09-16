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
    public partial class FormFindInstructor : Form
    {
        public FormFindInstructor()
        {
            InitializeComponent();
        }

        private void ChangeVisibility(bool Visibility)
        {

            lblName.Visible = Visibility;
            lblContactInfo.Visible = Visibility;
            lblAddress.Visible = Visibility;
            lblQualifications.Visible = Visibility;


            lblNameText.Visible = Visibility;
            lblContactInfoText.Visible = Visibility;
            lblAddressText.Visible = Visibility;
            lblQualificationsText.Visible = Visibility;


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            clsPeople Person = clsPeople.Find(Convert.ToInt32(txtID.Text));
            clsInstructor Instructor = clsInstructor.Find(Convert.ToInt32(txtID.Text));


            if (Person == null || Instructor == null)
            {

                MessageBox.Show("this ID [" + txtID.Text + "] is not Found");
                ChangeVisibility(false);
                return;

            }
            else
            {

                lblNameText.Text = Person.Name;
                lblContactInfoText.Text = Person.ContactInfo;
                lblAddressText.Text = Person.Address;
                lblQualificationsText.Text = Instructor.Qualifications;

                ChangeVisibility(true);

            }


        }

    }
}
