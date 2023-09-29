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
using System.Xml.Linq;

namespace KaratePresentationLayer
{
    public partial class FormUpdatePayment : Form
    {

        clsPeople _Person;
        clsMember _Member;
        clsPayment _Payment;
        public FormUpdatePayment()
        {
            InitializeComponent();
        }

        private void DisableFormData()
        {
            lblIsFound.Visible = false;

            lblName.Visible = false;
            lblAddress.Visible = false;
            lblContactInfo.Visible = false;
            lblEmergencyContactInfo.Visible = false;
            lblLastBeltRank.Visible = false;
            lblIsActive.Visible = false;
            lblAmount.Visible = false;
            lblDate.Visible = false;

            txtName.Visible = false;
            txtAddress.Visible = false;
            txtContactInfo.Visible = false;
            txtEmergencyContactInfo.Visible = false;
            numericLastBeltRank.Visible = false;
            rbActive.Visible = false;
            rbNotActive.Visible = false;
            txtAmount.Visible = false;
            dateTimePicker1.Visible = false;
            
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
            lblAmount.Visible = true;
            lblDate.Visible = true;

            txtName.Visible = true;
            txtAddress.Visible = true;
            txtContactInfo.Visible = true;
            txtEmergencyContactInfo.Visible = false;
            numericLastBeltRank.Visible = false;
            rbActive.Visible = true;
            rbNotActive.Visible = true;
            txtAmount.Visible = true;
            dateTimePicker1.Visible = true;
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
                MessageBox.Show("this form will be closed because No Instructor with ID  = " + txtPersonID.Text);

                this.Close();

                return;

            }

             _Payment = clsPayment.Find(_Member.MemberID);

            if (_Payment == null)
            {
                MessageBox.Show("this form will be closed because No Payment with ID  = " + txtPersonID.Text);

                this.Close();

                return;

            }


            lblIsFound.Text = "Found";

            lblMode.Text = "Edit Payment ID = " + _Member.MemberID;

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

            txtAmount.Text = _Payment.Amount.ToString();
            dateTimePicker1.Value = _Payment.Date;
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
            _Member.IsActive = true;
            _Payment.Amount = Convert.ToDecimal(txtAmount.Text);
            _Payment.Date = Convert.ToDateTime(dateTimePicker1.Value);


            if (_Person.Save())
            {
                _Member.PersonID = _Person.PersonID;

                if (_Member.Save())
                {
                    _Payment.MemberID = _Member.MemberID;

                    if (_Payment.Save())
                    {

                    MessageBox.Show("Payment Saved Successfully");

                    } 
                }

            } else
             {
                MessageBox.Show("Person failed to Save");
             }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void FormUpdatePayment_Load(object sender, EventArgs e)
        {
            DisableFormData();
        }
    }
}
