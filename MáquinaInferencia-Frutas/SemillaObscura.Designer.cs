﻿
namespace MáquinaInferencia_Frutas
{
    partial class SemillaObscura
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
            this.BNo = new System.Windows.Forms.Button();
            this.BSi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BNo
            // 
            this.BNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNo.Font = new System.Drawing.Font("Louis George Café", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BNo.Location = new System.Drawing.Point(209, 126);
            this.BNo.Name = "BNo";
            this.BNo.Size = new System.Drawing.Size(84, 39);
            this.BNo.TabIndex = 20;
            this.BNo.Text = "No";
            this.BNo.UseVisualStyleBackColor = true;
            // 
            // BSi
            // 
            this.BSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSi.Font = new System.Drawing.Font("Louis George Café", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BSi.Location = new System.Drawing.Point(119, 126);
            this.BSi.Name = "BSi";
            this.BSi.Size = new System.Drawing.Size(84, 39);
            this.BSi.TabIndex = 19;
            this.BSi.Text = "Sí";
            this.BSi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "¿Tu fruta es de semilla oscura?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SemillaObscura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 215);
            this.Controls.Add(this.BNo);
            this.Controls.Add(this.BSi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SemillaObscura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SemillaObscura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BNo;
        private System.Windows.Forms.Button BSi;
        private System.Windows.Forms.Label label1;
    }
}