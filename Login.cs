using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void Form2_Load(object sender, EventArgs e)
        {


        }




        /////////////////////////////////////////////////////////
        //Movimiento del Menu////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////

        bool val = false;

       

     
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
          
        }
        /////////////////////////////////////////////////////////
        //Movimiento del Menu////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == "Escriba su usuario")
            {
                Usuario.Text = "";
                Usuario.ForeColor = Color.Black;
            }
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = "Escriba su usuario";
                Usuario.ForeColor = Color.DimGray;
            }
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }
        void EntrarEnter()
        {
            ////////////Usuario////////////////////////
            ////////////Usuario////////////////////////
            ////////////Usuario////////////////////////
            string Usuario1 = "ImmanuelKant37";
            string Usuario2 = "NazaIbarrola";
            string Usuario3 = "MauroAio";
            string Usuario4 = "PauloLogio";
            string Usuario5 = "Carolina Monserrat";
            string Usuario6 = "Lara";
            ////////Password////////////////////
            ////////Password////////////////////
            ////////Password////////////////////
            string Password1 = "FranciFec37";
            string Password2 = "NazaIbarrola";
            string Password3 = "MauroAio";
            string Password4 = "PauloLogio";
            string Password5 = "CarolinaMonserrat";
            string Password6 = "Lara";
            if (Usuario.Text == Usuario1)
            {
                if (Password.Text == Password1)
                {
                    Armonizador F1 = new Armonizador();
                    F1.Show();
                    this.Hide();
                }
            }
            if (Usuario.Text == Usuario2)
            {
                if (Password.Text == Password2)
                {
                    Armonizador F1 = new Armonizador();
                    F1.Show();
                    this.Hide();
                }
            }
            if (Usuario.Text == Usuario3)
            {
                if (Password.Text == Password3)
                {
                    Armonizador F1 = new Armonizador();
                    F1.Show();
                    this.Hide();
                }
            }
            if (Usuario.Text == Usuario4)
            {
                if (Password.Text == Password4)
                {
                    Armonizador F1 = new Armonizador();
                    F1.Show();
                    this.Hide();
                }
            }
            if (Usuario.Text == Usuario5)
            {
                if (Password.Text == Password5)
                {
                    Armonizador F1 = new Armonizador();
                    F1.Show();
                    this.Hide();
                }
            }
            if (Usuario.Text == Usuario6)
            {
                if (Password.Text == Password6)
                {
                    Armonizador F1 = new Armonizador();
                    F1.Show();
                    this.Hide();
                }
            }
        

    }
    private void Entrar_Click(object sender, EventArgs e)
        {
            ////////////Usuario////////////////////////
            ////////////Usuario////////////////////////
            ////////////Usuario////////////////////////
            string Usuario1 = "ImmanuelKant37";
            string Usuario2 = "NazaIbarrola";
            string Usuario3 = "MauroAio";
            string Usuario4 = "PauloLogio";
            string Usuario5 = "Carolina Monserrat";
            string Usuario6 = "Lara";
            ////////Password////////////////////
            ////////Password////////////////////
            ////////Password////////////////////
            string Password1 = "FranciFec37";
            string Password2 = "NazaIbarrola";
            string Password3 = "MauroAio";
            string Password4 = "PauloLogio";
            string Password5 = "CarolinaMonserrat";
            string Password6 = "Lara";
            if (Usuario.Text == Usuario1)
            {
                if (Password.Text == Password1)
                {
                    Armonizador F1 = new Armonizador();
                    F1.Show();
                    this.Hide();
                }
            }
            if (Usuario.Text == Usuario2)
            {
                if (Password.Text == Password2)
                {
                    Armonizador F1 = new Armonizador();
                    F1.Show();
                    this.Hide();
                }
            }
            if (Usuario.Text == Usuario3)
            {
                if (Password.Text == Password3)
                {
                    Armonizador F1 = new Armonizador();
                    F1.Show();
                    this.Hide();
                }
            }
            if (Usuario.Text == Usuario4)
            {
                if (Password.Text == Password4)
                {
                    Armonizador F1 = new Armonizador();
                    F1.Show();
                    this.Hide();
                }
            }
            if (Usuario.Text == Usuario5)
            {
                if (Password.Text == Password5)
                {
                    Armonizador F1 = new Armonizador();
                    F1.Show();
                    this.Hide();
                }
            }
            if (Usuario.Text == Usuario6)
            {
                if (Password.Text == Password6)
                {
                    Armonizador F1 = new Armonizador();
                    F1.Show();
                    this.Hide();
                }
            }
        }



        private void Password_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                Password.UseSystemPasswordChar = true;
            }
            else Password.UseSystemPasswordChar = false;

        }

        private void Password_Enter(object sender, EventArgs e)
        {
            {
                if (Password.Text == "Contraseña")
                {
                    Password.Text = "";
                    Password.ForeColor = Color.Black;
                   
                }
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Contraseña";
                Password.ForeColor = Color.Silver;
              

            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

     
        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (Char)Keys.Enter)
            {
                EntrarEnter();
            }
           
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            EntrarEnter();
        }
        int xR, yR;
        
       
  

        private void label12_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
        }

        private void label12_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
         
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
           
          
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
         
    
        }

     
    }

        }
    



