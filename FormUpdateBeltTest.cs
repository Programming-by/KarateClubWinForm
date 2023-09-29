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
    public partial class FormUpdateBeltTest : Form
    {
        clsPeople _Person;
        clsMember _Member;
        clsInstructor _Instructor;
        clsBeltTest _BeltTest;
        clsPayment _Payment;
        public FormUpdateBeltTest()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ChangeVisibility(bool Visibility)
        {
           
            lblName.Visible = Visibility;
            lblContactInfo.Visible = Visibility;
            lblAddress.Visible = Visibility;
            lblEmergencyContactInfo.Visible = Visibility;
            lblLastBeltRank.Visible = Visibility;
            lblIsActive.Visible = Visibility;
            lblQualifications.Visible = Visibility;
            lblAmount.Visible = Visibility;
            lblDate.Visible = Visibility;
            lblBeltRank.Visible = Visibility;
            lblResult.Visible = Visibility;
            lblBeltTestDate.Visible = Visibility;

            txtName.Visible = Visibility;
            txtContactInfo.Visible = Visibility;
            txtAddress.Visible = Visibility;
            txtEmergencyContactInfo.Visible = Visibility;
            numericLastBeltRank.Visible = Visibility;
            rbActive.Visible = Visibility;
            rbNotActive.Visible = Visibility;
            txtQualifications.Visible = Visibility;
            txtAmount.Visible = Visibility; 
            dateTimePicker.Visible  = Visibility;
            numericBeltRank.Visible  = Visibility;
            rbResult.Visible = Visibility;
            rbNoResult.Visible = Visibility;
            BeltTestdateTimePicker.Visible = Visibility;

            btnClose.Visible = Visibility;  
            btnSave.Visible = Visibility;

        }


        private void _LoadData()
        {
            _Person = clsPeople.Find(Convert.ToInt32(txtPersonID.Text));
            _Member = clsMember.Find(Convert.ToInt32(txtPersonID.Text));
          //  _Instructor = clsInstructor.Find(Convert.ToInt32(txtPersonID.Text));
            _BeltTest = clsBeltTest.Find(Convert.ToInt32(txtPersonID.Text));
            if (_Person == null || _Member == null)
            {
                MessageBox.Show("this form will be closed because No Person  with ID  = " + txtPersonID.Text);
                ChangeVisibility(false);
                this.Close();

                return;
            }

            if ( _BeltTest == null)
            {
                MessageBox.Show("this form will be closed because No Belt Test with ID  = " + txtPersonID.Text);

                ChangeVisibility(false);
                this.Close();

                return;
            }

            lblIsFound.Text = "Found";

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

           // txtQualifications.Text = _Instructor.Qualifications;

            numericBeltRank.Value = _BeltTest.RankID;

            if (_BeltTest.Result == true)
            {
                rbResult.Checked = true;
            }
            else
            {
                rbNoResult.Checked = true;
            }

            BeltTestdateTimePicker.Value = _BeltTest.Date ;



            _Payment = clsPayment.Find(_Member.MemberID);

            if (_Payment != null)
            {
                txtAmount.Text = _Payment.Amount.ToString();

                dateTimePicker.Value = _Payment.Date;
            }
            else
            {
                return;
            }
            ChangeVisibility(true);
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

            }
            else
            {
                _Member.IsActive = false;
            }

            // _Instructor.Qualifications = txtQualifications.Text;

            _BeltTest.RankID = Convert.ToInt32(numericBeltRank.Value);

            if (rbResult.Checked)
            {
                _BeltTest.Result = true;
            }
            else
            {
                _BeltTest.Result = false;
            }


            _BeltTest.Date = BeltTestdateTimePicker.Value;

            if (decimal.TryParse(txtAmount.Text, out decimal Amount)) { 

                if (_Payment != null)
                {

                    _Payment.Amount = Amount;

                    _Payment.Date = dateTimePicker.Value;
                    if (_Payment.Save())
                    {
                        _BeltTest.PaymentID = _Payment.PaymentID;
                    }

                }
        }

            if (_Person.Save())
            {
                _Member.PersonID = _Person.PersonID;
                //_Instructor.PersonID = _Person.PersonID;

                if (_Member.Save())
                {
                    _Payment.MemberID = _Member.MemberID;

                    _BeltTest.MemberID = _Member.MemberID;
                   // _BeltTest.TestedByInstructorID = _Instructor.InstructorID;
                    if (_BeltTest.Save())
                    {
                        MessageBox.Show("Belt Test saved Successfully");
                    }
                
                }
            }



        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
