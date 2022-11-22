namespace Cine
{
    partial class Menu_cine
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
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_cartelera = new System.Windows.Forms.Button();
            this.btn_horarios = new System.Windows.Forms.Button();
            this.btn_sala = new System.Windows.Forms.Button();
            this.btn_peli = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_central = new System.Windows.Forms.Panel();
            this.panel_lateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.Transparent;
            this.panel_lateral.Controls.Add(this.btn_cerrar);
            this.panel_lateral.Controls.Add(this.btn_cartelera);
            this.panel_lateral.Controls.Add(this.btn_horarios);
            this.panel_lateral.Controls.Add(this.btn_sala);
            this.panel_lateral.Controls.Add(this.btn_peli);
            this.panel_lateral.Controls.Add(this.panel_logo);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(200, 435);
            this.panel_lateral.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_cerrar.Location = new System.Drawing.Point(0, 395);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(37, 40);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "x";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_cartelera
            // 
            this.btn_cartelera.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cartelera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_cartelera.ForeColor = System.Drawing.Color.White;
            this.btn_cartelera.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_cartelera.Location = new System.Drawing.Point(0, 321);
            this.btn_cartelera.Name = "btn_cartelera";
            this.btn_cartelera.Size = new System.Drawing.Size(200, 50);
            this.btn_cartelera.TabIndex = 4;
            this.btn_cartelera.Text = "Cartelera";
            this.btn_cartelera.UseVisualStyleBackColor = true;
            this.btn_cartelera.Click += new System.EventHandler(this.btn_cartelera_Click);
            // 
            // btn_horarios
            // 
            this.btn_horarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_horarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_horarios.ForeColor = System.Drawing.Color.White;
            this.btn_horarios.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_horarios.Location = new System.Drawing.Point(0, 271);
            this.btn_horarios.Name = "btn_horarios";
            this.btn_horarios.Size = new System.Drawing.Size(200, 50);
            this.btn_horarios.TabIndex = 3;
            this.btn_horarios.Text = "Horarios";
            this.btn_horarios.UseVisualStyleBackColor = true;
            this.btn_horarios.Click += new System.EventHandler(this.btn_horarios_Click);
            // 
            // btn_sala
            // 
            this.btn_sala.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_sala.ForeColor = System.Drawing.Color.White;
            this.btn_sala.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_sala.Location = new System.Drawing.Point(0, 221);
            this.btn_sala.Name = "btn_sala";
            this.btn_sala.Size = new System.Drawing.Size(200, 50);
            this.btn_sala.TabIndex = 2;
            this.btn_sala.Text = "Sala";
            this.btn_sala.UseVisualStyleBackColor = true;
            this.btn_sala.Click += new System.EventHandler(this.btn_sala_Click);
            // 
            // btn_peli
            // 
            this.btn_peli.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_peli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_peli.ForeColor = System.Drawing.Color.White;
            this.btn_peli.Image = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.btn_peli.Location = new System.Drawing.Point(0, 171);
            this.btn_peli.Name = "btn_peli";
            this.btn_peli.Size = new System.Drawing.Size(200, 50);
            this.btn_peli.TabIndex = 1;
            this.btn_peli.Text = "Peliculas";
            this.btn_peli.UseVisualStyleBackColor = true;
            this.btn_peli.Click += new System.EventHandler(this.btn_peli_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackgroundImage = global::Cine.Properties.Resources.logo_cine;
            this.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(200, 171);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_central
            // 
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(200, 0);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(734, 435);
            this.panel_central.TabIndex = 1;
            // 
            // Menu_cine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Cine.Properties.Resources.MicrosoftTeams_image__13_;
            this.ClientSize = new System.Drawing.Size(934, 435);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_lateral);
            this.Name = "Menu_cine";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_cine_Load);
            this.panel_lateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button btn_cartelera;
        private System.Windows.Forms.Button btn_horarios;
        private System.Windows.Forms.Button btn_sala;
        private System.Windows.Forms.Button btn_peli;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Panel panel_central;
    }
}

