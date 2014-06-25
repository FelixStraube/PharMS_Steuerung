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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AblaufListe = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabSequenzList = new System.Windows.Forms.TabPage();
            this.btnUebertragen = new System.Windows.Forms.Button();
            this.SequenzenGrid = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpeicherplatz = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSequenzedit = new System.Windows.Forms.TabPage();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.btnSaveOneSequenz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.SequenzeditorGrid = new System.Windows.Forms.DataGridView();
            this.colBefehl = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colParametereingabe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHelp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMasterablauf = new System.Windows.Forms.TabPage();
            this.MasterGrid = new System.Windows.Forms.DataGridView();
            this.colOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpeicherplatzMaster = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNameMaster = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.LiveGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiveChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Verzeichnisauswahl = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datenbankÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseDialog = new System.Windows.Forms.OpenFileDialog();
            this.NewDBDialog = new System.Windows.Forms.SaveFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AblaufStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Console_Senden = new System.Windows.Forms.Button();
            this.Console_Eingabe = new System.Windows.Forms.TextBox();
            this.Console_Ausgabe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.NOTSTOPP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabSequenzList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SequenzenGrid)).BeginInit();
            this.tabSequenzedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SequenzeditorGrid)).BeginInit();
            this.tabMasterablauf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Messdauer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Intervall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZellspannung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatenerfassungTab)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiveGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AblaufListe
            // 
            this.AblaufListe.FormattingEnabled = true;
            this.AblaufListe.Location = new System.Drawing.Point(6, 24);
            this.AblaufListe.Name = "AblaufListe";
            this.AblaufListe.Size = new System.Drawing.Size(174, 21);
            this.AblaufListe.TabIndex = 2;
            this.AblaufListe.SelectedValueChanged += new System.EventHandler(this.AblaufListe_SelectedValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabSequenzList);
            this.tabControl1.Controls.Add(this.tabSequenzedit);
            this.tabControl1.Controls.Add(this.tabMasterablauf);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(7, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 600);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.Console_Senden);
            this.tabPage1.Controls.Add(this.Console_Eingabe);
            this.tabPage1.Controls.Add(this.Console_Ausgabe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Übertragen";
            // 
            // tabSequenzList
            // 
            this.tabSequenzList.Controls.Add(this.btnUebertragen);
            this.tabSequenzList.Controls.Add(this.SequenzenGrid);
            this.tabSequenzList.Location = new System.Drawing.Point(4, 22);
            this.tabSequenzList.Name = "tabSequenzList";
            this.tabSequenzList.Size = new System.Drawing.Size(519, 574);
            this.tabSequenzList.TabIndex = 4;
            this.tabSequenzList.Text = "Sequenzen";
            this.tabSequenzList.UseVisualStyleBackColor = true;
            // 
            // btnUebertragen
            // 
            this.btnUebertragen.Location = new System.Drawing.Point(18, 529);
            this.btnUebertragen.Name = "btnUebertragen";
            this.btnUebertragen.Size = new System.Drawing.Size(75, 23);
            this.btnUebertragen.TabIndex = 1;
            this.btnUebertragen.Text = "Übertragen";
            this.btnUebertragen.UseVisualStyleBackColor = true;
            this.btnUebertragen.Click += new System.EventHandler(this.btnUebertragen_Click);
            // 
            // SequenzenGrid
            // 
            this.SequenzenGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SequenzenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SequenzenGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSpeicherplatz,
            this.colDelete,
            this.colIndex});
            this.SequenzenGrid.Location = new System.Drawing.Point(1, 3);
            this.SequenzenGrid.Name = "SequenzenGrid";
            this.SequenzenGrid.Size = new System.Drawing.Size(518, 500);
            this.SequenzenGrid.TabIndex = 0;
            this.SequenzenGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SequenzenGrid_CellMouseClick);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Sequenz";
            this.colName.Name = "colName";
            // 
            // colSpeicherplatz
            // 
            this.colSpeicherplatz.HeaderText = "Speicherplatz";
            this.colSpeicherplatz.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
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
            this.colSpeicherplatz.Name = "colSpeicherplatz";
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Löschen";
            this.colDelete.Image = ((System.Drawing.Image)(resources.GetObject("colDelete.Image")));
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 60;
            // 
            // colIndex
            // 
            this.colIndex.HeaderText = "Index";
            this.colIndex.Name = "colIndex";
            this.colIndex.Visible = false;
            // 
            // tabSequenzedit
            // 
            this.tabSequenzedit.Controls.Add(this.txtNewName);
            this.tabSequenzedit.Controls.Add(this.lblNewName);
            this.tabSequenzedit.Controls.Add(this.btnSaveOneSequenz);
            this.tabSequenzedit.Controls.Add(this.label2);
            this.tabSequenzedit.Controls.Add(this.AblaufListe);
            this.tabSequenzedit.Controls.Add(this.chkFilter);
            this.tabSequenzedit.Controls.Add(this.SequenzeditorGrid);
            this.tabSequenzedit.Location = new System.Drawing.Point(4, 22);
            this.tabSequenzedit.Name = "tabSequenzedit";
            this.tabSequenzedit.Size = new System.Drawing.Size(519, 574);
            this.tabSequenzedit.TabIndex = 3;
            this.tabSequenzedit.Text = "Sequenzeditor";
            this.tabSequenzedit.UseVisualStyleBackColor = true;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(142, 519);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(151, 20);
            this.txtNewName.TabIndex = 14;
            this.txtNewName.Visible = false;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(5, 519);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(134, 13);
            this.lblNewName.TabIndex = 13;
            this.lblNewName.Text = "Name der neuen Sequenz:";
            this.lblNewName.Visible = false;
            // 
            // btnSaveOneSequenz
            // 
            this.btnSaveOneSequenz.Location = new System.Drawing.Point(17, 544);
            this.btnSaveOneSequenz.Name = "btnSaveOneSequenz";
            this.btnSaveOneSequenz.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOneSequenz.TabIndex = 3;
            this.btnSaveOneSequenz.Text = "Speichern";
            this.btnSaveOneSequenz.UseVisualStyleBackColor = true;
            this.btnSaveOneSequenz.Click += new System.EventHandler(this.btnSaveOneSequenz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sequenz";
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Location = new System.Drawing.Point(270, 24);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(176, 17);
            this.chkFilter.TabIndex = 1;
            this.chkFilter.Text = "Filtern nach Eingabemöglichkeit";
            this.chkFilter.UseVisualStyleBackColor = true;
            // 
            // SequenzeditorGrid
            // 
            this.SequenzeditorGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SequenzeditorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SequenzeditorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBefehl,
            this.colParametereingabe,
            this.colHelp});
            this.SequenzeditorGrid.Location = new System.Drawing.Point(0, 51);
            this.SequenzeditorGrid.Name = "SequenzeditorGrid";
            this.SequenzeditorGrid.Size = new System.Drawing.Size(519, 456);
            this.SequenzeditorGrid.TabIndex = 0;
            // 
            // colBefehl
            // 
            this.colBefehl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colBefehl.Frozen = true;
            this.colBefehl.HeaderText = "Befehl";
            this.colBefehl.Name = "colBefehl";
            this.colBefehl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBefehl.Width = 60;
            // 
            // colParametereingabe
            // 
            this.colParametereingabe.Frozen = true;
            this.colParametereingabe.HeaderText = "Parametereingabe";
            this.colParametereingabe.Name = "colParametereingabe";
            this.colParametereingabe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colHelp
            // 
            this.colHelp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHelp.HeaderText = "Erklärung";
            this.colHelp.Name = "colHelp";
            this.colHelp.ReadOnly = true;
            this.colHelp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabMasterablauf
            // 
            this.tabMasterablauf.Controls.Add(this.progressBar1);
            this.tabMasterablauf.Controls.Add(this.numericUpDown1);
            this.tabMasterablauf.Controls.Add(this.AblaufStart);
            this.tabMasterablauf.Controls.Add(this.label5);
            this.tabMasterablauf.Controls.Add(this.MasterGrid);
            this.tabMasterablauf.Location = new System.Drawing.Point(4, 22);
            this.tabMasterablauf.Name = "tabMasterablauf";
            this.tabMasterablauf.Size = new System.Drawing.Size(519, 574);
            this.tabMasterablauf.TabIndex = 5;
            this.tabMasterablauf.Text = "Masterablauf";
            this.tabMasterablauf.UseVisualStyleBackColor = true;
            // 
            // MasterGrid
            // 
            this.MasterGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MasterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasterGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrder,
            this.colSpeicherplatzMaster,
            this.colNameMaster});
            this.MasterGrid.Location = new System.Drawing.Point(0, 50);
            this.MasterGrid.Name = "MasterGrid";
            this.MasterGrid.Size = new System.Drawing.Size(519, 512);
            this.MasterGrid.TabIndex = 1;
            this.MasterGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.MasterGrid_DataError);
            // 
            // colOrder
            // 
            this.colOrder.Frozen = true;
            this.colOrder.HeaderText = "";
            this.colOrder.Name = "colOrder";
            this.colOrder.ReadOnly = true;
            this.colOrder.Width = 20;
            // 
            // colSpeicherplatzMaster
            // 
            this.colSpeicherplatzMaster.Frozen = true;
            this.colSpeicherplatzMaster.HeaderText = "Speicherplatz";
            this.colSpeicherplatzMaster.Name = "colSpeicherplatzMaster";
            this.colSpeicherplatzMaster.Width = 60;
            // 
            // colNameMaster
            // 
            this.colNameMaster.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNameMaster.HeaderText = "Sequenz";
            this.colNameMaster.Name = "colNameMaster";
            this.colNameMaster.ReadOnly = true;
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
            this.tabPage2.Size = new System.Drawing.Size(519, 574);
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
            this.numeric_Messdauer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
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
            this.numeric_Intervall.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.LiveGrid);
            this.tabPage4.Controls.Add(this.LiveChart);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(519, 574);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Live Chart";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LiveGrid
            // 
            this.LiveGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LiveGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.LiveGrid.Location = new System.Drawing.Point(70, 344);
            this.LiveGrid.Name = "LiveGrid";
            this.LiveGrid.Size = new System.Drawing.Size(328, 150);
            this.LiveGrid.TabIndex = 1;
            this.LiveGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LiveGrid_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // LiveChart
            // 
            chartArea4.Name = "ChartArea1";
            this.LiveChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.LiveChart.Legends.Add(legend4);
            this.LiveChart.Location = new System.Drawing.Point(31, 32);
            this.LiveChart.Name = "LiveChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.LiveChart.Series.Add(series7);
            this.LiveChart.Series.Add(series8);
            this.LiveChart.Size = new System.Drawing.Size(466, 289);
            this.LiveChart.TabIndex = 0;
            this.LiveChart.Text = "chart1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.datenbankÖffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.ImportStripMenuItem2,
            this.beendenToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // datenbankÖffnenToolStripMenuItem
            // 
            this.datenbankÖffnenToolStripMenuItem.Name = "datenbankÖffnenToolStripMenuItem";
            this.datenbankÖffnenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.datenbankÖffnenToolStripMenuItem.Text = "Datenbank öffnen";
            this.datenbankÖffnenToolStripMenuItem.Click += new System.EventHandler(this.datenbankÖffnenToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // ImportStripMenuItem2
            // 
            this.ImportStripMenuItem2.Name = "ImportStripMenuItem2";
            this.ImportStripMenuItem2.Size = new System.Drawing.Size(183, 22);
            this.ImportStripMenuItem2.Text = "Sequenz importieren";
            this.ImportStripMenuItem2.Click += new System.EventHandler(this.ImportStripMenuItem2_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // openDatabaseDialog
            // 
            this.openDatabaseDialog.Filter = "Pharms (*.pharms)|*.pharms|Textdateien|*.txt";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 21);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(183, 23);
            this.progressBar1.TabIndex = 33;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(257, 24);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 31;
            // 
            // AblaufStart
            // 
            this.AblaufStart.Location = new System.Drawing.Point(393, 24);
            this.AblaufStart.Name = "AblaufStart";
            this.AblaufStart.Size = new System.Drawing.Size(75, 23);
            this.AblaufStart.TabIndex = 30;
            this.AblaufStart.Text = "Start";
            this.AblaufStart.UseVisualStyleBackColor = true;
            this.AblaufStart.Click += new System.EventHandler(this.AblaufStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Durchläufe\r\n";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Ausgabe";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Eingabe";
            // 
            // Console_Senden
            // 
            this.Console_Senden.Location = new System.Drawing.Point(35, 284);
            this.Console_Senden.Name = "Console_Senden";
            this.Console_Senden.Size = new System.Drawing.Size(75, 23);
            this.Console_Senden.TabIndex = 36;
            this.Console_Senden.Text = "Senden";
            this.Console_Senden.UseVisualStyleBackColor = true;
            // 
            // Console_Eingabe
            // 
            this.Console_Eingabe.Location = new System.Drawing.Point(32, 244);
            this.Console_Eingabe.Name = "Console_Eingabe";
            this.Console_Eingabe.Size = new System.Drawing.Size(369, 20);
            this.Console_Eingabe.TabIndex = 35;
            // 
            // Console_Ausgabe
            // 
            this.Console_Ausgabe.Location = new System.Drawing.Point(32, 27);
            this.Console_Ausgabe.Multiline = true;
            this.Console_Ausgabe.Name = "Console_Ausgabe";
            this.Console_Ausgabe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Console_Ausgabe.Size = new System.Drawing.Size(440, 198);
            this.Console_Ausgabe.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.NOTSTOPP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.Disconnect);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Location = new System.Drawing.Point(19, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 225);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Initialisieren";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NOTSTOPP
            // 
            this.NOTSTOPP.BackColor = System.Drawing.Color.Red;
            this.NOTSTOPP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NOTSTOPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOTSTOPP.Location = new System.Drawing.Point(342, 83);
            this.NOTSTOPP.Name = "NOTSTOPP";
            this.NOTSTOPP.Size = new System.Drawing.Size(128, 57);
            this.NOTSTOPP.TabIndex = 38;
            this.NOTSTOPP.Text = "STOPP";
            this.NOTSTOPP.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Status :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(11, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 43);
            this.panel1.TabIndex = 36;
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(207, 134);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Disconnect.TabIndex = 35;
            this.Disconnect.Text = "bbb";
            this.Disconnect.UseVisualStyleBackColor = true;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(207, 68);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 34;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 624);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "PharMS Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabSequenzList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SequenzenGrid)).EndInit();
            this.tabSequenzedit.ResumeLayout(false);
            this.tabSequenzedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SequenzeditorGrid)).EndInit();
            this.tabMasterablauf.ResumeLayout(false);
            this.tabMasterablauf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Messdauer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Intervall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZellspannung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatenerfassungTab)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LiveGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
   //     private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        //    private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        //  private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
      //  private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.FolderBrowserDialog Verzeichnisauswahl;
        public System.Windows.Forms.DataGridView DatenerfassungTab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericZellspannung;
        private System.Windows.Forms.Button Messung_Stopp;
        private System.Windows.Forms.Button Man_Messung;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.NumericUpDown numeric_Messdauer;
        public System.Windows.Forms.NumericUpDown numeric_Intervall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spannung1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spannung2;
        private System.Windows.Forms.TabPage tabSequenzedit;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        public System.Windows.Forms.DataGridView SequenzeditorGrid;
        public System.Windows.Forms.ComboBox AblaufListe;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datenbankÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openDatabaseDialog;
        private System.Windows.Forms.ToolStripMenuItem ImportStripMenuItem2;
        private System.Windows.Forms.TabPage tabSequenzList;
        public System.Windows.Forms.DataGridView SequenzenGrid;
        private System.Windows.Forms.SaveFileDialog NewDBDialog;
        public System.Windows.Forms.Button btnSaveOneSequenz;
        private System.Windows.Forms.DataGridViewComboBoxColumn colBefehl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParametereingabe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHelp;
        public System.Windows.Forms.TextBox txtNewName;
        public System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colSpeicherplatz;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.Button btnUebertragen;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataVisualization.Charting.Chart LiveChart;
        public System.Windows.Forms.DataGridView LiveGrid;

        private System.Windows.Forms.TabPage tabMasterablauf;
        public System.Windows.Forms.DataGridView MasterGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrder;
        private System.Windows.Forms.DataGridViewComboBoxColumn colSpeicherplatzMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameMaster;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Console_Senden;
        public System.Windows.Forms.TextBox Console_Eingabe;
        public System.Windows.Forms.TextBox Console_Ausgabe;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button AblaufStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button NOTSTOPP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Connect;

    }
}

