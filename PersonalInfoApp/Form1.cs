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

namespace PersonalInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var email = txtEmail.Text;
            var phone = txtPhone.Text.ToString();
            var dateOfBirth = int.Parse(dateTimePicker1.Value.ToString("yyyyMMdd"));
            var todayDate = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
            var age = ((todayDate - dateOfBirth) /10000).ToString();
            richTextBox1.Text= name+Environment.NewLine+email+Environment.NewLine+phone+Environment.NewLine+age;
            saveFileDialog1.ShowDialog();
            File.WriteAllLines(saveFileDialog1.FileName, richTextBox1.Lines);
        }
    }
}
