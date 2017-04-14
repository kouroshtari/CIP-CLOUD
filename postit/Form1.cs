using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace postit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richResults.Text))
            {
                richPostresults.ResetText();
                richPostresults.Text = PostRequest(richResults.Text);
                string data = getBetween(richPostresults.Text, "\"UniqueTransId\":\"", "\"}}");
                textBox1.Text = data;
                lblMsg.Text = "Follow the prompts on your device...";
            }
            else
            {
                MessageBox.Show("JSON object missing!", "Missing info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
        private string PostRequest(string myJson)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://cloud.chargeitpro.com/transaction.json");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
               
                streamWriter.Write(myJson);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;
            }
            
        }

        private void GetRequest(string myRefNo)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://cloud.chargeitpro.com/transactionresult/" + myRefNo);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                result = ClearResponse(result);
                ParseOutPut(result);
                

            }
            
        }
        private string ClearResponse(string responseCIP)
        {
            string resultBack;
            resultBack = responseCIP.Replace("\"", "");
            resultBack = responseCIP.Replace("}", "");
            resultBack = responseCIP.Replace("{", "");

            return resultBack;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text))
            {
                richGetResults.ResetText();
                GetRequest(textBox1.Text);
            }else
            {
                textBox1.Focus();
                textBox1.Select();
                return;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtLocationId.Text) && !string.IsNullOrEmpty(txtDeviceName.Text) && !string.IsNullOrEmpty(txtAmount.Text) && !string.IsNullOrEmpty(txtRef.Text) && listBox1.SelectedIndex >= 0 )
            {
                richResults.ResetText();
                CreateJson();
            }else
            {
                MessageBox.Show("Please enter all required values and try again!", "Missing info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }           
        }
        private void CreateJson()
        {
            string jsonStr;
            //Void requires UniqueTrnsId
            if(listBox1.SelectedIndex==2)
            {
                jsonStr = "{\"Action\":\"Transaction\",\"LocationId\":\"" + txtLocationId.Text + "\",\"DeviceName\":\"" + txtDeviceName.Text + "\",\"Data\":{ \"TransactionType\":\"" + listBox1.SelectedItem + "\",\"TransactionRef\":\"" + txtRef.Text + "\",\"Cashier\":\"" + txtCashier.Text + "\",\"UniqueTransId\":\"" + textBox1.Text + "\",\"BillingName\":\"" + txtBillingName.Text + "\",\"Street\":\"" + txtStreet.Text + "\",\"Zip\":\"" + txtZip.Text + "\"}}";
            }else
            {
                   jsonStr= "{\"Action\":\"Transaction\",\"LocationId\":\"" + txtLocationId.Text + "\",\"DeviceName\":\"" + txtDeviceName.Text + "\",\"Data\":{ \"TransactionType\":\"" + listBox1.SelectedItem + "\",\"Amount\":\"" + txtAmount.Text + "\",\"TransactionRef\":\"" + txtRef.Text + "\",\"Cashier\":\"" + txtCashier.Text + "\",\"BillingName\":\"" + txtBillingName.Text + "\",\"Street\":\"" + txtStreet.Text + "\",\"Zip\":\"" + txtZip.Text + "\"}}";
            }
         
            richResults.Text = jsonStr;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            txtAmount.ResetText();
            txtBillingName.ResetText();
            txtCashier.ResetText();
            txtDeviceName.ResetText();
            txtLocationId.ResetText();
            txtRef.ResetText();
            txtStreet.ResetText();
            txtZip.ResetText();
            richGetResults.ResetText();
            richPostresults.ResetText();
            richResults.ResetText();
            txtLocationId.Focus();
            txtLocationId.Select();
            lblMsg.Text = "Messages:";
        }
        private void ParseOutPut(string resultsCip)
        {
            char[] delimiterChars = {','};           

            string[] words = resultsCip.Split(delimiterChars);
           
            foreach (string s in words)
            {
                richGetResults.AppendText(s + Environment.NewLine);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
