namespace cajaDeHerramienta
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            lbl1 = new Label();
            pictureBox1 = new PictureBox();
            btn1 = new Button();
            btn2 = new Button();
            txt1 = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(307, 50);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(595, 65);
            lbl1.TabIndex = 0;
            lbl1.Text = "Banco de la Tierra Blanca";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bank;
            pictureBox1.Location = new Point(201, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Sienna;
            btn1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn1.FlatAppearance.BorderSize = 2;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ButtonHighlight;
            btn1.Location = new Point(507, 288);
            btn1.Name = "btn1";
            btn1.Size = new Size(161, 66);
            btn1.TabIndex = 2;
            btn1.Text = "Solicitar Prestamo";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Sienna;
            btn2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn2.FlatAppearance.BorderSize = 2;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.ButtonHighlight;
            btn2.Location = new Point(1026, 562);
            btn2.Name = "btn2";
            btn2.Size = new Size(109, 65);
            btn2.TabIndex = 3;
            btn2.Text = "EXIT";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(506, 243);
            txt1.Name = "txt1";
            txt1.Size = new Size(161, 23);
            txt1.TabIndex = 4;
            txt1.TextAlign = HorizontalAlignment.Center;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 238);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 5;
            label1.Text = "Digite Su Nombre:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(1183, 661);
            Controls.Add(label1);
            Controls.Add(txt1);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(pictureBox1);
            Controls.Add(lbl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banco de la Tierra Blanca";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private PictureBox pictureBox1;
        private Button btn1;
        private Button btn2;
        private TextBox txt1;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}
