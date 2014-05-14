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
            this.AblaufListe = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Sequenz = new System.Windows.Forms.Label();
            this.Masterablauf = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AblaufStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Uebertragen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NOTSTOPP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.numeric_Messdauer = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numeric_Intervall = new System.Windows.Forms.NumericUpDown();
            this.numericZellspannung = new System.Windows.Forms.NumericUpDown();
            this.Messung_Stopp = new System.Windows.Forms.Button();
            this.Man_Messung = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DatenerfassungTab = new System.Windows.Forms.DataGridView();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spannung1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spannung2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Console_Senden = new System.Windows.Forms.Button();
            this.Console_Eingabe = new System.Windows.Forms.TextBox();
            this.Console_Ausgabe = new System.Windows.Forms.TextBox();
            this.Verzeichnisauswahl = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Messdauer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Intervall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZellspannung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatenerfassungTab)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AblaufListe
            // 
            this.AblaufListe.FormattingEnabled = true;
            this.AblaufListe.Location = new System.Drawing.Point(9, 41);
            this.AblaufListe.Name = "AblaufListe";
            this.AblaufListe.Size = new System.Drawing.Size(174, 21);
            this.AblaufListe.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 457);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.NOTSTOPP);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.Disconnect);
            this.tabPage1.Controls.Add(this.Connect);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Übertragen";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Initialisieren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Sequenz);
            this.groupBox3.Controls.Add(this.Masterablauf);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.AblaufStart);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(6, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 117);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Automatischer Ablauf";
            // 
            // Sequenz
            // 
            this.Sequenz.AutoSize = true;
            this.Sequenz.Location = new System.Drawing.Point(6, 31);
            this.Sequenz.Name = "Sequenz";
            this.Sequenz.Size = new System.Drawing.Size(49, 13);
            this.Sequenz.TabIndex = 25;
            this.Sequenz.Text = "Sequenz";
            // 
            // Masterablauf
            // 
            this.Masterablauf.FormattingEnabled = true;
            this.Masterablauf.Location = new System.Drawing.Point(6, 47);
            this.Masterablauf.Name = "Masterablauf";
            this.Masterablauf.Size = new System.Drawing.Size(183, 21);
            this.Masterablauf.TabIndex = 22;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(183, 23);
            this.progressBar1.TabIndex = 29;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(246, 48);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 21;
            // 
            // AblaufStart
            // 
            this.AblaufStart.Location = new System.Drawing.Point(382, 48);
            this.AblaufStart.Name = "AblaufStart";
            this.AblaufStart.Size = new System.Drawing.Size(75, 23);
            this.AblaufStart.TabIndex = 19;
            this.AblaufStart.Text = "Start";
            this.AblaufStart.UseVisualStyleBackColor = true;
            this.AblaufStart.Click += new System.EventHandler(this.AblaufStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Durchläufe\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(6, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 100);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ablauf testen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Status :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bereit";
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
            this.comboBox2.Location = new System.Drawing.Point(246, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(40, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Speicherplatz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.AblaufListe);
            this.groupBox1.Controls.Add(this.Uebertragen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 82);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datenübertragung";
            // 
            // Uebertragen
            // 
            this.Uebertragen.Location = new System.Drawing.Point(382, 36);
            this.Uebertragen.Name = "Uebertragen";
            this.Uebertragen.Size = new System.Drawing.Size(75, 23);
            this.Uebertragen.TabIndex = 0;
            this.Uebertragen.Text = "Übertragen";
            this.Uebertragen.UseVisualStyleBackColor = true;
            this.Uebertragen.Click += new System.EventHandler(this.Uebertragen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sequenz";
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
            this.comboBox1.Location = new System.Drawing.Point(246, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(40, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Speicherplatz";
            // 
            // NOTSTOPP
            // 
            this.NOTSTOPP.BackColor = System.Drawing.Color.Red;
            this.NOTSTOPP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NOTSTOPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOTSTOPP.Location = new System.Drawing.Point(363, 338);
            this.NOTSTOPP.Name = "NOTSTOPP";
            this.NOTSTOPP.Size = new System.Drawing.Size(128, 57);
            this.NOTSTOPP.TabIndex = 15;
            this.NOTSTOPP.Text = "STOPP";
            this.NOTSTOPP.UseVisualStyleBackColor = false;
            this.NOTSTOPP.Click += new System.EventHandler(this.NOTSTOPP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Status :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(32, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 43);
            this.panel1.TabIndex = 10;
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(228, 389);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Disconnect.TabIndex = 9;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(228, 323);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 8;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.numeric_Messdauer);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.numeric_Intervall);
            this.tabPage2.Controls.Add(this.numericZellspannung);
            this.tabPage2.Controls.Add(this.Messung_Stopp);
            this.tabPage2.Controls.Add(this.Man_Messung);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.DatenerfassungTab);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empfangen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(384, 296);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Manuelle Messung";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(384, 272);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.Text = "Aktive Messung";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(144, 371);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Messdauer /min";
            // 
            // numeric_Messdauer
            // 
            this.numeric_Messdauer.Location = new System.Drawing.Point(144, 391);
            this.numeric_Messdauer.Name = "numeric_Messdauer";
            this.numeric_Messdauer.Size = new System.Drawing.Size(120, 20);
            this.numeric_Messdauer.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(141, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Intervall /s";
            // 
            // numeric_Intervall
            // 
            this.numeric_Intervall.Location = new System.Drawing.Point(144, 330);
            this.numeric_Intervall.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Intervall.Name = "numeric_Intervall";
            this.numeric_Intervall.Size = new System.Drawing.Size(120, 20);
            this.numeric_Intervall.TabIndex = 10;
            this.numeric_Intervall.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericZellspannung
            // 
            this.numericZellspannung.Location = new System.Drawing.Point(21, 331);
            this.numericZellspannung.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericZellspannung.Name = "numericZellspannung";
            this.numericZellspannung.Size = new System.Drawing.Size(71, 20);
            this.numericZellspannung.TabIndex = 9;
            this.numericZellspannung.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // Messung_Stopp
            // 
            this.Messung_Stopp.Location = new System.Drawing.Point(291, 371);
            this.Messung_Stopp.Name = "Messung_Stopp";
            this.Messung_Stopp.Size = new System.Drawing.Size(75, 23);
            this.Messung_Stopp.TabIndex = 8;
            this.Messung_Stopp.Text = "Stopp";
            this.Messung_Stopp.UseVisualStyleBackColor = true;
            this.Messung_Stopp.Click += new System.EventHandler(this.Messung_Stopp_Click);
            // 
            // Man_Messung
            // 
            this.Man_Messung.Location = new System.Drawing.Point(291, 328);
            this.Man_Messung.Name = "Man_Messung";
            this.Man_Messung.Size = new System.Drawing.Size(75, 23);
            this.Man_Messung.TabIndex = 7;
            this.Man_Messung.Text = "Start";
            this.Man_Messung.UseVisualStyleBackColor = true;
            this.Man_Messung.Click += new System.EventHandler(this.Man_Messung_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Zellspannung";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 64);
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
            this.Spannung1,
            this.Spannung2});
            this.DatenerfassungTab.Location = new System.Drawing.Point(9, 18);
            this.DatenerfassungTab.Name = "DatenerfassungTab";
            this.DatenerfassungTab.Size = new System.Drawing.Size(345, 271);
            this.DatenerfassungTab.TabIndex = 0;
            // 
            // Zeit
            // 
            this.Zeit.DataPropertyName = "Colum1";
            this.Zeit.HeaderText = "Zeit";
            this.Zeit.Name = "Zeit";
            // 
            // Spannung1
            // 
            this.Spannung1.HeaderText = "Sensor 1 [ nA ]";
            this.Spannung1.Name = "Spannung1";
            // 
            // Spannung2
            // 
            this.Spannung2.HeaderText = "Sensor 2 [ nA ]";
            this.Spannung2.Name = "Spannung2";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.Console_Senden);
            this.tabPage3.Controls.Add(this.Console_Eingabe);
            this.tabPage3.Controls.Add(this.Console_Ausgabe);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(519, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Controler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Ausgabe";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 282);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Eingabe";
            // 
            // Console_Senden
            // 
            this.Console_Senden.Location = new System.Drawing.Point(30, 350);
            this.Console_Senden.Name = "Console_Senden";
            this.Console_Senden.Size = new System.Drawing.Size(75, 23);
            this.Console_Senden.TabIndex = 2;
            this.Console_Senden.Text = "Senden";
            this.Console_Senden.UseVisualStyleBackColor = true;
            this.Console_Senden.Click += new System.EventHandler(this.Console_Senden_Click);
            // 
            // Console_Eingabe
            // 
            this.Console_Eingabe.Location = new System.Drawing.Point(30, 298);
            this.Console_Eingabe.Name = "Console_Eingabe";
            this.Console_Eingabe.Size = new System.Drawing.Size(369, 20);
            this.Console_Eingabe.TabIndex = 1;
            // 
            // Console_Ausgabe
            // 
            this.Console_Ausgabe.Location = new System.Drawing.Point(30, 41);
            this.Console_Ausgabe.MaxLength = 10;
            this.Console_Ausgabe.Multiline = true;
            this.Console_Ausgabe.Name = "Console_Ausgabe";
            this.Console_Ausgabe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Console_Ausgabe.Size = new System.Drawing.Size(440, 198);
            this.Console_Ausgabe.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PharMS Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Messdauer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Intervall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZellspannung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatenerfassungTab)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox AblaufListe;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
   //     private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    //    private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
      //  private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Connect;
      //  private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.FolderBrowserDialog Verzeichnisauswahl;
        public System.Windows.Forms.DataGridView DatenerfassungTab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NOTSTOPP;

        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Masterablauf;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button AblaufStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Sequenz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericZellspannung;
        private System.Windows.Forms.Button Messung_Stopp;
        private System.Windows.Forms.Button Man_Messung;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Console_Senden;
        public System.Windows.Forms.TextBox Console_Eingabe;
        public System.Windows.Forms.TextBox Console_Ausgabe;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.NumericUpDown numeric_Messdauer;
        public System.Windows.Forms.NumericUpDown numeric_Intervall;
        private System.Windows.Forms.Button Uebertragen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spannung1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spannung2;
    }
}

