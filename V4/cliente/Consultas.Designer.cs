namespace Cliente
{
    partial class consultas
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
            this.LabelUsuarioConsultado = new System.Windows.Forms.TextBox();
            this.UsuarioaConsultar = new System.Windows.Forms.TextBox();
            this.LabelConsulta = new System.Windows.Forms.TextBox();
            this.Consulta = new System.Windows.Forms.ComboBox();
            this.BotonConsulta = new System.Windows.Forms.Button();
            this.LabelResultado = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelUsuarioConsultado
            // 
            this.LabelUsuarioConsultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelUsuarioConsultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuarioConsultado.Location = new System.Drawing.Point(37, 24);
            this.LabelUsuarioConsultado.Name = "LabelUsuarioConsultado";
            this.LabelUsuarioConsultado.ReadOnly = true;
            this.LabelUsuarioConsultado.Size = new System.Drawing.Size(87, 30);
            this.LabelUsuarioConsultado.TabIndex = 11;
            this.LabelUsuarioConsultado.TabStop = false;
            this.LabelUsuarioConsultado.Text = "Usuario:";
            // 
            // UsuarioaConsultar
            // 
            this.UsuarioaConsultar.Location = new System.Drawing.Point(177, 32);
            this.UsuarioaConsultar.Name = "UsuarioaConsultar";
            this.UsuarioaConsultar.Size = new System.Drawing.Size(198, 22);
            this.UsuarioaConsultar.TabIndex = 12;
        
            // LabelConsulta
            // 
            this.LabelConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConsulta.Location = new System.Drawing.Point(37, 89);
            this.LabelConsulta.Name = "LabelConsulta";
            this.LabelConsulta.ReadOnly = true;
            this.LabelConsulta.Size = new System.Drawing.Size(99, 30);
            this.LabelConsulta.TabIndex = 13;
            this.LabelConsulta.TabStop = false;
            this.LabelConsulta.Text = "Consulta:";
            // 
            // Consulta
            // 
            this.Consulta.FormattingEnabled = true;
            this.Consulta.Items.AddRange(new object[] {
            "Partidas ganadas",
            "Puntos obtenidos",
            "Partidas jugadas"});
            this.Consulta.Location = new System.Drawing.Point(177, 95);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(184, 24);
            this.Consulta.TabIndex = 14;
            // 
            // BotonConsulta
            // 
            this.BotonConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonConsulta.Location = new System.Drawing.Point(37, 163);
            this.BotonConsulta.Name = "BotonConsulta";
            this.BotonConsulta.Size = new System.Drawing.Size(149, 29);
            this.BotonConsulta.TabIndex = 15;
            this.BotonConsulta.Text = "Consultar";
            this.BotonConsulta.UseVisualStyleBackColor = true;
            // 
            // LabelResultado
            // 
            this.LabelResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResultado.Location = new System.Drawing.Point(37, 249);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.ReadOnly = true;
            this.LabelResultado.Size = new System.Drawing.Size(102, 30);
            this.LabelResultado.TabIndex = 16;
            this.LabelResultado.TabStop = false;
            this.LabelResultado.Text = "Resultado:";
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(177, 256);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(198, 22);
            this.Resultado.TabIndex = 17;
            // 
            // consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.BotonConsulta);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.LabelConsulta);
            this.Controls.Add(this.UsuarioaConsultar);
            this.Controls.Add(this.LabelUsuarioConsultado);
            this.Name = "consultas";
            this.Text = "consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LabelUsuarioConsultado;
        private System.Windows.Forms.TextBox UsuarioaConsultar;
        private System.Windows.Forms.TextBox LabelConsulta;
        private System.Windows.Forms.ComboBox Consulta;
        private System.Windows.Forms.Button BotonConsulta;
        private System.Windows.Forms.TextBox LabelResultado;
        public System.Windows.Forms.TextBox Resultado;
    }
}