using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using outlook = Microsoft.Office.Interop.Outlook;

namespace smtp_client_send_and_receive_email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SENDbutton_Click(object sender, EventArgs e)
        {
            try
            {
                outlook._Application _app = new outlook.Application();
                outlook.MailItem mail = (outlook.MailItem)_app.CreateItem(outlook.OlItemType.olMailItem);
                mail.To = TOtextBox.Text;
                mail.Subject = SUBJECTtextBox.Text;
                mail.Body = MESSAGEtextBox.Text;
                mail.Importance = outlook.OlImportance.olImportanceNormal;
                ((outlook._MailItem)mail).Send();
                MessageBox.Show("you message has been send successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DataTable dt;
        private void RECEIVEbutton_Click(object sender, EventArgs e)
        {
            try
            {
                outlook._Application _app = new outlook.Application();
                outlook._NameSpace _ns = _app.GetNamespace("MAPI");
                outlook.MAPIFolder inbox = _ns.GetDefaultFolder(outlook.OlDefaultFolders.olFolderInbox);
                _ns.SendAndReceive(true);
                dt = new DataTable("inbox");
                dt.Columns.Add("Subject", typeof(string));
                dt.Columns.Add("Sender", typeof(string));
                dt.Columns.Add("Body", typeof(string));
                dt.Columns.Add("Date", typeof(string));

                dataGrid.DataSource = dt;
                foreach (outlook.MailItem item in inbox.Items)
                {
                    dt.Rows.Add(new object[] { item.Subject, item.SenderName, item.HTMLBody, item.SentOn.ToLongDateString() + "" + item.SentOn.ToLongTimeString() });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<dt.Rows.Count&&e.RowIndex>=0) 
            {
                webBrowser.DocumentText = dt.Rows[e.RowIndex]["body"].ToString();
            }
        }
    }
}
