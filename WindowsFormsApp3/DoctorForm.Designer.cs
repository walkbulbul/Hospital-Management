namespace WindowsFormsApp3
{
    partial class DoctorForm
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
            this.DocID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.DoctorName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.DoctorExp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.DocPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.DoctorNote = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorNote)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1435, 150);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(382, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital Management System\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(596, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOCTOR";
            // 
            // DocID
            // 
            this.DocID.Location = new System.Drawing.Point(58, 230);
            this.DocID.Name = "DocID";
            this.DocID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DocID.Size = new System.Drawing.Size(465, 46);
            this.DocID.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DocID.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DocID.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.DocID.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.DocID.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DocID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DocID.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DocID.StateCommon.Border.Rounding = 20;
            this.DocID.StateCommon.Border.Width = 1;
            this.DocID.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.DocID.StateCommon.Content.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DocID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DocID.TabIndex = 1;
            this.DocID.Text = "DoctorID";
            this.DocID.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // DoctorName
            // 
            this.DoctorName.Location = new System.Drawing.Point(58, 300);
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DoctorName.Size = new System.Drawing.Size(465, 46);
            this.DoctorName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DoctorName.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DoctorName.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.DoctorName.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.DoctorName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DoctorName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DoctorName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DoctorName.StateCommon.Border.Rounding = 20;
            this.DoctorName.StateCommon.Border.Width = 1;
            this.DoctorName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.DoctorName.StateCommon.Content.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoctorName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DoctorName.TabIndex = 2;
            this.DoctorName.Text = "DoctorName";
            // 
            // DoctorExp
            // 
            this.DoctorExp.Location = new System.Drawing.Point(58, 375);
            this.DoctorExp.Name = "DoctorExp";
            this.DoctorExp.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DoctorExp.Size = new System.Drawing.Size(465, 46);
            this.DoctorExp.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DoctorExp.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DoctorExp.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.DoctorExp.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.DoctorExp.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DoctorExp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DoctorExp.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DoctorExp.StateCommon.Border.Rounding = 20;
            this.DoctorExp.StateCommon.Border.Width = 1;
            this.DoctorExp.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.DoctorExp.StateCommon.Content.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoctorExp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DoctorExp.TabIndex = 3;
            this.DoctorExp.Text = "YearsOfExperience";
            // 
            // DocPass
            // 
            this.DocPass.Location = new System.Drawing.Point(58, 452);
            this.DocPass.Name = "DocPass";
            this.DocPass.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DocPass.Size = new System.Drawing.Size(465, 46);
            this.DocPass.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DocPass.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DocPass.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.DocPass.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.DocPass.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DocPass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DocPass.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DocPass.StateCommon.Border.Rounding = 20;
            this.DocPass.StateCommon.Border.Width = 1;
            this.DocPass.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.DocPass.StateCommon.Content.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DocPass.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DocPass.TabIndex = 4;
            this.DocPass.Text = "Password";
            this.DocPass.TextChanged += new System.EventHandler(this.kryptonTextBox4_TextChanged);
            // 
            // DoctorNote
            // 
            this.DoctorNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorNote.Location = new System.Drawing.Point(775, 230);
            this.DoctorNote.Name = "DoctorNote";
            this.DoctorNote.RowTemplate.Height = 24;
            this.DoctorNote.Size = new System.Drawing.Size(577, 622);
            this.DoctorNote.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DoctorNote.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DoctorNote.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DoctorNote.StateCommon.HeaderRow.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DoctorNote.StateNormal.Background.Color1 = System.Drawing.Color.White;
            this.DoctorNote.StateNormal.Background.Color2 = System.Drawing.Color.White;
            this.DoctorNote.TabIndex = 5;
            this.DoctorNote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorNote_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(58, 697);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(233, 697);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 68);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(412, 697);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 68);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(233, 805);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 68);
            this.button4.TabIndex = 9;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1435, 913);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoctorNote);
            this.Controls.Add(this.DocPass);
            this.Controls.Add(this.DoctorExp);
            this.Controls.Add(this.DoctorName);
            this.Controls.Add(this.DocID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox DocID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox DoctorName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox DoctorExp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox DocPass;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DoctorNote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}