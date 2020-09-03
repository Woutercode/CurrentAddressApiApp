using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrentAddressWindowsApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region UI - Event Handler

        private void btnCmdRequestBox_Click(object sender, EventArgs e)
        {
            AddressApiClient aClient = new AddressApiClient();
            aClient.endPoint = txtTopUrlBox.Text;

            debugOutput("Address API Client Created");

            string strResponse = string.Empty;

            strResponse = aClient.makeRequest();

            debugOutput(strResponse);


        }

        #endregion
        #region DebugOutput - Helps me understand what happens in the code
        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtLowResponseBox.Text = txtLowResponseBox.Text + strDebugText + Environment.NewLine;
                txtLowResponseBox.SelectionStart = txtLowResponseBox.TextLength;
                txtLowResponseBox.ScrollToCaret();

            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
        #endregion
    }
}
