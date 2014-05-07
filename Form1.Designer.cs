namespace PharMS_Steuerung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Uebertragen = new System.Windows.Forms.Button();
            this.AblaufListe = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Stopp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NOTSTOPP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.DatenerfassungTab = new System.Windows.Forms.DataGridView();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spannung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spannung2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verzeichnisauswahl = new System.Windows.Forms.FolderBrowserDialog();
            this.AblaufStart = new System.Windows.Forms.Button();
            this.AblaufStopp = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Masterablauf = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatenerfassungTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Uebertragen
            // 
            this.Uebertragen.Location = new System.Drawing.Point(324, 26);
            this.Uebertragen.Name = "Uebertragen";
            this.Uebertragen.Size = new System.Drawing.Size(75, 23);
            this.Uebertragen.TabIndex = 0;
            this.Uebertragen.Text = "Übertragen";
            this.Uebertragen.UseVisualStyleBackColor = true;
            this.Uebertragen.Click += new System.EventHandler(this.Uebertragen_Click);
            // 
            // AblaufListe
            // 
            this.AblaufListe.FormattingEnabled = true;
            this.AblaufListe.Location = new System.Drawing.Point(24, 30);
            this.AblaufListe.Name = "AblaufListe";
            this.AblaufListe.Size = new System.Drawing.Size(183, 21);
            this.AblaufListe.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 457);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Masterablauf);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.AblaufStopp);
            this.tabPage1.Controls.Add(this.AblaufStart);
            this.tabPage1.Controls.Add(this.Stopp);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.NOTSTOPP);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.Disconnect);
            this.tabPage1.Controls.Add(this.Connect);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Uebertragen);
            this.tabPage1.Controls.Add(this.AblaufListe);
            this.tabPage1.Controls.Add(this.shapeContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Übertragen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Stopp
            // 
            this.Stopp.Location = new System.Drawing.Point(416, 97);
            this.Stopp.Name = "Stopp";
            this.Stopp.Size = new System.Drawing.Size(75, 23);
            this.Stopp.TabIndex = 18;
            this.Stopp.Text = "Stopp";
            this.Stopp.UseVisualStyleBackColor = true;
            this.Stopp.Click += new System.EventHandler(this.Stopp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bereit";
            // 
            // NOTSTOPP
            // 
            this.NOTSTOPP.BackColor = System.Drawing.Color.Red;
            this.NOTSTOPP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NOTSTOPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOTSTOPP.Location = new System.Drawing.Point(351, 303);
            this.NOTSTOPP.Name = "NOTSTOPP";
            this.NOTSTOPP.Size = new System.Drawing.Size(128, 57);
            this.NOTSTOPP.TabIndex = 15;
            this.NOTSTOPP.Text = "NOTSTOPP";
            this.NOTSTOPP.UseVisualStyleBackColor = false;
            this.NOTSTOPP.Click += new System.EventHandler(this.NOTSTOPP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Speicherplatz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Speicherplatz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sequenz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Status :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(53, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 43);
            this.panel1.TabIndex = 10;
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(252, 343);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Disconnect.TabIndex = 9;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(252, 303);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 8;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox2.Location = new System.Drawing.Point(252, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(40, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(252, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(40, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Starten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(503, 425);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 14;
            this.lineShape3.X2 = 504;
            this.lineShape3.Y1 = 264;
            this.lineShape3.Y2 = 264;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 10;
            this.lineShape2.X2 = 500;
            this.lineShape2.Y1 = 131;
            this.lineShape2.Y2 = 131;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 8;
            this.lineShape1.X2 = 498;
            this.lineShape1.Y1 = 65;
            this.lineShape1.Y2 = 65;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.DatenerfassungTab);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empfangen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Export nach Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DatenerfassungTab
            // 
            this.DatenerfassungTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatenerfassungTab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zeit,
            this.Spannung,
            this.Spannung2});
            this.DatenerfassungTab.Location = new System.Drawing.Point(66, 26);
            this.DatenerfassungTab.Name = "DatenerfassungTab";
            this.DatenerfassungTab.Size = new System.Drawing.Size(343, 271);
            this.DatenerfassungTab.TabIndex = 0;
            // 
            // Zeit
            // 
            this.Zeit.DataPropertyName = "Colum1";
            this.Zeit.HeaderText = "Zeit";
            this.Zeit.Name = "Zeit";
            // 
            // Spannung
            // 
            this.Spannung.HeaderText = "Spannung";
            this.Spannung.Name = "Spannung";
            // 
            // Spannung2
            // 
            this.Spannung2.HeaderText = "Spannung 2";
            this.Spannung2.Name = "Spannung2";
            // 
            // AblaufStart
            // 
            this.AblaufStart.Location = new System.Drawing.Point(324, 184);
            this.AblaufStart.Name = "AblaufStart";
            this.AblaufStart.Size = new System.Drawing.Size(75, 23);
            this.AblaufStart.TabIndex = 19;
            this.AblaufStart.Text = "Start";
            this.AblaufStart.UseVisualStyleBackColor = true;
            this.AblaufStart.Click += new System.EventHandler(this.AblaufStart_Click);
            // 
            // AblaufStopp
            // 
            this.AblaufStopp.Location = new System.Drawing.Point(416, 184);
            this.AblaufStopp.Name = "AblaufStopp";
            this.AblaufStopp.Size = new System.Drawing.Size(75, 23);
            this.AblaufStopp.TabIndex = 20;
            this.AblaufStopp.Text = "Stopp";
            this.AblaufStopp.UseVisualStyleBackColor = true;
            this.AblaufStopp.Click += new System.EventHandler(this.AblaufStopp_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(252, 184);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 21;
            // 
            // Masterablauf
            // 
            this.Masterablauf.FormattingEnabled = true;
            this.Masterablauf.Location = new System.Drawing.Point(33, 186);
            this.Masterablauf.Name = "Masterablauf";
            this.Masterablauf.Size = new System.Drawing.Size(183, 21);
            this.Masterablauf.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PharMS Controller";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatenerfassungTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Uebertragen;
        private System.Windows.Forms.ComboBox AblaufListe;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Connect;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.FolderBrowserDialog Verzeichnisauswahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spannung;
        public System.Windows.Forms.DataGridView DatenerfassungTab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spannung2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NOTSTOPP;
    
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Stopp;
        private System.Windows.Forms.ComboBox Masterablauf;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button AblaufStopp;
        private System.Windows.Forms.Button AblaufStart;
    }
}

