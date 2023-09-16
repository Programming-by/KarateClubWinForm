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
    public partial class FormFindBeltRank : Form
    {
        public FormFindBeltRank()
        {
            InitializeComponent();
        }

        private void ChangeVisibility(bool Visibility)
        {

            lblRankName.Visible = Visibility;
            lblTestFees.Visible = Visibility;

            lblRankNameText.Visible = Visibility;
            lblTestFeesText.Visible = Visibility;


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            clsBeltRank BeltRank = clsBeltRank.Find(Convert.ToInt32(txtID.Text));


            if ( BeltRank == null)
            {

                MessageBox.Show("this ID [" + txtID.Text + "] is not Found");
                ChangeVisibility(false);
                return;

            }
            else
            {

                lblRankNameText.Text = BeltRank.RankName;
                lblTestFeesText.Text = BeltRank.TestFees.ToString();

                ChangeVisibility(true);

            }


        }

    }
}
