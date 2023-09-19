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
    public partial class FormAddEditBeltTest : Form
    {

        public enum enMode { AddNew = 0 , Update = 1};

        enMode _Mode;

        clsPeople _Person;
        clsMember _Member;
        clsInstructor _Instructor;
        clsBeltTest _BeltTest;
        clsPayment _Payment;

        int _MemberID;
        public FormAddEditBeltTest(int MemberID)
        {

            _MemberID = MemberID;

            if (_MemberID == -1) 
            {
                _Mode = enMode.AddNew;

            } else
            {
                _Mode = enMode.Update;
            }


            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _LoadData()
        {

            if (_Mode == enMode.AddNew)
            {

                lblMode.Text = "Add New Belt Test";
                _Person = new clsPeople();
                _Member = new clsMember();
                _Instructor = new clsInstructor();
                _Payment = new clsPayment();
                _BeltTest = new clsBeltTest();
                return;
            }


            //_BeltTest = clsBeltTest.Find();


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
               
            } else
            {
                _Member.IsActive= false;
            }

            _Instructor.Qualifications = txtQualifications.Text;

            _Payment.Amount = 20;
            _Payment.Date = dateTimePicker.Value;

            _BeltTest.RankID = 5;

            if (rbResult.Checked)
            {
                _BeltTest.Result = true;
            }
            else
            {
                _BeltTest.Result = false;
            }


            _BeltTest.Date = BeltTestdateTimePicker.Value;


            if (_Person.Save())
            {
                _Member.PersonID = _Person.PersonID;
                _Instructor.PersonID = _Person.PersonID;

                if (_Member.Save() && _Instructor.Save())
                {
                    _Payment.MemberID = _Member.MemberID;

                    if (_Payment.Save())
                    {
                        _BeltTest.PaymentID = _Payment.PaymentID;
                    }
                    _BeltTest.MemberID = _Member.MemberID;
                    _BeltTest.TestedByInstructorID = _Instructor.InstructorID;
                   // _BeltTest.TestedByInstructorID = Convert.ToInt32(null);

                    if (_BeltTest.Save())
                    {
                        MessageBox.Show("Belt Test Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Belt Test Failed to be Added");

                    }
                }
            }




        }


        private void FormAddEditBeltTest_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
