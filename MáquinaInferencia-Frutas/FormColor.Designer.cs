
namespace MáquinaInferencia_Frutas
{
    partial class FormColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColor));
            this.label1 = new System.Windows.Forms.Label();
            this.BAmarillo = new System.Windows.Forms.Button();
            this.BVerde = new System.Windows.Forms.Button();
            this.BCafe = new System.Windows.Forms.Button();
            this.BNaranja = new System.Windows.Forms.Button();
            this.BOtro = new System.Windows.Forms.Button();
            this.BRojo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿De qué color es tu fruta?";
            // 
            // BAmarillo
            // 
            this.BAmarillo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAmarillo.ForeColor = System.Drawing.Color.Gold;
            this.BAmarillo.Location = new System.Drawing.Point(65, 130);
            this.BAmarillo.Margin = new System.Windows.Forms.Padding(4);
            this.BAmarillo.Name = "BAmarillo";
            this.BAmarillo.Size = new System.Drawing.Size(86, 34);
            this.BAmarillo.TabIndex = 2;
            this.BAmarillo.Text = "Amarillo";
            this.BAmarillo.UseVisualStyleBackColor = true;
            // 
            // BVerde
            // 
            this.BVerde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVerde.ForeColor = System.Drawing.Color.ForestGreen;
            this.BVerde.Location = new System.Drawing.Point(158, 89);
            this.BVerde.Margin = new System.Windows.Forms.Padding(4);
            this.BVerde.Name = "BVerde";
            this.BVerde.Size = new System.Drawing.Size(86, 34);
            this.BVerde.TabIndex = 3;
            this.BVerde.Text = "Verde";
            this.BVerde.UseVisualStyleBackColor = true;
            // 
            // BCafe
            // 
            this.BCafe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCafe.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BCafe.Location = new System.Drawing.Point(159, 131);
            this.BCafe.Margin = new System.Windows.Forms.Padding(4);
            this.BCafe.Name = "BCafe";
            this.BCafe.Size = new System.Drawing.Size(86, 34);
            this.BCafe.TabIndex = 4;
            this.BCafe.Text = "Café";
            this.BCafe.UseVisualStyleBackColor = true;
            // 
            // BNaranja
            // 
            this.BNaranja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNaranja.ForeColor = System.Drawing.Color.DarkOrange;
            this.BNaranja.Location = new System.Drawing.Point(252, 89);
            this.BNaranja.Margin = new System.Windows.Forms.Padding(4);
            this.BNaranja.Name = "BNaranja";
            this.BNaranja.Size = new System.Drawing.Size(86, 34);
            this.BNaranja.TabIndex = 5;
            this.BNaranja.Text = "Naranja";
            this.BNaranja.UseVisualStyleBackColor = true;
            // 
            // BOtro
            // 
            this.BOtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BOtro.Location = new System.Drawing.Point(252, 130);
            this.BOtro.Margin = new System.Windows.Forms.Padding(4);
            this.BOtro.Name = "BOtro";
            this.BOtro.Size = new System.Drawing.Size(86, 34);
            this.BOtro.TabIndex = 6;
            this.BOtro.Text = "Otro";
            this.BOtro.UseVisualStyleBackColor = true;
            // 
            // BRojo
            // 
            this.BRojo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRojo.Font = new System.Drawing.Font("Louis George Café", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BRojo.ForeColor = System.Drawing.Color.Red;
            this.BRojo.Location = new System.Drawing.Point(65, 89);
            this.BRojo.Name = "BRojo";
            this.BRojo.Size = new System.Drawing.Size(86, 34);
            this.BRojo.TabIndex = 7;
            this.BRojo.Text = "Rojo";
            this.BRojo.UseVisualStyleBackColor = true;
            this.BRojo.Click += new System.EventHandler(this.button7_Click);
            // 
            // FormColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 187);
            this.Controls.Add(this.BRojo);
            this.Controls.Add(this.BOtro);
            this.Controls.Add(this.BNaranja);
            this.Controls.Add(this.BCafe);
            this.Controls.Add(this.BVerde);
            this.Controls.Add(this.BAmarillo);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Louis George Café", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Pregunta1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BAmarillo;
        private System.Windows.Forms.Button BVerde;
        private System.Windows.Forms.Button BCafe;
        private System.Windows.Forms.Button BNaranja;
        private System.Windows.Forms.Button BOtro;
        private System.Windows.Forms.Button BRojo;
    }
}