namespace Cine
{
    partial class Form_cartelera
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
            this.txt_idSala = new System.Windows.Forms.TextBox();
            this.txt_idHoras = new System.Windows.Forms.TextBox();
            this.txt_idCart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_carte = new System.Windows.Forms.Label();
            this.btn_salirS = new System.Windows.Forms.Button();
            this.btn_limpiarC = new System.Windows.Forms.Button();
            this.btn_insertarC = new System.Windows.Forms.Button();
            this.btn_mostrarC = new System.Windows.Forms.Button();
            this.dgv_carte = new System.Windows.Forms.DataGridView();
            this.txt_idPel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carte)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_idSala
            // 
            this.txt_idSala.Location = new System.Drawing.Point(216, 140);
            this.txt_idSala.Name = "txt_idSala";
            this.txt_idSala.Size = new System.Drawing.Size(77, 20);
            this.txt_idSala.TabIndex = 48;
            // 
            // txt_idHoras
            // 
            this.txt_idHoras.Location = new System.Drawing.Point(462, 104);
            this.txt_idHoras.Name = "txt_idHoras";
            this.txt_idHoras.Size = new System.Drawing.Size(87, 20);
            this.txt_idHoras.TabIndex = 47;
            // 
            // txt_idCart
            // 
            this.txt_idCart.Location = new System.Drawing.Point(216, 104);
            this.txt_idCart.Name = "txt_idCart";
            this.txt_idCart.Size = new System.Drawing.Size(77, 20);
            this.txt_idCart.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label4.Location = new System.Drawing.Point(359, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Id Horarios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label2.Location = new System.Drawing.Point(109, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Id Sala:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label1.Location = new System.Drawing.Point(109, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Id Cartelera:";
            // 
            // label_carte
            // 
            this.label_carte.AutoSize = true;
            this.label_carte.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label_carte.ForeColor = System.Drawing.Color.White;
            this.label_carte.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label_carte.Location = new System.Drawing.Point(277, 25);
            this.label_carte.Name = "label_carte";
            this.label_carte.Size = new System.Drawing.Size(135, 36);
            this.label_carte.TabIndex = 42;
            this.label_carte.Text = "Cartelera";
            // 
            // btn_salirS
            // 
            this.btn_salirS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_salirS.ForeColor = System.Drawing.Color.White;
            this.btn_salirS.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_salirS.Location = new System.Drawing.Point(643, 3);
            this.btn_salirS.Name = "btn_salirS";
            this.btn_salirS.Size = new System.Drawing.Size(39, 39);
            this.btn_salirS.TabIndex = 41;
            this.btn_salirS.Text = "x";
            this.btn_salirS.UseVisualStyleBackColor = true;
            this.btn_salirS.Click += new System.EventHandler(this.btn_salirS_Click);
            // 
            // btn_limpiarC
            // 
            this.btn_limpiarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_limpiarC.ForeColor = System.Drawing.Color.White;
            this.btn_limpiarC.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_limpiarC.Location = new System.Drawing.Point(419, 202);
            this.btn_limpiarC.Name = "btn_limpiarC";
            this.btn_limpiarC.Size = new System.Drawing.Size(105, 41);
            this.btn_limpiarC.TabIndex = 40;
            this.btn_limpiarC.Text = "Limpiar";
            this.btn_limpiarC.UseVisualStyleBackColor = true;
            this.btn_limpiarC.Click += new System.EventHandler(this.btn_limpiarC_Click);
            // 
            // btn_insertarC
            // 
            this.btn_insertarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_insertarC.ForeColor = System.Drawing.Color.White;
            this.btn_insertarC.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_insertarC.Location = new System.Drawing.Point(291, 202);
            this.btn_insertarC.Name = "btn_insertarC";
            this.btn_insertarC.Size = new System.Drawing.Size(105, 41);
            this.btn_insertarC.TabIndex = 38;
            this.btn_insertarC.Text = "Insertar";
            this.btn_insertarC.UseVisualStyleBackColor = true;
            this.btn_insertarC.Click += new System.EventHandler(this.btn_insertarC_Click);
            // 
            // btn_mostrarC
            // 
            this.btn_mostrarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_mostrarC.ForeColor = System.Drawing.Color.White;
            this.btn_mostrarC.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_mostrarC.Location = new System.Drawing.Point(163, 202);
            this.btn_mostrarC.Name = "btn_mostrarC";
            this.btn_mostrarC.Size = new System.Drawing.Size(105, 41);
            this.btn_mostrarC.TabIndex = 37;
            this.btn_mostrarC.Text = "Mostrar";
            this.btn_mostrarC.UseVisualStyleBackColor = true;
            this.btn_mostrarC.Click += new System.EventHandler(this.btn_mostrarC_Click);
            // 
            // dgv_carte
            // 
            this.dgv_carte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carte.Location = new System.Drawing.Point(81, 261);
            this.dgv_carte.Name = "dgv_carte";
            this.dgv_carte.Size = new System.Drawing.Size(487, 150);
            this.dgv_carte.TabIndex = 36;
            this.dgv_carte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_carte_CellClick);
            // 
            // txt_idPel
            // 
            this.txt_idPel.Location = new System.Drawing.Point(462, 140);
            this.txt_idPel.Name = "txt_idPel";
            this.txt_idPel.Size = new System.Drawing.Size(87, 20);
            this.txt_idPel.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label3.Location = new System.Drawing.Point(359, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Id Peliculas:";
            // 
            // Form_cartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.ClientSize = new System.Drawing.Size(684, 435);
            this.Controls.Add(this.txt_idPel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_idSala);
            this.Controls.Add(this.txt_idHoras);
            this.Controls.Add(this.txt_idCart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_carte);
            this.Controls.Add(this.btn_salirS);
            this.Controls.Add(this.btn_limpiarC);
            this.Controls.Add(this.btn_insertarC);
            this.Controls.Add(this.btn_mostrarC);
            this.Controls.Add(this.dgv_carte);
            this.Name = "Form_cartelera";
            this.Text = "Form_cartelera";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_idSala;
        private System.Windows.Forms.TextBox txt_idHoras;
        private System.Windows.Forms.TextBox txt_idCart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_carte;
        private System.Windows.Forms.Button btn_salirS;
        private System.Windows.Forms.Button btn_limpiarC;
        private System.Windows.Forms.Button btn_insertarC;
        private System.Windows.Forms.Button btn_mostrarC;
        private System.Windows.Forms.DataGridView dgv_carte;
        private System.Windows.Forms.TextBox txt_idPel;
        private System.Windows.Forms.Label label3;
    }
}