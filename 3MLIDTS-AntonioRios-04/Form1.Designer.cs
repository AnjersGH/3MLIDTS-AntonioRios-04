namespace _3MLIDTS_AntonioRios_04
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
            this.lablbNombreel1 = new System.Windows.Forms.Label();
            this.lbApelllido = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbEstatura = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbEstatura = new System.Windows.Forms.TextBox();
            this.rbMaculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lablbNombreel1
            // 
            this.lablbNombreel1.AutoSize = true;
            this.lablbNombreel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lablbNombreel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lablbNombreel1.ForeColor = System.Drawing.Color.Snow;
            this.lablbNombreel1.Location = new System.Drawing.Point(105, 60);
            this.lablbNombreel1.Name = "lablbNombreel1";
            this.lablbNombreel1.Size = new System.Drawing.Size(90, 26);
            this.lablbNombreel1.TabIndex = 0;
            this.lablbNombreel1.Text = "Nombre";
            // 
            // lbApelllido
            // 
            this.lbApelllido.AutoSize = true;
            this.lbApelllido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbApelllido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbApelllido.ForeColor = System.Drawing.Color.White;
            this.lbApelllido.Location = new System.Drawing.Point(297, 60);
            this.lbApelllido.Name = "lbApelllido";
            this.lbApelllido.Size = new System.Drawing.Size(90, 26);
            this.lbApelllido.TabIndex = 1;
            this.lbApelllido.Text = "Apellido";
            this.lbApelllido.Click += new System.EventHandler(this.lbApelllido_Click);
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbTelefono.Location = new System.Drawing.Point(502, 60);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(95, 26);
            this.lbTelefono.TabIndex = 2;
            this.lbTelefono.Text = "Telefono";
            this.lbTelefono.Click += new System.EventHandler(this.lbTelefono_Click);
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbEdad.Location = new System.Drawing.Point(216, 124);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(63, 26);
            this.lbEdad.TabIndex = 3;
            this.lbEdad.Text = "Edad";
            this.lbEdad.Click += new System.EventHandler(this.lbEdad_Click);
            // 
            // lbEstatura
            // 
            this.lbEstatura.AutoSize = true;
            this.lbEstatura.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEstatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbEstatura.ForeColor = System.Drawing.Color.White;
            this.lbEstatura.Location = new System.Drawing.Point(425, 124);
            this.lbEstatura.Name = "lbEstatura";
            this.lbEstatura.Size = new System.Drawing.Size(93, 26);
            this.lbEstatura.TabIndex = 4;
            this.lbEstatura.Text = "Estatura";
            this.lbEstatura.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Location = new System.Drawing.Point(54, 93);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(180, 22);
            this.tbNombre.TabIndex = 5;
            this.tbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNombre_KeyDown);
            // 
            // tbApellido
            // 
            this.tbApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApellido.Location = new System.Drawing.Point(249, 93);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(185, 22);
            this.tbApellido.TabIndex = 6;
            this.tbApellido.TextChanged += new System.EventHandler(this.tbApellido_TextChanged);
            // 
            // tbTelefono
            // 
            this.tbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelefono.Location = new System.Drawing.Point(452, 93);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(188, 22);
            this.tbTelefono.TabIndex = 7;
            // 
            // tbEdad
            // 
            this.tbEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdad.Location = new System.Drawing.Point(143, 153);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(202, 22);
            this.tbEdad.TabIndex = 8;
            // 
            // tbEstatura
            // 
            this.tbEstatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEstatura.Location = new System.Drawing.Point(374, 153);
            this.tbEstatura.Name = "tbEstatura";
            this.tbEstatura.Size = new System.Drawing.Size(202, 22);
            this.tbEstatura.TabIndex = 9;
            // 
            // rbMaculino
            // 
            this.rbMaculino.AutoSize = true;
            this.rbMaculino.ForeColor = System.Drawing.Color.White;
            this.rbMaculino.Location = new System.Drawing.Point(41, 26);
            this.rbMaculino.Name = "rbMaculino";
            this.rbMaculino.Size = new System.Drawing.Size(89, 20);
            this.rbMaculino.TabIndex = 10;
            this.rbMaculino.TabStop = true;
            this.rbMaculino.Text = "Masculino";
            this.rbMaculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.ForeColor = System.Drawing.Color.White;
            this.rbFemenino.Location = new System.Drawing.Point(166, 26);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(88, 20);
            this.rbFemenino.TabIndex = 11;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.ForeColor = System.Drawing.Color.White;
            this.rbOtro.Location = new System.Drawing.Point(299, 26);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(53, 20);
            this.rbOtro.TabIndex = 12;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // gbGenero
            // 
            this.gbGenero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbGenero.Controls.Add(this.rbOtro);
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Controls.Add(this.rbMaculino);
            this.gbGenero.ForeColor = System.Drawing.Color.White;
            this.gbGenero.Location = new System.Drawing.Point(180, 338);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(396, 68);
            this.gbGenero.TabIndex = 13;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Genero";
            this.gbGenero.Enter += new System.EventHandler(this.gbGenero_Enter);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(180, 417);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(187, 50);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Location = new System.Drawing.Point(389, 417);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(187, 50);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3MLIDTS_AntonioRios_04.Properties.Resources.ecomoda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 507);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.tbEstatura);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbEstatura);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbApelllido);
            this.Controls.Add(this.lablbNombreel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablbNombreel1;
        private System.Windows.Forms.Label lbApelllido;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbEstatura;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbEstatura;
        private System.Windows.Forms.RadioButton rbMaculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

