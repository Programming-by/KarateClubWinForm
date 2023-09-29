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
    public partial class FormAddEditSubscriptionPeriods : Form
    {
        clsPeople _Person;
        clsMember _Member;
        clsPayment _Payment;
        clsSubscriptionPeriod _SubscriptionPeriod;

        int _PersonID;

        public enum enMode { AddNew = 0, Update = 1 };

        enMode _Mode;
        public FormAddEditSubscriptionPeriods(int PersonID)
        {

            _PersonID = PersonID;


            if (PersonID == -1 )
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

                lblMode.Text = "Add New Period";
                _Person = new clsPeople();
                _Member = new clsMember();
                _SubscriptionPeriod = new clsSubscriptionPeriod();
                
                return;
            }

            _Person = clsPeople.Find(_PersonID);

            _Member = clsMember.Find(_PersonID);

            if (_Person == null || _Member == null)
            {
                MessageBox.Show("this form will be closed because No Member with ID  = " + _Member.PersonID);

                this.Close();
            }

            _SubscriptionPeriod = clsSubscriptionPeriod.Find(_PersonID);
        
            if (_SubscriptionPeriod == null)
            {
                MessageBox.Show("there is no Subscription Period Found");
                return;
            }

            lblMode.Text = "Edit SubscriptionPeriod ID = " + _PersonID;

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
            _Payment = clsPayment.Find(_Member.MemberID);
            if (_Payment != null)
            {
            txtAmount.Text = _Payment.Amount.ToString();
            dateTimePicker.Value = _Payment.Date;
            } else
            {
                MessageBox.Show("there is no Payment Found");
                return;
            }
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
            _Member.IsActive =  true;

            }
            else
            {
                _Member.IsActive = false;
            }

            _SubscriptionPeriod.StartDate = StartdateTimePicker.Value;
            _SubscriptionPeriod.EndDate = EnddateTimePicker.Value;
            _SubscriptionPeriod.Fees = Convert.ToDecimal(txtFees.Text);



            if (_Person.Save())
            {
                _Member.PersonID = _Person.PersonID;

                if (_Member.Save())
                {

                    _FillPaymentDataIfExist();
            
                    _SubscriptionPeriod.MemberID =_Member.MemberID;

                    if (_SubscriptionPeriod.Save())
                    {

                        MessageBox.Show("SubscriptionPeriod Saved Successfully");

                    }
                    else
                    {
                        MessageBox.Show("SubscriptionPeriod failed to Save");
                    }
                }
             

            } else
            {
                MessageBox.Show("Person doesn't save");

            }

        }

        private void _FillPaymentDataIfExist()
        {
            if (decimal.TryParse(txtAmount.Text, out decimal Amount))
            {
                if (_Payment == null)
                {
                    _Payment = new clsPayment();
                }
                _Payment.Amount = Amount;
                _Payment.Date = dateTimePicker.Value;
                _Payment.MemberID = _Member.MemberID;

                if (_Payment.Save())
                {
                    _SubscriptionPeriod.PaymentID = _Payment.PaymentID;
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddEditSubscriptionPeriods_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

     
    }
}
