using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace CW_EZ_Renewals
{
    public class sqlconnect
    {
        // class var & obj 
        public DataTable localData = new DataTable();
        private string connectionString = "REMOVED FOR GITHUB. CONNECTION STRING HERE.";
        OleDbConnection connection;
        OleDbCommand command;


        // open connection to the server
        public void openConnection()
        {
            try
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                command = new OleDbCommand("", connection);
              //  MessageBox.Show("Connection succesful");

            }
            catch (Exception)
            {
                MessageBox.Show("Cannot open connection.");
            }
        }
       
        //close connection to the server 
        public void closeConnection()
        {
            try
            {
                connection.Close();
                connection.Dispose();

            }
            catch (Exception)
            {
                MessageBox.Show("Cannot close connection.");
            }
        }

        // load data from server and place in data table ONLY LOADS 1K AT A TIME TO SAVE MEMORY 
        internal void loadWebUpAccounts()
        {
            command = new OleDbCommand("select top (1000) AlarmNo, lastName, firstName, strNum, FullStreet, currentStatus, NoResponseDateSet, Notes from ALARM_LICENSES where currentStatus = 'Web-Updated' ", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(localData);
            da.Dispose();

            localData.Columns.Add("Outstanding", typeof(string));

            for (int j = 0; j < localData.Rows.Count; j++)
            {
                string alarmNo = localData.Rows[j]["AlarmNo"].ToString();
                Console.WriteLine(alarmNo);
                command = new OleDbCommand("SELECT SUM(Charge - ((payment - refund) + adjudication)) As tOwed FROM ALARM_ACTIONS WHERE LicType = 'AR' AND AlarmNo = '" + alarmNo + "'", connection);
                OleDbDataReader da2 = command.ExecuteReader();
                while (da2.Read())
                {
                    Console.WriteLine(da2[0].ToString());
                    string outstandingBalance = da2[0].ToString();
                    localData.Rows[j]["Outstanding"] = outstandingBalance;

                }
            }


            for (int j = 0; j < localData.Rows.Count; j++)
            {
                for (int i = 0; i < localData.Columns.Count; i++)
                {
                    Console.Write(localData.Columns[i].ColumnName + " ");
                    Console.WriteLine(localData.Rows[j].ItemArray[i]);
                }


            }
        }

        public bool renewActiveStatus(Label acctNumberValue, int currentRow)
        {
            string AlarmNo = acctNumberValue.Text;
            Console.WriteLine("\n\n",AlarmNo);

            string notes = localData.Rows[currentRow]["Notes"].ToString();
            Console.WriteLine(notes);
            try
            {
                notes.Remove(120);
            }
            catch (Exception)
            {
            }
            Console.WriteLine(notes);
            notes.Trim('}');
            notes = "[" + DateTime.Now.ToString() + " EZ RENEW] RENEWED PERMIT VIA WEB UPDATE\\par" + notes;
            notes = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft Sans Serif;}}\\viewkind4\\uc1\\pard\\f0\\fs20" + notes;
            Console.WriteLine(notes);


            try
            {
                openConnection();
               
                // UPDATE THE PERMIT

                command = new OleDbCommand("UPDATE ALARM_LICENSES SET dateIssued = GETDATE(), dateExpires = '2020-12-31 00:00:00.000', updatedBy = 'EZ RENEW', NoResponseDateSet = NULL, currentStatus = 'Active', Notes = '" + notes + "'  WHERE AlarmNo = '" + AlarmNo + "';", connection);
                int pass = command.ExecuteNonQuery();
               
                // UDATE THE TRAIL AUDIT
                command = new OleDbCommand("INSERT INTO ALARM_TRAIL_AUDIT (Agency, InvoiceNo, AlarmNo, LicType, RecordType, DateCreated, TimeCreated, CreatedBy, Notes)" +
                                          " VALUES ('<Default>', 0, '" + AlarmNo + "', 'AR', 'Main Table', '" + DateTime.Now.ToString() + "', '" + string.Format("{0:hh:mm:ss tt}", DateTime.Now) + "', 'EZ RENEW', 'currentStatus: Web-Updated -> Active \ndateExpires: 12/31/2019 -> 12/31/2020 \nupdatedBy: EZ RENEW') ", connection);
                command.ExecuteNonQuery();

                //add active letter to outstanding letters
                command = new OleDbCommand("INSERT INTO ALARM_ACTIONS (Agency, AlarmNo, LicType, letterType, CaseNo, Charge, Payment, Refund, Adjudication, feeInvolved, isOutstanding, needsLetter, actionDate, dateLetterSent, letterSent, MonitoredBy, RelatedAlarmNo, RelatedInvoiceNo, RelatedCaseNo, ItemizedStatement, Comments, Invoices, created, updated, createdby, updatedby, IncidentDate, ignoreAlarm, validAlarm, alarmCount, LinkedInvoiceNo, HearingNo, HasInvoices, inAbeyance, CurrentStatus, PaymentRecNo, exempt, adjudicationgranted, LastDelinquentDays) VALUES ('<Default>', '" + AlarmNo + "', 'AR', 'Active', '', 0, 0, 0, 0, 0, 0, -1, GETDATE(), NULL, 0, '','',0, '','','','', GETDATE(), GETDATE(), 'EZ RENEW', 'EZ RENEW', NULL, 0,0,0,0,0,0,0,'Active',0,0,0,0)", connection);
                Console.WriteLine(command.CommandText.ToString());
                command.ExecuteNonQuery();
                closeConnection();

                if (pass > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error processing this renewal. Review manually.");
                return true;
            }
        }

        public bool renewNRNPStatus(Label acctNumberValue, int currentRow)
        {
            string AlarmNo = acctNumberValue.Text;
            Console.WriteLine("\n\n", AlarmNo);
            string notes = localData.Rows[currentRow]["Notes"].ToString();
            Console.WriteLine(notes);
            notes.Remove(120);
            Console.WriteLine(notes);
            notes.Trim('}');
            notes = "[" + DateTime.Now.ToString() + " EZ RENEW] RENEWED PERMIT VIA WEB UPDATE\\par" + notes;
            notes = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft Sans Serif;}}\\viewkind4\\uc1\\pard\\f0\\fs20" + notes;
            Console.WriteLine(notes);
  
            try
            {
                openConnection();
                command = new OleDbCommand("UPDATE ALARM_LICENSES SET dateIssued = GETDATE(), dateExpires = '2020-12-31 00:00:00.000', updatedBy = 'EZ RENEW', currentStatus = 'No Response NP', Notes = '" + notes + "'  WHERE AlarmNo = '" + AlarmNo + "';", connection);
                int pass = command.ExecuteNonQuery();
                command = new OleDbCommand("INSERT INTO ALARM_TRAIL_AUDIT (Agency, InvoiceNo, AlarmNo, LicType, RecordType, DateCreated, TimeCreated, CreatedBy, Notes)" +
                                          " VALUES ('<Default>', 0, '" + AlarmNo + "', 'AR', 'Main Table', '" + DateTime.Now.ToString() + "', '" + string.Format("{0:hh:mm:ss tt}", DateTime.Now) + "', 'EZ RENEW', 'currentStatus: Web-Updated -> No Response NP \ndateExpires: 12/31/2019 -> 12/31/2020 \nupdatedBy: EZ RENEW') ", connection);
                command.ExecuteNonQuery();



                command = new OleDbCommand("INSERT INTO ALARM_ACTIONS (Agency, AlarmNo, LicType, letterType, CaseNo, Charge, Payment, Refund, Adjudication, feeInvolved, isOutstanding, needsLetter, actionDate, dateLetterSent, letterSent, MonitoredBy, RelatedAlarmNo, RelatedInvoiceNo, RelatedCaseNo, ItemizedStatement, Comments, Invoices, created, updated, createdby, updatedby, IncidentDate, ignoreAlarm, validAlarm, alarmCount, LinkedInvoiceNo, HearingNo, HasInvoices, inAbeyance, CurrentStatus, PaymentRecNo, exempt, adjudicationgranted, LastDelinquentDays) VALUES ('<Default>', '" + AlarmNo + "', 'AR', 'New Invoice', '', 0, 0, 0, 0, 0, 0, -1, GETDATE(), NULL, 0, '','',0, '','','','', GETDATE(), GETDATE(), 'EZ RENEW', 'EZ RENEW', NULL, 0,0,0,0,0,0,0,'No Response NP',0,0,0,0)", connection);
                Console.WriteLine(command.CommandText.ToString());
                command.ExecuteNonQuery();






                closeConnection();
                if (pass > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error processing this renewal. Review manually.");
                return true;
            }


        }


    }
}
