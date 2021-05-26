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
    public partial class Armonizador : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
      

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        public Armonizador()
        {
            InitializeComponent();
        }
        void MostrarFila1()
        {

            UnoxUno.Text = Tonica.Text;
            UnoxDos.Text = SegundaMenor.Text;
            UnoxTres.Text = Segunda.Text;
            UnoxCuatro.Text = TerceraMenor.Text;
            UnoxCinco.Text = TerceraMay.Text;
            UnoxSeis.Text = Cuarta.Text;
            UnoxSiete.Text = QuintaDIM.Text;
            UnoxOcho.Text = Quinta.Text;
            UnoxNueve.Text = SextaMenor.Text;
            UnoxDiez.Text = Sexta.Text;
            UnoxOnce.Text = SeptimaMenor.Text;
            UnoxDoce.Text = Septima.Text;
        }
        void MostrarFila2()
        {
            DosxUno.Text = SegundaMenor.Text;
            DosxDos.Text = Segunda.Text;
            DosxTres.Text = TerceraMenor.Text;
            DosxCuatro.Text = TerceraMay.Text;
            DosxCinco.Text = Cuarta.Text;
            DosxSeis.Text = QuintaDIM.Text;
            DosxSiete.Text = Quinta.Text;
            DosxOcho.Text = SextaMenor.Text;
            DosxNueve.Text = Sexta.Text;
            DosxDiez.Text = SeptimaMenor.Text;
            DosxOnce.Text = Septima.Text;
            DosxTres.Text = Tonica.Text;
        }
        void MostrarFila3()
        {
            TresxUno.Text = Segunda.Text;
            TresxDos.Text = TerceraMenor.Text;
            TresxTres.Text = TerceraMay.Text;
            TresxCuatro.Text = Cuarta.Text;
            TresxCinco.Text = QuintaDIM.Text;
            TresxSeis.Text = Quinta.Text;
            TresxSiete.Text = SextaMenor.Text;
            TresxOcho.Text = Sexta.Text;
            TresxNueve.Text = SeptimaMenor.Text;
            TresxDiez.Text = Septima.Text;
            TresxOnce.Text = Tonica.Text;
            TresxDoce.Text = SegundaMenor.Text;
        }
        void MostrarFila4()
        {
            CuatroxUno.Text = TerceraMenor.Text;
            CuatroxDos.Text = TerceraMay.Text;
            CuatroxTres.Text = Cuarta.Text;
            CuatroxCuatro.Text = QuintaDIM.Text;
            CuatroxCinco.Text = Quinta.Text;
            CuatroxSeis.Text = SextaMenor.Text;
            CuatroxSiete.Text = Sexta.Text;
            CuatroxOcho.Text = SeptimaMenor.Text;
            CuatroxNueve.Text = Septima.Text;
            CuatroxDiez.Text = Tonica.Text;
            CuatroxOnce.Text = SegundaMenor.Text;
            CuatroxDoce.Text = Segunda.Text;
        }
        void MostrarFila5()
        {
            CincoxUno.Text = TerceraMay.Text;
            CincoxDos.Text = Cuarta.Text;
            CincoxTres.Text = QuintaDIM.Text;
            CincoxCuatro.Text = Quinta.Text;
            CincoxCinco.Text = SextaMenor.Text;
            CincoxSeis.Text = Sexta.Text;
            CincoxSiete.Text = SeptimaMenor.Text;
            CincoxOcho.Text = Septima.Text;
            CincoxNueve.Text = Tonica.Text;
            CincoxDiez.Text = SegundaMenor.Text;
            CincoxOnce.Text = Segunda.Text;
            CincoxDoce.Text = TerceraMenor.Text;
        }
        void MostrarFila6()
        {
            SeisxUno.Text = Cuarta.Text;
            SeisxDos.Text = QuintaDIM.Text;
            SeisxTres.Text = Quinta.Text;
            SeisxCuatro.Text = SextaMenor.Text;
            SeisxCinco.Text = Sexta.Text;
            SeisxSeis.Text = SeptimaMenor.Text;
            SeisxSiete.Text = Septima.Text;
            SeisxOcho.Text = Tonica.Text;
            SeisxNueve.Text = SegundaMenor.Text;
            SeisxDiez.Text = Segunda.Text;
            SeisxOnce.Text = TerceraMenor.Text;
            SeisxDoce.Text = TerceraMay.Text;
        }
        void MostrarFila7()
        {
            SietexUno.Text = QuintaDIM.Text;
            SietexDos.Text = Quinta.Text;
            SietexTres.Text = SextaMenor.Text;
            SietexCuatro.Text = Sexta.Text;
            SietexCinco.Text = SeptimaMenor.Text;
            SietexSeis.Text = Septima.Text;
            SietexSiete1.Text = Tonica.Text;
            SietexOcho.Text = SegundaMenor.Text;
            SietexNueve.Text = Segunda.Text;
            SietexDiez.Text = TerceraMenor.Text;
            SietexOnce.Text = TerceraMay.Text;
            SietexDoce.Text = Cuarta.Text;
        }
        void MostrarFila8()
        {
            OchoxUno.Text = Quinta.Text;
            OchoxDos.Text = SextaMenor.Text;
            OchoxTres.Text = Sexta.Text;
            OchoxCuatro.Text = SeptimaMenor.Text;
            OchoxCinco.Text = Septima.Text;
            OchoxSeis.Text = Tonica.Text;
            OchoxSiete.Text = SegundaMenor.Text;
            OchoxOcho.Text = Segunda.Text;
            OchoxNueve.Text = TerceraMenor.Text;
            OchoxDiez.Text = TerceraMay.Text;
            OchoxOnce.Text = Cuarta.Text;
            OchoxDoce.Text = QuintaDIM.Text;
        }
        void MostrarFila9()
        {
            NuevexUno.Text = SextaMenor.Text;
            NuevexDos.Text = Sexta.Text;
            NuevexTres.Text = SeptimaMenor.Text;
            NuevexCuatro.Text = Septima.Text;
            NuevexCinco.Text = Tonica.Text;
            NuevexSeis.Text = SegundaMenor.Text;
            NuevexSiete.Text = Segunda.Text;
            NuevexOcho.Text = TerceraMenor.Text;
            NuevexNueve.Text = TerceraMay.Text;
            NuevexDiez.Text = Cuarta.Text;
            NuevexOnce.Text = QuintaDIM.Text;
            NuevexDoce.Text = Quinta.Text;
        }
        void MostrarFila10()
        {
            DiezxUno.Text = Sexta.Text;
            DiezxDos.Text = SeptimaMenor.Text;
            DiezxTres.Text = Septima.Text;
            DiezxCuatro.Text = Tonica.Text;
            DiezxCinco.Text = SegundaMenor.Text;
            DiezxSeis.Text = Segunda.Text;
            DiezxSiete.Text = TerceraMenor.Text;
            DiezxOcho.Text = TerceraMay.Text;
            DiezxNueve.Text = Cuarta.Text;
            DiezxDiez.Text = QuintaDIM.Text;
            DiezxOnce.Text = Quinta.Text;
            DiezxDoce.Text = SextaMenor.Text;
        }
        void MostrarFila11()
        {
            OncexUno.Text = SeptimaMenor.Text;
            OncexDos.Text = Septima.Text;
            OncexTres.Text = Tonica.Text;
            OncexCuatro.Text = SegundaMenor.Text;
            OncexCinco.Text = Segunda.Text;
            OncexSeis.Text = TerceraMenor.Text;
            OncexSiete.Text = TerceraMay.Text;
            OncexOcho.Text = Cuarta.Text;
            OncexNueve.Text = QuintaDIM.Text;
            OncexDiez.Text = Quinta.Text;
            OncexOnce.Text = SextaMenor.Text;
            OncexDoce.Text = Sexta.Text;
        }
        void MostrarFila12()
        {
            DocexUno.Text = Septima.Text;
            DocexDos.Text = Tonica.Text;
            DocexTres.Text = SegundaMenor.Text;
            DocexCuatro.Text = Segunda.Text;
            DocexCinco.Text = TerceraMenor.Text;
            DocexSeis.Text = TerceraMay.Text;
            DocexSiete.Text = Cuarta.Text;
            DocexOcho.Text = QuintaDIM.Text;
            DocexNueve.Text = Quinta.Text;
            DocexDiez.Text = SextaMenor.Text;
            DocexOnce.Text = Sexta.Text;
            DocexDoce.Text = SeptimaMenor.Text;
        }

     
        public void UbicarNotas() {
            //Cambia la seccion acordes - Primer Fila
            UnoxUno.Text = Tonica.Text;
            UnoxDos.Text = SegundaMenor.Text;
            UnoxTres.Text = Segunda.Text;
            UnoxCuatro.Text = TerceraMenor.Text;
            UnoxCinco.Text = TerceraMay.Text;
            UnoxSeis.Text = Cuarta.Text;
            UnoxSiete.Text = QuintaDIM.Text;
            UnoxOcho.Text = Quinta.Text;
            UnoxNueve.Text = SextaMenor.Text;
            UnoxDiez.Text = Sexta.Text;
            UnoxOnce.Text = SeptimaMenor.Text;
            UnoxDoce.Text = Septima.Text;

            //Cambia la seccion acordes - Primer Fila
           
            DosxUno.Text = SegundaMenor.Text;
            DosxDos.Text = Segunda.Text;
            DosxTres.Text = TerceraMenor.Text;
            DosxCuatro.Text = TerceraMay.Text;
            DosxCinco.Text = Cuarta.Text;
            DosxSeis.Text = QuintaDIM.Text;
            DosxSiete.Text = Quinta.Text;
            DosxOcho.Text = SextaMenor.Text;
            DosxNueve.Text = Sexta.Text;
            DosxDiez.Text = SeptimaMenor.Text;
            DosxOnce.Text = Septima.Text;
            DosxDoce.Text = Tonica.Text;
            //Cambia la seccion acordes - Segunda Fila

            TresxUno.Text = Segunda.Text;
            TresxDos.Text = TerceraMenor.Text;
            TresxTres.Text = TerceraMay.Text;
            TresxCuatro.Text = Cuarta.Text;
            TresxCinco.Text = QuintaDIM.Text;
            TresxSeis.Text = Quinta.Text;
            TresxSiete.Text = SextaMenor.Text;
            TresxOcho.Text = Sexta.Text;
            TresxNueve.Text = SeptimaMenor.Text;
            TresxDiez.Text = Septima.Text;
            TresxOnce.Text = Tonica.Text;
            TresxDoce.Text = SegundaMenor.Text;

            //Cambia la seccion acordes - Tercera Fila
            CuatroxUno.Text = TerceraMenor.Text;
            CuatroxDos.Text = TerceraMay.Text;
            CuatroxTres.Text = Cuarta.Text;
            CuatroxCuatro.Text = QuintaDIM.Text;
            CuatroxCinco.Text = Quinta.Text;
            CuatroxSeis.Text = SextaMenor.Text;
            CuatroxSiete.Text = Sexta.Text;
            CuatroxOcho.Text = SeptimaMenor.Text;
            CuatroxNueve.Text = Septima.Text;
            CuatroxDiez.Text = Tonica.Text;
            CuatroxOnce.Text = SegundaMenor.Text;
            CuatroxDoce.Text = Segunda.Text;

            //Cambia la seccion acordes - Cuarta Fila

            CincoxUno.Text = TerceraMay.Text;
            CincoxDos.Text = Cuarta.Text;
            CincoxTres.Text = QuintaDIM.Text;
            CincoxCuatro.Text = Quinta.Text;
            CincoxCinco.Text = SextaMenor.Text;
            CincoxSeis.Text = Sexta.Text;
            CincoxSiete.Text = SeptimaMenor.Text;
            CincoxOcho.Text = Septima.Text;
            CincoxNueve.Text = Tonica.Text;
            CincoxDiez.Text = SegundaMenor.Text;
            CincoxOnce.Text = Segunda.Text;
            CincoxDoce.Text = TerceraMenor.Text;


            //Cambia la seccion acordes - Quinta Fila

            SeisxUno.Text = Cuarta.Text;
            SeisxDos.Text = QuintaDIM.Text;
            SeisxTres.Text = Quinta.Text;
            SeisxCuatro.Text = SextaMenor.Text;
            SeisxCinco.Text = Sexta.Text;
            SeisxSeis.Text = SeptimaMenor.Text;
            SeisxSiete.Text = Septima.Text;
            SeisxOcho.Text = Tonica.Text;
            SeisxNueve.Text = SegundaMenor.Text;
            SeisxDiez.Text = Segunda.Text;
            SeisxOnce.Text = TerceraMenor.Text;
            SeisxDoce.Text = TerceraMay.Text;



            //Cambia la seccion acordes - Sexta Fila


            SietexUno.Text = QuintaDIM.Text;
            SietexDos.Text = Quinta.Text;
            SietexTres.Text = SextaMenor.Text;
            SietexCuatro.Text = Sexta.Text;
            SietexCinco.Text = SeptimaMenor.Text;
            SietexSeis.Text = Septima.Text;
            SietexSiete1.Text = Tonica.Text;
            SietexOcho.Text = SegundaMenor.Text;
            SietexNueve.Text = Segunda.Text;
            SietexDiez.Text = TerceraMenor.Text;
            SietexOnce.Text = TerceraMay.Text;
            SietexDoce.Text = Cuarta.Text;


            //Cambia la seccion acordes - Septima Fila
            OchoxUno.Text = Quinta.Text;
            OchoxDos.Text = SextaMenor.Text;
            OchoxTres.Text = Sexta.Text;
            OchoxCuatro.Text = SeptimaMenor.Text;
            OchoxCinco.Text = Septima.Text;
            OchoxSeis.Text = Tonica.Text;
            OchoxSiete.Text = SegundaMenor.Text;
            OchoxOcho.Text = Segunda.Text;
            OchoxNueve.Text = TerceraMenor.Text;
            OchoxDiez.Text = TerceraMay.Text;
            OchoxOnce.Text = Cuarta.Text;
            OchoxDoce.Text = QuintaDIM.Text;


            //Cambia la seccion acordes - Octava Fila
            NuevexUno.Text = SextaMenor.Text;
            NuevexDos.Text = Sexta.Text;
            NuevexTres.Text = SeptimaMenor.Text;
            NuevexCuatro.Text = Septima.Text;
            NuevexCinco.Text = Tonica.Text;
            NuevexSeis.Text = SegundaMenor.Text;
            NuevexSiete.Text = Segunda.Text;
            NuevexOcho.Text = TerceraMenor.Text;
            NuevexNueve.Text = TerceraMay.Text;
            NuevexDiez.Text = Cuarta.Text;
            NuevexOnce.Text = QuintaDIM.Text;
            NuevexDoce.Text = Quinta.Text;




            //Cambia la seccion acordes - Novena Fila
          
            DiezxUno.Text = Sexta.Text;
            DiezxDos.Text = SeptimaMenor.Text;
            DiezxTres.Text = Septima.Text;
            DiezxCuatro.Text = Tonica.Text;
            DiezxCinco.Text = SegundaMenor.Text;
            DiezxSeis.Text = Segunda.Text;
            DiezxSiete.Text = TerceraMenor.Text;
            DiezxOcho.Text = TerceraMay.Text;
            DiezxNueve.Text = Cuarta.Text;
            DiezxDiez.Text = QuintaDIM.Text;
            DiezxOnce.Text = Quinta.Text;
            DiezxDoce.Text = SextaMenor.Text;

            //Cambia la seccion acordes - Decima Fila

           
            OncexUno.Text = SeptimaMenor.Text;
            OncexDos.Text = Septima.Text;
            OncexTres.Text = Tonica.Text;
            OncexCuatro.Text = SegundaMenor.Text;
            OncexCinco.Text = Segunda.Text;
            OncexSeis.Text = TerceraMenor.Text;
            OncexSiete.Text = TerceraMay.Text;
            OncexOcho.Text = Cuarta.Text;
            OncexNueve.Text = QuintaDIM.Text;
            OncexDiez.Text = Quinta.Text;
            OncexOnce.Text = SextaMenor.Text;
            OncexDoce.Text = Sexta.Text;
            //Cambia la seccion acordes - Fila Once

           
            DocexUno.Text = Septima.Text;
            DocexDos.Text = Tonica.Text;
            DocexTres.Text = SegundaMenor.Text;
            DocexCuatro.Text = Segunda.Text;
            DocexCinco.Text = TerceraMenor.Text;
            DocexSeis.Text = TerceraMay.Text;
            DocexSiete.Text = Cuarta.Text;
            DocexOcho.Text = QuintaDIM.Text;
            DocexNueve.Text = Quinta.Text;
            DocexDiez.Text = SextaMenor.Text;
            DocexOnce.Text = Sexta.Text;
            DocexDoce.Text = SeptimaMenor.Text;






        }
        void Columna1()
        {
            UnoxUno.Text = Tonica.Text;
            DosxUno.Text = SegundaMenor.Text;
            TresxUno.Text = Segunda.Text;
            CuatroxUno.Text = TerceraMenor.Text;
            CincoxUno.Text = TerceraMay.Text;
            SeisxUno.Text = Cuarta.Text;
            SietexUno.Text = QuintaDIM.Text;
            OchoxUno.Text = Quinta.Text;
            NuevexUno.Text = SextaMenor.Text;
            DiezxUno.Text = Sexta.Text;
            OncexUno.Text = SeptimaMenor.Text;
            DocexUno.Text = Septima.Text;

        }
        void Columna2()
        {
            UnoxDos.Text = SegundaMenor.Text;
            DosxDos.Text = Segunda.Text;
            TresxDos.Text = TerceraMenor.Text;
            CuatroxDos.Text = TerceraMay.Text;
            CincoxDos.Text = Cuarta.Text;
            SeisxDos.Text = QuintaDIM.Text;
            SietexDos.Text = Quinta.Text;
            OchoxDos.Text = SextaMenor.Text;
            NuevexDos.Text = Sexta.Text;
            DiezxDos.Text = SeptimaMenor.Text;
            OncexDos.Text = Septima.Text;
            DocexDos.Text = Tonica.Text;
        }
        void Columna3()
        {
            UnoxTres.Text = Segunda.Text;
            DosxTres.Text = TerceraMenor.Text;
            TresxTres.Text = TerceraMay.Text;
            CuatroxTres.Text = Cuarta.Text;
            CincoxTres.Text = QuintaDIM.Text;
            SeisxTres.Text = Quinta.Text;
            SietexTres.Text = SextaMenor.Text;
            OchoxTres.Text = Sexta.Text;
            NuevexTres.Text = SeptimaMenor.Text;
            DiezxTres.Text = Septima.Text;
            OncexTres.Text = Tonica.Text;
            DocexTres.Text = SegundaMenor.Text;
        }
        void Columna4()
        {
            UnoxCuatro.Text = TerceraMenor.Text;
            DosxCuatro.Text = TerceraMay.Text;
            TresxCuatro.Text = Cuarta.Text;
            CuatroxCuatro.Text = QuintaDIM.Text;
            CincoxCuatro.Text = Quinta.Text;
            SeisxCuatro.Text = SextaMenor.Text;
            SietexCuatro.Text = Sexta.Text;
            OchoxCuatro.Text = SeptimaMenor.Text;
            NuevexCuatro.Text = Septima.Text;
            DiezxCuatro.Text = Tonica.Text;
            OncexCuatro.Text = SegundaMenor.Text;
            DocexCuatro.Text = Segunda.Text;
        }
        void Columna5()
        {
            UnoxCinco.Text = TerceraMay.Text;
            DosxCinco.Text = Cuarta.Text;
            TresxCinco.Text = QuintaDIM.Text;
            CuatroxCinco.Text = Quinta.Text;
            CincoxCinco.Text = SextaMenor.Text;
            SeisxCinco.Text = Sexta.Text;
            SietexCinco.Text = SeptimaMenor.Text;
            OchoxCinco.Text = Septima.Text;
            NuevexCinco.Text = Tonica.Text;
            DiezxCinco.Text = SegundaMenor.Text;
            OncexCinco.Text = Segunda.Text;
            DocexCinco.Text = TerceraMenor.Text;
        }
        void Columna6()
        {
            UnoxSeis.Text = Cuarta.Text;
            DosxSeis.Text = QuintaDIM.Text;
            TresxSeis.Text = Quinta.Text;
            CuatroxSeis.Text = SextaMenor.Text;
            CincoxSeis.Text = Sexta.Text;
            SeisxSeis.Text = SeptimaMenor.Text;
            SietexSeis.Text = Septima.Text;
            OchoxSeis.Text = Tonica.Text;
            NuevexSeis.Text = SegundaMenor.Text;
            DiezxSeis.Text = Segunda.Text;
            OncexSeis.Text = TerceraMenor.Text;
            DocexSeis.Text = TerceraMay.Text;
        }
        void Columna7()
        {
            UnoxSiete.Text = QuintaDIM.Text;
            DosxSiete.Text = Quinta.Text;
            TresxSiete.Text = SextaMenor.Text;
            CuatroxSiete.Text = Sexta.Text;
            CincoxSiete.Text = SeptimaMenor.Text;
            SeisxSiete.Text = Septima.Text;
            SietexSiete1.Text = Tonica.Text;
            OchoxSiete.Text = SegundaMenor.Text;
            NuevexSiete.Text = Segunda.Text;
            DiezxSiete.Text = TerceraMenor.Text;
            OncexSiete.Text = TerceraMay.Text;
            DocexSiete.Text = Cuarta.Text;
        }
        void Columna8()
        {
            UnoxOcho.Text = Quinta.Text;
            DosxOcho.Text = SextaMenor.Text;
            TresxOcho.Text = Sexta.Text;
            CuatroxOcho.Text = SeptimaMenor.Text;
            CincoxOcho.Text = Septima.Text;
            SeisxOcho.Text = Tonica.Text;
            SietexOcho.Text = SegundaMenor.Text;
            OchoxOcho.Text = Segunda.Text;
            NuevexOcho.Text = TerceraMenor.Text;
            DiezxOcho.Text = TerceraMay.Text;
            OncexOcho.Text = Cuarta.Text;
            DocexOcho.Text = QuintaDIM.Text;
        }
        void Columna9()
        {
            UnoxNueve.Text = SextaMenor.Text;
            DosxNueve.Text = Sexta.Text;
            TresxNueve.Text = SeptimaMenor.Text;
            CuatroxNueve.Text = Septima.Text;
            CincoxNueve.Text = Tonica.Text;
            SeisxNueve.Text = SegundaMenor.Text;
            SietexNueve.Text = Segunda.Text;
            OchoxNueve.Text = TerceraMenor.Text;
            NuevexNueve.Text = TerceraMay.Text;
            DiezxNueve.Text = Cuarta.Text;
            OncexNueve.Text = QuintaDIM.Text;
            DocexNueve.Text = Quinta.Text;
        }
        void Columna10() {
            UnoxDiez.Text = Sexta.Text;
            DosxDiez.Text = SeptimaMenor.Text;
            TresxDiez.Text = Septima.Text;
            CuatroxDiez.Text = Tonica.Text;
            CincoxDiez.Text = SegundaMenor.Text;
            SeisxDiez.Text = Segunda.Text;
            SietexDiez.Text = TerceraMenor.Text;
            OchoxDiez.Text = TerceraMay.Text;
            NuevexDiez.Text = Cuarta.Text;
            DiezxDiez.Text = QuintaDIM.Text;
            OncexDiez.Text = Quinta.Text;
            DocexDiez.Text = SextaMenor.Text;

        }
        void Columna11()
        {
            UnoxOnce.Text = SeptimaMenor.Text;
            DosxOnce.Text = Septima.Text;
            TresxOnce.Text = Tonica.Text;
            CuatroxOnce.Text = SegundaMenor.Text;
            CincoxOnce.Text = Segunda.Text;
            SeisxOnce.Text = TerceraMenor.Text;
            SietexOnce.Text = TerceraMay.Text;
            OchoxOnce.Text = Cuarta.Text;
            NuevexOnce.Text = QuintaDIM.Text;
            DiezxOnce.Text = Quinta.Text;
            OncexOnce.Text = SextaMenor.Text;
            DocexOnce.Text = Sexta.Text;
        }
        void Columna12()
        {
            UnoxDoce.Text = Septima.Text;
            DosxDoce.Text = Tonica.Text;
            TresxDoce.Text = SegundaMenor.Text;
            CuatroxDoce.Text = Segunda.Text;
            CincoxDoce.Text = TerceraMenor.Text;
            SeisxDoce.Text = TerceraMay.Text;
            SietexDoce.Text = Cuarta.Text;
            OchoxDoce.Text = QuintaDIM.Text;
            NuevexDoce.Text = Quinta.Text;
            DiezxDoce.Text = SextaMenor.Text;
            OncexDoce.Text = Sexta.Text;
            DocexDoce.Text = SeptimaMenor.Text;
        }
        void LimpiarColumna1()
        {
            UnoxUno.Text = "";
            DosxUno.Text = "";
            TresxUno.Text = "";
            CuatroxUno.Text = "";
            CincoxUno.Text = "";
            SeisxUno.Text = "";
            SietexUno.Text = "";
            OchoxUno.Text = "";
            NuevexUno.Text = "";
            DiezxUno.Text = "";
            OncexUno.Text = "";
            DocexUno.Text = "";

        }
        void LimpiarColumna2()
        {
            UnoxDos.Text = "";
            DosxDos.Text = "";
            TresxDos.Text = "";
            CuatroxDos.Text = "";
            CincoxDos.Text = "";
            SeisxDos.Text = "";
            SietexDos.Text = "";
            OchoxDos.Text = "";
            NuevexDos.Text = "";
            DiezxDos.Text = "";
            OncexDos.Text = "";
            DocexDos.Text = "";
        }
        void LimpiarColumna3()
        {
            UnoxTres.Text = "";
            DosxTres.Text = "";
            TresxTres.Text = "";
            CuatroxTres.Text = "";
            CincoxTres.Text = "";
            SeisxTres.Text = "";
            SietexTres.Text = "";
            OchoxTres.Text = "";
            NuevexTres.Text = "";
            DiezxTres.Text = "";
            OncexTres.Text = "";
            DocexTres.Text = "";
        }
        void LimpiarColumna4()
        {
            UnoxCuatro.Text = "";
            DosxCuatro.Text = "";
            TresxCuatro.Text = "";
            CuatroxCuatro.Text = "";
            CincoxCuatro.Text = "";
            SeisxCuatro.Text = "";
            SietexCuatro.Text = "";
            OchoxCuatro.Text = "";
            NuevexCuatro.Text = "";
            DiezxCuatro.Text = "";
            OncexCuatro.Text = "";
            DocexCuatro.Text = "";
        }
        void LimpiarColumna5()
        {
            UnoxCinco.Text = "";
            DosxCinco.Text = "";
            TresxCinco.Text = "";
            CuatroxCinco.Text = "";
            CincoxCinco.Text = "";
            SeisxCinco.Text = "";
            SietexCinco.Text = "";
            OchoxCinco.Text = "";
            NuevexCinco.Text = "";
            DiezxCinco.Text = "";
            OncexCinco.Text = "";
            DocexCinco.Text = "";
        }
        void LimpiarColumna6()
        {
            UnoxSeis.Text = "";
            DosxSeis.Text = "";
            TresxSeis.Text = "";
            CuatroxSeis.Text = "";
            CincoxSeis.Text = "";
            SeisxSeis.Text = "";
            SietexSeis.Text = "";
            OchoxSeis.Text = "";
            NuevexSeis.Text = "";
            DiezxSeis.Text = "";
            OncexSeis.Text = "";
            DocexSeis.Text = "";
        }
        void LimpiarColumna7()
        {
            UnoxSiete.Text = "";
            DosxSiete.Text = "";
            TresxSiete.Text = "";
            CuatroxSiete.Text = "";
            CincoxSiete.Text = "";
            SeisxSiete.Text = "";
            SietexSiete1.Text = "";
            OchoxSiete.Text = "";
            NuevexSiete.Text = "";
            DiezxSiete.Text = "";
            OncexSiete.Text = "";
            DocexSiete.Text = "";
        }
        void LimpiarColumna8()
        {
            UnoxOcho.Text = "";
            DosxOcho.Text = "";
            TresxOcho.Text = "";
            CuatroxOcho.Text = "";
            CincoxOcho.Text = "";
            SeisxOcho.Text = "";
            SietexOcho.Text = "";
            OchoxOcho.Text = "";
            NuevexOcho.Text = "";
            DiezxOcho.Text = "";
            OncexOcho.Text = "";
            DocexOcho.Text = "";
        }
        void LimpiarColumna9()
        {
            UnoxNueve.Text = "";
            DosxNueve.Text = "";
            TresxNueve.Text = "";
            CuatroxNueve.Text = "";
            CincoxNueve.Text = "";
            SeisxNueve.Text = "";
            SietexNueve.Text = "";
            OchoxNueve.Text = "";
            NuevexNueve.Text = "";
            DiezxNueve.Text = "";
            OncexNueve.Text = "";
            DocexNueve.Text = "";
        }
        void LimpiarColumna10()
        {
            UnoxDiez.Text = "";
            DosxDiez.Text = "";
            TresxDiez.Text = "";
            CuatroxDiez.Text = "";
            CincoxDiez.Text = "";
            SeisxDiez.Text = "";
            SietexDiez.Text = "";
            OchoxDiez.Text = "";
            NuevexDiez.Text = "";
            DiezxDiez.Text = "";
            OncexDiez.Text = "";
            DocexDiez.Text = "";

        }
        void LimpiarColumna11()
        {
            UnoxOnce.Text = "";
            DosxOnce.Text = "";
            TresxOnce.Text = "";
            CuatroxOnce.Text = "";
            CincoxOnce.Text = "";
            SeisxOnce.Text = "";
            SietexOnce.Text = "";
            OchoxOnce.Text = "";
            NuevexOnce.Text = "";
            DiezxOnce.Text = "";
            OncexOnce.Text = "";
            DocexOnce.Text = "";
        }
        void LimpiarColumna12()
        {
            UnoxDoce.Text = "";
            DosxDoce.Text = "";
            TresxDoce.Text = "";
            CuatroxDoce.Text = "";
            CincoxDoce.Text = "";
            SeisxDoce.Text = "";
            SietexDoce.Text = "";
            OchoxDoce.Text = "";
            NuevexDoce.Text = "";
            DiezxDoce.Text = "";
            OncexDoce.Text = "";
            DocexDoce.Text = "";
        }


        public void UbicarNotasColumnas()
        {
            //Cambia la seccion acordes - Primer Fila

            UnoxUno.Text = Tonica.Text;
            DosxUno.Text = SegundaMenor.Text;
            TresxUno.Text = Segunda.Text;
            CuatroxUno.Text = TerceraMenor.Text;
            CincoxUno.Text = TerceraMay.Text;
            SeisxUno.Text = Cuarta.Text;
            SietexUno.Text = QuintaDIM.Text;
            OchoxUno.Text = Quinta.Text;
            NuevexUno.Text = SextaMenor.Text;
            DiezxUno.Text = Sexta.Text;
            OncexUno.Text = SeptimaMenor.Text;
            DocexUno.Text = Septima.Text;



            UnoxDos.Text = SegundaMenor.Text;
            DosxDos.Text = Segunda.Text;
            TresxDos.Text = TerceraMenor.Text;
            CuatroxDos.Text = TerceraMay.Text;
            CincoxDos.Text = Cuarta.Text;
            SeisxDos.Text = QuintaDIM.Text;
            SietexDos.Text = Quinta.Text;
            OchoxDos.Text = SextaMenor.Text;
            NuevexDos.Text = Sexta.Text;
            DiezxDos.Text = SeptimaMenor.Text;
            OncexDos.Text = Septima.Text;
            DocexDos.Text = Tonica.Text;




            UnoxTres.Text = Segunda.Text;
            DosxTres.Text = TerceraMenor.Text;
            TresxTres.Text = TerceraMay.Text;
            CuatroxTres.Text = Cuarta.Text;
            CincoxTres.Text = QuintaDIM.Text;
            SeisxTres.Text = Quinta.Text;
            SietexTres.Text = SextaMenor.Text;
            OchoxTres.Text = Sexta.Text;
            NuevexTres.Text = SeptimaMenor.Text;
            DiezxTres.Text = Septima.Text;
            OncexTres.Text = Tonica.Text;
            DocexTres.Text = SegundaMenor.Text;




            UnoxCuatro.Text = TerceraMenor.Text;
            DosxCuatro.Text = TerceraMay.Text;
            TresxCuatro.Text = Cuarta.Text;
            CuatroxCuatro.Text = QuintaDIM.Text;
            CincoxCuatro.Text = Quinta.Text;
            SeisxCuatro.Text = SextaMenor.Text;
            SietexCuatro.Text = Sexta.Text;
            OchoxCuatro.Text = SeptimaMenor.Text;
            NuevexCuatro.Text = Septima.Text;
            DiezxCuatro.Text = Tonica.Text;
            OncexCuatro.Text = SegundaMenor.Text;
            DocexCuatro.Text = Segunda.Text;



            UnoxCinco.Text = TerceraMay.Text;
            DosxCinco.Text = Cuarta.Text;
            TresxCinco.Text = QuintaDIM.Text;
            CuatroxCinco.Text = Quinta.Text;
            CincoxCinco.Text = SextaMenor.Text;
            SeisxCinco.Text = Sexta.Text;
            SietexCinco.Text = SeptimaMenor.Text;
            OchoxCinco.Text = Septima.Text;
            NuevexCinco.Text = Tonica.Text;
            DiezxCinco.Text = SegundaMenor.Text;
            OncexCinco.Text = Segunda.Text;
            DocexCinco.Text = TerceraMenor.Text;



            UnoxSeis.Text = Cuarta.Text;
            DosxSeis.Text = QuintaDIM.Text;
            TresxSeis.Text = Quinta.Text;
            CuatroxSeis.Text = SextaMenor.Text;
            CincoxSeis.Text = Sexta.Text;
            SeisxSeis.Text = SeptimaMenor.Text;
            SietexSeis.Text = Septima.Text;
            OchoxSeis.Text = Tonica.Text;
            NuevexSeis.Text = SegundaMenor.Text;
            DiezxSeis.Text = Segunda.Text;
            OncexSeis.Text = TerceraMenor.Text;
            DocexSeis.Text = TerceraMay.Text;



            UnoxSiete.Text = QuintaDIM.Text;
            DosxSiete.Text = Quinta.Text;
            TresxSiete.Text = SextaMenor.Text;
            CuatroxSiete.Text = Sexta.Text;
            CincoxSiete.Text = SeptimaMenor.Text;
            SeisxSiete.Text = Septima.Text;
            SietexSiete1.Text = Tonica.Text;
            OchoxSiete.Text = SegundaMenor.Text;
            NuevexSiete.Text = Segunda.Text;
            DiezxSiete.Text = TerceraMenor.Text;
            OncexSiete.Text = TerceraMay.Text;
            DocexSiete.Text = Cuarta.Text;




            UnoxOcho.Text = Quinta.Text;
            DosxOcho.Text = SextaMenor.Text;
            TresxOcho.Text = Sexta.Text;
            CuatroxOcho.Text = SeptimaMenor.Text;
            CincoxOcho.Text = Septima.Text;
            SeisxOcho.Text = Tonica.Text;
            SietexOcho.Text = SegundaMenor.Text;
            OchoxOcho.Text = Segunda.Text;
            NuevexOcho.Text = TerceraMenor.Text;
            DiezxOcho.Text = TerceraMay.Text;
            OncexOcho.Text = Cuarta.Text;
            DocexOcho.Text = QuintaDIM.Text;



            UnoxNueve.Text = SextaMenor.Text;
            DosxNueve.Text = Sexta.Text;
            TresxNueve.Text = SeptimaMenor.Text;
            CuatroxNueve.Text = Septima.Text;
            CincoxNueve.Text = Tonica.Text;
            SeisxNueve.Text = SegundaMenor.Text;
            SietexNueve.Text = Segunda.Text;
            OchoxNueve.Text = TerceraMenor.Text;
            NuevexNueve.Text = TerceraMay.Text;
            DiezxNueve.Text = Cuarta.Text;
            OncexNueve.Text = QuintaDIM.Text;
            DocexNueve.Text = Quinta.Text;




            UnoxDiez.Text = Sexta.Text;
            DosxDiez.Text = SeptimaMenor.Text;
            TresxDiez.Text = Septima.Text;
            CuatroxDiez.Text = Tonica.Text;
            CincoxDiez.Text = SegundaMenor.Text;
            SeisxDiez.Text = Segunda.Text;
            SietexDiez.Text = TerceraMenor.Text;
            OchoxDiez.Text = TerceraMay.Text;
            NuevexDiez.Text = Cuarta.Text;
            DiezxDiez.Text = QuintaDIM.Text;
            OncexDiez.Text = Quinta.Text;
            DocexDiez.Text = SextaMenor.Text;




            UnoxOnce.Text = SeptimaMenor.Text;
            DosxOnce.Text = Septima.Text;
            TresxOnce.Text = Tonica.Text;
            CuatroxOnce.Text = SegundaMenor.Text;
            CincoxOnce.Text = Segunda.Text;
            SeisxOnce.Text = TerceraMenor.Text;
            SietexOnce.Text = TerceraMay.Text;
            OchoxOnce.Text = Cuarta.Text;
            NuevexOnce.Text = QuintaDIM.Text;
            DiezxOnce.Text = Quinta.Text;
            OncexOnce.Text = SextaMenor.Text;
            DocexOnce.Text = Sexta.Text;



            UnoxDoce.Text = Septima.Text;
            DosxDoce.Text = Tonica.Text;
            TresxDoce.Text = SegundaMenor.Text;
            CuatroxDoce.Text = Segunda.Text;
            CincoxDoce.Text = TerceraMenor.Text;
            SeisxDoce.Text = TerceraMay.Text;
            SietexDoce.Text = Cuarta.Text;
            OchoxDoce.Text = QuintaDIM.Text;
            NuevexDoce.Text = Quinta.Text;
            DiezxDoce.Text = SextaMenor.Text;
            OncexDoce.Text = Sexta.Text;
            DocexDoce.Text = SeptimaMenor.Text;
            //Cambia la seccion acordes - Quinta Fil




         
           
            
            
          
           
            
           
            
           
            
            






        }
        void LimpiarFila1()
        {
            UnoxUno.Text = "";
            UnoxDos.Text = "";
            UnoxTres.Text = "";
            UnoxCuatro.Text = "";
            UnoxCinco.Text = "";
            UnoxSeis.Text = "";
            UnoxSiete.Text = "";
            UnoxOcho.Text = "";
            UnoxNueve.Text = "";
            UnoxDiez.Text = "";
            UnoxOnce.Text = "";
            UnoxDoce.Text = "";
        }
        void LimpiarFila2() {
            DosxUno.Text = "";
            DosxDos.Text = "";
            DosxTres.Text = "";
            DosxCuatro.Text = "";
            DosxCinco.Text = "";
            DosxSeis.Text = "";
            DosxSiete.Text = "";
            DosxOcho.Text = "";
            DosxNueve.Text = "";
            DosxDiez.Text = "";
            DosxOnce.Text = "";
            DosxDoce.Text = "";
        }
        void LimpiarFila3() {
            TresxUno.Text = "";
            TresxDos.Text = "";
            TresxTres.Text = "";
            TresxCuatro.Text = "";
            TresxCinco.Text = "";
            TresxSeis.Text = "";
            TresxSiete.Text = "";
            TresxOcho.Text = "";
            TresxNueve.Text = "";
            TresxDiez.Text = "";
            TresxOnce.Text = "";
            TresxDoce.Text = "";
        }
        void LimpiarFila4()
        {
            CuatroxUno.Text = "";
            CuatroxDos.Text = "";
            CuatroxTres.Text = "";
            CuatroxCuatro.Text = "";
            CuatroxCinco.Text = "";
            CuatroxSeis.Text = "";
            CuatroxSiete.Text = "";
            CuatroxOcho.Text = "";
            CuatroxNueve.Text = "";
            CuatroxDiez.Text = "";
            CuatroxOnce.Text = "";
            CuatroxDoce.Text = "";
        }
        void LimpiarFila5()
        {
            CincoxUno.Text = "";
            CincoxDos.Text = "";
            CincoxTres.Text = "";
            CincoxCuatro.Text = "";
            CincoxCinco.Text = "";
            CincoxSeis.Text = "";
            CincoxSiete.Text = "";
            CincoxOcho.Text = "";
            CincoxNueve.Text = "";
            CincoxDiez.Text = "";
            CincoxOnce.Text = "";
            CincoxDoce.Text = "";
        }
        void LimpiarFila6()
        {
            SeisxUno.Text = "";
            SeisxDos.Text = "";
            SeisxTres.Text = "";
            SeisxCuatro.Text = "";
            SeisxCinco.Text = "";
            SeisxSeis.Text = "";
            SeisxSiete.Text = "";
            SeisxOcho.Text = "";
            SeisxNueve.Text = "";
            SeisxDiez.Text = "";
            SeisxOnce.Text = "";
            SeisxDoce.Text = "";
        }
        void LimpiarFila7()
        {
            SietexUno.Text = "";
            SietexDos.Text = "";
            SietexTres.Text = "";
            SietexCuatro.Text = "";
            SietexCinco.Text = "";
            SietexSeis.Text = "";
            SietexSiete1.Text = "";
            SietexOcho.Text = "";
            SietexNueve.Text = "";
            SietexDiez.Text = "";
            SietexOnce.Text = "";
            SietexDoce.Text = "";
        }
        void LimpiarFila8()
        {
            OchoxUno.Text = "";
            OchoxDos.Text = "";
            OchoxTres.Text = "";
            OchoxCuatro.Text = "";
            OchoxCinco.Text = "";
            OchoxSeis.Text = "";
            OchoxSiete.Text = "";
            OchoxOcho.Text = "";
            OchoxNueve.Text = "";
            OchoxDiez.Text = "";
            OchoxOnce.Text = "";
            OchoxDoce.Text = "";
        }
        void LimpiarFila9()
        {
            NuevexUno.Text = "";
            NuevexDos.Text = "";
            NuevexTres.Text = "";
            NuevexCuatro.Text = "";
            NuevexCinco.Text = "";
            NuevexSeis.Text = "";
            NuevexSiete.Text = "";
            NuevexOcho.Text = "";
            NuevexNueve.Text = "";
            NuevexDiez.Text = "";
            NuevexOnce.Text = "";
            NuevexDoce.Text = "";
        }
        void LimpiarFila10()
        {
            DiezxUno.Text = "";
            DiezxDos.Text = "";
            DiezxTres.Text = "";
            DiezxCuatro.Text = "";
            DiezxCinco.Text = "";
            DiezxSeis.Text = "";
            DiezxSiete.Text = "";
            DiezxOcho.Text = "";
            DiezxNueve.Text = "";
            DiezxDiez.Text = "";
            DiezxOnce.Text = "";
            DiezxDoce.Text = "";
        }
        void LimpiarFila11()
        {
            OncexUno.Text = "";
            OncexDos.Text = "";
            OncexTres.Text = "";
            OncexCuatro.Text = "";
            OncexCinco.Text = "";
            OncexSeis.Text = "";
            OncexSiete.Text = "";
            OncexOcho.Text = "";
            OncexNueve.Text = "";
            OncexDiez.Text = "";
            OncexOnce.Text = "";
            OncexDoce.Text = "";
        }
        void LimpiarFila12()
        {
            DocexUno.Text = "";
            DocexDos.Text = "";
            DocexTres.Text = "";
            DocexCuatro.Text = "";
            DocexCinco.Text = "";
            DocexSeis.Text = "";
            DocexSiete.Text = "";
            DocexOcho.Text = "";
            DocexNueve.Text = "";
            DocexDiez.Text = "";
            DocexOnce.Text = "";
            DocexDoce.Text = "";
        }
        void LimpiarFilas()
        {
            Tonica.Text= "";
            SegundaMenor.Text= "";
            Segunda.Text = "";
            TerceraMenor.Text = "";
            TerceraMay.Text = "";
            Cuarta.Text = "";
            QuintaDIM.Text = "";
            Quinta.Text = "";
            SextaMenor.Text = "";
            Sexta.Text = "";
            SeptimaMenor.Text = "";
            Septima.Text = "";
            //Cambia la seccion acordes - Primer Fila
            UnoxUno.Text = "";
            UnoxDos.Text = "";
            UnoxTres.Text = "";
            UnoxCuatro.Text = "";
            UnoxCinco.Text = "";
            UnoxSeis.Text = "";
            UnoxSiete.Text = "";
            UnoxOcho.Text = "";
            UnoxNueve.Text = "";
            UnoxDiez.Text = "";
            UnoxOnce.Text = "";
            UnoxDoce.Text = "";
            //Cambia la seccion acordes - Segunda Fila
            DosxUno.Text = "";
            DosxDos.Text = "";
            DosxTres.Text = "";
            DosxCuatro.Text = "";
            DosxCinco.Text = "";
            DosxSeis.Text = "";
            DosxSiete.Text = "";
            DosxOcho.Text = "";
            DosxNueve.Text = "";
            DosxDiez.Text = "";
            DosxOnce.Text = "";
            DosxDoce.Text = "";
            //Cambia la seccion acordes - Tercera Fila
            TresxUno.Text = "";
            TresxDos.Text = "";
            TresxTres.Text = "";
            TresxCuatro.Text = "";
            TresxCinco.Text = "";
            TresxSeis.Text = "";
            TresxSiete.Text = "";
            TresxOcho.Text = "";
            TresxNueve.Text = "";
            TresxDiez.Text = "";
            TresxOnce.Text = "";
            TresxDoce.Text = "";

            //Cambia la seccion acordes - Cuarta Fila

            CuatroxUno.Text = "";
            CuatroxDos.Text = "";
            CuatroxTres.Text = "";
            CuatroxCuatro.Text = "";
            CuatroxCinco.Text = "";
            CuatroxSeis.Text = "";
            CuatroxSiete.Text = "";
            CuatroxOcho.Text = "";
            CuatroxNueve.Text = "";
            CuatroxDiez.Text = "";
            CuatroxOnce.Text = "";
            CuatroxDoce.Text = "";


            //Cambia la seccion acordes - Quinta Fila

            CincoxUno.Text = "";
            CincoxDos.Text = "";
            CincoxTres.Text = "";
            CincoxCuatro.Text = "";
            CincoxCinco.Text = "";
            CincoxSeis.Text = "";
            CincoxSiete.Text = "";
            CincoxOcho.Text = "";
            CincoxNueve.Text = "";
            CincoxDiez.Text = "";
            CincoxOnce.Text = "";
            CincoxDoce.Text = "";



            //Cambia la seccion acordes - Sexta Fila


            SeisxUno.Text = "";
            SeisxDos.Text = "";
            SeisxTres.Text = "";
            SeisxCuatro.Text = "";
            SeisxCinco.Text = "";
            SeisxSeis.Text = "";
            SeisxSiete.Text = "";
            SeisxOcho.Text = "";
            SeisxNueve.Text = "";
            SeisxDiez.Text = "";
            SeisxOnce.Text = "";
            SeisxDoce.Text = "";


            //Cambia la seccion acordes - Septima Fila
            SietexUno.Text = "";
            SietexDos.Text = "";
            SietexTres.Text = "";
            SietexCuatro.Text = "";
            SietexCinco.Text = "";
            SietexSeis.Text = "";
            SietexSiete1.Text = "";
            SietexOcho.Text = "";
            SietexNueve.Text = "";
            SietexDiez.Text = "";
            SietexOnce.Text = "";
            SietexDoce.Text = "";




            //Cambia la seccion acordes - Octava Fila
            OchoxUno.Text = "";
            OchoxDos.Text = "";
            OchoxTres.Text = "";
            OchoxCuatro.Text = "";
            OchoxCinco.Text = "";
            OchoxSeis.Text = "";
            OchoxSiete.Text = "";
            OchoxOcho.Text = "";
            OchoxNueve.Text = "";
            OchoxDiez.Text = "";
            OchoxOnce.Text = "";
            OchoxDoce.Text = "";




            //Cambia la seccion acordes - Novena Fila

            NuevexUno.Text = "";
            NuevexDos.Text = "";
            NuevexTres.Text = "";
            NuevexCuatro.Text = "";
            NuevexCinco.Text = "";
            NuevexSeis.Text = "";
            NuevexSiete.Text = "";
            NuevexOcho.Text = "";
            NuevexNueve.Text = "";
            NuevexDiez.Text = "";
            NuevexOnce.Text = "";
            NuevexDoce.Text = "";

            //Cambia la seccion acordes - Decima Fila


            DiezxUno.Text = "";
            DiezxDos.Text = "";
            DiezxTres.Text = "";
            DiezxCuatro.Text = "";
            DiezxCinco.Text = "";
            DiezxSeis.Text = "";
            DiezxSiete.Text = "";
            DiezxOcho.Text = "";
            DiezxNueve.Text = "";
            DiezxDiez.Text = "";
            DiezxOnce.Text = "";
            DiezxDoce.Text = "";
            //Cambia la seccion acordes - Fila Once


            OncexUno.Text = "";
            OncexDos.Text = "";
            OncexTres.Text = "";
            OncexCuatro.Text = "";
            OncexCinco.Text = "";
            OncexSeis.Text = "";
            OncexSiete.Text = "";
            OncexOcho.Text = "";
            OncexNueve.Text = "";
            OncexDiez.Text = "";
            OncexOnce.Text = "";
            OncexDoce.Text = "";

            //Cambia la seccion acordes - Fila Once


            DocexUno.Text = "";
            DocexDos.Text = "";
            DocexTres.Text = "";
            DocexCuatro.Text = "";
            DocexCinco.Text = "";
            DocexSeis.Text = "";
            DocexSiete.Text = "";
            DocexOcho.Text = "";
            DocexNueve.Text = "";
            DocexDiez.Text = "";
            DocexOnce.Text = "";
            DocexDoce.Text = "";

        }

     


        private void Form1_Load(object sender, EventArgs e)
        {

            LimpiarFilas();
       
            cbxNotas.SelectedIndex = 0;
          
         
                   
              
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////
        //SECCION ARMONIA NEGATIVA
        ///////////////////////////////////////////////////////////////////////////////////////
        private void ArmoniaNegativa_CheckedChanged(object sender, EventArgs e)
        {
            if (ArmoniaNegativa.Checked == true)
                MayoresNegativa.Enabled = true;
            MayoresNegativaBemol.Enabled = true;
       




    }
        private void MayoresNegativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Seleccion = cbxNotas.SelectedIndex;
            int Seleccion2 = MayoresNegativa.SelectedIndex;

            //Escalas al cambiar notas en la lista de sostenidos
            Tonica.Text = cbxNotas.Items[Seleccion + Seleccion2 + 7].ToString();//Do
            Segunda.Text = cbxNotas.Items[Seleccion + Seleccion2 + 5].ToString();//Re
            TerceraMay.Text = cbxNotas.Items[Seleccion + Seleccion2 + 3].ToString();//Mi
            Cuarta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 2].ToString();//Fa
            Quinta.Text = cbxNotas.Items[Seleccion + Seleccion2].ToString();//Sol
            Sexta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 10].ToString();//La
            Septima.Text = cbxNotas.Items[Seleccion + Seleccion2 + 8].ToString();//Si
        }
        private void MayoresNegativaBemol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Seleccion = cbxNotas.SelectedIndex;
            int Seleccion2 = MayoresNegativaBemol.SelectedIndex;

            //Escalas al cambiar notas en la lista de sostenidos
            Tonica.Text = cbxNotas.Items[Seleccion + Seleccion2 + 31].ToString();//Do
            Segunda.Text = cbxNotas.Items[Seleccion + Seleccion2 + 29].ToString();//Re
            TerceraMay.Text = cbxNotas.Items[Seleccion + Seleccion2 + 27].ToString();//Mi
            Cuarta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 26].ToString();//Fa
            Quinta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 24].ToString();//Sol
            Sexta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 34].ToString();//La
            Septima.Text = cbxNotas.Items[Seleccion + Seleccion2 + 32].ToString();//Si
        }


        /// ///////////////////////////////////////////////////////////////////////////////////////
        //SECCION ARMONIA NEGATIVA
        ///////////////////////////////////////////////////////////////////////////////////////
        ///
        private void MelodicaBemol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Seleccion3 = cbxNotas.SelectedIndex;
            int Seleccion = MelodicaBemol.SelectedIndex;

            //Escalas al cambiar notas en Bemoles
            Tonica.Text = cbxNotas.Items[Seleccion3 + Seleccion + 24].ToString();//Primera
            Segunda.Text = cbxNotas.Items[Seleccion3 + Seleccion + 26].ToString();//Segunda
            TerceraMenor.Text = cbxNotas.Items[Seleccion3 + Seleccion + 27].ToString();//Tercera
            Cuarta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 29].ToString();//Cuarta
            Quinta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 31].ToString();//Quinta
            Sexta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 33].ToString();//Sexta
            Septima.Text = cbxNotas.Items[Seleccion3 + Seleccion + 35].ToString();//Septima

        }
        private void MelodicaSostenido_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Seleccion = cbxNotas.SelectedIndex;
            int Seleccion2 = MelodicaSostenido.SelectedIndex;

            //Escalas al cambiar notas en la lista de sostenidos
            Tonica.Text = cbxNotas.Items[Seleccion + Seleccion2].ToString();//Do
            Segunda.Text = cbxNotas.Items[Seleccion + Seleccion2 + 2].ToString();//Do
            TerceraMenor.Text = cbxNotas.Items[Seleccion + Seleccion2 + 3].ToString();//Do
            Cuarta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 5].ToString();//Do
            Quinta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 7].ToString();//Do
            Sexta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 9].ToString();//Do
            Septima.Text = cbxNotas.Items[Seleccion + Seleccion2 + 11].ToString();//Do
        }
        private void ArmonicaSostenido2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Seleccion = cbxNotas.SelectedIndex;
            int Seleccion2 = ArmonicaSostenido2.SelectedIndex;

            //Escalas al cambiar notas en la lista de sostenidos
            Tonica.Text = cbxNotas.Items[Seleccion + Seleccion2].ToString();//Do
            Segunda.Text = cbxNotas.Items[Seleccion + Seleccion2 + 2].ToString();//Do
            TerceraMenor.Text = cbxNotas.Items[Seleccion + Seleccion2 + 3].ToString();//Do
            Cuarta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 5].ToString();//Do
            Quinta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 7].ToString();//Do
            SextaMenor.Text = cbxNotas.Items[Seleccion + Seleccion2 + 8].ToString();//Do
            Septima.Text = cbxNotas.Items[Seleccion + Seleccion2 + 11].ToString();//Do
        }
        private void ArmonicaBemol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Seleccion3 = cbxNotas.SelectedIndex;
            int Seleccion = ArmonicaBemol.SelectedIndex;

            //Escalas al cambiar notas en Bemoles
            Tonica.Text = cbxNotas.Items[Seleccion3 + Seleccion + 24].ToString();//Primera
            Segunda.Text = cbxNotas.Items[Seleccion3 + Seleccion + 26].ToString();//Segunda
            TerceraMenor.Text = cbxNotas.Items[Seleccion3 + Seleccion + 27].ToString();//Tercera
            Cuarta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 29].ToString();//Cuarta
            Quinta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 31].ToString();//Quinta
            SextaMenor.Text = cbxNotas.Items[Seleccion3 + Seleccion + 32].ToString();//Sexta
            Septima.Text = cbxNotas.Items[Seleccion3 + Seleccion + 35].ToString();//Septima
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            int Seleccion = cbxNotas.SelectedIndex;
            int Seleccion2 = Sostenidos.SelectedIndex;
           
            //Escalas al cambiar notas en la lista de sostenidos
            Tonica.Text = cbxNotas.Items[Seleccion + Seleccion2].ToString();//Do
            Segunda.Text = cbxNotas.Items[Seleccion + Seleccion2 + 2].ToString();//Do
            TerceraMay.Text = cbxNotas.Items[Seleccion + Seleccion2 + 4].ToString();//Do
            Cuarta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 5].ToString();//Do
            Quinta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 7].ToString();//Do
            Sexta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 9].ToString();//Do
            Septima.Text = cbxNotas.Items[Seleccion + Seleccion2 + 11].ToString();//Do
        }
        private void Bemoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Seleccion3 = cbxNotas.SelectedIndex;
            int Seleccion = Bemoles.SelectedIndex;

            //Escalas al cambiar notas en Bemoles
            Tonica.Text = cbxNotas.Items[Seleccion3 + Seleccion + 24].ToString();//Primera
            Segunda.Text = cbxNotas.Items[Seleccion3 + Seleccion + 26].ToString();//Segunda
            TerceraMay.Text = cbxNotas.Items[Seleccion3 + Seleccion + 28].ToString();//Tercera
            Cuarta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 29].ToString();//Cuarta
            Quinta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 31].ToString();//Quinta
            Sexta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 33].ToString();//Sexta
            Septima.Text = cbxNotas.Items[Seleccion3  +Seleccion + 35].ToString();//Septima

        }
        private void EscalasMenores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Seleccion = cbxNotas.SelectedIndex;
            int Seleccion2 = EscalasMenores.SelectedIndex;

            //Escalas al cambiar notas en la lista de sostenidos
            Tonica.Text = cbxNotas.Items[Seleccion + Seleccion2].ToString();//Do
            Segunda.Text = cbxNotas.Items[Seleccion + Seleccion2 + 2].ToString();//RE
            TerceraMenor.Text = cbxNotas.Items[Seleccion + Seleccion2 + 3].ToString();//MIB
            Cuarta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 5].ToString();//FA
            Quinta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 7].ToString();//SOL
            SextaMenor.Text = cbxNotas.Items[Seleccion + Seleccion2 + 8].ToString();//LAB
            SeptimaMenor.Text = cbxNotas.Items[Seleccion + Seleccion2 + 10].ToString();//SIB
        }

        private void EscalasMenoresb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Seleccion3 = cbxNotas.SelectedIndex;
            int Seleccion = EscalasMenoresb.SelectedIndex;

            //Escalas al cambiar notas en Bemoles
            Tonica.Text = cbxNotas.Items[Seleccion3 + Seleccion + 24].ToString();//Primera
            Segunda.Text = cbxNotas.Items[Seleccion3 + Seleccion + 26].ToString();//Segunda
            TerceraMenor.Text = cbxNotas.Items[Seleccion3 + Seleccion + 27].ToString();//Tercera
            Cuarta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 29].ToString();//Cuarta
            Quinta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 31].ToString();//Quinta
            SextaMenor.Text = cbxNotas.Items[Seleccion3 + Seleccion + 32].ToString();//Sexta
            SeptimaMenor.Text = cbxNotas.Items[Seleccion3 + Seleccion + 34].ToString();//Septima
        }

        private void Tonica_TextChanged(object sender, EventArgs e)
        {
            UbicarNotas();
          
        }

        private void Segunda_TextChanged(object sender, EventArgs e)
        {
            UbicarNotas();
        }

        private void Tercera_TextChanged(object sender, EventArgs e)
        {
            UbicarNotas();
        }

        private void Cuarta_TextChanged(object sender, EventArgs e)
        {
            UbicarNotas();
        }

        private void Quinta_TextChanged(object sender, EventArgs e)
        {
            UbicarNotas();
        }

        private void Sexta_TextChanged(object sender, EventArgs e)
        {
            UbicarNotas();
        }

        private void Septima_TextChanged(object sender, EventArgs e)
        {
            UbicarNotas();
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
          Application.Exit();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Guardar_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            sfd.Filter = "Documento|*.txt";
            sfd.Title = "Guardar";
            sfd.InitialDirectory = @"C:\";
            sfd.FileName = "H1 ";
            var resultado = sfd.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamWriter escribir = new(sfd.FileName);
                foreach (object line in Tonica.Lines)
                {
                    escribir.WriteLine(line);
                }
                foreach (object line in SegundaMenor.Lines)
                {
                    escribir.WriteLine(line);
                }
                foreach (object line in Segunda.Lines)
                {
                    escribir.WriteLine(line);
                }
                foreach (object line in TerceraMenor.Lines)
                {
                    escribir.WriteLine(line);
                }
                foreach (object line in TerceraMay.Lines)
                {
                    escribir.WriteLine(line);
                }
                foreach (object line in Cuarta.Lines)
                {
                    escribir.WriteLine(line);
                }
                foreach (object line in QuintaDIM.Lines)
                {
                    escribir.WriteLine(line);
                }
                foreach (object line in Quinta.Lines)
                {
                    escribir.WriteLine(line);
                }
                foreach (object line in SextaMenor.Lines)
                {
                    escribir.WriteLine(line);
                }
                foreach (object line in Sexta.Lines)
                {
                    escribir.WriteLine(line);
                }
                foreach (object line in SeptimaMenor.Lines)
                {
                    escribir.WriteLine(line);
                }
                foreach (object line in Septima.Lines)
                {
                    escribir.WriteLine(line);
                }

                escribir.Close();
            }


        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new();
            Abrir.Filter = "Documento|*.txt";
            Abrir.Title = "Cargar";
            Abrir.InitialDirectory = @"C:\";
            Abrir.FileName = "H1 ";
            var resultado = Abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamReader leer = new(Abrir.FileName);
                Tonica.Text = leer.ReadLine();
                SegundaMenor.Text = leer.ReadLine();
                Segunda.Text = leer.ReadLine();
                TerceraMenor.Text = leer.ReadLine();
                TerceraMay.Text = leer.ReadLine();
                Cuarta.Text = leer.ReadLine();
                QuintaDIM.Text = leer.ReadLine();
                Quinta.Text = leer.ReadLine();
                SextaMenor.Text = leer.ReadLine();
                Sexta.Text = leer.ReadLine();
                SeptimaMenor.Text = leer.ReadLine();
                Septima.Text = leer.ReadLine();
                leer.Close();
            }
        }

       

        private void SegundaMenor_TextChanged(object sender, EventArgs e)
        {
            UbicarNotas();
        }

        private void SextaMenor_TextChanged(object sender, EventArgs e)
        {
            UbicarNotas();
        }

        private void QuintaDIM_TextChanged(object sender, EventArgs e)
        {
            UbicarNotas();
        }

        private void TerceraMenor_TextChanged(object sender, EventArgs e)
        {
            UbicarNotas();
        }

        private void SeptimaMenor_TextChanged(object sender, EventArgs e)
        {
            UbicarNotas();
        }

        private void LimpiarPantalla_Click(object sender, EventArgs e)
        {
            LimpiarFilas();
        }

      
        private void Septima_Menor_Click(object sender, EventArgs e)
        {
            LimpiarColumna11();
        }

        private void Sexta_Mayor_Click(object sender, EventArgs e)
        {
            LimpiarColumna10();
        }

        private void Sexta_Menor_Click(object sender, EventArgs e)
        {
            LimpiarColumna9();
        }

        private void Quinta__Click(object sender, EventArgs e)
        {
            LimpiarColumna8();
        }

        private void QuintoDisminuido_Click(object sender, EventArgs e)
        {
            LimpiarColumna7();
        }

        private void CuartoSuspendido_Click(object sender, EventArgs e)
        {
            LimpiarColumna6();
        }

        private void TerceraMayor_Click(object sender, EventArgs e)
        {
            LimpiarColumna5();
        }

        private void Tercera_Menor_Click(object sender, EventArgs e)
        {
            LimpiarColumna4();
        }

        private void NovenaMayor_Click(object sender, EventArgs e)
        {
            LimpiarColumna3();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LimpiarColumna2();
        }

        private void Tonica__Click(object sender, EventArgs e)
        {
            LimpiarColumna1();
        }

        private void Septima_Mayor_Click(object sender, EventArgs e)
        {
            LimpiarColumna12();
        }

        private void Tonica__DoubleClick(object sender, EventArgs e)
        {
            Columna1();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            Columna2();
        }

        private void NovenaMayor_DoubleClick(object sender, EventArgs e)
        {
            Columna3();
        }

        private void Tercera_Menor_DoubleClick(object sender, EventArgs e)
        {
            Columna4();
        }

        private void TerceraMayor_DoubleClick(object sender, EventArgs e)
        {
            Columna5();
        }

        private void CuartoSuspendido_DoubleClick(object sender, EventArgs e)
        {
            Columna6();
        }

        private void QuintoDisminuido_DoubleClick(object sender, EventArgs e)
        {
            Columna7();
        }

        private void Quinta__DoubleClick(object sender, EventArgs e)
        {
            Columna8();
        }

        private void Sexta_Menor_DoubleClick(object sender, EventArgs e)
        {
           Columna9();
        }

        private void Septima_Mayor_DoubleClick(object sender, EventArgs e)
        {
            Columna12();
        }

        private void Septima_Menor_DoubleClick(object sender, EventArgs e)
        {
            Columna11();
        }

        private void Sexta_Mayor_DoubleClick(object sender, EventArgs e)
        {
            Columna10();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            LimpiarFila1();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            LimpiarFila2();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            LimpiarFila3();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            LimpiarFila4();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            LimpiarFila5();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            LimpiarFila6();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            LimpiarFila7();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            LimpiarFila8();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            LimpiarFila9();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            LimpiarFila10();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            LimpiarFila11();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            LimpiarFila12();
        }

        private void label34_DoubleClick(object sender, EventArgs e)
        {
            MostrarFila1();
        }

        private void label33_DoubleClick(object sender, EventArgs e)
        {
            MostrarFila2();
        }

        private void label32_DoubleClick(object sender, EventArgs e)
        {
            MostrarFila3();
        }

        private void label31_DoubleClick(object sender, EventArgs e)
        {
            MostrarFila4();
        }

        private void label30_DoubleClick(object sender, EventArgs e)
        {
            MostrarFila5();
        }

        private void label28_DoubleClick(object sender, EventArgs e)
        {
            MostrarFila6();
        }

        private void label27_DoubleClick(object sender, EventArgs e)
        {
            MostrarFila7();
        }

        private void label26_DoubleClick(object sender, EventArgs e)
        {
            MostrarFila8();
        }

        private void label25_DoubleClick(object sender, EventArgs e)
        {
            MostrarFila9();
        }

        private void label24_DoubleClick(object sender, EventArgs e)
        {
            MostrarFila10();
        }

        private void label23_DoubleClick(object sender, EventArgs e)
        {
            MostrarFila11();
        }

        private void label22_DoubleClick(object sender, EventArgs e)
        {
            MostrarFila12();
        }
        private void Circulo_Click(object sender, EventArgs e)
        {
            Circulo F2 = new Circulo();
            F2.Show();

        }
        private void Guitarra_Click(object sender, EventArgs e)
        {
            Guitarra F3 = new Guitarra();
            F3.Show();
        }

        private void Ukelele_Click(object sender, EventArgs e)
        {
            Ukelele F4 = new Ukelele();
            F4.Show();
        }

        private void Violín_Click(object sender, EventArgs e)
        {
            Violín F5 = new Violín();
            F5.Show();
        }

        private void Armonizador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

     
    }


}
