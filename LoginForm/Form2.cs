using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml;


namespace LoginForm
{
    public partial class Interface : Form
    {
        bool sidebarExpand;
        XmlDocument xmlDoc = new XmlDocument();
        public Interface()
        {
            InitializeComponent();
            LoadXmlData();
        }

        private void LoadXmlData()
        {
            try
            {
                string xmlFilePath = @"C:\Users\Kalle\source\repos\ArrowMedia\LoginForm\Frame.xaml";

                xmlDoc.Load(xmlFilePath);

                XmlNode rootElement = xmlDoc.SelectSingleNode(".//[local-name()='RootElement'");

                if (rootElement != null)
                {
                    XmlNode childElement1 = rootElement.SelectSingleNode(".//*[local-name()='ChildElement1']");
                    if (childElement1 != null)
                    {
                        textBox1.text = childElement1.InnerText;
                    }
                    XmlNode childElement2 = rootElement.SelectSingleNode(".//*[local-name()='ChildElemenet2'");
                    if (childElement2 != null)
                    {
                        textBox2.text = childElement2.InnerText;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading XML data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            LoadXmlData();
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
