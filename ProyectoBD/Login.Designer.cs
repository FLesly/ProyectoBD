namespace ProyectoBD
{
    partial class Login
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
            Acceso = new GroupBox();
            button1 = new Button();
            Usuario = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Acceso.SuspendLayout();
            SuspendLayout();
            // 
            // Acceso
            // 
            Acceso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Acceso.Controls.Add(label2);
            Acceso.Controls.Add(label1);
            Acceso.Controls.Add(textBox2);
            Acceso.Controls.Add(Usuario);
            Acceso.Controls.Add(button1);
            Acceso.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Acceso.ForeColor = SystemColors.HotTrack;
            Acceso.Location = new Point(286, 127);
            Acceso.Name = "Acceso";
            Acceso.Size = new Size(252, 258);
            Acceso.TabIndex = 0;
            Acceso.TabStop = false;
            Acceso.Text = "Bienvenido";
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.HotTrack;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(6, 188);
            button1.Name = "button1";
            button1.Size = new Size(240, 39);
            button1.TabIndex = 0;
            button1.Text = "Iniciar Sesión ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Usuario
            // 
            Usuario.BackColor = SystemColors.Window;
            Usuario.BorderStyle = BorderStyle.None;
            Usuario.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Usuario.ForeColor = SystemColors.InactiveCaptionText;
            Usuario.Location = new Point(6, 63);
            Usuario.Name = "Usuario";
            Usuario.RightToLeft = RightToLeft.Yes;
            Usuario.ScrollBars = ScrollBars.Both;
            Usuario.Size = new Size(240, 19);
            Usuario.TabIndex = 1;
            Usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(6, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 22);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(70, 18);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 18);
            label2.TabIndex = 4;
            label2.Text = "contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(841, 567);
            Controls.Add(Acceso);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Registro";
            Acceso.ResumeLayout(false);
            Acceso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Acceso;
        private Button button1;
        private TextBox textBox2;
        private TextBox Usuario;
        private Label label2;
        private Label label1;
    }
}