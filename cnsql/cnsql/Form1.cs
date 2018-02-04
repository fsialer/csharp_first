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

namespace cnsql
{
    public partial class Form1 : Form
    {
        public string accion = "insertar", archivoOrigen, imagen, extension, imgEliminar;
        public string email, sexo, genero, imgExiste;
        Conexion Conet = new Conexion();
        OpenFileDialog fd = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Inhabilitar();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                MessageBox.Show("Ingrese un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombres.Focus();
                return ;
            }
            if (txtApellidos.Text == "")
            {
                MessageBox.Show("Ingrese un apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellidos.Focus();
                return;
            }
            if (txtTelf.Text == "")
            {
                MessageBox.Show("Ingrese un telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelf.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Ingrese un email", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            if (rbtnMasculino.Checked)
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "Femenino";
            }
            email = txtEmail.Text;
            //condicion que verifica que no exista el nuevo email en la base de datos
            if (Conet.consultar2("Email ", "Usuarios", "Email", email))
            {
                MessageBox.Show("El email " + email + " ya existe en la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
            else
            {
                cargarImagen();
            }

           
        }

        private void tblDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MEtodo para habilitar los controles
            Habilitar();
            //la variable accion pasa hacer igual a modificar
            accion = "modificar";
            txtEmail.Enabled = false;
            //metodos para mostrar los datos del dataGrridView en los textbox
            txtId.Text = Convert.ToString(tblDatos.CurrentRow.Cells[0].Value);
            txtNombres.Text = Convert.ToString(tblDatos.CurrentRow.Cells[1].Value);
            txtApellidos.Text = Convert.ToString(tblDatos.CurrentRow.Cells[2].Value);
            txtTelf.Text = Convert.ToString(tblDatos.CurrentRow.Cells[3].Value);
            txtEmail.Text = Convert.ToString(tblDatos.CurrentRow.Cells[4].Value);
            genero = Convert.ToString(tblDatos.CurrentRow.Cells[5].Value);
            //condicion para evaluar la variable genero
            if (genero=="Masculino")
            {
                rbtnMasculino.Checked = true;
            }
            else
            {
                rbtnFemenino.Checked = true;
            }
            //Metodo para mostrar l imagen en el pictureBox
            imagen = Convert.ToString(tblDatos.CurrentRow.Cells[6].Value);
            pictureBox1.ImageLocation = imagen;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
            string email = txtEmail.Text;
            extension = imagen.Substring(imagen.LastIndexOf(".")+1).ToLower();
            //Funcion para eliminar la imagen de la carpeta fotos
            imgExiste = @"C:\Users\fernando\source\repos\cnsql\cnsql\fotos\" + email+"."+extension;
            if (File.Exists(imgExiste))
            {
                File.Delete(imgExiste);
            }
            if (Conet.Eliminar("Usuarios", "IdUsuario='" + txtId.Text+"'"))
            {
                MessageBox.Show("REgistro eliminado con exito", "Advertencuia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Inhabilitar();
                tblDatos.DataSource = Conet.consultar("Usuarios");
            }
            else
            {
                MessageBox.Show("Error al eliminar el registro", "Advertencuia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
            tblDatos.DataSource = Conet.consultar3("Usuarios", "email",txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (pictureBox1.Image==null)
            {
                if (rbtnMasculino.Checked)
                {
                    archivoOrigen= @"C:\Users\fernando\source\repos\cnsql\cnsql\fotos\default\masculino.png";
                }
                if (rbtnFemenino.Checked)
                {
                    archivoOrigen = @"C:\Users\fernando\source\repos\cnsql\cnsql\fotos\default\femenino.png";
                }
                if (fd.FileName==string.Empty)
                {
                    imagen = Convert.ToString(tblDatos.CurrentRow.Cells[6].Value);

                }
                extension = archivoOrigen.Substring(archivoOrigen.LastIndexOf(".") + 1).ToLower();
                //ruta de la imagen que se almacenara en la base de datos
                imagen = @"C:\Users\fernando\source\repos\cnsql\cnsql\fotos\" + email + "." + extension;

            }
            //metodo para eliminar imagen duplicadas
           imgExiste = @"C:\Users\fernando\source\repos\cnsql\cnsql\fotos\" + email;
            imgEliminar = @"C:\Users\fernando\source\repos\cnsql\cnsql\fotos\" + email;
            string gif = ".gif", jpg = ".jpg", png = ".png";
            switch (extension)
            {
                case "jpg":
                    if (File.Exists(imgExiste+gif))
                    {
                        File.Delete(imgEliminar+gif);
                    }
                    if(File.Exists(imgExiste + png))
                    {
                        File.Delete(imgEliminar + png);
                    }
                    break;
                case "gif":
                    if (File.Exists(imgExiste + jpg))
                    {
                        File.Delete(imgEliminar + jpg);
                    }
                    if (File.Exists(imgExiste + png))
                    {
                        File.Delete(imgEliminar + png);
                    }
                    break;
                case "png":
                    if (File.Exists(imgExiste + gif))
                    {
                        File.Delete(imgEliminar + gif);
                    }
                    if (File.Exists(imgExiste + jpg))
                    {
                        File.Delete(imgEliminar + jpg);
                    }
                    break;

            }
            try
            {
                File.Copy(archivoOrigen,imagen,true);
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
            GuardarDatos();
        }

        //metodo para insertar y modificar los datos
        private void GuardarDatos()
        {
            //condicion que evalua la variable accion
            if (accion == "insertar")
            {
                //condicion que evalua los textbox si estan vacios
                if (txtNombres.Text == "")
                {
                    MessageBox.Show("Ingrese un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombres.Focus();
                    return;
                }
                if (txtApellidos.Text == "")
                {
                    MessageBox.Show("Ingrese un apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtApellidos.Focus();
                    return;
                }
                if (txtTelf.Text == "")
                {
                    MessageBox.Show("Ingrese un telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelf.Focus();
                    return;
                }
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Ingrese un email", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                    return;
                }
                if (rbtnMasculino.Checked)
                {
                    sexo = "Masculino";
                }
                else
                {
                    sexo = "Femenino";
                }
                email = txtEmail.Text;
                //condicion que verifica que no exista el nuevo email en la base de datos
                if (Conet.consultar2("Email ", "Usuarios", "Email", email))
                {
                    MessageBox.Show("El email " + email + " ya existe en la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                }
               // imagen = "imagen";
                string sql = "INSERT INTO Usuarios (Nombres,Apellidos,Telefono,Email,Sexo,Imagen) VALUES ('"+txtNombres.Text+"','"+txtApellidos.Text+"','"+txtTelf.Text+"','"+txtEmail.Text+"','"+sexo+"','"+imagen+"')";
                if (Conet.Insertar(sql))
                {
                    MessageBox.Show("REgistro insertado con exito","Advertencuia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Inhabilitar();
                    this.tblDatos.DataSource = Conet.consultar("Usuarios");

                }
                else{
                    MessageBox.Show("Error al insertar el registro", "Advertencuia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                if (rbtnMasculino.Checked)
                {
                    sexo = "Masculino";
                }
                else
                {
                    sexo = "Femenino";
                }
                //condicion que evalua la varibale accion
                if (accion=="modificar")
                {
                    string campos = "Nombres='"+txtNombres.Text+"', Apellidos='"+txtApellidos.Text+"', Sexo='"+sexo+"', " +
                        "Telefono='"+txtTelf.Text+"', Email='"+txtEmail.Text+"', Imagen='"+imagen+"'";
                    if (Conet.Actualizar("Usuarios", campos, "IdUsuario='" + txtId.Text+"'" )) 
                    {
                        MessageBox.Show("REgistro actualizados con exito", "Advertencuia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Inhabilitar();
                        tblDatos.DataSource = Conet.consultar("Usuarios");
                    }
                }
            }
        }
        //metodo que cargar las imagenes
        private void cargarImagen()
        {
            //Establecerla propiedad de waitOnliad a true significa que la imagen se carga
            //de forma sincronica
            pictureBox1.WaitOnLoad = true;
            //Metodos para cargar la imagen
            fd.Filter = "Todos(*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp";
            DialogResult = fd.ShowDialog();
            archivoOrigen = fd.FileName;
            //Condicion que evalua si el FileNmae esta vacio
            if (fd.FileName==string.Empty)
            {

            }
            else
            {
                pictureBox1.ImageLocation = fd.FileName;
            }
            //Obtiene la extension de la imagen cargada
            extension = archivoOrigen.Substring(archivoOrigen.LastIndexOf(".")+1).ToLower();
            string email = txtEmail.Text;
            //La nueva ruta de la imagen que se almacenara en la base de datos}
            imagen = @"C:\Users\fernando\source\repos\cnsql\cnsql\fotos\"+email+"."+extension;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //La variable accion pasa hacer igual a insertar
            accion = "insertar";
            //metodo para habilitar los controles
            Habilitar();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            txtId.Visible = false;
            Inhabilitar();
            //Funcion para mostrar los registros en el dataGridView
            this.tblDatos.DataSource = Conet.consultar("usuarios");
            tblDatos.Columns[6].Visible = false;
            tblDatos.ReadOnly = true;
            tblDatos.AllowUserToAddRows = false;
        }

        //metodo para inhabilitar los controles
        private void Inhabilitar()
        {
            fd.FileName = "";
            imagen = "";
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelf.Enabled = false;
            txtEmail.Enabled = false;
            txtId.Text ="" ;
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelf.Text = "";
            txtEmail.Text = "";
            txtBuscar.Text = "";
            pictureBox1.Image = null;

            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExaminar.Enabled = false;
            rbtnMasculino.Enabled = false;
            rbtnFemenino.Enabled = false;
            rbtnFemenino.Checked = true;


        }

        private void Habilitar()
        {
            fd.FileName = "";
            imagen = "";
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtTelf.Enabled = true;
            txtEmail.Enabled = true;
            txtNombres.Focus();
            txtId.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelf.Text = "";
            txtEmail.Text = "";
            txtBuscar.Text = "";




            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExaminar.Enabled = true;
            rbtnMasculino.Enabled = true;
            rbtnFemenino.Enabled = true;
            rbtnFemenino.Checked = true;
        }
    }
}
