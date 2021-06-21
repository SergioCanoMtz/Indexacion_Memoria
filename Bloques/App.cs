using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Bloques
{
    public partial class App : Form
    {
        String conexion = "Data Source=.\\SQLEXPRESS; Initial Catalog=bloque; Integrated Security = True";
        public App()
        {
            InitializeComponent();
        }


        private void App_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        int primerbloque = 0;
        int comp = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textTam.Text == "") {
                MessageBox.Show("Por ingresa los valores correspondientes");
            } else {
                if (Convert.ToInt32(textTam.Text) > 100 || Convert.ToInt32(textTam.Text) < 1) {
                    MessageBox.Show("Por favor ingresa un tamaño entre 1 y 100");
                    textTam.Text = "";
                } else {
                    Random r = new Random();
                    int i = 1;
                    do {
                        primerbloque = r.Next(1, 26);
                        comp = consultarBloque(primerbloque);
                       // MessageBox.Show(Convert.ToString(primerbloque));
                        i++;
                    } while (primerbloque == comp);
                    insertar_bloque(primerbloque, textName.Text);
                    rellenarBloquePrincipal(primerbloque, textName.Text);

                    int tamanio = Convert.ToInt32(textTam.Text);
                    int div = 0;

                    if (tamanio % 4 == 0) {
                        div = tamanio / 4;
                    } else {
                        div = (tamanio / 4) + 1;
                    }

                    for (int j = 0; j < div; j++) {
                        do {
                            primerbloque = r.Next(1, 26);
                            comp = consultarBloque(primerbloque);
                            //MessageBox.Show(Convert.ToString(primerbloque));
                            //i++;
                        } while (primerbloque == comp);
                        rellenarBloqueSecundario(primerbloque, j+1, textName.Text);
                        insertar_bloque(primerbloque, textName.Text);
                    }


                    textName.Text = "";
                    textTam.Text = "";
                    //MessageBox.Show("No son iguales, insertalos");
                    //insertar_bloque(bloque);
                }
            }
        }

        public void rellenarBloquePrincipal(int numero, string nombre)
        {
            switch (numero)
            {
                case 1: pane1.BackColor = Color.Black;
                    labe1.Text = nombre;
                    break;
                case 2:
                    pane2.BackColor = Color.Black;
                    labe2.Text = nombre;
                    break;
                case 3:
                    pane3.BackColor = Color.Black;
                    labe3.Text = nombre;
                    break;
                case 4:
                    pane4.BackColor = Color.Black;
                    labe4.Text = nombre;
                    break;
                case 5:
                    pane5.BackColor = Color.Black;
                    labe5.Text = nombre;
                    break;
                case 6:
                    pane6.BackColor = Color.Black;
                    label71.Text = nombre;
                    break;
                case 7:
                    pane7.BackColor = Color.Black;
                    label72.Text = nombre;
                    break;
                case 8:
                    pane8.BackColor = Color.Black;
                    label73.Text = nombre;
                    break;
                case 9:
                    pane9.BackColor = Color.Black;
                    label74.Text = nombre;
                    break;
                case 10:
                    pane10.BackColor = Color.Black;
                    label75.Text = nombre;
                    break;
                case 11:
                    pane11.BackColor = Color.Black;
                    label76.Text = nombre;
                    break;
                case 12:
                    pane12.BackColor = Color.Black;
                    label77.Text = nombre;
                    break;
                case 13:
                    pane13.BackColor = Color.Black;
                    label78.Text = nombre;
                    break;
                case 14:
                    pane14.BackColor = Color.Black;
                    label79.Text = nombre;
                    break;
                case 15:
                    pane15.BackColor = Color.Black;
                    label80.Text = nombre;
                    break;
                case 16:
                    pane16.BackColor = Color.Black;
                    label81.Text = nombre;
                    break;
                case 17:
                    pane17.BackColor = Color.Black;
                    label82.Text = nombre;
                    break;
                case 18:
                    pane18.BackColor = Color.Black;
                    label83.Text = nombre;
                    break;
                case 19:
                    pane19.BackColor = Color.Black;
                    label84.Text = nombre;
                    break;
                case 20:
                    pane20.BackColor = Color.Black;
                    label85.Text = nombre;
                    break;
                case 21:
                    pane21.BackColor = Color.Black;
                    label86.Text = nombre;
                    break;
                case 22:
                    pane22.BackColor = Color.Black;
                    label87.Text = nombre;
                    break;
                case 23:
                    pane23.BackColor = Color.Black;
                    label88.Text = nombre;
                    break;
                case 24:
                    pane24.BackColor = Color.Black;
                    label89.Text = nombre;
                    break;
                case 25:
                    pane25.BackColor = Color.Black;
                    label90.Text = nombre;
                    break;
            }
        }


        public void rellenarBloqueSecundario(int numero, int orden, string nombre)
        {
            switch (numero)
            {
                case 1:
                    pane1.BackColor = Color.Red;
                    labe1.Text = orden+"-"+nombre;
                    break;
                case 2:
                    pane2.BackColor = Color.Red;
                    labe2.Text = orden + "-" + nombre;
                    break;
                case 3:
                    pane3.BackColor = Color.Red;
                    labe3.Text = orden + "-" + nombre;
                    break;
                case 4:
                    pane4.BackColor = Color.Red;
                    labe4.Text = orden + "-" + nombre;
                    break;
                case 5:
                    pane5.BackColor = Color.Red;
                    labe5.Text = orden + "-" + nombre;
                    break;
                case 6:
                    pane6.BackColor = Color.Red;
                    label71.Text = orden + "-" + nombre;
                    break;
                case 7:
                    pane7.BackColor = Color.Red;
                    label72.Text = orden + "-" + nombre;
                    break;
                case 8:
                    pane8.BackColor = Color.Red;
                    label73.Text = orden + "-" + nombre;
                    break;
                case 9:
                    pane9.BackColor = Color.Red;
                    label74.Text = orden + "-" + nombre;
                    break;
                case 10:
                    pane10.BackColor = Color.Red;
                    label75.Text = orden + "-" + nombre;
                    break;
                case 11:
                    pane11.BackColor = Color.Red;
                    label76.Text = orden + "-" + nombre;
                    break;
                case 12:
                    pane12.BackColor = Color.Red;
                    label77.Text = orden + "-" + nombre;
                    break;
                case 13:
                    pane13.BackColor = Color.Red;
                    label78.Text = orden + "-" + nombre;
                    break;
                case 14:
                    pane14.BackColor = Color.Red;
                    label79.Text = orden + "-" + nombre;
                    break;
                case 15:
                    pane15.BackColor = Color.Red;
                    label80.Text = orden + "-" + nombre;
                    break;
                case 16:
                    pane16.BackColor = Color.Red;
                    label81.Text = orden + "-" + nombre;
                    break;
                case 17:
                    pane17.BackColor = Color.Red;
                    label82.Text = orden + "-" + nombre;
                    break;
                case 18:
                    pane18.BackColor = Color.Red;
                    label83.Text = orden + "-" + nombre;
                    break;
                case 19:
                    pane19.BackColor = Color.Red;
                    label84.Text = orden + "-" + nombre;
                    break;
                case 20:
                    pane20.BackColor = Color.Red;
                    label85.Text = orden + "-" + nombre;
                    break;
                case 21:
                    pane21.BackColor = Color.Red;
                    label86.Text = orden + "-" + nombre;
                    break;
                case 22:
                    pane22.BackColor = Color.Red;
                    label87.Text = orden + "-" + nombre;
                    break;
                case 23:
                    pane23.BackColor = Color.Red;
                    label88.Text = orden + "-" + nombre;
                    break;
                case 24:
                    pane24.BackColor = Color.Red;
                    label89.Text = orden + "-" + nombre;
                    break;
                case 25:
                    pane25.BackColor = Color.Red;
                    label90.Text = orden + "-" + nombre;
                    break;
            }
        }


        public void borrar_enPantalla(int pos)
        {
            string nombre = "vacio";
            switch (pos)
            {
                case 1:
                    pane1.BackColor = Color.Blue;
                    labe1.Text = nombre;
                    break;
                case 2:
                    pane2.BackColor = Color.Blue;
                    labe2.Text = nombre;
                    break;
                case 3:
                    pane3.BackColor = Color.Blue;
                    labe3.Text = nombre;
                    break;
                case 4:
                    pane4.BackColor = Color.Blue;
                    labe4.Text = nombre;
                    break;
                case 5:
                    pane5.BackColor = Color.Blue;
                    labe5.Text = nombre;
                    break;
                case 6:
                    pane6.BackColor = Color.Blue;
                    label71.Text = nombre;
                    break;
                case 7:
                    pane7.BackColor = Color.Blue;
                    label72.Text = nombre;
                    break;
                case 8:
                    pane8.BackColor = Color.Blue;
                    label73.Text = nombre;
                    break;
                case 9:
                    pane9.BackColor = Color.Blue;
                    label74.Text = nombre;
                    break;
                case 10:
                    pane10.BackColor = Color.Blue;
                    label75.Text = nombre;
                    break;
                case 11:
                    pane11.BackColor = Color.Blue;
                    label76.Text = nombre;
                    break;
                case 12:
                    pane12.BackColor = Color.Blue;
                    label77.Text = nombre;
                    break;
                case 13:
                    pane13.BackColor = Color.Blue;
                    label78.Text = nombre;
                    break;
                case 14:
                    pane14.BackColor = Color.Blue;
                    label79.Text = nombre;
                    break;
                case 15:
                    pane15.BackColor = Color.Blue;
                    label80.Text = nombre;
                    break;
                case 16:
                    pane16.BackColor = Color.Blue;
                    label81.Text = nombre;
                    break;
                case 17:
                    pane17.BackColor = Color.Blue;
                    label82.Text = nombre;
                    break;
                case 18:
                    pane18.BackColor = Color.Blue;
                    label83.Text = nombre;
                    break;
                case 19:
                    pane19.BackColor = Color.Blue;
                    label84.Text = nombre;
                    break;
                case 20:
                    pane20.BackColor = Color.Blue;
                    label85.Text = nombre;
                    break;
                case 21:
                    pane21.BackColor = Color.Blue;
                    label86.Text = nombre;
                    break;
                case 22:
                    pane22.BackColor = Color.Blue;
                    label87.Text = nombre;
                    break;
                case 23:
                    pane23.BackColor = Color.Blue;
                    label88.Text = nombre;
                    break;
                case 24:
                    pane24.BackColor = Color.Blue;
                    label89.Text = nombre;
                    break;
                case 25:
                    pane25.BackColor = Color.Blue;
                    label90.Text = nombre;
                    break;
            }
        }
        public void insertar_bloque(int valores, string nombre)
        {
            SqlConnection conexionBD = new SqlConnection(conexion);
            SqlCommand comando = new SqlCommand("insertar_bloque", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@valores", valores);

            try
            {
                conexionBD.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conexionBD.Dispose();
                comando.Dispose();
            }
        }


        public int consultarBloque(int primerbloque){
            int valores = 0;
            SqlConnection conexionBD = new SqlConnection(conexion);
            SqlCommand comando = new SqlCommand("consulta_comp", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@primerbloque", primerbloque);
            comando.Parameters.Add("@valores", SqlDbType.Int);
            comando.Parameters["@valores"].Direction = ParameterDirection.Output;

            try
            {
                conexionBD.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                string cadena = "";
                cadena = comando.Parameters["@valores"].Value.ToString();

                if(cadena == "")
                {
                    valores = 30;
                }
                else
                {
                    valores = Convert.ToInt32(cadena);
                }

                

                conexionBD.Dispose();
                comando.Dispose();
            }
            return valores;
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void borrar_primerValor(int pos)
        {
            SqlConnection conexionBD = new SqlConnection(conexion);
            SqlCommand comando = new SqlCommand("borrar_primerValor", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@valores", pos);
            try
            {
               conexionBD.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                
                conexionBD.Dispose();
                comando.Dispose();
            }
        }

        private void delete_Click(object sender, EventArgs e){
            if(textEliminar.Text == "") {
                MessageBox.Show("Por ingresa el nombre del proceso a eliminar");
            } else {
                int total = total_valores(textEliminar.Text);

                if (total == 0) {
                    MessageBox.Show("No hay bloques con ese nombre");
                }
                else{
                    //MessageBox.Show("SI hay bloques con ese nombre");
                    
                    

                    for(int iterador=0; iterador<total; iterador++){
                        SqlConnection conexionBD = new SqlConnection(conexion);
                        SqlCommand comando = new SqlCommand("recuperar_valores", conexionBD);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@nombre", textEliminar.Text);
                        comando.Parameters.Add("@valor", SqlDbType.Int);
                        comando.Parameters["@valor"].Direction = ParameterDirection.Output;
                        try
                        {
                            conexionBD.Open();
                            comando.ExecuteNonQuery();
                        } catch (Exception ex) {

                        } finally {
                            int pos = Convert.ToInt32(comando.Parameters["@valor"].Value.ToString());      
                            borrar_enPantalla(pos);
                            
                            conexionBD.Dispose();
                            comando.Dispose();
                            borrar_primerValor(pos);
                        }
                        
                    }      
                }
            }
        }

        public int total_valores(string nombre){
            int total = 100;
            SqlConnection conexionBD = new SqlConnection(conexion);
            SqlCommand comando = new SqlCommand("total_valores", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.Add("@valores", SqlDbType.Int);
            comando.Parameters["@valores"].Direction = ParameterDirection.Output;

            try
            {
                conexionBD.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                
                string cadena = "";
                cadena = comando.Parameters["@valores"].Value.ToString();        
                total = Convert.ToInt32(cadena);
                conexionBD.Dispose();
                comando.Dispose();
            }
            return total;
        }

        private void pane25_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane19_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane18_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane23_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane22_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane17_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane21_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane16_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane11_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane12_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane13_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane14_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane15_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane10_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane9_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane8_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pane2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
