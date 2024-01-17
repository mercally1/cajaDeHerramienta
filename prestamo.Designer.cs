namespace cajaDeHerramienta
{
    partial class prestamo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prestamo));
            saludo = new Label();
            btnConfirmar = new Button();
            btnBack = new Button();
            lblDates = new Label();
            label1 = new Label();
            datosPersonales = new Panel();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            raza = new Label();
            DetallePrestamo = new Panel();
            cuotas = new TextBox();
            comboBox5 = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            datosPersonales.SuspendLayout();
            DetallePrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // saludo
            // 
            saludo.AutoSize = true;
            saludo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saludo.Location = new Point(111, 58);
            saludo.Name = "saludo";
            saludo.Size = new Size(203, 32);
            saludo.TabIndex = 0;
            saludo.Text = "Bienvenido Sr(a)";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Sienna;
            btnConfirmar.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnConfirmar.FlatAppearance.BorderSize = 2;
            btnConfirmar.Font = new Font("Franklin Gothic Book", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.Control;
            errorProvider1.SetIconAlignment(btnConfirmar, ErrorIconAlignment.MiddleLeft);
            btnConfirmar.Location = new Point(506, 421);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(161, 60);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar ";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Sienna;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.Font = new Font("Franklin Gothic Book", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(999, 604);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 47);
            btnBack.TabIndex = 2;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblDates
            // 
            lblDates.AutoSize = true;
            lblDates.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblDates.ForeColor = Color.Sienna;
            lblDates.Location = new Point(111, 156);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(251, 40);
            lblDates.TabIndex = 3;
            lblDates.Text = "Datos Personales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(636, 156);
            label1.Name = "label1";
            label1.Size = new Size(320, 40);
            label1.TabIndex = 4;
            label1.Text = "Detalles de Prestamos";
            // 
            // datosPersonales
            // 
            datosPersonales.BackColor = Color.Sienna;
            datosPersonales.BorderStyle = BorderStyle.Fixed3D;
            datosPersonales.Controls.Add(comboBox2);
            datosPersonales.Controls.Add(label2);
            datosPersonales.Controls.Add(comboBox1);
            datosPersonales.Controls.Add(raza);
            datosPersonales.ForeColor = Color.Transparent;
            errorProvider1.SetIconAlignment(datosPersonales, ErrorIconAlignment.MiddleLeft);
            datosPersonales.Location = new Point(111, 216);
            datosPersonales.Name = "datosPersonales";
            datosPersonales.Size = new Size(352, 157);
            datosPersonales.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(143, 86);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 23);
            comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 2;
            label2.Text = "Nacionalidad";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(143, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 1;
            // 
            // raza
            // 
            raza.AutoSize = true;
            raza.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            raza.Location = new Point(84, 34);
            raza.Name = "raza";
            raza.Size = new Size(53, 25);
            raza.TabIndex = 0;
            raza.Text = "Raza";
            // 
            // DetallePrestamo
            // 
            DetallePrestamo.BackColor = Color.Sienna;
            DetallePrestamo.BorderStyle = BorderStyle.Fixed3D;
            DetallePrestamo.Controls.Add(cuotas);
            DetallePrestamo.Controls.Add(comboBox5);
            DetallePrestamo.Controls.Add(label5);
            DetallePrestamo.Controls.Add(label3);
            DetallePrestamo.ForeColor = Color.Transparent;
            DetallePrestamo.Location = new Point(636, 216);
            DetallePrestamo.Name = "DetallePrestamo";
            DetallePrestamo.Size = new Size(352, 157);
            DetallePrestamo.TabIndex = 6;
            // 
            // cuotas
            // 
            cuotas.Location = new Point(137, 42);
            cuotas.Multiline = true;
            cuotas.Name = "cuotas";
            cuotas.Size = new Size(163, 23);
            cuotas.TabIndex = 6;
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FlatStyle = FlatStyle.Flat;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(137, 81);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(163, 23);
            comboBox5.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(60, 79);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 4;
            label5.Text = "Cuotas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 37);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 2;
            label3.Text = "Monto ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // prestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(1129, 663);
            Controls.Add(DetallePrestamo);
            Controls.Add(datosPersonales);
            Controls.Add(label1);
            Controls.Add(lblDates);
            Controls.Add(btnBack);
            Controls.Add(btnConfirmar);
            Controls.Add(saludo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "prestamo";
            Text = "Solicita Prestamo";
            Load += prestamo_Load;
            datosPersonales.ResumeLayout(false);
            datosPersonales.PerformLayout();
            DetallePrestamo.ResumeLayout(false);
            DetallePrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label saludo;
        private Button btnConfirmar;
        private Button btnBack;
        private Label lblDates;
        private Label label1;
        private Panel datosPersonales;
        private Panel DetallePrestamo;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Label raza;
        private ComboBox comboBox5;
        private Label label5;
        private Label label3;
        private TextBox cuotas;
        private ErrorProvider errorProvider1;
    }
}