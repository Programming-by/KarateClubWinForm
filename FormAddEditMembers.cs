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
    public partial class FormAddEditMembers : Form
    {

        clsPeople _Person;
        clsMember _Member;
        int _PersonID;

        public enum enMode { AddNew = 0 , Update = 1};

        enMode _Mode;
        public FormAddEditMembers(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            if (_PersonID == -1)
            {
                _Mode = enMode.AddNew;

            } else
            {
                _Mode = enMode.Update;
            }

        }


        private void _LoadData()
        {

            if (_Mode == enMode.AddNew)
            {

                lblMode.Text = "Add New Member";
                _Person = new clsPeople();
                _Member = new clsMember();
                return;
            }

            _Person =  clsPeople.Find(_PersonID);

            _Member =  clsMember.Find(_PersonID);

            if (_Person == null || _Member == null)
            {
                MessageBox.Show("this form will be closed because No Member with ID  = " + _Member.PersonID);

                this.Close();

            }


            lblMode.Text = "Edit Member ID = " + _PersonID; 

            txtName.Text = _Person.Name;
            txtContactInfo.Text = _Person.ContactInfo;
            txtAddress.Text = _Person.Address;
            txtEmergencyContactInfo.Text = _Member.EmergencyContactInfo;
            numericLastBeltRank.Value = _Member.LastBeltRank;

            if (_Member.IsActive == true)
            {
                rbActive.Checked = true;

            } else
            {
                rbNotActive.Checked = true;
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
            _Member.IsActive = true;

            
                if (_Person.Save())
                {
                    _Member.PersonID = _Person.PersonID;

                    if (_Member.Save())
                    {

                        MessageBox.Show("Member Saved Successfully");

                        return;
                    }
                    else
                    {
                        MessageBox.Show("Member failed to Save");

                    }

                }

            }

        private void FormAddEditMembers_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
