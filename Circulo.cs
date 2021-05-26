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
    public partial class Circulo : Form
    {
        public Circulo()
        {
            InitializeComponent();
            PopUps();
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

        void PopUps()
        {
            this.DOO.SetToolTip(this.label1, "Armonia de Do Mayor");
            this.DOSO.SetToolTip(this.label14, "Armonia de Do Sostenido o Re Bemol Mayor");
            this.REE.SetToolTip(this.label3, "Armonia de Re Mayor");
            this.RESO.SetToolTip(this.label16, "Armonia de Mi Bemol Mayor");
            this.MII.SetToolTip(this.label5, "Armonia de Mi Mayor");
            this.FAA.SetToolTip(this.label18, "Armonia de Fa Mayor");
            this.FASO.SetToolTip(this.label11, "Armonia de Fa Sostenido o Sol Bemol Mayor");
            this.SOLL.SetToolTip(this.label2, "Armonia de Sol Mayor");
            this.SOLSO.SetToolTip(this.label15, "Armonia de La Bemol Mayor");
            this.LAA.SetToolTip(this.label4, "Armonia de La Mayor");
            this.LASO.SetToolTip(this.label17, "Armonia de Si Bemol Mayor");
            this.SII.SetToolTip(this.label6, "Armonia de Si Mayor ");
            this.MostrarMensaje.SetToolTip(this.Mostrar, "Completa el Circulo de Quintas");
            this.LimpiarMensaje.SetToolTip(this.button1, "Limpia el Circulo de Quintas");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
          

        }
    
        private void Bemoles_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        

    
        /////////////////////////////////////////////////////////
        //Movimiento del Menu////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////

     
      

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }
        /////////////////////////////////////////////////////////
        //Movimiento del Menu////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////
        private void Close_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EscDo_Click(object sender, EventArgs e)
        {
            Limpiar();
            DO();
            RE();
            MI();
            FA();
            SOL();
            LA();
            SI();
        }
        /// <summary>
        ///  /// //////////TODAS LAS NOTAS///////////////////////////////
        /// //////////TODAS LAS NOTAS///////////////////////////////
        /// </summary>


        void Rellenar() {
            Do3.Visible = true;
            Do2.Visible = true;
            DoS.Visible = true;
            Reb2.Visible = true;
            Re.Visible = true;
            Re20.Visible = true;
            ReS.Visible = true;
            Mib.Visible = true;
            Mi.Visible = true;
            Mi2.Visible = true;
            Fa.Visible = true;
            Fa2.Visible = true;
            FaS.Visible = true;
            FaS2.Visible = true;
            Sol.Visible = true;
            Sol2.Visible = true;
            Lab.Visible = true;
            SolS.Visible = true;
            La.Visible = true;
            La2.Visible = true;
            Sib.Visible = true;
            Sib2.Visible = true;
            Si.Visible = true;
            Si2.Visible = true;
        }
        void Limpiar()
        {
            Do3.Visible = false;
            Do2.Visible = false;
            DoS.Visible = false;
            Reb2.Visible = false;
            Re.Visible = false;
            Re20.Visible = false;
            ReS.Visible = false;
            Mib.Visible = false;
            Mi.Visible = false;
            Mi2.Visible = false;
            Fa.Visible = false;
            Fa2.Visible = false;
            FaS.Visible = false;
            FaS2.Visible = false;

            Sol.Visible = false;
            Sol2.Visible = false;

            Lab.Visible = false;
            SolS.Visible = false;
            La.Visible = false;
            La2.Visible = false;
            Sib.Visible = false;
            Sib2.Visible = false;
            Si.Visible = false;
            Si2.Visible = false;
        }
        void DO()
        {
            Do3.Visible = true;
            Do2.Visible = true;
        }
        void REB() {
            DoS.Visible = true;
            Reb2.Visible = true;
        }
        void RE() {
            Re.Visible = true;
            Re20.Visible = true;
        }
        void MIB()
        {
            ReS.Visible = true;
            Mib.Visible = true;
        }
        void MI()
        {
            Mi.Visible = true;
            Mi2.Visible = true;
        }
        void FA()
        {
            Fa.Visible = true;
            Fa2.Visible = true;
        }
        void FAS()
        {
            FaS.Visible = true;
            FaS2.Visible = true;
        }
        void SOL() {
            Sol.Visible = true;
            Sol2.Visible = true;
        }
        void LAB()
        {
            Lab.Visible = true;
            SolS.Visible = true;
        }
        void LA() {
            La.Visible = true;
            La2.Visible = true;
        }
        void SIB() {
            Sib.Visible = true;
            Sib2.Visible = true;
        }
        void SI()
        {
            Si.Visible = true;
            Si2.Visible = true;
        }
        /// //////////TODAS LAS NOTAS///////////////////////////////
        /// //////////TODAS LAS NOTAS///////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
            button1.Visible = false;
            Mostrar.Visible = true;
        }

        private void EscDoS_Click(object sender, EventArgs e)
        {
            Limpiar();
            REB();
            MIB();
            FA();
            FAS();
            LAB();
            SIB();
            DO();
        }

        private void EscRe_Click(object sender, EventArgs e)
        {
            Limpiar();
            RE();
            MI();
            FAS();
            SOL();
            LA();
            SI();
            REB();
        }

        private void EscReS_Click(object sender, EventArgs e)
        {
            Limpiar();
            MIB();
            FA();
            SOL();
            LAB();
            SIB();
            DO();
            RE();
        }

        private void EscMi_Click(object sender, EventArgs e)
        {
            Limpiar();
            MI();
            FAS();
            LAB();
            LA();
            SI();
            REB();
            MIB();
        }

        private void EscFa_Click(object sender, EventArgs e)
        {
            Limpiar();
            FA();
            SOL();
            LA();
            SIB();
            DO();
            RE();
            MI();
        }

        private void EscFaS_Click(object sender, EventArgs e)
        {
            Limpiar();
            FAS();
            LAB();
            SIB();
            SI();
            REB();
            MIB();
            FA();
        }

        private void EscSol_Click(object sender, EventArgs e)
        {
            Limpiar();
            SOL();
            LA();
            SI();
            DO();
            RE();
            MI();
            FAS();

        }

        private void EscSolS_Click(object sender, EventArgs e)
        {
            Limpiar();
            LAB();
            SIB();
            DO();
            REB();
            MIB();
            FA();
            SOL();
        }

        private void EscLa_Click(object sender, EventArgs e)
        {
            Limpiar();
            LA();
            SI();
            REB();
            RE();
            MI();
            FAS();
            LAB();
        }

        private void EscLaS_Click(object sender, EventArgs e)
        {
            Limpiar();
            SIB();
            DO();
            RE();
            MIB();
            FA();
            SOL();
            LA();
        }

        private void EscSi_Click(object sender, EventArgs e)
        {
            Limpiar();
            SI();
            REB();
            MIB();
            MI();
            FAS();
            LAB();
            SIB();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

       void ArmoniaDO()
        {
            Limpiar();
            DO();
            if (Mayor.Checked == true)
                MI();
            if (Menor.Checked == true)
                MIB();
            if (Quinta.Checked == true)
                SOL();
            if (Suspendida2.Checked == true)
                RE();
            if (Suspendida4.Checked == true)
                FA();
            if (SextaMayor.Checked == true)
                LA();
            if (Disminuido.Checked == true)
                FAS();
            if (SeptimaMenor.Checked == true)
                SIB();
            if (SeptimaMayor.Checked == true)
                SI();
            if (NovenaBemol.Checked == true)
                REB();
            if (QuintaAumentada.Checked == true) 
                LAB();
        }
        void ArmoniaREB()
        {
            Limpiar();
            REB();
            if (NovenaBemol.Checked == true)
                RE();
            if (Suspendida2.Checked == true)
                MIB();
            if (Menor.Checked == true)
                MI();
            if (Mayor.Checked == true)
                FA();
            if (Disminuido.Checked == true)
                SOL();
            if (Suspendida4.Checked == true)
                FAS();
            if (Quinta.Checked == true)
                LAB();
            if (QuintaAumentada.Checked == true)
                LA();
            if (SextaMayor.Checked == true)
                SIB();
            if (SeptimaMenor.Checked == true)
                SI();
            if (SeptimaMayor.Checked == true)
                DO();
        }
        void ArmoniaRE()
        {
            Limpiar();
            RE();
            if (NovenaBemol.Checked == true)
                MIB();
            if (Suspendida2.Checked == true)
                MI();
            if (Menor.Checked == true)
                FA();
            if (Mayor.Checked == true)
                FAS();
            if (Disminuido.Checked == true)
                LAB();
            if (Suspendida4.Checked == true)
                SOL();
            if (Quinta.Checked == true)
                LA();
            if (QuintaAumentada.Checked == true)
                SIB();
            if (SextaMayor.Checked == true)
                SI();
            if (SeptimaMenor.Checked == true)
                DO();
            if (SeptimaMayor.Checked == true)
                REB();
        }
        void ArmoniaMIB()
        {
            Limpiar();
            MIB();
            if (NovenaBemol.Checked == true)
                MI();
            if (Suspendida2.Checked == true)
                FA();
            if (Menor.Checked == true)
                FAS();
            if (Mayor.Checked == true)
                SOL();
            if (Disminuido.Checked == true)
                LA();
            if (Suspendida4.Checked == true)
                SIB();
            if (Quinta.Checked == true)
                SIB();
            if (QuintaAumentada.Checked == true)
                SI();
            if (SextaMayor.Checked == true)
                DO();
            if (SeptimaMenor.Checked == true)
                REB();
            if (SeptimaMayor.Checked == true)
                RE();
        }
        void ArmoniaMI()
        {
            Limpiar();
            MI();
            if (NovenaBemol.Checked == true)
                FA();
            if (Suspendida2.Checked == true)
                FAS();
            if (Menor.Checked == true)
                SOL();
            if (Mayor.Checked == true)
                LAB();
            if (Disminuido.Checked == true)
                SIB();
            if (Suspendida4.Checked == true)
                LA();
            if (Quinta.Checked == true)
                SI();
            if (QuintaAumentada.Checked == true)
                DO();
            if (SextaMayor.Checked == true)
                REB();
            if (SeptimaMenor.Checked == true)
                RE();
            if (SeptimaMayor.Checked == true)
                MIB();
        }
        void ArmoniaFA()
        {
            Limpiar();
            FA();
            if (NovenaBemol.Checked == true)
                FAS();
            if (Suspendida2.Checked == true)
                SOL();
            if (Menor.Checked == true)
                LAB();
            if (Mayor.Checked == true)
                LA();
            if (Disminuido.Checked == true)
                SI();
            if (Suspendida4.Checked == true)
                SIB();
            if (Quinta.Checked == true)
                DO();
            if (QuintaAumentada.Checked == true)
                REB();
            if (SextaMayor.Checked == true)
                RE();
            if (SeptimaMenor.Checked == true)
                MIB();
            if (SeptimaMayor.Checked == true)
                MI();
        }
        void ArmoniaFAS()
        {
            Limpiar();
            FAS();
            if (NovenaBemol.Checked == true)
                SOL();
            if (Suspendida2.Checked == true)
                LAB();
            if (Menor.Checked == true)
                LA();
            if (Mayor.Checked == true)
                SIB();
            if (Disminuido.Checked == true)
                DO();
            if (Suspendida4.Checked == true)
                SI();
            if (Quinta.Checked == true)
                REB();
            if (QuintaAumentada.Checked == true)
                RE();
            if (SextaMayor.Checked == true)
                MIB();
            if (SeptimaMenor.Checked == true)
                MI();
            if (SeptimaMayor.Checked == true)
                FA();
        }
        void ArmoniaSOL()
        {
            Limpiar();
            SOL();
            if (NovenaBemol.Checked == true)
                LAB();
            if (Suspendida2.Checked == true)
                LA();
            if (Menor.Checked == true)
                SIB();
            if (Mayor.Checked == true)
                SI();
            if (Disminuido.Checked == true)
                REB();
            if (Suspendida4.Checked == true)
                DO();
            if (Quinta.Checked == true)
                RE();
            if (QuintaAumentada.Checked == true)
                MIB();
            if (SextaMayor.Checked == true)
                MI();
            if (SeptimaMenor.Checked == true)
                FA();
            if (SeptimaMayor.Checked == true)
                FAS();
        }
        void ArmoniaLAB()
        {
            Limpiar();
            LAB();
            if (NovenaBemol.Checked == true)
                LA();
            if (Suspendida2.Checked == true)
                SIB();
            if (Menor.Checked == true)
                SI();
            if (Mayor.Checked == true)
                DO();
            if (Disminuido.Checked == true)
                RE();
            if (Suspendida4.Checked == true)
                REB();
            if (Quinta.Checked == true)
                MIB();
            if (QuintaAumentada.Checked == true)
                MI();
            if (SextaMayor.Checked == true)
                FA();
            if (SeptimaMenor.Checked == true)
                FAS();
            if (SeptimaMayor.Checked == true)
                SOL();
        }
        void ArmoniaLA()
        {
            Limpiar();
            LA();
            if (NovenaBemol.Checked == true)
                SIB();
            if (Suspendida2.Checked == true)
                SI();
            if (Menor.Checked == true)
                DO();
            if (Mayor.Checked == true)
                REB();
            if (Disminuido.Checked == true)
                MIB();
            if (Suspendida4.Checked == true)
                RE();
            if (Quinta.Checked == true)
                MI();
            if (QuintaAumentada.Checked == true)
                FA();
            if (SextaMayor.Checked == true)
                FAS();
            if (SeptimaMenor.Checked == true)
                SOL();
            if (SeptimaMayor.Checked == true)
                LAB();
        }
        void ArmoniaSIB()
        {
            Limpiar();
            SIB();
            if (NovenaBemol.Checked == true)
                SI();
            if (Suspendida2.Checked == true)
                DO();
            if (Menor.Checked == true)
                REB();
            if (Mayor.Checked == true)
                RE();
            if (Disminuido.Checked == true)
                MI();
            if (Suspendida4.Checked == true)
                MIB();
            if (Quinta.Checked == true)
                FA();
            if (QuintaAumentada.Checked == true)
                FAS();
            if (SextaMayor.Checked == true)
                SOL();
            if (SeptimaMenor.Checked == true)
                LAB();
            if (SeptimaMayor.Checked == true)
                LA();
        }
        void ArmoniaSI()
        {
            Limpiar();
            SI();
            if (NovenaBemol.Checked == true)
                DO();
            if (Suspendida2.Checked == true)
                REB();
            if (Menor.Checked == true)
                RE();
            if (Mayor.Checked == true)
                MIB();
            if (Disminuido.Checked == true)
                FA();
            if (Suspendida4.Checked == true)
                MI();
            if (Quinta.Checked == true)
                FAS();
            if (QuintaAumentada.Checked == true)
                SOL();
            if (SextaMayor.Checked == true)
                LAB();
            if (SeptimaMenor.Checked == true)
                LA();
            if (SeptimaMayor.Checked == true)
                SIB();
        }

        private void Do3_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaDO();
        }

        private void Sol_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaSOL();
        }

        private void Re20_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaRE();
        }

        private void La2_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaLA();
        }

        private void Mi2_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaMI();
        }

        private void Si2_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaSI();
        }

        private void FaS2_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaFAS();
        }

        private void Reb2_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaREB();
        }

        private void Lab_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaLAB();
        }

        private void Mib_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaMIB();
        }

        private void Sib_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaSIB();
        }

        private void Fa_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaFA();
        }

        private void La_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaLA();
        }

        private void Mi_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaMI();
        }

        private void Si_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaSI();
        }

        private void FaS_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaFAS();
        }

        private void DoS_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaREB();
        }

        private void SolS_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaLAB();
        }

        private void ReS_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaMIB();
        }

        private void Sib2_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaSIB();
        }

        private void Fa2_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaFA();
        }

        private void Do2_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaDO();
        }

        private void Sol2_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaSOL();
        }

        private void Re_DoubleClick(object sender, EventArgs e)
        {
            ArmoniaREB();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Rellenar();
            button1.Visible = true;
            Mostrar.Visible = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// //////////REGION MOVIMIENTO////////////////////////////////////
        /// </summary>
        /// 
        int xR, yR;
 
        private void Do3_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Do3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        private void DoS_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void DoS_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        /////////////////////////////////////////
private void Si_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

private void Si_MouseMove(object sender, MouseEventArgs e)
{
    if (e.Button == System.Windows.Forms.MouseButtons.Left)
    {
        ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
    }
}
        ///  /////////////////////////////////////////
        private void Si2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Si2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        ///    /////////////////////////////////////////
        private void FaS2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void FaS2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        /////////////////////////////////////////
        private void Sol_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Sol_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        /////////////////////////////////////////
        private void Sol2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Sol2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        /////////////////////////////////////////
        private void Lab_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Lab_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        /////////////////////////////////////////
        private void SolS_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void SolS_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        /////////////////////////////////////////
        private void La_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void La_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        /////////////////////////////////////////
        private void La2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void La2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        /////////////////////////////////////////
        private void Sib_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Sib_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        /////////////////////////////////////////
        private void Sib2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Sib2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        ///////
        private void Do2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Do2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }

        private void Fa2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Fa2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }

        private void FaS_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void FaS_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        private void Fa_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Fa_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        private void Mi2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Mi2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        private void Mib_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Mib_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        private void Mi_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Mi_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        private void Re20_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Re20_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        private void Reb2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Reb2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        private void ReS_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void ReS_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
        private void Re_MouseDown(object sender, MouseEventArgs e)
        {
            {
                xR = e.X;
                yR = e.Y;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Label)sender).Visible = false;
            }
        }

        private void Re_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Label)sender).Location = new Point(((Label)sender).Left + e.X - xR, ((Label)sender).Top + e.Y - yR);
            }
        }
    }

}


