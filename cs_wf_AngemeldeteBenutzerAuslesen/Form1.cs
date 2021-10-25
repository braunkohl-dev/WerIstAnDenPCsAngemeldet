using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace cs_wf_AngemeldeteBenutzerAuslesen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string[] ComputerNameList;
            textBoxErg.Text = "";

            ComputerNameList = textBoxConf.Text.Split(';');
            string tempTXTbxConf = textBoxConf.Text;
            
            foreach (string ComputerName in ComputerNameList)
            {

                try
                {
                    textBoxErg.BackColor = Color.Yellow;
                    buttonStart.Enabled = false;
                    buttonConfigSave.Enabled = false;
                    buttonExit.Enabled = false;
                    textBoxConf.Text = "Bitte warten...";

                    ManagementScope theScope = new ManagementScope("\\\\" + ComputerName + "\\root\\cimv2");

                    ObjectQuery theQuery = new ObjectQuery("SELECT username FROM Win32_ComputerSystem");

                    ManagementObjectSearcher theSearcher = new ManagementObjectSearcher(theScope, theQuery);

                    ManagementObjectCollection theCollection = theSearcher.Get();

                    foreach (ManagementObject theCurObject in theCollection)

                    {

                        textBoxErg.Text = textBoxErg.Text + "Am Computer:  " + ComputerName + "  ist derzeit angemeldet: " + theCurObject["username"].ToString() + Environment.NewLine;
                        textBoxErg.BackColor = Color.White;
                        buttonStart.Enabled = true;
                        buttonConfigSave.Enabled = true;
                        buttonExit.Enabled = true;
                        textBoxConf.Text = tempTXTbxConf;
                    }
                }
                catch
                {
                    textBoxErg.BackColor = Color.White;
                    buttonStart.Enabled = true;
                    buttonConfigSave.Enabled = true;
                    buttonExit.Enabled = true;
                    textBoxConf.Text = tempTXTbxConf;
                }

            }

            if (textBoxErg.Text != "")
            {
            }
            else
            { 
                textBoxErg.Text = "es wurden keine Anmeldungen gefunden";
                
            }

    }

        private void Form1_Load(object sender, EventArgs e)
        {

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\wf_cs_AngemeldeteBenutzerAuslesen");

            if (key != null)
            {
                textBoxConf.Text = (string)key.GetValue("ComputerListe");
                key.Close();
            }

        }

        private void buttonConfigSave_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\wf_cs_AngemeldeteBenutzerAuslesen", true);
            if (key is null)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\wf_cs_AngemeldeteBenutzerAuslesen", true);
                key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\wf_cs_AngemeldeteBenutzerAuslesen", true);
                
            }

            key.SetValue("ComputerListe", textBoxConf.Text);
            key.Close();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
