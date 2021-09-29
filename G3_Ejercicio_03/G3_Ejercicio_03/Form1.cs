using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G3_Ejercicio_03
{

    public partial class Form1 : Form
    {
        //listado que permite tener varios elementos de la clase Persona
        private List<Producto> Productos = new List<Producto>();
        private int edit_indice = -1; //el indice para editar comienza en -1, significa que no hay nada seleccionado, sirve para el DataGridView 

        private void actualizarGrid()
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = Productos; //los nombres de columna que veremos son los de las priopedades
        }

        private void reseteo()
        {
            txt_nombre.Clear();
            text_desc.Clear();
            text_marca.Clear();
            text_precio.Clear();
            text_stock.Clear();
            pic_imagen.Image = null;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dataGrid.SelectedRows[0];
            int posicion = dataGrid.Rows.IndexOf(selected); //guarda en que fila estoy
            edit_indice = posicion; //copia la variavle en indice editado
            Producto product = Productos[posicion]; ///esta variable de tipo persona se carga con los valores del listado
            //lo que tenga el atributo se le da al textbox
            txt_nombre.Text = product.Nombre;
            text_desc.Text = product.Descripcion;
            text_marca.Text = product.Marca;
            text_precio.Text = Convert.ToString(product.Precio);
            text_stock.Text = Convert.ToString(product.Stock);
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //se crea un objeto de la clase Persona y se guarda a travez de las Propiedades
            Producto product = new Producto();
            product.Nombre = txt_nombre.Text;
            product.Descripcion = text_desc.Text;
            product.Marca = text_marca.Text;
            product.Precio = float.Parse(text_precio.Text);
            product.Stock = int.Parse(text_stock.Text);
            

            if (edit_indice > -1)//verfica si hay un indice seleccionado
            {
                Productos[edit_indice] = product;
                edit_indice = -1;
            }
            else
            {
                Productos.Add(product);//al arreglo de productos se le agrega el objeto creado con todos los datos que recolecte
            }

            actualizarGrid();//llama al procedimiento que guarda en el datagrid
            reseteo(); //llama al metodo que resetea
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Productos.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1
                reseteo();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }
        }
        class Producto
        {
            string nombre;

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            string descripcion;

            public string Descripcion
            {
                get { return descripcion; }
                set { descripcion = value; }
            }
            string marca;

            public string Marca
            {
                get { return marca; }
                set { marca = value; }
            }
            float precio;
            public float Precio
            {
                get { return precio; }
                set { precio = value; }
            }
            int stock;

            public int Stock
            {
                get { return stock; }
                set { stock = value; }
            }
            Image imagen;
            public Image Imagen
            {
                get { return imagen; }
                set { imagen = value; }
            }

        }//fin clase producto
    }
}
