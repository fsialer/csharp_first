using Linq.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class Form1 : Form
    {
        List<Datos> lista;
        UserData user = new UserData();
        string action = "insert";
        int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnMostrar.Click += (a, j) => Datos();
            user.usuario(listView1, listView2, "");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            if (action=="insert")
            {
                if (user.insertar(txtNombre, txtEdad,txtInformacion))
                {
                    MessageBox.Show("Datos insertados");                    
                }
            }
            if (action =="update")
            {
                if (user.update(txtNombre, txtEdad,txtInformacion,id))
                {
                    MessageBox.Show("Datos actualizados");
                }
            }
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtInformacion.Text = "";
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
            }
            if (listView2.Items.Count > 0)
            {
                listView2.Items.Clear();
            }
            user.usuario(listView1, listView2, "");


        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.GetItemAt(e.X, e.Y);
            id = Convert.ToInt32(item.SubItems[0].Text);
            txtNombre.Text = item.SubItems[1].Text;
            txtEdad.Text = item.SubItems[2].Text;
            action = "update";
            user.consult(txtInformacion,id);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (user.delete(id))
            {
                MessageBox.Show("Datos eliminados");
                txtNombre.Text = "";
                txtEdad.Text = "";
                if (listView1.Items.Count > 0)
                {
                    listView1.Items.Clear();
                }
                if (listView2.Items.Count > 0)
                {
                    listView2.Items.Clear();
                }
                user.usuario(listView1, listView2,"");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
            }
            if (listView2.Items.Count > 0)
            {
                listView2.Items.Clear();
            }
            user.usuario(listView1, listView2, txtBuscar.Text);
        }
        //private void Datos()
        //{
        //    lista = new List<Datos>() {
        //        new Datos(){name="Fer",age=23},
        //        new Datos(){name="AJ",age=32},
        //        new Datos(){name="PDHN",age=30},

        //    };
        //    // 1. La fuente de datos
        //    int[] numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    // 2. Creacion de la consulta:
        //    var numerosConsulta = from num in lista where num.age>=30 select num;
        //    // 3. Ejecion de la consulta:
        //    foreach (Datos dato in numerosConsulta)
        //    {
        //        ListViewItem item = new ListViewItem();
        //        item.Text = dato.name;
        //        item.SubItems.Add(dato.age.ToString());

        //        listView1.Items.Add(item);
        //    }

        //}
    }
}
