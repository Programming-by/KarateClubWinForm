using KarateDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        
        
        // Belt Test Create Read Update Delete
        // Check if you can make user control to shorten forms

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

        private void _LoadBeltTestsData()
        {
            dgvAllData.DataSource = clsBeltTest.GetAllBeltTests();
        }

        private void btnGetAllMembers_Click(object sender, EventArgs e)
        {
            _LoadMembersData();

            dgvAllData.ContextMenuStrip = contextMenuStripForMembers;

        }

        private void btnGetAllInstructors_Click(object sender, EventArgs e)
        {
            _LoadInstructorsData();

            dgvAllData.ContextMenuStrip = contextMenuStripForInstructors;


        }

        private void btnGetAllBeltRanks_Click(object sender, EventArgs e)
        {
            _LoadBeltRanksData();
        }

        private void btnGetAllPayments_Click(object sender, EventArgs e)
        {
            _LoadPaymentsData();

            dgvAllData.ContextMenuStrip = contextMenuStripForPayments;


        }

        private void btnGetAllSupscriptionPeriods_Click(object sender, EventArgs e)
        {
            _LoadSubscriptionPeriodssData();

            dgvAllData.ContextMenuStrip = contextMenuStripForSubscriptionPeriods;
        }
      
        private void btnGetAllBeltTests_Click(object sender, EventArgs e)
        {
            _LoadBeltTestsData();

          //  dgvAllData.ContextMenuStrip = contextMenuStrip5;
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

        private void btnFindBeltRank_Click(object sender, EventArgs e)
        {
            FormFindBeltRank frm = new FormFindBeltRank();

            frm.ShowDialog();
        }

        private void btnFindPayments_Click(object sender, EventArgs e)
        {
            FormFindPayment frm = new FormFindPayment();

            frm.ShowDialog();

        }

        private void btnSubscriptionPeriod_Click(object sender, EventArgs e)
        {
            FormFindSubscriptionPeriod frm = new FormFindSubscriptionPeriod();

            frm.ShowDialog();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
           FormAddEditMembers frm  = new FormAddEditMembers(-1);


            frm.ShowDialog();

            _LoadMembersData();

        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            FormAddEditInstructors frm = new FormAddEditInstructors(-1);

            frm.ShowDialog();

            _LoadInstructorsData();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            FormAddEditPayments frm = new FormAddEditPayments(-1);

            frm.ShowDialog();

            _LoadPaymentsData();
        }

        private void btnAddSubscriptionPeriod_Click(object sender, EventArgs e)
        {
            FormAddEditSubscriptionPeriods frm = new FormAddEditSubscriptionPeriods(-1);

            frm.ShowDialog();

            _LoadSubscriptionPeriodssData();
        }

        private void editToolStripMenuItemForMembers_Click(object sender, EventArgs e)
        {
            FormAddEditMembers frm = new FormAddEditMembers((int)dgvAllData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _LoadMembersData();
        }

        private void toolStripMenuItemForInstructors_Click(object sender, EventArgs e)
        {
            FormAddEditInstructors frm = new FormAddEditInstructors((int)dgvAllData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _LoadInstructorsData();
        }

        private void toolStripMenuItemForPayments_Click(object sender, EventArgs e)
        {
                FormAddEditPayments frm = new FormAddEditPayments((int)dgvAllData.CurrentRow.Cells[0].Value);

                frm.ShowDialog();

                _LoadPaymentsData();
        }

        private void toolStripMenuItemForSubscriptionPeriods_Click(object sender, EventArgs e)
        {
            FormAddEditSubscriptionPeriods frm = new FormAddEditSubscriptionPeriods((int)dgvAllData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _LoadSubscriptionPeriodssData();

        }
        private void deleteToolStripMenuItemForMembers_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Member [" + dgvAllData.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteStripMenuItemForPayments_Click(sender, e);
                deleteStripMenuItemForSubscriptionPeriods_Click(sender, e);
                if (clsMember.Delete((int)dgvAllData.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Member Deleted Successfully.");
                    _LoadMembersData();

                }
            }
        }

        private void deleteStripMenuItemForInstructors_Click(object sender, EventArgs e)
        {

                if (MessageBox.Show("Are you sure you want to delete Instructor [" + dgvAllData.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (clsInstructor.Delete((int)dgvAllData.CurrentRow.Cells[0].Value))
                    {
                        if (clsPeople.Delete((int)dgvAllData.CurrentRow.Cells[0].Value))
                        {
                            MessageBox.Show("Instructor Deleted Successfully.");
                            _LoadInstructorsData();
                        }
                    }
                }
    }
     
        private void deleteStripMenuItemForPayments_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Payment [" + dgvAllData.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteStripMenuItemForSubscriptionPeriods_Click(sender, e);

                if (clsPayment.Delete((int)dgvAllData.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Payment Deleted Successfully.");
                    _LoadPaymentsData();

                }

            }
        }

        private void deleteStripMenuItemForSubscriptionPeriods_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Subscription Period [" + dgvAllData.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsSubscriptionPeriod.Delete((int)dgvAllData.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Subscription Period Deleted Successfully.");
                    _LoadSubscriptionPeriodssData();

                }
            }
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            FormUpdateMember frm = new FormUpdateMember();

            frm.ShowDialog();
        }

        private void btnUpdateInstructor_Click(object sender, EventArgs e)
        {
             FormUpdateInstructor frm = new FormUpdateInstructor();

            frm.ShowDialog();
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            FormUpdatePayment frm = new FormUpdatePayment();

            frm.ShowDialog();   
        }

        private void btnUpdateSubscriptionPeriod_Click(object sender, EventArgs e)
        {
            FormUpdateSubscriptionPeriod frm = new FormUpdateSubscriptionPeriod();

            frm.ShowDialog();

        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {

            FormDeleteMember frm = new FormDeleteMember();

            frm.ShowDialog();

        }

        private void btnDeleteInstructor_Click(object sender, EventArgs e)
        {
            FormDeleteInstructors frm = new FormDeleteInstructors();

            frm.ShowDialog();

            _LoadInstructorsData();

        }

        private void btnDeleteSubscriptionPeriod_Click(object sender, EventArgs e)
        {

            FormDeleteSubscriptionPeriod frm = new FormDeleteSubscriptionPeriod();
            frm.ShowDialog();
            _LoadSubscriptionPeriodssData();
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            FormDeletePayment frm = new FormDeletePayment();

            frm.ShowDialog();
        }

    }
}
