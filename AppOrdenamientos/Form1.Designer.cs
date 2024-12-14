namespace AppOrdenamientos
{
    partial class Form1
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
            lblID = new Label();
            txtID = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            lblCarrera = new Label();
            txtCarrera = new TextBox();
            lblSemestre = new Label();
            txtSemestre = new TextBox();
            btnAgregar = new Button();
            btnIrAOrdenamientos = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.Location = new Point(109, 75);
            lblID.Name = "lblID";
            lblID.Size = new Size(50, 23);
            lblID.TabIndex = 11;
            lblID.Text = "ID:";
            lblID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            txtID.Location = new Point(165, 66);
            txtID.Name = "txtID";
            txtID.Size = new Size(200, 27);
            txtID.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(86, 99);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 23);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(165, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblEdad
            // 
            lblEdad.Location = new Point(86, 128);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(73, 23);
            lblEdad.TabIndex = 9;
            lblEdad.Text = "Edad:";
            lblEdad.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(165, 124);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(200, 27);
            txtEdad.TabIndex = 2;
            // 
            // lblCarrera
            // 
            lblCarrera.Location = new Point(86, 157);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(73, 23);
            lblCarrera.TabIndex = 8;
            lblCarrera.Text = "Carrera:";
            lblCarrera.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(165, 153);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(200, 27);
            txtCarrera.TabIndex = 3;
            // 
            // lblSemestre
            // 
            lblSemestre.Location = new Point(86, 184);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(73, 23);
            lblSemestre.TabIndex = 7;
            lblSemestre.Text = "Semestre:";
            lblSemestre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSemestre
            // 
            txtSemestre.Location = new Point(165, 182);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.Size = new Size(200, 27);
            txtSemestre.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(54, 247);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 58);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnIrAOrdenamientos
            // 
            btnIrAOrdenamientos.Location = new Point(284, 247);
            btnIrAOrdenamientos.Name = "btnIrAOrdenamientos";
            btnIrAOrdenamientos.Size = new Size(133, 58);
            btnIrAOrdenamientos.TabIndex = 6;
            btnIrAOrdenamientos.Text = "Ir a Ordenamientos";
            btnIrAOrdenamientos.UseVisualStyleBackColor = true;
            btnIrAOrdenamientos.Click += btnIrAOrdenamientos_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(507, 368);
            Controls.Add(btnIrAOrdenamientos);
            Controls.Add(btnAgregar);
            Controls.Add(txtSemestre);
            Controls.Add(lblSemestre);
            Controls.Add(txtCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Name = "Form1";
            Text = "Agregar Estudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnIrAOrdenamientos;
    }
}
