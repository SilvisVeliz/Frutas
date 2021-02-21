
namespace MáquinaInferencia_Frutas
{
    partial class FormSemillas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSemillas));
            this.BNo = new System.Windows.Forms.Button();
            this.BSi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BNo
            // 
            this.BNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNo.Font = new System.Drawing.Font("Louis George Café", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BNo.Location = new System.Drawing.Point(211, 100);
            this.BNo.Name = "BNo";
            this.BNo.Size = new System.Drawing.Size(84, 39);
            this.BNo.TabIndex = 8;
            this.BNo.Text = "No";
            this.BNo.UseVisualStyleBackColor = true;
            // 
            // BSi
            // 
            this.BSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSi.Font = new System.Drawing.Font("Louis George Café", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BSi.Location = new System.Drawing.Point(121, 100);
            this.BSi.Name = "BSi";
            this.BSi.Size = new System.Drawing.Size(84, 39);
            this.BSi.TabIndex = 7;
            this.BSi.Text = "Sí";
            this.BSi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "¿Tiene semillas?";
            // 
            // FormSemillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(413, 199);
            this.Controls.Add(this.BNo);
            this.Controls.Add(this.BSi);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormSemillas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BNo;
        private System.Windows.Forms.Button BSi;
        private System.Windows.Forms.Label label1;
    }
}