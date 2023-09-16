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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


        }



        private void _LoadMembersData()
        {
            dgvAllData.DataSource = clsMember.GetAllMembers();
        }

        private void _LoadInstructorsData()
        {
            dgvAllData.DataSource = clsInstructor.GetAllInstructors();
        }

        private void _LoadPaymentsData()
        {
            dgvAllData.DataSource = clsPayment.GetAllPayments();
        }

        private void _LoadSubscriptionPeriodssData()
        {
            dgvAllData.DataSource = clsSubscriptionPeriod.GetAllSubscriptionPeriods(); 
        }

        private void _LoadBeltRanksData()
        {
            dgvAllData.DataSource = clsBeltRank.GetAllBeltRanks();
        }

        private void btnGetAllMembers_Click(object sender, EventArgs e)
        {
            _LoadMembersData();
        }

        private void btnGetAllInstructors_Click(object sender, EventArgs e)
        {
            _LoadInstructorsData();
        }

        private void btnGetAllBeltRanks_Click(object sender, EventArgs e)
        {
            _LoadBeltRanksData();
        }

        private void btnGetAllPayments_Click(object sender, EventArgs e)
        {
            _LoadPaymentsData();

        }

        private void btnSupscriptionPeriods_Click(object sender, EventArgs e)
        {
            _LoadSubscriptionPeriodssData();
        }


        private void btnFindMember_Click(object sender, EventArgs e)
        {
            FormFindMember frm = new FormFindMember();

            frm.ShowDialog();


        }

        private void btnFindInstructor_Click(object sender, EventArgs e)
        {
            FormFindInstructor frm = new FormFindInstructor();

            frm.ShowDialog();

        }





        /*
        Name
        Address
        ContactInfo

        EmergencyContactInfo
        LastBeltRank
        IsActive

        Qualifications

        StartDate
        EndDate
        Fees

        Amount
        Date

        RankName
        TestFees

        Result
        Date
        */

    }
}
