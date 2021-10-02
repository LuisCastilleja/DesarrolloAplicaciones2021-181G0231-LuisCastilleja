
namespace ServidorUDP
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbMensaje = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoMensaje = new System.Windows.Forms.ComboBox();
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba su mensaje:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbMensaje);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rtbMensaje
            // 
            this.rtbMensaje.BackColor = System.Drawing.Color.Azure;
            this.rtbMensaje.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rtbMensaje.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtbMensaje.Location = new System.Drawing.Point(6, 42);
            this.rtbMensaje.Name = "rtbMensaje";
            this.rtbMensaje.Size = new System.Drawing.Size(368, 134);
            this.rtbMensaje.TabIndex = 2;
            this.rtbMensaje.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de mensaje:";
            // 
            // cmbTipoMensaje
            // 
            this.cmbTipoMensaje.BackColor = System.Drawing.Color.Azure;
            this.cmbTipoMensaje.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoMensaje.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbTipoMensaje.FormattingEnabled = true;
            this.cmbTipoMensaje.Items.AddRange(new object[] {
            "Normal",
            "Alerta",
            "Advertencia"});
            this.cmbTipoMensaje.Location = new System.Drawing.Point(12, 241);
            this.cmbTipoMensaje.Name = "cmbTipoMensaje";
            this.cmbTipoMensaje.Size = new System.Drawing.Size(380, 26);
            this.cmbTipoMensaje.TabIndex = 3;
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.BackColor = System.Drawing.Color.Azure;
            this.btnEnviarMensaje.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnEnviarMensaje.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnEnviarMensaje.Location = new System.Drawing.Point(234, 362);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(158, 35);
            this.btnEnviarMensaje.TabIndex = 4;
            this.btnEnviarMensaje.Text = "Enviar mensaje";
            this.btnEnviarMensaje.UseVisualStyleBackColor = false;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(404, 409);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Controls.Add(this.cmbTipoMensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Servidor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoMensaje;
        private System.Windows.Forms.RichTextBox rtbMensaje;
        private System.Windows.Forms.Button btnEnviarMensaje;
    }
}

