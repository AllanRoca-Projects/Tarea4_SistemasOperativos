namespace Tarea4_Procesos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Img2 = new System.Windows.Forms.PictureBox();
            this.Img3 = new System.Windows.Forms.PictureBox();
            this.Img4 = new System.Windows.Forms.PictureBox();
            this.Img1 = new System.Windows.Forms.PictureBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.tmrCarrera = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGanador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(950, 86);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(135, 38);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "INCIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Img2);
            this.panel1.Controls.Add(this.Img3);
            this.panel1.Controls.Add(this.Img4);
            this.panel1.Controls.Add(this.Img1);
            this.panel1.Location = new System.Drawing.Point(10, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 479);
            this.panel1.TabIndex = 1;
            // 
            // Img2
            // 
            this.Img2.Location = new System.Drawing.Point(53, 134);
            this.Img2.Name = "Img2";
            this.Img2.Size = new System.Drawing.Size(76, 62);
            this.Img2.TabIndex = 3;
            this.Img2.TabStop = false;
            // 
            // Img3
            // 
            this.Img3.Location = new System.Drawing.Point(53, 224);
            this.Img3.Name = "Img3";
            this.Img3.Size = new System.Drawing.Size(76, 62);
            this.Img3.TabIndex = 2;
            this.Img3.TabStop = false;
            // 
            // Img4
            // 
            this.Img4.Location = new System.Drawing.Point(53, 315);
            this.Img4.Name = "Img4";
            this.Img4.Size = new System.Drawing.Size(76, 62);
            this.Img4.TabIndex = 1;
            this.Img4.TabStop = false;
            // 
            // Img1
            // 
            this.Img1.Location = new System.Drawing.Point(53, 49);
            this.Img1.Name = "Img1";
            this.Img1.Size = new System.Drawing.Size(76, 62);
            this.Img1.TabIndex = 0;
            this.Img1.TabStop = false;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(946, 13);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(118, 24);
            this.lblCarrera.TabIndex = 2;
            this.lblCarrera.Text = "CARRERAS";
            // 
            // tmrCarrera
            // 
            this.tmrCarrera.Tick += new System.EventHandler(this.tmrCarrera_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(664, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 374);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Location = new System.Drawing.Point(860, 269);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(0, 17);
            this.lblGanador.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "META";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 494);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Img2;
        private System.Windows.Forms.PictureBox Img3;
        private System.Windows.Forms.PictureBox Img4;
        private System.Windows.Forms.PictureBox Img1;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Timer tmrCarrera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.Label label1;
    }
}

