namespace Distancia_Dos_Puntos2
{
    partial class FrmPractica1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPractica1));
            this.Label3 = new System.Windows.Forms.Label();
            this.tbDistamcia = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(319, 475);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 20);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Distancia";
            // 
            // tbDistamcia
            // 
            this.tbDistamcia.Location = new System.Drawing.Point(296, 514);
            this.tbDistamcia.Name = "tbDistamcia";
            this.tbDistamcia.Size = new System.Drawing.Size(148, 22);
            this.tbDistamcia.TabIndex = 21;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(232, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(322, 35);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Distancia entre 2 Puntos";
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(70, 231);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(78, 22);
            this.tbY1.TabIndex = 18;
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(253, 392);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(91, 22);
            this.tbX1.TabIndex = 17;
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(404, 392);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(92, 22);
            this.tbX2.TabIndex = 16;
            // 
            // tbY2
            // 
            this.tbY2.Location = new System.Drawing.Point(70, 123);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(78, 22);
            this.tbY2.TabIndex = 15;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(163, 500);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 36);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular ";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = global::Distancia_Dos_Puntos2.Properties.Resources.distancia_entre_2_puntossi;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Location = new System.Drawing.Point(163, 67);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(455, 305);
            this.PictureBox1.TabIndex = 20;
            this.PictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::Distancia_Dos_Puntos2.Properties.Resources.limpieza_de_datos;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(654, 98);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(69, 59);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Distancia_Dos_Puntos2.Properties.Resources.salida;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(654, 189);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 65);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPractica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Distancia_Dos_Puntos2.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(819, 557);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.tbDistamcia);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tbY1);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbY2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPractica1";
            this.Text = "Practica1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tbDistamcia;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tbY1;
        internal System.Windows.Forms.TextBox tbX1;
        internal System.Windows.Forms.TextBox tbX2;
        internal System.Windows.Forms.TextBox tbY2;
        internal System.Windows.Forms.Button btnLimpiar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnCalcular;
    }
}

