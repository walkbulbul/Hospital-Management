namespace WindowsFormsApp3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonContextMenu1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonMaskedTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.kryptonMaskedTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 124);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Management System\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(81, 460);
            this.label2.MaximumSize = new System.Drawing.Size(175, 0);
            this.label2.MinimumSize = new System.Drawing.Size(265, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kryptonMaskedTextBox1
            // 
            this.kryptonMaskedTextBox1.Location = new System.Drawing.Point(63, 200);
            this.kryptonMaskedTextBox1.MaximumSize = new System.Drawing.Size(300, 50);
            this.kryptonMaskedTextBox1.Name = "kryptonMaskedTextBox1";
            this.kryptonMaskedTextBox1.Size = new System.Drawing.Size(300, 50);
            this.kryptonMaskedTextBox1.StateActive.Back.Color1 = System.Drawing.SystemColors.Highlight;
            this.kryptonMaskedTextBox1.StateActive.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonMaskedTextBox1.StateActive.Border.Color2 = System.Drawing.Color.Blue;
            this.kryptonMaskedTextBox1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonMaskedTextBox1.StateActive.Border.Rounding = 10;
            this.kryptonMaskedTextBox1.StateActive.Border.Width = 3;
            this.kryptonMaskedTextBox1.StateActive.Content.Color1 = System.Drawing.Color.White;
            this.kryptonMaskedTextBox1.StateActive.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonMaskedTextBox1.StateActive.Content.Padding = new System.Windows.Forms.Padding(3, 6, 5, 0);
            this.kryptonMaskedTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonMaskedTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonMaskedTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonMaskedTextBox1.StateCommon.Border.Width = 3;
            this.kryptonMaskedTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonMaskedTextBox1.StateNormal.Back.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.kryptonMaskedTextBox1.StateNormal.Content.Color1 = System.Drawing.Color.White;
            this.kryptonMaskedTextBox1.StateNormal.Content.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonMaskedTextBox1.TabIndex = 2;
            this.kryptonMaskedTextBox1.Text = "Doctor Name";
            // 
            // kryptonMaskedTextBox2
            // 
            this.kryptonMaskedTextBox2.Location = new System.Drawing.Point(63, 317);
            this.kryptonMaskedTextBox2.MaximumSize = new System.Drawing.Size(300, 50);
            this.kryptonMaskedTextBox2.Name = "kryptonMaskedTextBox2";
            this.kryptonMaskedTextBox2.Size = new System.Drawing.Size(300, 50);
            this.kryptonMaskedTextBox2.StateActive.Back.Color1 = System.Drawing.SystemColors.Highlight;
            this.kryptonMaskedTextBox2.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonMaskedTextBox2.StateActive.Border.Rounding = 10;
            this.kryptonMaskedTextBox2.StateActive.Border.Width = 3;
            this.kryptonMaskedTextBox2.StateActive.Content.Color1 = System.Drawing.Color.White;
            this.kryptonMaskedTextBox2.StateActive.Content.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.kryptonMaskedTextBox2.StateActive.Content.Padding = new System.Windows.Forms.Padding(3, 6, 5, 0);
            this.kryptonMaskedTextBox2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonMaskedTextBox2.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonMaskedTextBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonMaskedTextBox2.StateCommon.Border.Width = 3;
            this.kryptonMaskedTextBox2.StateNormal.Back.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.kryptonMaskedTextBox2.StateNormal.Content.Color1 = System.Drawing.Color.White;
            this.kryptonMaskedTextBox2.StateNormal.Content.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonMaskedTextBox2.TabIndex = 3;
            this.kryptonMaskedTextBox2.Text = "Doctor Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(170, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clear";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(420, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kryptonMaskedTextBox2);
            this.Controls.Add(this.kryptonMaskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBox2;
        private System.Windows.Forms.Label label3;
    }
}

