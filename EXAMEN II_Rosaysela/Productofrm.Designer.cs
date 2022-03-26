namespace EXAMEN_II_Rosaysela
{
    partial class Productofrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.ExistenciatextBox4 = new System.Windows.Forms.TextBox();
            this.PreciotextBox3 = new System.Windows.Forms.TextBox();
            this.DescripciontextBox2 = new System.Windows.Forms.TextBox();
            this.CodigotextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelarbutton5 = new System.Windows.Forms.Button();
            this.Eliminarbutton4 = new System.Windows.Forms.Button();
            this.Guardarbutton3 = new System.Windows.Forms.Button();
            this.Modificarbutton2 = new System.Windows.Forms.Button();
            this.Nuevobutton1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "PRODUCTOS";
            // 
            // ExistenciatextBox4
            // 
            this.ExistenciatextBox4.Enabled = false;
            this.ExistenciatextBox4.Location = new System.Drawing.Point(134, 212);
            this.ExistenciatextBox4.Name = "ExistenciatextBox4";
            this.ExistenciatextBox4.Size = new System.Drawing.Size(185, 20);
            this.ExistenciatextBox4.TabIndex = 18;
            this.ExistenciatextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExistenciatextBox4_KeyPress);
            // 
            // PreciotextBox3
            // 
            this.PreciotextBox3.Enabled = false;
            this.PreciotextBox3.Location = new System.Drawing.Point(134, 178);
            this.PreciotextBox3.Name = "PreciotextBox3";
            this.PreciotextBox3.Size = new System.Drawing.Size(185, 20);
            this.PreciotextBox3.TabIndex = 17;
            this.PreciotextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreciotextBox3_KeyPress);
            // 
            // DescripciontextBox2
            // 
            this.DescripciontextBox2.Enabled = false;
            this.DescripciontextBox2.Location = new System.Drawing.Point(134, 141);
            this.DescripciontextBox2.MaxLength = 45;
            this.DescripciontextBox2.Name = "DescripciontextBox2";
            this.DescripciontextBox2.Size = new System.Drawing.Size(185, 20);
            this.DescripciontextBox2.TabIndex = 16;
            // 
            // CodigotextBox1
            // 
            this.CodigotextBox1.Enabled = false;
            this.CodigotextBox1.Location = new System.Drawing.Point(134, 107);
            this.CodigotextBox1.MaxLength = 45;
            this.CodigotextBox1.Name = "CodigotextBox1";
            this.CodigotextBox1.Size = new System.Drawing.Size(185, 20);
            this.CodigotextBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Existencia :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descripcion :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codigo :";
            // 
            // Cancelarbutton5
            // 
            this.Cancelarbutton5.Enabled = false;
            this.Cancelarbutton5.Location = new System.Drawing.Point(481, 154);
            this.Cancelarbutton5.Name = "Cancelarbutton5";
            this.Cancelarbutton5.Size = new System.Drawing.Size(83, 30);
            this.Cancelarbutton5.TabIndex = 26;
            this.Cancelarbutton5.Text = "Cancelar";
            this.Cancelarbutton5.UseVisualStyleBackColor = true;
            this.Cancelarbutton5.Click += new System.EventHandler(this.Cancelarbutton5_Click);
            // 
            // Eliminarbutton4
            // 
            this.Eliminarbutton4.Location = new System.Drawing.Point(392, 154);
            this.Eliminarbutton4.Name = "Eliminarbutton4";
            this.Eliminarbutton4.Size = new System.Drawing.Size(83, 30);
            this.Eliminarbutton4.TabIndex = 25;
            this.Eliminarbutton4.Text = "Eliminar";
            this.Eliminarbutton4.UseVisualStyleBackColor = true;
            this.Eliminarbutton4.Click += new System.EventHandler(this.Eliminarbutton4_Click);
            // 
            // Guardarbutton3
            // 
            this.Guardarbutton3.Enabled = false;
            this.Guardarbutton3.Location = new System.Drawing.Point(529, 106);
            this.Guardarbutton3.Name = "Guardarbutton3";
            this.Guardarbutton3.Size = new System.Drawing.Size(83, 30);
            this.Guardarbutton3.TabIndex = 24;
            this.Guardarbutton3.Text = "Guardar";
            this.Guardarbutton3.UseVisualStyleBackColor = true;
            this.Guardarbutton3.Click += new System.EventHandler(this.Guardarbutton3_Click);
            // 
            // Modificarbutton2
            // 
            this.Modificarbutton2.Location = new System.Drawing.Point(440, 106);
            this.Modificarbutton2.Name = "Modificarbutton2";
            this.Modificarbutton2.Size = new System.Drawing.Size(83, 30);
            this.Modificarbutton2.TabIndex = 23;
            this.Modificarbutton2.Text = "Modificar";
            this.Modificarbutton2.UseVisualStyleBackColor = true;
            this.Modificarbutton2.Click += new System.EventHandler(this.Modificarbutton2_Click);
            // 
            // Nuevobutton1
            // 
            this.Nuevobutton1.Location = new System.Drawing.Point(351, 106);
            this.Nuevobutton1.Name = "Nuevobutton1";
            this.Nuevobutton1.Size = new System.Drawing.Size(83, 30);
            this.Nuevobutton1.TabIndex = 22;
            this.Nuevobutton1.Text = "Nuevo";
            this.Nuevobutton1.UseVisualStyleBackColor = true;
            this.Nuevobutton1.Click += new System.EventHandler(this.Nuevobutton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 166);
            this.dataGridView1.TabIndex = 27;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Productofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(652, 434);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancelarbutton5);
            this.Controls.Add(this.Eliminarbutton4);
            this.Controls.Add(this.Guardarbutton3);
            this.Controls.Add(this.Modificarbutton2);
            this.Controls.Add(this.Nuevobutton1);
            this.Controls.Add(this.ExistenciatextBox4);
            this.Controls.Add(this.PreciotextBox3);
            this.Controls.Add(this.DescripciontextBox2);
            this.Controls.Add(this.CodigotextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Productofrm";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ExistenciatextBox4;
        private System.Windows.Forms.TextBox PreciotextBox3;
        private System.Windows.Forms.TextBox DescripciontextBox2;
        private System.Windows.Forms.TextBox CodigotextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelarbutton5;
        private System.Windows.Forms.Button Eliminarbutton4;
        private System.Windows.Forms.Button Guardarbutton3;
        private System.Windows.Forms.Button Modificarbutton2;
        private System.Windows.Forms.Button Nuevobutton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}