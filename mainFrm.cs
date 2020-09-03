using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CW_EZ_Renewals
{
    public partial class mainFrm : Form
    {
        int currentRow = 0;
        sqlconnect controlHandler = new sqlconnect();
        public mainFrm()
        {
            InitializeComponent();
        }

        public void setValues(int currentRow)
        {

            //setting the count.
            int totalCount = controlHandler.localData.Rows.Count;
            int currentCount = currentRow + 1;
            listCountValue.Text = currentCount + "/" + totalCount;

            //setting values to the first row in the table
            try
            {
                string AlarmNo = controlHandler.localData.Rows[currentRow]["AlarmNo"].ToString();
                acctNumberValue.Text = AlarmNo;

                string fullName = controlHandler.localData.Rows[currentRow]["lastName"].ToString() + " " + controlHandler.localData.Rows[currentRow]["firstName"].ToString();
                acctNameValue.Text = fullName;

                string fullAddress = controlHandler.localData.Rows[currentRow]["strNum"].ToString() + " " + controlHandler.localData.Rows[currentRow]["fullStreet"].ToString();
                acctAddressValue.Text = fullAddress;

                string balance = controlHandler.localData.Rows[currentRow]["Outstanding"].ToString();
                outstandingBalanceValue.Text = balance;
                if (balance == "0")
                {
                    outstandingBalanceValue.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    outstandingBalanceValue.ForeColor = System.Drawing.Color.Red;
                }

                string nrFlag = controlHandler.localData.Rows[currentRow]["NoResponseDateSet"].ToString();

                if (nrFlag == "")
                {

                    acctNRFlag.BackColor = System.Drawing.SystemColors.ButtonShadow;
                }
                else
                {
                    acctNRFlag.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There are no accounts with status \"Web-Updated\"\nPress OK to Quit.");
                Environment.Exit(0);
            }
        }

        private void loadAcctsBtn_Click(object sender, EventArgs e)
        {

            // loading data into the data table. 
   
            controlHandler.openConnection();
            controlHandler.loadWebUpAccounts();
            controlHandler.closeConnection();
            setValues(currentRow);
            this.loadAcctsBtn.Hide();
            this.renewActiveBtn.Show();
            this.renewNRNPBtn.Show();

        }


        private void renewActiveBtn_Click(object sender, EventArgs e)
        {
            //renew permit 
            //do things to update permit '

            bool pass = controlHandler.renewActiveStatus(acctNumberValue, currentRow);
            if (pass)
            {
                //load next row
                currentRow++;
                try
                {
                    setValues(currentRow);
                }
                catch (Exception)
                {
                    MessageBox.Show("All Records Completed");
                }
            }
            else
            {
                MessageBox.Show("Failed to update record. Check connection and try again.");
            }
        }

        private void renewNRNPBtn_Click(object sender, EventArgs e)
        {
            //renew permit 
            //do things to update permit '

            bool pass = controlHandler.renewNRNPStatus(acctNumberValue, currentRow);
            if (pass)
            {
                //load next row
                currentRow++;
                try
                {
                    setValues(currentRow);
                }
                catch (Exception)
                {
                    MessageBox.Show("All Records Completed");
                }
            }
            else
            {
                MessageBox.Show("Failed to update record. Check connection and try again.");
            }


        }



    }
   
}
