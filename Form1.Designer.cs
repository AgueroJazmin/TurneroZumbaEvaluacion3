namespace TurneroZumbaEvaluacion3
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btAgendar = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.cbTurnos = new System.Windows.Forms.ComboBox();
            this.lblTurnos = new System.Windows.Forms.Label();
            this.cbHorarios = new System.Windows.Forms.ComboBox();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bell MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(88, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(584, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Doble Giro Gym - Turnero Zumba";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(44, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(47, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // btAgendar
            // 
            this.btAgendar.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgendar.Location = new System.Drawing.Point(47, 389);
            this.btAgendar.Name = "btAgendar";
            this.btAgendar.Size = new System.Drawing.Size(73, 30);
            this.btAgendar.TabIndex = 3;
            this.btAgendar.Text = "Agendar";
            this.btAgendar.UseVisualStyleBackColor = true;
            this.btAgendar.Click += new System.EventHandler(this.btAgendar_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.White;
            this.lblDia.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(47, 169);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(31, 16);
            this.lblDia.TabIndex = 4;
            this.lblDia.Text = "Dias";
            // 
            // cbDias
            // 
            this.cbDias.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Location = new System.Drawing.Point(47, 197);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(121, 24);
            this.cbDias.TabIndex = 5;
            // 
            // cbTurnos
            // 
            this.cbTurnos.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurnos.FormattingEnabled = true;
            this.cbTurnos.Location = new System.Drawing.Point(47, 267);
            this.cbTurnos.Name = "cbTurnos";
            this.cbTurnos.Size = new System.Drawing.Size(121, 24);
            this.cbTurnos.TabIndex = 7;
            this.cbTurnos.SelectedIndexChanged += new System.EventHandler(this.cbTurnos_SelectedIndexChanged);
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.BackColor = System.Drawing.Color.White;
            this.lblTurnos.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnos.Location = new System.Drawing.Point(47, 239);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(45, 16);
            this.lblTurnos.TabIndex = 6;
            this.lblTurnos.Text = "Turnos";
            // 
            // cbHorarios
            // 
            this.cbHorarios.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHorarios.FormattingEnabled = true;
            this.cbHorarios.Location = new System.Drawing.Point(47, 342);
            this.cbHorarios.Name = "cbHorarios";
            this.cbHorarios.Size = new System.Drawing.Size(121, 24);
            this.cbHorarios.TabIndex = 9;
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.BackColor = System.Drawing.Color.White;
            this.lblHorarios.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarios.Location = new System.Drawing.Point(47, 314);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(56, 16);
            this.lblHorarios.TabIndex = 8;
            this.lblHorarios.Text = "Horarios";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(50, 450);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(97, 13);
            this.lblSalida.TabIndex = 10;
            this.lblSalida.Text = "Turnos Agendados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.cbHorarios);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.cbTurnos);
            this.Controls.Add(this.lblTurnos);
            this.Controls.Add(this.cbDias);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.btAgendar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btAgendar;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.ComboBox cbDias;
        private System.Windows.Forms.ComboBox cbTurnos;
        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.ComboBox cbHorarios;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.Label lblSalida;
    }
}

