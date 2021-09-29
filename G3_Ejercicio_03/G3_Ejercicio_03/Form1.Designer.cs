
namespace G3_Ejercicio_03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.grupo_1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_imagen = new System.Windows.Forms.PictureBox();
            this.text_stock = new System.Windows.Forms.TextBox();
            this.text_precio = new System.Windows.Forms.TextBox();
            this.text_marca = new System.Windows.Forms.TextBox();
            this.text_desc = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lb_stock = new System.Windows.Forms.Label();
            this.lb_precio = new System.Windows.Forms.Label();
            this.lb_marca = new System.Windows.Forms.Label();
            this.lb_descripcion = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.btn_imagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.grupo_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE PRODUCTOS";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(40, 59);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 29;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(687, 311);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(40, 376);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(118, 35);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // grupo_1
            // 
            this.grupo_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grupo_1.Controls.Add(this.btn_imagen);
            this.grupo_1.Controls.Add(this.label2);
            this.grupo_1.Controls.Add(this.pic_imagen);
            this.grupo_1.Controls.Add(this.text_stock);
            this.grupo_1.Controls.Add(this.text_precio);
            this.grupo_1.Controls.Add(this.text_marca);
            this.grupo_1.Controls.Add(this.text_desc);
            this.grupo_1.Controls.Add(this.txt_nombre);
            this.grupo_1.Controls.Add(this.btn_guardar);
            this.grupo_1.Controls.Add(this.lb_stock);
            this.grupo_1.Controls.Add(this.lb_precio);
            this.grupo_1.Controls.Add(this.lb_marca);
            this.grupo_1.Controls.Add(this.lb_descripcion);
            this.grupo_1.Controls.Add(this.lb_nombre);
            this.grupo_1.Location = new System.Drawing.Point(733, 22);
            this.grupo_1.Name = "grupo_1";
            this.grupo_1.Size = new System.Drawing.Size(472, 466);
            this.grupo_1.TabIndex = 3;
            this.grupo_1.TabStop = false;
            this.grupo_1.Text = "Mantenimiento de productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Imagen:";
            // 
            // pic_imagen
            // 
            this.pic_imagen.Location = new System.Drawing.Point(145, 241);
            this.pic_imagen.Name = "pic_imagen";
            this.pic_imagen.Size = new System.Drawing.Size(207, 163);
            this.pic_imagen.TabIndex = 11;
            this.pic_imagen.TabStop = false;
            // 
            // text_stock
            // 
            this.text_stock.Location = new System.Drawing.Point(145, 168);
            this.text_stock.Name = "text_stock";
            this.text_stock.Size = new System.Drawing.Size(250, 27);
            this.text_stock.TabIndex = 10;
            // 
            // text_precio
            // 
            this.text_precio.Location = new System.Drawing.Point(145, 135);
            this.text_precio.Name = "text_precio";
            this.text_precio.Size = new System.Drawing.Size(250, 27);
            this.text_precio.TabIndex = 9;
            // 
            // text_marca
            // 
            this.text_marca.Location = new System.Drawing.Point(145, 100);
            this.text_marca.Name = "text_marca";
            this.text_marca.Size = new System.Drawing.Size(250, 27);
            this.text_marca.TabIndex = 8;
            // 
            // text_desc
            // 
            this.text_desc.Location = new System.Drawing.Point(145, 67);
            this.text_desc.Name = "text_desc";
            this.text_desc.Size = new System.Drawing.Size(250, 27);
            this.text_desc.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(145, 34);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(250, 27);
            this.txt_nombre.TabIndex = 6;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(145, 422);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(177, 38);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Location = new System.Drawing.Point(38, 168);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(48, 20);
            this.lb_stock.TabIndex = 4;
            this.lb_stock.Text = "Stock:";
            // 
            // lb_precio
            // 
            this.lb_precio.AutoSize = true;
            this.lb_precio.Location = new System.Drawing.Point(33, 135);
            this.lb_precio.Name = "lb_precio";
            this.lb_precio.Size = new System.Drawing.Size(53, 20);
            this.lb_precio.TabIndex = 3;
            this.lb_precio.Text = "Precio:";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.Location = new System.Drawing.Point(33, 96);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(53, 20);
            this.lb_marca.TabIndex = 2;
            this.lb_marca.Text = "Marca:";
            // 
            // lb_descripcion
            // 
            this.lb_descripcion.AutoSize = true;
            this.lb_descripcion.Location = new System.Drawing.Point(33, 66);
            this.lb_descripcion.Name = "lb_descripcion";
            this.lb_descripcion.Size = new System.Drawing.Size(87, 20);
            this.lb_descripcion.TabIndex = 1;
            this.lb_descripcion.Text = "Descripcion";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(33, 37);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(67, 20);
            this.lb_nombre.TabIndex = 0;
            this.lb_nombre.Text = "Nombre:";
            // 
            // btn_imagen
            // 
            this.btn_imagen.Location = new System.Drawing.Point(145, 206);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(94, 29);
            this.btn_imagen.TabIndex = 13;
            this.btn_imagen.Text = "Seleccionar";
            this.btn_imagen.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofd_seleccionar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 500);
            this.Controls.Add(this.grupo_1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.grupo_1.ResumeLayout(false);
            this.grupo_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.GroupBox grupo_1;
        private System.Windows.Forms.TextBox text_stock;
        private System.Windows.Forms.TextBox text_precio;
        private System.Windows.Forms.TextBox text_marca;
        private System.Windows.Forms.TextBox text_desc;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.Label lb_precio;
        private System.Windows.Forms.Label lb_marca;
        private System.Windows.Forms.Label lb_descripcion;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_imagen;
        private System.Windows.Forms.Button btn_imagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

