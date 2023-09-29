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
    public partial class FormUpdateMember : Form
    {

        clsPeople _Person;
        clsMember _Member;

        public enum enMode { AddNew = 0, Update = 1 };

        enMode _Mode;
        public FormUpdateMember()
        {
            InitializeComponent();
        }

        private void DisableFormData()
        {
            lblIsFound.Visible = false ;

            lblName.Visible = false;
            lblAddress.Visible = false;
            lblContactInfo.Visible = false;

            lblEmergencyContactInfo.Visible = false;
            lblLastBeltRank.Visible = false;
            lblIsActive.Visible = false;


            txtName.Visible = false;
            txtAddress.Visible = false;
            txtContactInfo.Visible = false;

            txtEmergencyContactInfo.Visible = false;
            numericLastBeltRank.Visible = false;
            btnClose.Visible = false;
            btnSave.Visible = false;
        }
        private void EnableFormData()
        {

            lblIsFound.Visible = true;
            lblName.Visible = true;
            lblAddress.Visible = true;
            lblContactInfo.Visible = true;

            lblEmergencyContactInfo.Visible = true;
            lblLastBeltRank.Visible = true;
            lblIsActive.Visible = true; 


            txtName.Visible = true;
            txtAddress.Visible = true;
            txtContactInfo.Visible = true;

            txtEmergencyContactInfo.Visible = true;
            numericLastBeltRank.Visible = true;
            rbActive.Visible = true;
            rbNotActive.Visible = true;
            btnClose.Visible = true;
            btnSave.Visible = true;


        }

        private void _LoadData()
        {
            if (string.IsNullOrEmpty(txtPersonID.Text)) return;
           
            _Person = clsPeople.Find(Convert.ToInt32(txtPersonID.Text));


            _Member = clsMember.Find(Convert.ToInt32(txtPersonID.Text));

            if (_Person == null || _Member == null)
            {
                MessageBox.Show("this form will be closed because No Member with ID  = " + txtPersonID.Text);

                this.Close();

                return;

            }

            lblIsFound.Text = "Found";

            lblMode.Text = "Edit Member ID = " + txtPersonID.Text;

            txtName.Text = _Person.Name;
            txtContactInfo.Text = _Person.ContactInfo;
            txtAddress.Text = _Person.Address;
            txtEmergencyContactInfo.Text = _Member.EmergencyContactInfo;
            numericLastBeltRank.Value = _Member.LastBeltRank;
            if (_Member.IsActive == true)
            {
                rbActive.Checked = true;

            }
            else
            {
                rbNotActive.Checked = true;
            }
            EnableFormData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Person.Name = txtName.Text;
            _Person.ContactInfo = txtContactInfo.Text;
            _Person.Address = txtAddress.Text;
            _Member.EmergencyContactInfo = txtEmergencyContactInfo.Text;
            _Member.LastBeltRank = Convert.ToInt32(numericLastBeltRank.Value);
            if (rbActive.Checked == true)
            {
                _Member.IsActive = true;
            }
            else
            {
              _Member.IsActive = false;
            }


            if (_Person.Save())
            {
                _Member.PersonID = _Person.PersonID;

                if (_Member.Save())
                {

                    MessageBox.Show("Member Saved Successfully");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Person failed to Save");
            }
        }

        private void FormUpdateMember_Load(object sender, EventArgs e)
        {
            DisableFormData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
