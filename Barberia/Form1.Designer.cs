namespace Barberia_Cita
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
            this.btnRealizarCita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnVerCitas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRealizarCita
            // 
            this.btnRealizarCita.Location = new System.Drawing.Point(112, 152);
            this.btnRealizarCita.Name = "btnRealizarCita";
            this.btnRealizarCita.Size = new System.Drawing.Size(181, 46);
            this.btnRealizarCita.TabIndex = 0;
            this.btnRealizarCita.Text = "Realizar una cita";
            this.btnRealizarCita.UseVisualStyleBackColor = true;
            this.btnRealizarCita.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Barlow Semi Condensed Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Varonil BaberRoom";
            // 
            // btnCitas
            // 
            this.btnCitas.Location = new System.Drawing.Point(112, 285);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(181, 46);
            this.btnCitas.TabIndex = 2;
            this.btnCitas.Text = "Salir";
            this.btnCitas.UseVisualStyleBackColor = true;
            // 
            // btnVerCitas
            // 
            this.btnVerCitas.Location = new System.Drawing.Point(112, 219);
            this.btnVerCitas.Name = "btnVerCitas";
            this.btnVerCitas.Size = new System.Drawing.Size(181, 46);
            this.btnVerCitas.TabIndex = 3;
            this.btnVerCitas.Text = "Ver citas";
            this.btnVerCitas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 488);
            this.Controls.Add(this.btnVerCitas);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRealizarCita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRealizarCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnVerCitas;
    }
}

