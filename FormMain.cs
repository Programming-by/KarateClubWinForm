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
        // Belt Test Crud
        // Update , Delete 
        // Delete on Menu Strips


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

            dgvAllData.ContextMenuStrip = contextMenuStrip1;

        }

        private void btnGetAllInstructors_Click(object sender, EventArgs e)
        {
            _LoadInstructorsData();

            dgvAllData.ContextMenuStrip = contextMenuStrip2;


        }

        private void btnGetAllBeltRanks_Click(object sender, EventArgs e)
        {
            _LoadBeltRanksData();
        }

        private void btnGetAllPayments_Click(object sender, EventArgs e)
        {
            _LoadPaymentsData();

            dgvAllData.ContextMenuStrip = contextMenuStrip3;


        }

        private void btnSupscriptionPeriods_Click(object sender, EventArgs e)
        {
            _LoadSubscriptionPeriodssData();

            dgvAllData.ContextMenuStrip = contextMenuStrip4;

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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEditMembers frm = new FormAddEditMembers((int) dgvAllData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _LoadMembersData();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddEditInstructors frm = new FormAddEditInstructors((int)dgvAllData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _LoadInstructorsData();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormAddEditPayments frm = new FormAddEditPayments((int)dgvAllData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _LoadPaymentsData();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FormAddEditSubscriptionPeriods frm = new FormAddEditSubscriptionPeriods((int)dgvAllData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _LoadSubscriptionPeriodssData();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }
    }
}
