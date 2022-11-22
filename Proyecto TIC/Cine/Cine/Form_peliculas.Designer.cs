namespace Cine
{
    partial class Form_peliculas
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
            this.dgv_pelis = new System.Windows.Forms.DataGridView();
            this.btn_mostrarP = new System.Windows.Forms.Button();
            this.btn_insertarP = new System.Windows.Forms.Button();
            this.btn_eliminarP = new System.Windows.Forms.Button();
            this.btn_actualiarP = new System.Windows.Forms.Button();
            this.btn_limpiarP = new System.Windows.Forms.Button();
            this.btn_salirP = new System.Windows.Forms.Button();
            this.label_peli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idP = new System.Windows.Forms.TextBox();
            this.txt_duracionP = new System.Windows.Forms.TextBox();
            this.txt_caliP = new System.Windows.Forms.TextBox();
            this.txt_generoP = new System.Windows.Forms.TextBox();
            this.txt_tituloP = new System.Windows.Forms.TextBox();
            this.btn_txt = new System.Windows.Forms.Button();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pelis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pelis
            // 
            this.dgv_pelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pelis.Location = new System.Drawing.Point(82, 239);
            this.dgv_pelis.Name = "dgv_pelis";
            this.dgv_pelis.Size = new System.Drawing.Size(487, 150);
            this.dgv_pelis.TabIndex = 0;
            this.dgv_pelis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pelis_CellClick);
            // 
            // btn_mostrarP
            // 
            this.btn_mostrarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_mostrarP.ForeColor = System.Drawing.Color.White;
            this.btn_mostrarP.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_mostrarP.Location = new System.Drawing.Point(61, 178);
            this.btn_mostrarP.Name = "btn_mostrarP";
            this.btn_mostrarP.Size = new System.Drawing.Size(105, 41);
            this.btn_mostrarP.TabIndex = 1;
            this.btn_mostrarP.Text = "Mostrar";
            this.btn_mostrarP.UseVisualStyleBackColor = true;
            this.btn_mostrarP.Click += new System.EventHandler(this.btn_mostrarP_Click);
            // 
            // btn_insertarP
            // 
            this.btn_insertarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_insertarP.ForeColor = System.Drawing.Color.White;
            this.btn_insertarP.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_insertarP.Location = new System.Drawing.Point(172, 178);
            this.btn_insertarP.Name = "btn_insertarP";
            this.btn_insertarP.Size = new System.Drawing.Size(105, 41);
            this.btn_insertarP.TabIndex = 2;
            this.btn_insertarP.Text = "Insertar";
            this.btn_insertarP.UseVisualStyleBackColor = true;
            this.btn_insertarP.Click += new System.EventHandler(this.btn_insertarP_Click);
            // 
            // btn_eliminarP
            // 
            this.btn_eliminarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_eliminarP.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarP.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_eliminarP.Location = new System.Drawing.Point(283, 178);
            this.btn_eliminarP.Name = "btn_eliminarP";
            this.btn_eliminarP.Size = new System.Drawing.Size(105, 41);
            this.btn_eliminarP.TabIndex = 3;
            this.btn_eliminarP.Text = "Eliminar";
            this.btn_eliminarP.UseVisualStyleBackColor = true;
            this.btn_eliminarP.Click += new System.EventHandler(this.btn_eliminarP_Click);
            // 
            // btn_actualiarP
            // 
            this.btn_actualiarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_actualiarP.ForeColor = System.Drawing.Color.White;
            this.btn_actualiarP.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_actualiarP.Location = new System.Drawing.Point(394, 178);
            this.btn_actualiarP.Name = "btn_actualiarP";
            this.btn_actualiarP.Size = new System.Drawing.Size(105, 41);
            this.btn_actualiarP.TabIndex = 4;
            this.btn_actualiarP.Text = "Actualizar";
            this.btn_actualiarP.UseVisualStyleBackColor = true;
            this.btn_actualiarP.Click += new System.EventHandler(this.btn_actualiarP_Click);
            // 
            // btn_limpiarP
            // 
            this.btn_limpiarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_limpiarP.ForeColor = System.Drawing.Color.White;
            this.btn_limpiarP.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_limpiarP.Location = new System.Drawing.Point(505, 178);
            this.btn_limpiarP.Name = "btn_limpiarP";
            this.btn_limpiarP.Size = new System.Drawing.Size(105, 41);
            this.btn_limpiarP.TabIndex = 5;
            this.btn_limpiarP.Text = "Limpiar";
            this.btn_limpiarP.UseVisualStyleBackColor = true;
            this.btn_limpiarP.Click += new System.EventHandler(this.btn_limpiarP_Click);
            // 
            // btn_salirP
            // 
            this.btn_salirP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_salirP.ForeColor = System.Drawing.Color.White;
            this.btn_salirP.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_salirP.Location = new System.Drawing.Point(645, 1);
            this.btn_salirP.Name = "btn_salirP";
            this.btn_salirP.Size = new System.Drawing.Size(39, 39);
            this.btn_salirP.TabIndex = 6;
            this.btn_salirP.Text = "x";
            this.btn_salirP.UseVisualStyleBackColor = true;
            this.btn_salirP.Click += new System.EventHandler(this.btn_salirP_Click);
            // 
            // label_peli
            // 
            this.label_peli.AutoSize = true;
            this.label_peli.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label_peli.ForeColor = System.Drawing.Color.White;
            this.label_peli.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label_peli.Location = new System.Drawing.Point(277, 9);
            this.label_peli.Name = "label_peli";
            this.label_peli.Size = new System.Drawing.Size(135, 36);
            this.label_peli.TabIndex = 7;
            this.label_peli.Text = "Peliculas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label1.Location = new System.Drawing.Point(61, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id Pelicula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label2.Location = new System.Drawing.Point(61, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label3.Location = new System.Drawing.Point(259, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Duracion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label4.Location = new System.Drawing.Point(259, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label5.Location = new System.Drawing.Point(440, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Clasificacion:";
            // 
            // txt_idP
            // 
            this.txt_idP.Location = new System.Drawing.Point(148, 74);
            this.txt_idP.Name = "txt_idP";
            this.txt_idP.Size = new System.Drawing.Size(77, 20);
            this.txt_idP.TabIndex = 13;
            // 
            // txt_duracionP
            // 
            this.txt_duracionP.Location = new System.Drawing.Point(347, 131);
            this.txt_duracionP.Name = "txt_duracionP";
            this.txt_duracionP.Size = new System.Drawing.Size(95, 20);
            this.txt_duracionP.TabIndex = 14;
            // 
            // txt_caliP
            // 
            this.txt_caliP.Location = new System.Drawing.Point(556, 78);
            this.txt_caliP.Name = "txt_caliP";
            this.txt_caliP.Size = new System.Drawing.Size(77, 20);
            this.txt_caliP.TabIndex = 15;
            // 
            // txt_generoP
            // 
            this.txt_generoP.Location = new System.Drawing.Point(325, 76);
            this.txt_generoP.Name = "txt_generoP";
            this.txt_generoP.Size = new System.Drawing.Size(87, 20);
            this.txt_generoP.TabIndex = 16;
            // 
            // txt_tituloP
            // 
            this.txt_tituloP.Location = new System.Drawing.Point(122, 124);
            this.txt_tituloP.Name = "txt_tituloP";
            this.txt_tituloP.Size = new System.Drawing.Size(103, 20);
            this.txt_tituloP.TabIndex = 17;
            // 
            // btn_txt
            // 
            this.btn_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_txt.ForeColor = System.Drawing.Color.White;
            this.btn_txt.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_txt.Location = new System.Drawing.Point(587, 348);
            this.btn_txt.Name = "btn_txt";
            this.btn_txt.Size = new System.Drawing.Size(85, 41);
            this.btn_txt.TabIndex = 18;
            this.btn_txt.Text = "txt";
            this.btn_txt.UseVisualStyleBackColor = true;
            this.btn_txt.Click += new System.EventHandler(this.btn_txt_Click);
            // 
            // btn_pdf
            // 
            this.btn_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_pdf.ForeColor = System.Drawing.Color.White;
            this.btn_pdf.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_pdf.Location = new System.Drawing.Point(587, 301);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(85, 41);
            this.btn_pdf.TabIndex = 19;
            this.btn_pdf.Text = "pdf";
            this.btn_pdf.UseVisualStyleBackColor = true;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_excel.ForeColor = System.Drawing.Color.White;
            this.btn_excel.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_excel.Location = new System.Drawing.Point(587, 254);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(85, 41);
            this.btn_excel.TabIndex = 20;
            this.btn_excel.Text = "excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // Form_peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.ClientSize = new System.Drawing.Size(684, 435);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.btn_txt);
            this.Controls.Add(this.txt_tituloP);
            this.Controls.Add(this.txt_generoP);
            this.Controls.Add(this.txt_caliP);
            this.Controls.Add(this.txt_duracionP);
            this.Controls.Add(this.txt_idP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_peli);
            this.Controls.Add(this.btn_salirP);
            this.Controls.Add(this.btn_limpiarP);
            this.Controls.Add(this.btn_actualiarP);
            this.Controls.Add(this.btn_eliminarP);
            this.Controls.Add(this.btn_insertarP);
            this.Controls.Add(this.btn_mostrarP);
            this.Controls.Add(this.dgv_pelis);
            this.Name = "Form_peliculas";
            this.Text = "Form_peliculas";
            this.Load += new System.EventHandler(this.Form_peliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pelis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pelis;
        private System.Windows.Forms.Button btn_mostrarP;
        private System.Windows.Forms.Button btn_insertarP;
        private System.Windows.Forms.Button btn_eliminarP;
        private System.Windows.Forms.Button btn_actualiarP;
        private System.Windows.Forms.Button btn_limpiarP;
        private System.Windows.Forms.Button btn_salirP;
        private System.Windows.Forms.Label label_peli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idP;
        private System.Windows.Forms.TextBox txt_duracionP;
        private System.Windows.Forms.TextBox txt_caliP;
        private System.Windows.Forms.TextBox txt_generoP;
        private System.Windows.Forms.TextBox txt_tituloP;
        private System.Windows.Forms.Button btn_txt;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Button btn_excel;
    }
}