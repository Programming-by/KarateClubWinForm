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
    public partial class FormAddEditPayments : Form
    {
        public enum enMode {AddNew = 0, Update = 1 };

        enMode _Mode = enMode.AddNew;

        clsPeople _Person;
        clsMember _Member;
        clsPayment _Payment;

        int _PersonID;
        public FormAddEditPayments(int PersonID)
        {
            _PersonID = PersonID;

            if (PersonID == -1)
            {
              _Mode = enMode.AddNew;
            } else
            {
                _Mode = enMode.Update;
            }


            InitializeComponent();
        }

        private void _LoadData()
        {

            if (_Mode == enMode.AddNew)
            {

                lblMode.Text = "Add New Payment";
                _Person = new clsPeople();
                _Member = new clsMember();
                _Payment = new clsPayment();
                return;
            }

            _Person = clsPeople.Find(_PersonID);

            _Member = clsMember.Find(_PersonID);

            if (_Person == null || _Member == null)
            {
                MessageBox.Show("this form will be closed because No Member with ID  = " + _Member.PersonID);

                this.Close();

            }

            _Payment = clsPayment.Find(_Member.MemberID);

            if (_Payment == null)
            {

                MessageBox.Show("this ID [" + _Member.MemberID + "] is not Found");
                return;

            }

            lblMode.Text = "Edit Payment ID = " + _PersonID;

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
            dateTimePicker.Value = _Payment.Date;

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
            _Payment.Date = dateTimePicker.Value;

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

                    return;
                }
                else
                {
                    MessageBox.Show("Payment failed to Save");

                }

            }
        }

        private void FormAddEditPayments_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
