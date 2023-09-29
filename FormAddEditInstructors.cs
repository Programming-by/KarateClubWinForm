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
    public partial class FormAddEditInstructors : Form
    {

        clsPeople _Person;
        clsInstructor _Instructor;
        int _PersonID;

        public enum enMode { AddNew = 0, Update = 1 };

        enMode _Mode;
        public FormAddEditInstructors(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            if (_PersonID == -1)
            {
                _Mode = enMode.AddNew;
            } else
            {
                _Mode= enMode.Update;
            }


        }

        private void _LoadData()
        {

            if (_Mode == enMode.AddNew)
            {

                lblMode.Text = "Add New Member";
                _Person = new clsPeople();
                _Instructor = new clsInstructor();
                return;
            }

            _Person = clsPeople.Find(_PersonID);

            _Instructor = clsInstructor.Find(_PersonID);

            if (_Person == null || _Instructor == null)
            {
                MessageBox.Show("this form will be closed because No Member with ID  = " + _Instructor.PersonID);

                this.Close();

            }


            lblMode.Text = "Edit Member ID = " + _PersonID;

            txtName.Text = _Person.Name;
            txtContactInfo.Text = _Person.ContactInfo;
            txtAddress.Text = _Person.Address;
            txtQualifications.Text = _Instructor.Qualifications;

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
            _Instructor.Qualifications = txtQualifications.Text;


            if (_Person.Save())
            {
                _Instructor.PersonID = _Person.PersonID;

                if (_Instructor.Save())
                {

                    MessageBox.Show("Instructor Saved Successfully");

                    return;
                }
            } else
            {
                MessageBox.Show("Person failed to Save");
            }
        }

        private void FormAddEditInstructors_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
