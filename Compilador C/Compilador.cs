using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Compilador_C
{
    public partial class Compilador : Form
    {
        int id;
        string[] vectorPalabrasReservadas = new string[30];
        int[,] matriz;
        public Compilador()
        {
            InitializeComponent();

            Lenguaje.SelectedIndex = 0;

        }

        private void leerPalabrasReservadas(string archivo)
        {
            string renglon;
            StreamReader lector = new StreamReader(archivo);
            renglon = lector.ReadLine();
            vectorPalabrasReservadas = renglon.Split(',');
            lector.Close();
        }
        private void leerMatrizEstados(string archivo)
        {
            string renglon;
            string[] datosrenglon;
            int r = 0;
            StreamReader lector = new StreamReader(archivo);
            string indices = lector.ReadLine();
            matriz = new int[Convert.ToInt32(indices.Split(',')[0]), Convert.ToInt32(indices.Split(',')[1])];

            while (!lector.EndOfStream)
            {
                renglon = lector.ReadLine();
                datosrenglon = renglon.Split(',');
                for (int c = 0; c < datosrenglon.Length; c++)
                {
                    matriz[r, c] = Convert.ToInt32(datosrenglon[c]);
                }
                r++;
            }
            lector.Close();
        }
        private void Cargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string archivo = openFileDialog1.FileName;
            StreamReader fileReader;
            fileReader = File.OpenText(archivo);
            string stringReader;
            while (!(fileReader.EndOfStream))
            {
                stringReader = fileReader.ReadLine();
                LBEntrada.Items.Add(stringReader);
            }
        }
        int renglon;
        string token, PalabraSalida;
        string Lineaz;
        int direccion;
        private void BuscaId()
        {
            bool encontro = false;
            int renglon2 = 0;
            while ((encontro == false) & (renglon2 < LBIdentificador.Items.Count))
            {
                if ((token.ToUpper() == LBIdentificador.Text.ToUpper()))
                {
                    encontro = true;
                    direccion = renglon2;
                }
                renglon2 = renglon2 + 1;
            }
            if ((encontro == false))
            {
                LBIdentificador.Items.Add(token);
                direccion = LBIdentificador.Items.Count - 1;
            }
        }
        private void CntesEnteras()
        {
            bool encontro;
            int renglon2;
            encontro = false;
            renglon2 = 0;
            while ((encontro == false) & (renglon2 < LBCntesEnteras.Items.Count))
            {
                LBCntesEnteras.SelectedIndex = renglon2;
                if ((token.ToUpper() == LBCntesEnteras.Text.ToUpper())) //ToUpper= ucase
                {
                    encontro = true;
                    direccion = renglon2;
                }
                renglon2 = renglon2 + 1;
            }
            if ((encontro == false))
            {
                LBCntesEnteras.Items.Add(token);
                direccion = LBCntesEnteras.Items.Count - 1;
            }
        }

        private void CntesReales()
        {
            bool encontro;
            int renglon2;
            encontro = false;
            renglon2 = 0;
            while ((encontro == false) && (renglon2 < LBCntesReales.Items.Count))
            {
                LBCntesReales.SelectedIndex = renglon2;
                if (string.Equals(token.ToUpper(), LBCntesReales.Text.ToUpper()))
                {
                    encontro = true;
                    direccion = renglon2;
                }
                renglon2 = renglon2 + 1;
            }
            if (encontro == false)
            {
                LBCntesReales.Items.Add(token);
                direccion = LBCntesReales.Items.Count - 1;
            }
        }
        private void Strings()
        {
            bool encontro;
            int renglon2;
            encontro = false;
            renglon2 = 0;
            while ((encontro == false) && (renglon2 < LBStrings.Items.Count))
            {
                LBStrings.SelectedIndex = renglon2;
                if (string.Equals(token.ToUpper(), LBStrings.Text.ToUpper()))
                {
                    encontro = true;
                    direccion = renglon2;
                }
                renglon2 = renglon2 + 1;
            }
            if (encontro == false)
            {
                LBStrings.Items.Add(token);
                direccion = LBStrings.Items.Count - 1;
            }
        }
        int ColumnaN;
        int Posicion;
        char Caracter;
        public void BuscaToken()
        {
            Estado = 0;
            token = "";
            Posicion = 1;
            while (Posicion <= Lineaz.Length) // mientras que la pocicsion sea menor que la longitud de linea Z 
            {
                Caracter = Convert.ToChar(Lineaz.Substring(Posicion - 1, 1)); //extrae de una cadena el caracter indicado en la posicion indicada 
                ColumnaX();
                Estado = matriz[Estado, ColumnaN]; //caracter= cadena,inicio,#caracteres a sacar

                if (Estado >= 100)
                {
                    if (token.Length > 0)
                    {
                        ReconocimientoToken();
                    }
                    else if (token.Length == 0)
                    {
                        token = token + Caracter; //solo lee un caracter 
                        ReconocimientoToken();
                    }
                    Estado = 0;
                    token = "";
                }
                else
                {
                    if (Estado != 0)
                    {
                        token = token + Caracter; //añadir a token el caracter (h)
                    }
                }
                Posicion = Posicion + 1;
            }
            if (token.Length > 0) //el token hola es mayor si hola=4
            {
                Caracter = ' ';
                ColumnaX();
                Estado = matriz[Estado, ColumnaN];
                ReconocimientoToken();
            }
        }

        public void ColumnaX()
        {
            if (Caracter >= 'A' && Caracter <= 'Z' || Caracter >= 'a' && Caracter <= 'z')
            {
                ColumnaN = 0;
            }
            else if (Caracter == ' ' || Caracter == ' ')
            {
                ColumnaN = 2;
                //Constantes enteras
            }
            else if (Caracter >= '0' && Caracter <= '9')
            {
                ColumnaN = 1;
                //Delimitadores 
            }
            else if (Caracter == '_')
            {
                ColumnaN = 3;
            }
            else if (Caracter == '.')
            {
                ColumnaN = 4;
                //Strings
            }
            else if (Caracter == '\"') //Identifica el caracter especial (Comillas) asckii
            {
                ColumnaN = 5;
            }
            else if (Caracter == '#')
            {
                ColumnaN = 6;
            }
            else if (Caracter == '+')
            {
                ColumnaN = 7;
            }
            else if (Caracter == '-')
            {
                ColumnaN = 8;
            }
            else if (Caracter == '*')
            {
                ColumnaN = 9;
            }
            else if (Caracter == '/')
            {
                ColumnaN = 10;
            }
            else if (Caracter == '>')
            {
                ColumnaN = 11;
            }
            else if (Caracter == '<')
            {
                ColumnaN = 12;
            }
            else if (Caracter == '=')
            {
                ColumnaN = 13;
            }
        }
        int Estado;
        bool Pr;
        private void borrar()
        {
            LBArSalida.Items.Clear();
            LBStrings.Items.Clear();
            LBIdentificador.Items.Clear();
            LBCntesEnteras.Items.Clear();
            LBCntesReales.Items.Clear();
        }
        private void exportar()
        {
            //Solo Exporta un solo dato del Archivo de Salida :C
            DateTime date = DateTime.Now;
            string fechahra = date.ToString("dd_MM_yyyy_HH_mm_ss");
            string archivo = "ArchivosSalida/output" + Lenguaje.Text + Usuario.Text + fechahra + ".txt";
            StreamWriter sw = new StreamWriter(archivo);
            foreach (var item in LBArSalida.Items)
            {
                if (item.ToString() != "")
                {
                    sw.WriteLine(item.ToString());

                }
            }
            sw.Close();
            Conexion.Query("insert into log(id_Usuario,id_Lenguaje,Fecha,Archivo) values (" + id.ToString() + "," + (Lenguaje.SelectedIndex + 1).ToString() + ",'" + date.ToString("yyyy/MM/dd HH:mm:ss") + "','" + archivo + "')");
        }


        public void ReconocimientoToken()
        {
            if (Estado == 100)
            {
                Pr = false;
                BuscapalReservada();
                if (Pr)
                {
                    PalabraSalida = token + "   Pr   " + direccion.ToString();
                    Posicion = Posicion - 1;
                    token = token + Caracter;
                }
                else
                {
                    Buscaidentificadores();
                    PalabraSalida = token + " Id  " + direccion.ToString();
                    Posicion = Posicion - 1;
                }
            }
            if (Estado == 101)
            {
                CntesEnteras();
                PalabraSalida = token + " Cnte. Entera" + direccion.ToString();
                Posicion = Posicion - 1;
            }
            else if (Estado == 102)
            {
                CntesReales();
                PalabraSalida = token + " Cnte. Real" + direccion.ToString();
                Posicion = Posicion - 1;
            }
            if (Estado == 103)
            {
                token = token + Caracter;
                Strings();
                PalabraSalida = token + " String" + direccion.ToString();
            }
            if (Estado == 105)
            {
                PalabraSalida = token + " C.Esp";
            }
            else if (Estado == 106)
            {
                PalabraSalida = token + " C.Esp";
            }
            else if (Estado == 107)
            {
                PalabraSalida = token + " C.Esp";
            }
            else if (Estado == 108)
            {
                PalabraSalida = token + " C.Esp";
            }
            else if (Estado == 109)
            {
                PalabraSalida = token + " C.Esp";
                Posicion = Posicion - 1;
            }
            else if (Estado == 110)
            {
                token = token + Caracter;
                PalabraSalida = token + " C.Esp";
            }
            else if (Estado == 111)
            {
                token = token + Caracter;
                PalabraSalida = token + " C.Esp";
            }
            else if (Estado == 112)
            {
                PalabraSalida = token + " C.Esp";
                Posicion = Posicion - 1;
            }
            else if (Estado == 113)
            {
                token = token + Caracter;
                PalabraSalida = token + " C.Esp";
            }
            else if (Estado == 114)
            {
                token = token + Caracter;
                PalabraSalida = token + " C.Esp";
            }
            LBArSalida.Items.Add(PalabraSalida);
        }
        public void Buscaidentificadores()
        {
            bool encontro = false;
            int renglon2 = 0;
            while ((encontro == false) && (renglon2 < LBIdentificador.Items.Count))
            {
                LBIdentificador.SelectedIndex = renglon2;
                if (string.Equals(token.ToUpper(), LBIdentificador.Text.ToUpper()))
                {
                    encontro = true;
                    direccion = renglon2;
                }
                renglon2 = renglon2 + 1;
            }
            if ((encontro == false))
            {
                LBIdentificador.Items.Add(token);
                direccion = LBIdentificador.Items.Count - 1;
            }
        }

        private void BtnCompilar_Click(object sender, EventArgs e)
        {
            borrar();
            renglon = 0;
            while ((renglon < LBEntrada.Items.Count))
            {
                LBEntrada.SelectedIndex = renglon;
                Lineaz = LBEntrada.Text;
                BuscaToken();
                renglon = renglon + 1;
            }
            exportar();
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            CrearUsuario crear = new CrearUsuario();
            crear.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            DataTable usuario = Conexion.Query("select id_Usuario from Usuario where nombre = '" + Usuario.Text + "' and contraseña = '" + Conexion.encriptar(Contraseña.Text) + "'");
            if (usuario.Rows.Count == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            else
            {
                id = Convert.ToInt32(usuario.Rows[0][0]);
                Usuario.Enabled = false;
                Contraseña.Enabled = false;
                Login.Enabled = false;
                Logout.Enabled = true;
                Lenguaje.Enabled = true;
                Seleccionar.Enabled = true;
                MessageBox.Show("Inicio exitoso, selecciona un lenguaje");
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login.Enabled = true;
            Usuario.Text = "";
            Contraseña.Text = "";
            Usuario.Enabled = true;
            Contraseña.Enabled = true;
            Logout.Enabled = false;
            panel2.Enabled = false;
            Seleccionar.Enabled = false;
            Lenguaje.Enabled = false;
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            LBPalabrareservada.Items.Clear();
            leerMatrizEstados("matriz" + Lenguaje.Text + ".csv");
            leerPalabrasReservadas("PalabrasReservadas" + Lenguaje.Text + ".csv");
            for (int i = 0; i < vectorPalabrasReservadas.Length; i++)
            {
                LBPalabrareservada.Items.Add(vectorPalabrasReservadas[i] + "");
            }
            panel2.Enabled = true;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            Log registros = new Log();
            registros.Show();
        }

        private void LBCntesReales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lenguaje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void BuscapalReservada()
        {
            int Posicion = 0;
            Posicion = 0;
            direccion = -1;
            while ((Pr == false) && (Posicion < vectorPalabrasReservadas.Length))
            {
                if (string.Equals(token.ToUpper(), vectorPalabrasReservadas[Posicion].ToUpper()))
                {
                    Pr = true;
                    direccion = Posicion;
                }
                Posicion += 1;
            }
        }
    }
}
