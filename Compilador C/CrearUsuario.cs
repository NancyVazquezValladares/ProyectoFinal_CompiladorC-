using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador_C
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Conexion.Query("select * from Usuario where Nombre = '" + Nombre.Text+"'").Rows.Count != 0)
            {
                MessageBox.Show("Usuario Existente: "+ Nombre.Text);
            }
            else
            {
                Conexion.Query("insert into Usuario(Nombre,Contraseña,Correo,Numero) values ('" + Nombre.Text + "','" + Conexion.encriptar(Contraseña.Text) + "','" + Email.Text + "','" + Telefono.Text + "')");
                MessageBox.Show("Usuario Creado");
            }
            Nombre.Text = "";
            Contraseña.Text = "";
            Email.Text = "";
            Telefono.Text = "";
        }
    }
}
