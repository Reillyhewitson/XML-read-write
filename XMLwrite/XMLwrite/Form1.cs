using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace XMLwrite
{
    public partial class Form1 : Form
    {
        string directory = Path.GetDirectoryName(Application.ExecutablePath);
        public Form1()
        {
            InitializeComponent();
        }

        private void directorySet_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                fbd.Filter = "Text files (*.xml)|*.xml";
                DialogResult result = fbd.ShowDialog();
                directory = fbd.FileName;
                Console.WriteLine(directory);
            }
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void writeStart_Click(object sender, EventArgs e)
        {
            string title = inputTitle.Text;
            string text;
            using (var streamReader = new StreamReader(directory, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }
            InputBody.Text = text;

            
        }
    }
}
