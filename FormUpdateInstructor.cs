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
    public partial class FormUpdateInstructor : Form
    {

        clsPeople _Person;
        clsInstructor _Instructor;
        public FormUpdateInstructor()
        {
            InitializeComponent();
        }

        private void DisableFormData()
        {
            lblIsFound.Visible = false;

            lblName.Visible = false;
            lblAddress.Visible = false;
            lblContactInfo.Visible = false;

            lblQualifications.Visible = false;


            txtName.Visible = false;
            txtAddress.Visible = false;
            txtContactInfo.Visible = false;

            txtQualifications.Visible = false;
            btnClose.Visible = false;
            btnSave.Visible = false;
        }
        private void EnableFormData()
        {

            lblIsFound.Visible = true;
            lblName.Visible = true;
            lblAddress.Visible = true;
            lblContactInfo.Visible = true;

            lblQualifications.Visible = false;



            txtName.Visible = true;
            txtAddress.Visible = true;
            txtContactInfo.Visible = true;

            txtQualifications.Visible = true;
            btnClose.Visible = true;
            btnSave.Visible = true;


        }

        private void _LoadData()
        {
            if (string.IsNullOrEmpty(txtPersonID.Text)) return;

            _Person = clsPeople.Find(Convert.ToInt32(txtPersonID.Text));

            _Instructor = clsInstructor.Find(Convert.ToInt32(txtPersonID.Text));

            if (_Person == null || _Instructor == null)
            {
                MessageBox.Show("this form will be closed because No Instructor with ID  = " + txtPersonID.Text);

                this.Close();

                return;

            }

            lblIsFound.Text = "Found";

            lblMode.Text = "Edit Instructor ID = " + Convert.ToInt32(txtPersonID.Text);

            txtName.Text = _Person.Name;
            txtContactInfo.Text = _Person.ContactInfo;
            txtAddress.Text = _Person.Address;
            txtQualifications.Text = _Instructor.Qualifications;

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
            _Instructor.Qualifications = txtQualifications.Text;


            if (_Person.Save())
            {
                _Instructor.PersonID = _Person.PersonID;

                if (_Instructor.Save())
                {

                    MessageBox.Show("Instructor Saved Successfully");


                    return;
                }
                else
                {
                    MessageBox.Show("Instructor failed to Save");

                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void FormUpdateInstructor_Load(object sender, EventArgs e)
        {
            DisableFormData();
        }
    }
}
