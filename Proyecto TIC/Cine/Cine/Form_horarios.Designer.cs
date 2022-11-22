namespace Cine
{
    partial class Form_horarios
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
            this.label_horas = new System.Windows.Forms.Label();
            this.btn_salirH = new System.Windows.Forms.Button();
            this.dgv_horas = new System.Windows.Forms.DataGridView();
            this.btn_limpiarH = new System.Windows.Forms.Button();
            this.btn_actualiarH = new System.Windows.Forms.Button();
            this.btn_insertarH = new System.Windows.Forms.Button();
            this.btn_mostrarH = new System.Windows.Forms.Button();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.txt_idhora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horas)).BeginInit();
            this.SuspendLayout();
            // 
            // label_horas
            // 
            this.label_horas.AutoSize = true;
            this.label_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label_horas.ForeColor = System.Drawing.Color.White;
            this.label_horas.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label_horas.Location = new System.Drawing.Point(256, 25);
            this.label_horas.Name = "label_horas";
            this.label_horas.Size = new System.Drawing.Size(128, 36);
            this.label_horas.TabIndex = 26;
            this.label_horas.Text = "Horarios";
            // 
            // btn_salirH
            // 
            this.btn_salirH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_salirH.ForeColor = System.Drawing.Color.White;
            this.btn_salirH.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_salirH.Location = new System.Drawing.Point(644, 1);
            this.btn_salirH.Name = "btn_salirH";
            this.btn_salirH.Size = new System.Drawing.Size(39, 39);
            this.btn_salirH.TabIndex = 27;
            this.btn_salirH.Text = "x";
            this.btn_salirH.UseVisualStyleBackColor = true;
            this.btn_salirH.Click += new System.EventHandler(this.btn_salirH_Click);
            // 
            // dgv_horas
            // 
            this.dgv_horas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horas.Location = new System.Drawing.Point(73, 231);
            this.dgv_horas.Name = "dgv_horas";
            this.dgv_horas.Size = new System.Drawing.Size(479, 150);
            this.dgv_horas.TabIndex = 28;
            this.dgv_horas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_horas_CellClick);
            // 
            // btn_limpiarH
            // 
            this.btn_limpiarH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_limpiarH.ForeColor = System.Drawing.Color.White;
            this.btn_limpiarH.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_limpiarH.Location = new System.Drawing.Point(452, 165);
            this.btn_limpiarH.Name = "btn_limpiarH";
            this.btn_limpiarH.Size = new System.Drawing.Size(105, 41);
            this.btn_limpiarH.TabIndex = 32;
            this.btn_limpiarH.Text = "Limpiar";
            this.btn_limpiarH.UseVisualStyleBackColor = true;
            this.btn_limpiarH.Click += new System.EventHandler(this.btn_limpiarH_Click);
            // 
            // btn_actualiarH
            // 
            this.btn_actualiarH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_actualiarH.ForeColor = System.Drawing.Color.White;
            this.btn_actualiarH.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_actualiarH.Location = new System.Drawing.Point(326, 165);
            this.btn_actualiarH.Name = "btn_actualiarH";
            this.btn_actualiarH.Size = new System.Drawing.Size(105, 41);
            this.btn_actualiarH.TabIndex = 31;
            this.btn_actualiarH.Text = "Actualizar";
            this.btn_actualiarH.UseVisualStyleBackColor = true;
            this.btn_actualiarH.Click += new System.EventHandler(this.btn_actualiarH_Click);
            // 
            // btn_insertarH
            // 
            this.btn_insertarH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_insertarH.ForeColor = System.Drawing.Color.White;
            this.btn_insertarH.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_insertarH.Location = new System.Drawing.Point(198, 165);
            this.btn_insertarH.Name = "btn_insertarH";
            this.btn_insertarH.Size = new System.Drawing.Size(105, 41);
            this.btn_insertarH.TabIndex = 30;
            this.btn_insertarH.Text = "Insertar";
            this.btn_insertarH.UseVisualStyleBackColor = true;
            this.btn_insertarH.Click += new System.EventHandler(this.btn_insertarH_Click);
            // 
            // btn_mostrarH
            // 
            this.btn_mostrarH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_mostrarH.ForeColor = System.Drawing.Color.White;
            this.btn_mostrarH.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_mostrarH.Location = new System.Drawing.Point(70, 165);
            this.btn_mostrarH.Name = "btn_mostrarH";
            this.btn_mostrarH.Size = new System.Drawing.Size(105, 41);
            this.btn_mostrarH.TabIndex = 29;
            this.btn_mostrarH.Text = "Mostrar";
            this.btn_mostrarH.UseVisualStyleBackColor = true;
            this.btn_mostrarH.Click += new System.EventHandler(this.btn_mostrarH_Click);
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(415, 99);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(103, 20);
            this.txt_hora.TabIndex = 39;
            // 
            // txt_idhora
            // 
            this.txt_idhora.Location = new System.Drawing.Point(211, 99);
            this.txt_idhora.Name = "txt_idhora";
            this.txt_idhora.Size = new System.Drawing.Size(77, 20);
            this.txt_idhora.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label2.Location = new System.Drawing.Point(336, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.label1.Location = new System.Drawing.Point(124, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Id Horario:";
            // 
            // Form_horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.ClientSize = new System.Drawing.Size(684, 435);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.txt_idhora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_limpiarH);
            this.Controls.Add(this.btn_actualiarH);
            this.Controls.Add(this.btn_insertarH);
            this.Controls.Add(this.btn_mostrarH);
            this.Controls.Add(this.dgv_horas);
            this.Controls.Add(this.btn_salirH);
            this.Controls.Add(this.label_horas);
            this.Name = "Form_horarios";
            this.Text = "Form_horarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_horas;
        private System.Windows.Forms.Button btn_salirH;
        private System.Windows.Forms.DataGridView dgv_horas;
        private System.Windows.Forms.Button btn_limpiarH;
        private System.Windows.Forms.Button btn_actualiarH;
        private System.Windows.Forms.Button btn_insertarH;
        private System.Windows.Forms.Button btn_mostrarH;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.TextBox txt_idhora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}