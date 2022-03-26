namespace EXAMEN_II_Rosaysela
{
    partial class pedidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DescripciontextBox1 = new System.Windows.Forms.TextBox();
            this.CantidadtextBox2 = new System.Windows.Forms.TextBox();
            this.PreciotextBox3 = new System.Windows.Forms.TextBox();
            this.ClientetextBox4 = new System.Windows.Forms.TextBox();
            this.DirecciontextBox5 = new System.Windows.Forms.TextBox();
            this.TelefonotextBox6 = new System.Windows.Forms.TextBox();
            this.Guardarbutton1 = new System.Windows.Forms.Button();
            this.Cancelarbutton2 = new System.Windows.Forms.Button();
            this.ealizarpedidobutton3 = new System.Windows.Forms.Button();
            this.Nuevobutton4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEDIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion  Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Cliente : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccio  del cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono del cliente :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 232);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DescripciontextBox1
            // 
            this.DescripciontextBox1.Enabled = false;
            this.DescripciontextBox1.Location = new System.Drawing.Point(233, 86);
            this.DescripciontextBox1.Name = "DescripciontextBox1";
            this.DescripciontextBox1.Size = new System.Drawing.Size(142, 20);
            this.DescripciontextBox1.TabIndex = 8;
            // 
            // CantidadtextBox2
            // 
            this.CantidadtextBox2.Enabled = false;
            this.CantidadtextBox2.Location = new System.Drawing.Point(233, 120);
            this.CantidadtextBox2.Name = "CantidadtextBox2";
            this.CantidadtextBox2.Size = new System.Drawing.Size(142, 20);
            this.CantidadtextBox2.TabIndex = 9;
            // 
            // PreciotextBox3
            // 
            this.PreciotextBox3.Enabled = false;
            this.PreciotextBox3.Location = new System.Drawing.Point(233, 151);
            this.PreciotextBox3.Name = "PreciotextBox3";
            this.PreciotextBox3.Size = new System.Drawing.Size(142, 20);
            this.PreciotextBox3.TabIndex = 10;
            // 
            // ClientetextBox4
            // 
            this.ClientetextBox4.Enabled = false;
            this.ClientetextBox4.Location = new System.Drawing.Point(233, 185);
            this.ClientetextBox4.Name = "ClientetextBox4";
            this.ClientetextBox4.Size = new System.Drawing.Size(142, 20);
            this.ClientetextBox4.TabIndex = 11;
            // 
            // DirecciontextBox5
            // 
            this.DirecciontextBox5.Enabled = false;
            this.DirecciontextBox5.Location = new System.Drawing.Point(233, 216);
            this.DirecciontextBox5.Name = "DirecciontextBox5";
            this.DirecciontextBox5.Size = new System.Drawing.Size(142, 20);
            this.DirecciontextBox5.TabIndex = 12;
            // 
            // TelefonotextBox6
            // 
            this.TelefonotextBox6.Enabled = false;
            this.TelefonotextBox6.Location = new System.Drawing.Point(233, 248);
            this.TelefonotextBox6.Name = "TelefonotextBox6";
            this.TelefonotextBox6.Size = new System.Drawing.Size(142, 20);
            this.TelefonotextBox6.TabIndex = 13;
            // 
            // Guardarbutton1
            // 
            this.Guardarbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton1.Location = new System.Drawing.Point(402, 196);
            this.Guardarbutton1.Name = "Guardarbutton1";
            this.Guardarbutton1.Size = new System.Drawing.Size(106, 36);
            this.Guardarbutton1.TabIndex = 14;
            this.Guardarbutton1.Text = "Guardar";
            this.Guardarbutton1.UseVisualStyleBackColor = true;
            this.Guardarbutton1.Click += new System.EventHandler(this.Guardarbutton1_Click);
            // 
            // Cancelarbutton2
            // 
            this.Cancelarbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbutton2.Location = new System.Drawing.Point(524, 152);
            this.Cancelarbutton2.Name = "Cancelarbutton2";
            this.Cancelarbutton2.Size = new System.Drawing.Size(106, 32);
            this.Cancelarbutton2.TabIndex = 15;
            this.Cancelarbutton2.Text = "Cancelar Pedido";
            this.Cancelarbutton2.UseVisualStyleBackColor = true;
            this.Cancelarbutton2.Click += new System.EventHandler(this.Cancelarbutton2_Click);
            // 
            // ealizarpedidobutton3
            // 
            this.ealizarpedidobutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ealizarpedidobutton3.Location = new System.Drawing.Point(402, 152);
            this.ealizarpedidobutton3.Name = "ealizarpedidobutton3";
            this.ealizarpedidobutton3.Size = new System.Drawing.Size(106, 32);
            this.ealizarpedidobutton3.TabIndex = 16;
            this.ealizarpedidobutton3.Text = "Realizar pedido";
            this.ealizarpedidobutton3.UseVisualStyleBackColor = true;
            this.ealizarpedidobutton3.Click += new System.EventHandler(this.ealizarpedidobutton3_Click);
            // 
            // Nuevobutton4
            // 
            this.Nuevobutton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton4.Location = new System.Drawing.Point(402, 104);
            this.Nuevobutton4.Name = "Nuevobutton4";
            this.Nuevobutton4.Size = new System.Drawing.Size(106, 34);
            this.Nuevobutton4.TabIndex = 17;
            this.Nuevobutton4.Text = "Nuevo";
            this.Nuevobutton4.UseVisualStyleBackColor = true;
            this.Nuevobutton4.Click += new System.EventHandler(this.Nuevobutton4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(524, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Eliminarbutton7
            // 
            this.Eliminarbutton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton7.Location = new System.Drawing.Point(518, 197);
            this.Eliminarbutton7.Name = "Eliminarbutton7";
            this.Eliminarbutton7.Size = new System.Drawing.Size(112, 36);
            this.Eliminarbutton7.TabIndex = 20;
            this.Eliminarbutton7.Text = "Eliminar";
            this.Eliminarbutton7.UseVisualStyleBackColor = true;
            this.Eliminarbutton7.Click += new System.EventHandler(this.button2_Click);
            // 
            // pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(740, 522);
            this.Controls.Add(this.Eliminarbutton7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nuevobutton4);
            this.Controls.Add(this.ealizarpedidobutton3);
            this.Controls.Add(this.Cancelarbutton2);
            this.Controls.Add(this.Guardarbutton1);
            this.Controls.Add(this.TelefonotextBox6);
            this.Controls.Add(this.DirecciontextBox5);
            this.Controls.Add(this.ClientetextBox4);
            this.Controls.Add(this.PreciotextBox3);
            this.Controls.Add(this.CantidadtextBox2);
            this.Controls.Add(this.DescripciontextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "pedidos";
            this.Text = "pedidos";
            this.Load += new System.EventHandler(this.pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox DescripciontextBox1;
        private System.Windows.Forms.TextBox CantidadtextBox2;
        private System.Windows.Forms.TextBox PreciotextBox3;
        private System.Windows.Forms.TextBox ClientetextBox4;
        private System.Windows.Forms.TextBox DirecciontextBox5;
        private System.Windows.Forms.TextBox TelefonotextBox6;
        private System.Windows.Forms.Button Guardarbutton1;
        private System.Windows.Forms.Button Cancelarbutton2;
        private System.Windows.Forms.Button ealizarpedidobutton3;
        private System.Windows.Forms.Button Nuevobutton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Eliminarbutton7;
    }
}