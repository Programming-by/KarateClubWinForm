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
    public partial class FormUpdateSubscriptionPeriod : Form
    {

        clsPeople _Person;
        clsMember _Member;
        clsPayment _Payment;
        clsSubscriptionPeriod _SubscriptionPeriod;
        public FormUpdateSubscriptionPeriod()
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
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            lblFees.Visible = false;
            lblAmount.Visible = false;
            lblDate.Visible = false;
            txtName.Visible = false;
            txtAddress.Visible = false;
            txtContactInfo.Visible = false;
            txtEmergencyContactInfo.Visible = false;
            numericLastBeltRank.Visible = false;
            rbActive.Visible = false;
            rbNotActive.Visible = false;
            StartdateTimePicker.Visible = false;
            EnddateTimePicker.Visible = false;
            txtFees.Visible = false;
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
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            lblFees.Visible = true;
            lblAmount.Visible = true;
            lblDate.Visible = true;

            txtName.Visible = true;
            txtAddress.Visible = true;
            txtContactInfo.Visible = true;
            txtEmergencyContactInfo.Visible = true;
            numericLastBeltRank.Visible = true;
            rbActive.Visible = true;
            rbNotActive.Visible = true;
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            lblFees.Visible = true;
            StartdateTimePicker.Visible = true;
            EnddateTimePicker.Visible = true;
            txtFees.Visible = true;
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

            _SubscriptionPeriod = clsSubscriptionPeriod.Find(Convert.ToInt32(txtPersonID.Text));

            if (_Person == null || _Member == null || _SubscriptionPeriod == null)
            {
                MessageBox.Show("this form will be closed because No Subscription Period with ID  = " + txtPersonID.Text);

                this.Close();

                return;

            }


            lblIsFound.Text = "Found";

            lblMode.Text = "Edit SubscriptionPeriod ID = " +  _Member.MemberID;

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

            StartdateTimePicker.Value = _SubscriptionPeriod.StartDate;
            EnddateTimePicker.Value = _SubscriptionPeriod.EndDate;
            txtFees.Text = _SubscriptionPeriod.Fees.ToString();

            clsPayment Payment = clsPayment.Find(_Member.MemberID);

            EnableFormData();
            if (Payment != null)
            {
                txtAmount.Text = Payment.Amount.ToString();
                dateTimePicker1.Value = Payment.Date;

            }
            else
            {
                txtAmount.Text = "";
            }

       


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
            if (rbActive.Checked)
            {
            _Member.IsActive = true;

            } else
            {
                _Member.IsActive= false;
            }
            _SubscriptionPeriod.StartDate = StartdateTimePicker.Value;
            _SubscriptionPeriod.EndDate = EnddateTimePicker.Value;
            _SubscriptionPeriod.Fees = Convert.ToDecimal(txtFees.Text);

            if (decimal.TryParse(txtAmount.Text,out decimal Amount))
            {
                _Payment = clsPayment.Find(_Member.MemberID);

                if (_Payment != null)
                {
                    _Payment.Amount = Amount;
                    _Payment.Date = Convert.ToDateTime(dateTimePicker1.Value);

                    if (_Payment.Save())
                    {
                        MessageBox.Show("Payment Saved Successfully");
                    }
                }
            }
                    if (_Person.Save() && _Member.Save() && _SubscriptionPeriod.Save())
                    {
                        MessageBox.Show("SubscriptionPeriod Saved Successfully");
                    }
        
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void FormUpdateSubscriptionPeriod_Load(object sender, EventArgs e)
        {
            DisableFormData();
        }
    }
}
