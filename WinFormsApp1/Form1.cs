using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Seleccion = cbxNotas.SelectedIndex;
            int Seleccion2 = Sostenidos.SelectedIndex;
            int Seleccion3 = Bemoles.SelectedIndex;
            //Escalas al cambiar notas en la lista de sostenidos
            Tonica.Text = cbxNotas.Items[Seleccion + Seleccion2].ToString();//Do
            Segunda.Text = cbxNotas.Items[Seleccion + Seleccion2 +2].ToString();//Do
            Tercera.Text = cbxNotas.Items[Seleccion + Seleccion2 + 4].ToString();//Do
            Cuarta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 5].ToString();//Do
            Quinta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 7].ToString();//Do
            Sexta.Text = cbxNotas.Items[Seleccion + Seleccion2 + 9].ToString();//Do
            Septima.Text = cbxNotas.Items[Seleccion + Seleccion2 +11].ToString();//Do
  //Cambia la seccion acordes - Primer Fila

            label4.Text = Tonica.Text;
            label5.Text = Tercera.Text;
            label6.Text = Quinta.Text;
            label7.Text = Septima.Text;
            label8.Text = Segunda.Text;
            label9.Text = Cuarta.Text;
            //Segunda Fila
            label10.Text = Segunda.Text;
            label11.Text = Cuarta.Text;
            label12.Text = Sexta.Text;
            label13.Text = Tonica.Text;
            label14.Text = Tercera.Text;
            label15.Text = Quinta.Text;
            //Tercera Fila
            label16.Text = Tercera.Text;
            label17.Text = Quinta.Text;
            label18.Text = Septima.Text;
            label19.Text = Segunda.Text;
            label20.Text = Cuarta.Text;
            label21.Text = Sexta.Text;
            //Cuarta Fila
            label22.Text = Cuarta.Text;
            label23.Text = Sexta.Text;
            label24.Text = Tonica.Text;
            label26.Text = Tercera.Text;
            label25.Text = Quinta.Text;
            label27.Text = Septima.Text;
            //Quinta Fila
            label28.Text = Quinta.Text;
            label29.Text = Septima.Text;
            label30.Text = Segunda.Text;
            label31.Text = Cuarta.Text;
            label32.Text = Sexta.Text;
            label33.Text = Tonica.Text;
            //Sexta Fila
            label34.Text = Sexta.Text;
            label35.Text = Tonica.Text;
            label36.Text = Tercera.Text;
            label37.Text = Quinta.Text;
            label38.Text = Septima.Text;
            label39.Text = Segunda.Text;
            //Septima Fila
            label40.Text = Septima.Text;
            label41.Text = Segunda.Text;
            label42.Text = Cuarta.Text;
            label43.Text = Sexta.Text;
            label44.Text = Tonica.Text;
            label45.Text = Tercera.Text;
        }

        



        

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxNotas.SelectedIndex = 0;

            //Cambia la seccion acordes - Primer Fila
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            //Segunda Fila
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            //Tercera Fila
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            //Cuarta Fila
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
            label26.Text = "";
            label25.Text = "";
            label27.Text = "";
            //Quinta Fila
            label28.Text = "";
            label29.Text = "";
            label30.Text = "";
            label31.Text = "";
            label32.Text = "";
            label33.Text = "";
            //Sexta Fila
            label34.Text = "";
            label35.Text = "";
            label36.Text = "";
            label37.Text = "";
            label38.Text = "";
            label39.Text = "";
            //Septima Fila
            label40.Text = "";
            label41.Text = "";
            label42.Text = "";
            label43.Text = "";
            label44.Text = "";
            label45.Text = "";

        }

        private void Bemoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Seleccion3 = cbxNotas.SelectedIndex;
            int Seleccion = Bemoles.SelectedIndex;

            //Escalas al cambiar notas en Bemoles
            Tonica.Text = cbxNotas.Items[Seleccion3 + Seleccion + 24].ToString();//Primera
            Segunda.Text = cbxNotas.Items[Seleccion3 + Seleccion + 26].ToString();//Segunda
            Tercera.Text = cbxNotas.Items[Seleccion3 + Seleccion + 28].ToString();//Tercera
            Cuarta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 29].ToString();//Cuarta
            Quinta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 31].ToString();//Quinta
            Sexta.Text = cbxNotas.Items[Seleccion3 + Seleccion + 33].ToString();//Sexta
            Septima.Text = cbxNotas.Items[Seleccion3  +Seleccion + 35].ToString();//Septima

            //Cambia la seccion acordes - Primer Fila
            label4.Text = Tonica.Text;
            label5.Text = Tercera.Text;
            label6.Text = Quinta.Text;
            label7.Text = Septima.Text;
            label8.Text = Segunda.Text;
            label9.Text = Cuarta.Text;
            //Segunda Fila
            label10.Text = Segunda.Text;
            label11.Text = Cuarta.Text;
            label12.Text = Sexta.Text;
            label13.Text = Tonica.Text;
            label14.Text = Tercera.Text;
            label15.Text = Quinta.Text;
            //Tercera Fila
            label16.Text = Tercera.Text;
            label17.Text = Quinta.Text;
            label18.Text = Septima.Text;
            label19.Text = Segunda.Text;
            label20.Text = Cuarta.Text;
            label21.Text = Sexta.Text;
            //Cuarta Fila
            label22.Text = Cuarta.Text;
            label23.Text = Sexta.Text;
            label24.Text = Tonica.Text;
            label26.Text = Tercera.Text;
            label25.Text = Quinta.Text;
            label27.Text = Septima.Text;
            //Quinta Fila
            label28.Text = Quinta.Text;
            label29.Text = Septima.Text;
            label30.Text = Segunda.Text;
            label31.Text = Cuarta.Text;
            label32.Text = Sexta.Text;
            label33.Text = Tonica.Text;
            //Sexta Fila
            label34.Text = Sexta.Text;
            label35.Text = Tonica.Text;
            label36.Text = Tercera.Text;
            label37.Text = Quinta.Text;
            label38.Text = Septima.Text;
            label39.Text = Segunda.Text;
            //Septima Fila
            label40.Text = Septima.Text;
            label41.Text = Segunda.Text;
            label42.Text = Cuarta.Text;
            label43.Text = Sexta.Text;
            label44.Text = Tonica.Text;
            label45.Text = Tercera.Text;
        }

        private void Tonica_TextChanged(object sender, EventArgs e)
        {
            //Cambia la seccion acordes - Primer Fila
            label4.Text = Tonica.Text;
            label5.Text = Tercera.Text;
            label6.Text = Quinta.Text;
            label7.Text = Septima.Text;
            label8.Text = Segunda.Text;
            label9.Text = Cuarta.Text;
            //Segunda Fila
            label10.Text = Segunda.Text;
            label11.Text = Cuarta.Text;
            label12.Text = Sexta.Text;
            label13.Text = Tonica.Text;
            label14.Text = Tercera.Text;
            label15.Text = Quinta.Text;
            //Tercera Fila
            label16.Text = Tercera.Text;
            label17.Text = Quinta.Text;
            label18.Text = Septima.Text;
            label19.Text = Segunda.Text;
            label20.Text = Cuarta.Text;
            label21.Text = Sexta.Text;
            //Cuarta Fila
            label22.Text = Cuarta.Text;
            label23.Text = Sexta.Text;
            label24.Text = Tonica.Text;
            label26.Text = Tercera.Text;
            label25.Text = Quinta.Text;
            label27.Text = Septima.Text;
            //Quinta Fila
            label28.Text = Quinta.Text;
            label29.Text = Septima.Text;
            label30.Text = Segunda.Text;
            label31.Text = Cuarta.Text;
            label32.Text = Sexta.Text;
            label33.Text = Tonica.Text;
            //Sexta Fila
            label34.Text = Sexta.Text;
            label35.Text = Tonica.Text;
            label36.Text = Tercera.Text;
            label37.Text = Quinta.Text;
            label38.Text = Septima.Text;
            label39.Text = Segunda.Text;
            //Septima Fila
            label40.Text = Septima.Text;
            label41.Text = Segunda.Text;
            label42.Text = Cuarta.Text;
            label43.Text = Sexta.Text;
            label44.Text = Tonica.Text;
            label45.Text = Tercera.Text;
        }

        private void Segunda_TextChanged(object sender, EventArgs e)
        {
            //Cambia la seccion acordes - Primer Fila
            label4.Text = Tonica.Text;
            label5.Text = Tercera.Text;
            label6.Text = Quinta.Text;
            label7.Text = Septima.Text;
            label8.Text = Segunda.Text;
            label9.Text = Cuarta.Text;
            //Segunda Fila
            label10.Text = Segunda.Text;
            label11.Text = Cuarta.Text;
            label12.Text = Sexta.Text;
            label13.Text = Tonica.Text;
            label14.Text = Tercera.Text;
            label15.Text = Quinta.Text;
            //Tercera Fila
            label16.Text = Tercera.Text;
            label17.Text = Quinta.Text;
            label18.Text = Septima.Text;
            label19.Text = Segunda.Text;
            label20.Text = Cuarta.Text;
            label21.Text = Sexta.Text;
            //Cuarta Fila
            label22.Text = Cuarta.Text;
            label23.Text = Sexta.Text;
            label24.Text = Tonica.Text;
            label26.Text = Tercera.Text;
            label25.Text = Quinta.Text;
            label27.Text = Septima.Text;
            //Quinta Fila
            label28.Text = Quinta.Text;
            label29.Text = Septima.Text;
            label30.Text = Segunda.Text;
            label31.Text = Cuarta.Text;
            label32.Text = Sexta.Text;
            label33.Text = Tonica.Text;
            //Sexta Fila
            label34.Text = Sexta.Text;
            label35.Text = Tonica.Text;
            label36.Text = Tercera.Text;
            label37.Text = Quinta.Text;
            label38.Text = Septima.Text;
            label39.Text = Segunda.Text;
            //Septima Fila
            label40.Text = Septima.Text;
            label41.Text = Segunda.Text;
            label42.Text = Cuarta.Text;
            label43.Text = Sexta.Text;
            label44.Text = Tonica.Text;
            label45.Text = Tercera.Text;
        }

        private void Tercera_TextChanged(object sender, EventArgs e)
        {
            //Cambia la seccion acordes - Primer Fila
            label4.Text = Tonica.Text;
            label5.Text = Tercera.Text;
            label6.Text = Quinta.Text;
            label7.Text = Septima.Text;
            label8.Text = Segunda.Text;
            label9.Text = Cuarta.Text;
            //Segunda Fila
            label10.Text = Segunda.Text;
            label11.Text = Cuarta.Text;
            label12.Text = Sexta.Text;
            label13.Text = Tonica.Text;
            label14.Text = Tercera.Text;
            label15.Text = Quinta.Text;
            //Tercera Fila
            label16.Text = Tercera.Text;
            label17.Text = Quinta.Text;
            label18.Text = Septima.Text;
            label19.Text = Segunda.Text;
            label20.Text = Cuarta.Text;
            label21.Text = Sexta.Text;
            //Cuarta Fila
            label22.Text = Cuarta.Text;
            label23.Text = Sexta.Text;
            label24.Text = Tonica.Text;
            label26.Text = Tercera.Text;
            label25.Text = Quinta.Text;
            label27.Text = Septima.Text;
            //Quinta Fila
            label28.Text = Quinta.Text;
            label29.Text = Septima.Text;
            label30.Text = Segunda.Text;
            label31.Text = Cuarta.Text;
            label32.Text = Sexta.Text;
            label33.Text = Tonica.Text;
            //Sexta Fila
            label34.Text = Sexta.Text;
            label35.Text = Tonica.Text;
            label36.Text = Tercera.Text;
            label37.Text = Quinta.Text;
            label38.Text = Septima.Text;
            label39.Text = Segunda.Text;
            //Septima Fila
            label40.Text = Septima.Text;
            label41.Text = Segunda.Text;
            label42.Text = Cuarta.Text;
            label43.Text = Sexta.Text;
            label44.Text = Tonica.Text;
            label45.Text = Tercera.Text;
        }

        private void Cuarta_TextChanged(object sender, EventArgs e)
        {
            //Cambia la seccion acordes - Primer Fila
            label4.Text = Tonica.Text;
            label5.Text = Tercera.Text;
            label6.Text = Quinta.Text;
            label7.Text = Septima.Text;
            label8.Text = Segunda.Text;
            label9.Text = Cuarta.Text;
            //Segunda Fila
            label10.Text = Segunda.Text;
            label11.Text = Cuarta.Text;
            label12.Text = Sexta.Text;
            label13.Text = Tonica.Text;
            label14.Text = Tercera.Text;
            label15.Text = Quinta.Text;
            //Tercera Fila
            label16.Text = Tercera.Text;
            label17.Text = Quinta.Text;
            label18.Text = Septima.Text;
            label19.Text = Segunda.Text;
            label20.Text = Cuarta.Text;
            label21.Text = Sexta.Text;
            //Cuarta Fila
            label22.Text = Cuarta.Text;
            label23.Text = Sexta.Text;
            label24.Text = Tonica.Text;
            label26.Text = Tercera.Text;
            label25.Text = Quinta.Text;
            label27.Text = Septima.Text;
            //Quinta Fila
            label28.Text = Quinta.Text;
            label29.Text = Septima.Text;
            label30.Text = Segunda.Text;
            label31.Text = Cuarta.Text;
            label32.Text = Sexta.Text;
            label33.Text = Tonica.Text;
            //Sexta Fila
            label34.Text = Sexta.Text;
            label35.Text = Tonica.Text;
            label36.Text = Tercera.Text;
            label37.Text = Quinta.Text;
            label38.Text = Septima.Text;
            label39.Text = Segunda.Text;
            //Septima Fila
            label40.Text = Septima.Text;
            label41.Text = Segunda.Text;
            label42.Text = Cuarta.Text;
            label43.Text = Sexta.Text;
            label44.Text = Tonica.Text;
            label45.Text = Tercera.Text;
        }

        private void Quinta_TextChanged(object sender, EventArgs e)
        {
            //Cambia la seccion acordes - Primer Fila
            label4.Text = Tonica.Text;
            label5.Text = Tercera.Text;
            label6.Text = Quinta.Text;
            label7.Text = Septima.Text;
            label8.Text = Segunda.Text;
            label9.Text = Cuarta.Text;
            //Segunda Fila
            label10.Text = Segunda.Text;
            label11.Text = Cuarta.Text;
            label12.Text = Sexta.Text;
            label13.Text = Tonica.Text;
            label14.Text = Tercera.Text;
            label15.Text = Quinta.Text;
            //Tercera Fila
            label16.Text = Tercera.Text;
            label17.Text = Quinta.Text;
            label18.Text = Septima.Text;
            label19.Text = Segunda.Text;
            label20.Text = Cuarta.Text;
            label21.Text = Sexta.Text;
            //Cuarta Fila
            label22.Text = Cuarta.Text;
            label23.Text = Sexta.Text;
            label24.Text = Tonica.Text;
            label26.Text = Tercera.Text;
            label25.Text = Quinta.Text;
            label27.Text = Septima.Text;
            //Quinta Fila
            label28.Text = Quinta.Text;
            label29.Text = Septima.Text;
            label30.Text = Segunda.Text;
            label31.Text = Cuarta.Text;
            label32.Text = Sexta.Text;
            label33.Text = Tonica.Text;
            //Sexta Fila
            label34.Text = Sexta.Text;
            label35.Text = Tonica.Text;
            label36.Text = Tercera.Text;
            label37.Text = Quinta.Text;
            label38.Text = Septima.Text;
            label39.Text = Segunda.Text;
            //Septima Fila
            label40.Text = Septima.Text;
            label41.Text = Segunda.Text;
            label42.Text = Cuarta.Text;
            label43.Text = Sexta.Text;
            label44.Text = Tonica.Text;
            label45.Text = Tercera.Text;
        }

        private void Sexta_TextChanged(object sender, EventArgs e)
        {
            //Cambia la seccion acordes - Primer Fila
            label4.Text = Tonica.Text;
            label5.Text = Tercera.Text;
            label6.Text = Quinta.Text;
            label7.Text = Septima.Text;
            label8.Text = Segunda.Text;
            label9.Text = Cuarta.Text;
            //Segunda Fila
            label10.Text = Segunda.Text;
            label11.Text = Cuarta.Text;
            label12.Text = Sexta.Text;
            label13.Text = Tonica.Text;
            label14.Text = Tercera.Text;
            label15.Text = Quinta.Text;
            //Tercera Fila
            label16.Text = Tercera.Text;
            label17.Text = Quinta.Text;
            label18.Text = Septima.Text;
            label19.Text = Segunda.Text;
            label20.Text = Cuarta.Text;
            label21.Text = Sexta.Text;
            //Cuarta Fila
            label22.Text = Cuarta.Text;
            label23.Text = Sexta.Text;
            label24.Text = Tonica.Text;
            label26.Text = Tercera.Text;
            label25.Text = Quinta.Text;
            label27.Text = Septima.Text;
            //Quinta Fila
            label28.Text = Quinta.Text;
            label29.Text = Septima.Text;
            label30.Text = Segunda.Text;
            label31.Text = Cuarta.Text;
            label32.Text = Sexta.Text;
            label33.Text = Tonica.Text;
            //Sexta Fila
            label34.Text = Sexta.Text;
            label35.Text = Tonica.Text;
            label36.Text = Tercera.Text;
            label37.Text = Quinta.Text;
            label38.Text = Septima.Text;
            label39.Text = Segunda.Text;
            //Septima Fila
            label40.Text = Septima.Text;
            label41.Text = Segunda.Text;
            label42.Text = Cuarta.Text;
            label43.Text = Sexta.Text;
            label44.Text = Tonica.Text;
            label45.Text = Tercera.Text;
        }

        private void Septima_TextChanged(object sender, EventArgs e)
        {
            //Cambia la seccion acordes - Primer Fila
            label4.Text = Tonica.Text;
            label5.Text = Tercera.Text;
            label6.Text = Quinta.Text;
            label7.Text = Septima.Text;
            label8.Text = Segunda.Text;
            label9.Text = Cuarta.Text;
            //Segunda Fila
            label10.Text = Segunda.Text;
            label11.Text = Cuarta.Text;
            label12.Text = Sexta.Text;
            label13.Text = Tonica.Text;
            label14.Text = Tercera.Text;
            label15.Text = Quinta.Text;
            //Tercera Fila
            label16.Text = Tercera.Text;
            label17.Text = Quinta.Text;
            label18.Text = Septima.Text;
            label19.Text = Segunda.Text;
            label20.Text = Cuarta.Text;
            label21.Text = Sexta.Text;
            //Cuarta Fila
            label22.Text = Cuarta.Text;
            label23.Text = Sexta.Text;
            label24.Text = Tonica.Text;
            label26.Text = Tercera.Text;
            label25.Text = Quinta.Text;
            label27.Text = Septima.Text;
            //Quinta Fila
            label28.Text = Quinta.Text;
            label29.Text = Septima.Text;
            label30.Text = Segunda.Text;
            label31.Text = Cuarta.Text;
            label32.Text = Sexta.Text;
            label33.Text = Tonica.Text;
            //Sexta Fila
            label34.Text = Sexta.Text;
            label35.Text = Tonica.Text;
            label36.Text = Tercera.Text;
            label37.Text = Quinta.Text;
            label38.Text = Septima.Text;
            label39.Text = Segunda.Text;
            //Septima Fila
            label40.Text = Septima.Text;
            label41.Text = Segunda.Text;
            label42.Text = Cuarta.Text;
            label43.Text = Sexta.Text;
            label44.Text = Tonica.Text;
            label45.Text = Tercera.Text;
        }
    }
    

}
