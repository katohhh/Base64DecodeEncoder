using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.IO; 

namespace Base64DecodeEncoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try { guna2TextBox3.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(guna2TextBox1.Text)); }
            catch { }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try { guna2TextBox3.Text = Encoding.UTF8.GetString(Convert.FromBase64String(guna2TextBox2.Text)); }
            catch { }
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch
            {

            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(guna2TextBox3.Text);

           
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright by Copper ©️", "HackTeamHttpsrame", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox3.ReadOnly = true;

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (!!guna2CirclePictureBox1.Visible) { guna2CirclePictureBox1.Visible = false; } else { guna2CirclePictureBox1.Visible = true; }
            if (!!guna2HtmlLabel1.Visible) { guna2HtmlLabel1.Visible = false; } else { guna2HtmlLabel1.Visible = true; }
            if (!!guna2HtmlLabel3.Visible) { guna2HtmlLabel3.Visible = false; } else { guna2ToggleSwitch1.Visible = true; }
            if (!guna2ToggleSwitch1.Visible) { guna2HtmlLabel3.Visible = true; } else { guna2ToggleSwitch1.Visible = false; }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
                    }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
