namespace Cine
{
    partial class Form_sala
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
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.txt_idSala = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_sala = new System.Windows.Forms.Label();
            this.btn_salirS = new System.Windows.Forms.Button();
            this.btn_limpiarS = new System.Windows.Forms.Button();
            this.btn_actualiarS = new System.Windows.Forms.Button();
            this.btn_insertarS = new System.Windows.Forms.Button();
            this.btn_mostrarS = new System.Windows.Forms.Button();
            this.dgv_sala = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sala)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(322, 115);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(103, 20);
            this.txt_nom.TabIndex = 35;
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(554, 115);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(87, 20);
            this.txt_des.TabIndex = 34;
            // 
            // txt_idSala
            // 
            this.txt_idSala.Location = new System.Drawing.Point(118, 115);
            this.txt_idSala.Name = "txt_idSala";
            this.txt_idSala.Size = new System.Drawing.Size(77, 20);
            this.txt_idSala.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label4.Location = new System.Drawing.Point(444, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label2.Location = new System.Drawing.Point(243, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label1.Location = new System.Drawing.Point(31, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Id Sala:";
            // 
            // label_sala
            // 
            this.label_sala.AutoSize = true;
            this.label_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label_sala.ForeColor = System.Drawing.Color.White;
            this.label_sala.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label_sala.Location = new System.Drawing.Point(279, 23);
            this.label_sala.Name = "label_sala";
            this.label_sala.Size = new System.Drawing.Size(89, 36);
            this.label_sala.TabIndex = 25;
            this.label_sala.Text = "Salas";
            // 
            // btn_salirS
            // 
            this.btn_salirS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_salirS.ForeColor = System.Drawing.Color.White;
            this.btn_salirS.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_salirS.Location = new System.Drawing.Point(645, 1);
            this.btn_salirS.Name = "btn_salirS";
            this.btn_salirS.Size = new System.Drawing.Size(39, 39);
            this.btn_salirS.TabIndex = 24;
            this.btn_salirS.Text = "x";
            this.btn_salirS.UseVisualStyleBackColor = true;
            this.btn_salirS.Click += new System.EventHandler(this.btn_salirS_Click);
            // 
            // btn_limpiarS
            // 
            this.btn_limpiarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_limpiarS.ForeColor = System.Drawing.Color.White;
            this.btn_limpiarS.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_limpiarS.Location = new System.Drawing.Point(465, 200);
            this.btn_limpiarS.Name = "btn_limpiarS";
            this.btn_limpiarS.Size = new System.Drawing.Size(105, 41);
            this.btn_limpiarS.TabIndex = 23;
            this.btn_limpiarS.Text = "Limpiar";
            this.btn_limpiarS.UseVisualStyleBackColor = true;
            this.btn_limpiarS.Click += new System.EventHandler(this.btn_limpiarS_Click);
            // 
            // btn_actualiarS
            // 
            this.btn_actualiarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_actualiarS.ForeColor = System.Drawing.Color.White;
            this.btn_actualiarS.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_actualiarS.Location = new System.Drawing.Point(339, 200);
            this.btn_actualiarS.Name = "btn_actualiarS";
            this.btn_actualiarS.Size = new System.Drawing.Size(105, 41);
            this.btn_actualiarS.TabIndex = 22;
            this.btn_actualiarS.Text = "Actualizar";
            this.btn_actualiarS.UseVisualStyleBackColor = true;
            this.btn_actualiarS.Click += new System.EventHandler(this.btn_actualiarS_Click);
            // 
            // btn_insertarS
            // 
            this.btn_insertarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_insertarS.ForeColor = System.Drawing.Color.White;
            this.btn_insertarS.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_insertarS.Location = new System.Drawing.Point(211, 200);
            this.btn_insertarS.Name = "btn_insertarS";
            this.btn_insertarS.Size = new System.Drawing.Size(105, 41);
            this.btn_insertarS.TabIndex = 20;
            this.btn_insertarS.Text = "Insertar";
            this.btn_insertarS.UseVisualStyleBackColor = true;
            this.btn_insertarS.Click += new System.EventHandler(this.btn_insertarS_Click);
            // 
            // btn_mostrarS
            // 
            this.btn_mostrarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_mostrarS.ForeColor = System.Drawing.Color.White;
            this.btn_mostrarS.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_mostrarS.Location = new System.Drawing.Point(83, 200);
            this.btn_mostrarS.Name = "btn_mostrarS";
            this.btn_mostrarS.Size = new System.Drawing.Size(105, 41);
            this.btn_mostrarS.TabIndex = 19;
            this.btn_mostrarS.Text = "Mostrar";
            this.btn_mostrarS.UseVisualStyleBackColor = true;
            this.btn_mostrarS.Click += new System.EventHandler(this.btn_mostrarS_Click);
            // 
            // dgv_sala
            // 
            this.dgv_sala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sala.Location = new System.Drawing.Point(83, 259);
            this.dgv_sala.Name = "dgv_sala";
            this.dgv_sala.Size = new System.Drawing.Size(487, 150);
            this.dgv_sala.TabIndex = 18;
            this.dgv_sala.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sala_CellClick);
            // 
            // Form_sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.ClientSize = new System.Drawing.Size(684, 435);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.txt_idSala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_sala);
            this.Controls.Add(this.btn_salirS);
            this.Controls.Add(this.btn_limpiarS);
            this.Controls.Add(this.btn_actualiarS);
            this.Controls.Add(this.btn_insertarS);
            this.Controls.Add(this.btn_mostrarS);
            this.Controls.Add(this.dgv_sala);
            this.Name = "Form_sala";
            this.Text = "Form_sala";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.TextBox txt_idSala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_sala;
        private System.Windows.Forms.Button btn_salirS;
        private System.Windows.Forms.Button btn_limpiarS;
        private System.Windows.Forms.Button btn_actualiarS;
        private System.Windows.Forms.Button btn_insertarS;
        private System.Windows.Forms.Button btn_mostrarS;
        private System.Windows.Forms.DataGridView dgv_sala;
    }
}