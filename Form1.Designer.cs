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
            this.components = new System.ComponentModel.Container();
            this.Verzeichnisauswahl = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemDatenbankÖffnen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemSpeichern = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemSpeichernUnter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseDialog = new System.Windows.Forms.OpenFileDialog();
            this.NewDBDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLiveChart = new System.Windows.Forms.Button();
            this.MesszyklusGrid = new System.Windows.Forms.DataGridView();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnNeueMessung = new System.Windows.Forms.Button();
            this.Messung_Stopp = new System.Windows.Forms.Button();
            this.Man_Messung = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DatenerfassungTab = new System.Windows.Forms.DataGridView();
            this.tabMasterablauf = new System.Windows.Forms.TabPage();
            this.MasterGrid2 = new System.Windows.Forms.DataGridView();
            this.btnProbe1_leeren = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AblaufStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabSequenzedit = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.AblaufListe = new System.Windows.Forms.ComboBox();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.SequenzeditorGrid = new System.Windows.Forms.DataGridView();
            this.tabSequenzList = new System.Windows.Forms.TabPage();
            this.btnUebertragen = new System.Windows.Forms.Button();
            this.SequenzenGrid = new System.Windows.Forms.DataGridView();
            this.tabGKommunikation = new System.Windows.Forms.TabPage();
            this.lblSequenz = new System.Windows.Forms.Label();
            this.lblMaster = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Console_Senden = new System.Windows.Forms.Button();
            this.Console_Eingabe = new System.Windows.Forms.TextBox();
            this.Console_Ausgabe = new System.Windows.Forms.TextBox();
            this.tabDeviceParameter = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLeitungen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numSpuelen = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLeitungDes = new System.Windows.Forms.Button();
            this.numDesinfektion = new System.Windows.Forms.NumericUpDown();
            this.btnElektrodenTest = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericResponsetime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numeric_Messdauer = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numeric_Intervall = new System.Windows.Forms.NumericUpDown();
            this.numericZellspannung = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.grbTemperierung = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxTemperatur = new System.Windows.Forms.TextBox();
            this.lbTemperatur = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Button_Pumpe_Abfall_AUS = new System.Windows.Forms.Button();
            this.Button_Pumpe_Abfall_EIN = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button_Pumpe_MZ_AUS = new System.Windows.Forms.Button();
            this.Button_Pumpe_MZ_EIN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.NOTSTOPP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProben = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabMastersequenz = new System.Windows.Forms.TabPage();
            this.cmbMastersequenz = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.MasterGrid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipResponsetime = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesszyklusGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatenerfassungTab)).BeginInit();
            this.tabMasterablauf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabSequenzedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SequenzeditorGrid)).BeginInit();
            this.tabSequenzList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SequenzenGrid)).BeginInit();
            this.tabGKommunikation.SuspendLayout();
            this.tabDeviceParameter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpuelen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesinfektion)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericResponsetime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Messdauer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Intervall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZellspannung)).BeginInit();
            this.grbTemperierung.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabProben.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabMastersequenz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemNeu,
            this.mnItemDatenbankÖffnen,
            this.mnItemSpeichern,
            this.mnItemSpeichernUnter,
            this.mnItemBeenden});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Datei";
            // 
            // mnItemNeu
            // 
            this.mnItemNeu.Name = "mnItemNeu";
            this.mnItemNeu.Size = new System.Drawing.Size(169, 22);
            this.mnItemNeu.Text = "Neu";
            this.mnItemNeu.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // mnItemDatenbankÖffnen
            // 
            this.mnItemDatenbankÖffnen.Name = "mnItemDatenbankÖffnen";
            this.mnItemDatenbankÖffnen.Size = new System.Drawing.Size(169, 22);
            this.mnItemDatenbankÖffnen.Text = "Datenbank öffnen";
            this.mnItemDatenbankÖffnen.Click += new System.EventHandler(this.datenbankÖffnenToolStripMenuItem_Click);
            // 
            // mnItemSpeichern
            // 
            this.mnItemSpeichern.Name = "mnItemSpeichern";
            this.mnItemSpeichern.Size = new System.Drawing.Size(169, 22);
            this.mnItemSpeichern.Text = "Speichern";
            this.mnItemSpeichern.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // mnItemSpeichernUnter
            // 
            this.mnItemSpeichernUnter.Name = "mnItemSpeichernUnter";
            this.mnItemSpeichernUnter.Size = new System.Drawing.Size(169, 22);
            this.mnItemSpeichernUnter.Text = "Speichern unter...";
            this.mnItemSpeichernUnter.Visible = false;
            this.mnItemSpeichernUnter.Click += new System.EventHandler(this.mnItemSpeichernUnter_Click);
            // 
            // mnItemBeenden
            // 
            this.mnItemBeenden.Name = "mnItemBeenden";
            this.mnItemBeenden.Size = new System.Drawing.Size(169, 22);
            this.mnItemBeenden.Text = "Beenden";
            this.mnItemBeenden.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // openDatabaseDialog
            // 
            this.openDatabaseDialog.Filter = "DB3 (*.db3)|*.db3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLiveChart);
            this.tabPage2.Controls.Add(this.MesszyklusGrid);
            this.tabPage2.Controls.Add(this.btnChart);
            this.tabPage2.Controls.Add(this.btnNeueMessung);
            this.tabPage2.Controls.Add(this.Messung_Stopp);
            this.tabPage2.Controls.Add(this.Man_Messung);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.DatenerfassungTab);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 744);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Messdaten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLiveChart
            // 
            this.btnLiveChart.Location = new System.Drawing.Point(447, 268);
            this.btnLiveChart.Name = "btnLiveChart";
            this.btnLiveChart.Size = new System.Drawing.Size(75, 23);
            this.btnLiveChart.TabIndex = 35;
            this.btnLiveChart.Text = "Live Chart";
            this.btnLiveChart.UseVisualStyleBackColor = true;
            this.btnLiveChart.Click += new System.EventHandler(this.btnLiveChart_Click);
            // 
            // MesszyklusGrid
            // 
            this.MesszyklusGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MesszyklusGrid.Location = new System.Drawing.Point(9, 353);
            this.MesszyklusGrid.Name = "MesszyklusGrid";
            this.MesszyklusGrid.Size = new System.Drawing.Size(432, 217);
            this.MesszyklusGrid.TabIndex = 34;
            this.MesszyklusGrid.SelectionChanged += new System.EventHandler(this.MesszyklusGrid_SelectionChanged);
            this.MesszyklusGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.MesszyklusGrid_UserDeletingRow);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(447, 225);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(75, 23);
            this.btnChart.TabIndex = 11;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnNeueMessung
            // 
            this.btnNeueMessung.Location = new System.Drawing.Point(447, 103);
            this.btnNeueMessung.Name = "btnNeueMessung";
            this.btnNeueMessung.Size = new System.Drawing.Size(96, 23);
            this.btnNeueMessung.TabIndex = 9;
            this.btnNeueMessung.Text = "Neue Messung";
            this.btnNeueMessung.UseVisualStyleBackColor = true;
            this.btnNeueMessung.Visible = false;
            this.btnNeueMessung.Click += new System.EventHandler(this.btnNeueMessung_Click);
            // 
            // Messung_Stopp
            // 
            this.Messung_Stopp.Location = new System.Drawing.Point(447, 181);
            this.Messung_Stopp.Name = "Messung_Stopp";
            this.Messung_Stopp.Size = new System.Drawing.Size(75, 23);
            this.Messung_Stopp.TabIndex = 8;
            this.Messung_Stopp.Text = "Stopp";
            this.Messung_Stopp.UseVisualStyleBackColor = true;
            this.Messung_Stopp.Click += new System.EventHandler(this.Messung_Stopp_Click);
            // 
            // Man_Messung
            // 
            this.Man_Messung.Location = new System.Drawing.Point(447, 141);
            this.Man_Messung.Name = "Man_Messung";
            this.Man_Messung.Size = new System.Drawing.Size(75, 23);
            this.Man_Messung.TabIndex = 7;
            this.Man_Messung.Text = "Start";
            this.Man_Messung.UseVisualStyleBackColor = true;
            this.Man_Messung.Click += new System.EventHandler(this.Man_Messung_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Export als *.csv";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // DatenerfassungTab
            // 
            this.DatenerfassungTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatenerfassungTab.Location = new System.Drawing.Point(9, 18);
            this.DatenerfassungTab.Name = "DatenerfassungTab";
            this.DatenerfassungTab.Size = new System.Drawing.Size(432, 318);
            this.DatenerfassungTab.TabIndex = 0;
            this.DatenerfassungTab.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DatenerfassungTab_DataError);
            // 
            // tabMasterablauf
            // 
            this.tabMasterablauf.Controls.Add(this.MasterGrid2);
            this.tabMasterablauf.Controls.Add(this.btnProbe1_leeren);
            this.tabMasterablauf.Controls.Add(this.numericUpDown1);
            this.tabMasterablauf.Controls.Add(this.AblaufStart);
            this.tabMasterablauf.Controls.Add(this.label5);
            this.tabMasterablauf.Location = new System.Drawing.Point(4, 22);
            this.tabMasterablauf.Name = "tabMasterablauf";
            this.tabMasterablauf.Size = new System.Drawing.Size(583, 744);
            this.tabMasterablauf.TabIndex = 5;
            this.tabMasterablauf.Text = "Masterablauf";
            this.tabMasterablauf.UseVisualStyleBackColor = true;
            // 
            // MasterGrid2
            // 
            this.MasterGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MasterGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasterGrid2.Location = new System.Drawing.Point(3, 64);
            this.MasterGrid2.Name = "MasterGrid2";
            this.MasterGrid2.Size = new System.Drawing.Size(435, 540);
            this.MasterGrid2.TabIndex = 34;
            this.MasterGrid2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.MasterGrid2_DataBindingComplete);
            this.MasterGrid2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.MasterGrid2_DataError);
            this.MasterGrid2.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.MasterGrid2_RowValidating);
            // 
            // btnProbe1_leeren
            // 
            this.btnProbe1_leeren.Location = new System.Drawing.Point(256, 21);
            this.btnProbe1_leeren.Name = "btnProbe1_leeren";
            this.btnProbe1_leeren.Size = new System.Drawing.Size(100, 23);
            this.btnProbe1_leeren.TabIndex = 33;
            this.btnProbe1_leeren.Text = "Gefäß 1 leeren";
            this.btnProbe1_leeren.UseVisualStyleBackColor = true;
            this.btnProbe1_leeren.Click += new System.EventHandler(this.btnProbe1_leeren_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(20, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 31;
            // 
            // AblaufStart
            // 
            this.AblaufStart.Location = new System.Drawing.Point(156, 21);
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
            this.label5.Location = new System.Drawing.Point(17, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Durchläufe\r\n";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(11, 709);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(591, 15);
            this.progressBar1.TabIndex = 33;
            // 
            // tabSequenzedit
            // 
            this.tabSequenzedit.Controls.Add(this.label2);
            this.tabSequenzedit.Controls.Add(this.AblaufListe);
            this.tabSequenzedit.Controls.Add(this.chkFilter);
            this.tabSequenzedit.Controls.Add(this.SequenzeditorGrid);
            this.tabSequenzedit.Location = new System.Drawing.Point(4, 22);
            this.tabSequenzedit.Name = "tabSequenzedit";
            this.tabSequenzedit.Size = new System.Drawing.Size(583, 744);
            this.tabSequenzedit.TabIndex = 3;
            this.tabSequenzedit.Text = "Sequenzeditor";
            this.tabSequenzedit.UseVisualStyleBackColor = true;
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
            // AblaufListe
            // 
            this.AblaufListe.FormattingEnabled = true;
            this.AblaufListe.Location = new System.Drawing.Point(6, 24);
            this.AblaufListe.Name = "AblaufListe";
            this.AblaufListe.Size = new System.Drawing.Size(174, 21);
            this.AblaufListe.TabIndex = 2;
            this.AblaufListe.SelectedValueChanged += new System.EventHandler(this.AblaufListe_SelectedValueChanged);
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
            this.chkFilter.Visible = false;
            // 
            // SequenzeditorGrid
            // 
            this.SequenzeditorGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SequenzeditorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SequenzeditorGrid.Location = new System.Drawing.Point(0, 51);
            this.SequenzeditorGrid.Name = "SequenzeditorGrid";
            this.SequenzeditorGrid.Size = new System.Drawing.Size(435, 441);
            this.SequenzeditorGrid.TabIndex = 0;
            this.SequenzeditorGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.SequenzeditorGrid_CellValidated);
            this.SequenzeditorGrid.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.SequenzeditorGrid_DefaultValuesNeeded);
            // 
            // tabSequenzList
            // 
            this.tabSequenzList.Controls.Add(this.btnUebertragen);
            this.tabSequenzList.Controls.Add(this.SequenzenGrid);
            this.tabSequenzList.Location = new System.Drawing.Point(4, 22);
            this.tabSequenzList.Name = "tabSequenzList";
            this.tabSequenzList.Size = new System.Drawing.Size(583, 744);
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
            this.SequenzenGrid.Location = new System.Drawing.Point(1, 3);
            this.SequenzenGrid.Name = "SequenzenGrid";
            this.SequenzenGrid.Size = new System.Drawing.Size(433, 500);
            this.SequenzenGrid.TabIndex = 0;
            this.SequenzenGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.SequenzenGrid_UserDeletingRow);
            this.SequenzenGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SequenzenGrid_MouseClick);
            // 
            // tabGKommunikation
            // 
            this.tabGKommunikation.BackColor = System.Drawing.Color.White;
            this.tabGKommunikation.Controls.Add(this.lblSequenz);
            this.tabGKommunikation.Controls.Add(this.lblMaster);
            this.tabGKommunikation.Controls.Add(this.label16);
            this.tabGKommunikation.Controls.Add(this.label15);
            this.tabGKommunikation.Controls.Add(this.Console_Senden);
            this.tabGKommunikation.Controls.Add(this.Console_Eingabe);
            this.tabGKommunikation.Controls.Add(this.Console_Ausgabe);
            this.tabGKommunikation.Location = new System.Drawing.Point(4, 22);
            this.tabGKommunikation.Name = "tabGKommunikation";
            this.tabGKommunikation.Padding = new System.Windows.Forms.Padding(3);
            this.tabGKommunikation.Size = new System.Drawing.Size(583, 744);
            this.tabGKommunikation.TabIndex = 0;
            this.tabGKommunikation.Text = "Gerätekommunikation";
            // 
            // lblSequenz
            // 
            this.lblSequenz.AutoSize = true;
            this.lblSequenz.Location = new System.Drawing.Point(39, 371);
            this.lblSequenz.Name = "lblSequenz";
            this.lblSequenz.Size = new System.Drawing.Size(49, 13);
            this.lblSequenz.TabIndex = 40;
            this.lblSequenz.Text = "Sequenz";
            // 
            // lblMaster
            // 
            this.lblMaster.AutoSize = true;
            this.lblMaster.Location = new System.Drawing.Point(39, 349);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(39, 13);
            this.lblMaster.TabIndex = 39;
            this.lblMaster.Text = "Master";
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
            this.Console_Senden.Click += new System.EventHandler(this.Console_Senden_Click);
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
            // tabDeviceParameter
            // 
            this.tabDeviceParameter.Controls.Add(this.groupBox2);
            this.tabDeviceParameter.Controls.Add(this.groupBox1);
            this.tabDeviceParameter.Location = new System.Drawing.Point(4, 22);
            this.tabDeviceParameter.Name = "tabDeviceParameter";
            this.tabDeviceParameter.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeviceParameter.Size = new System.Drawing.Size(583, 744);
            this.tabDeviceParameter.TabIndex = 6;
            this.tabDeviceParameter.Text = "Geräteparameter";
            this.tabDeviceParameter.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLeitungen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numSpuelen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnLeitungDes);
            this.groupBox2.Controls.Add(this.numDesinfektion);
            this.groupBox2.Controls.Add(this.btnElektrodenTest);
            this.groupBox2.Controls.Add(this.btnReg);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.grbTemperierung);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(21, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 419);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geräteparameter";
            // 
            // btnLeitungen
            // 
            this.btnLeitungen.Location = new System.Drawing.Point(11, 390);
            this.btnLeitungen.Name = "btnLeitungen";
            this.btnLeitungen.Size = new System.Drawing.Size(112, 23);
            this.btnLeitungen.TabIndex = 28;
            this.btnLeitungen.Text = "Leitungen befüllen";
            this.btnLeitungen.UseVisualStyleBackColor = true;
            this.btnLeitungen.Click += new System.EventHandler(this.btnLeitungen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Anzahl der Spülzyklen";
            // 
            // numSpuelen
            // 
            this.numSpuelen.Location = new System.Drawing.Point(383, 363);
            this.numSpuelen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSpuelen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpuelen.Name = "numSpuelen";
            this.numSpuelen.Size = new System.Drawing.Size(49, 20);
            this.numSpuelen.TabIndex = 26;
            this.numSpuelen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Anzahl der Desinfektionszyklen";
            // 
            // btnLeitungDes
            // 
            this.btnLeitungDes.Enabled = false;
            this.btnLeitungDes.Location = new System.Drawing.Point(11, 360);
            this.btnLeitungDes.Name = "btnLeitungDes";
            this.btnLeitungDes.Size = new System.Drawing.Size(178, 23);
            this.btnLeitungDes.TabIndex = 6;
            this.btnLeitungDes.Text = "Leitungen desinfizieren und spülen";
            this.btnLeitungDes.UseVisualStyleBackColor = true;
            this.btnLeitungDes.Click += new System.EventHandler(this.btnLeitungDes_Click);
            // 
            // numDesinfektion
            // 
            this.numDesinfektion.Location = new System.Drawing.Point(227, 363);
            this.numDesinfektion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDesinfektion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDesinfektion.Name = "numDesinfektion";
            this.numDesinfektion.Size = new System.Drawing.Size(49, 20);
            this.numDesinfektion.TabIndex = 24;
            this.numDesinfektion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnElektrodenTest
            // 
            this.btnElektrodenTest.Enabled = false;
            this.btnElektrodenTest.Location = new System.Drawing.Point(11, 330);
            this.btnElektrodenTest.Name = "btnElektrodenTest";
            this.btnElektrodenTest.Size = new System.Drawing.Size(97, 23);
            this.btnElektrodenTest.TabIndex = 5;
            this.btnElektrodenTest.Text = "Elektrodentest";
            this.btnElektrodenTest.UseVisualStyleBackColor = true;
            this.btnElektrodenTest.Click += new System.EventHandler(this.btnElektrodenTest_Click);
            // 
            // btnReg
            // 
            this.btnReg.Enabled = false;
            this.btnReg.Location = new System.Drawing.Point(11, 299);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(141, 23);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Elektroden regenerieren";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericResponsetime);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.numeric_Messdauer);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.numeric_Intervall);
            this.groupBox5.Controls.Add(this.numericZellspannung);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(11, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(508, 132);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Messung";
            this.toolTipResponsetime.SetToolTip(this.groupBox5, "Die Wartezeit gibt an wie lange die Software auf die Antwort vom Pharmsgerät maxi" +
        "mal wartet.");
            // 
            // numericResponsetime
            // 
            this.numericResponsetime.Location = new System.Drawing.Point(166, 93);
            this.numericResponsetime.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericResponsetime.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericResponsetime.Name = "numericResponsetime";
            this.numericResponsetime.Size = new System.Drawing.Size(94, 20);
            this.numericResponsetime.TabIndex = 25;
            this.toolTipResponsetime.SetToolTip(this.numericResponsetime, "Gibt die maximale Wartezeit für die Annahme eines Befehls an.");
            this.numericResponsetime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericResponsetime.ValueChanged += new System.EventHandler(this.numericResponsetime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Wartezeit in min";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Messdauer /min";
            // 
            // numeric_Messdauer
            // 
            this.numeric_Messdauer.Location = new System.Drawing.Point(13, 93);
            this.numeric_Messdauer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_Messdauer.Name = "numeric_Messdauer";
            this.numeric_Messdauer.Size = new System.Drawing.Size(120, 20);
            this.numeric_Messdauer.TabIndex = 22;
            this.numeric_Messdauer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Messdauer.ValueChanged += new System.EventHandler(this.numeric_Messdauer_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Intervall /s";
            // 
            // numeric_Intervall
            // 
            this.numeric_Intervall.Location = new System.Drawing.Point(13, 41);
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
            this.numeric_Intervall.TabIndex = 20;
            this.numeric_Intervall.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_Intervall.ValueChanged += new System.EventHandler(this.numeric_Intervall_ValueChanged);
            // 
            // numericZellspannung
            // 
            this.numericZellspannung.Location = new System.Drawing.Point(167, 41);
            this.numericZellspannung.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericZellspannung.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericZellspannung.Name = "numericZellspannung";
            this.numericZellspannung.Size = new System.Drawing.Size(94, 20);
            this.numericZellspannung.TabIndex = 19;
            this.numericZellspannung.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Zellspannung /mV";
            // 
            // grbTemperierung
            // 
            this.grbTemperierung.Controls.Add(this.button4);
            this.grbTemperierung.Controls.Add(this.button1);
            this.grbTemperierung.Controls.Add(this.txtboxTemperatur);
            this.grbTemperierung.Controls.Add(this.lbTemperatur);
            this.grbTemperierung.Location = new System.Drawing.Point(323, 37);
            this.grbTemperierung.Name = "grbTemperierung";
            this.grbTemperierung.Size = new System.Drawing.Size(196, 105);
            this.grbTemperierung.TabIndex = 2;
            this.grbTemperierung.TabStop = false;
            this.grbTemperierung.Text = "Temperierung";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 25);
            this.button4.TabIndex = 6;
            this.button4.Text = "Aus";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnTemperierungAus);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ein";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTemperierungEin);
            // 
            // txtboxTemperatur
            // 
            this.txtboxTemperatur.Location = new System.Drawing.Point(104, 70);
            this.txtboxTemperatur.Name = "txtboxTemperatur";
            this.txtboxTemperatur.Size = new System.Drawing.Size(70, 20);
            this.txtboxTemperatur.TabIndex = 4;
            this.txtboxTemperatur.Text = "37";
            // 
            // lbTemperatur
            // 
            this.lbTemperatur.AutoSize = true;
            this.lbTemperatur.Location = new System.Drawing.Point(10, 77);
            this.lbTemperatur.Name = "lbTemperatur";
            this.lbTemperatur.Size = new System.Drawing.Size(89, 13);
            this.lbTemperatur.TabIndex = 3;
            this.lbTemperatur.Text = "Temperatur in °C:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Button_Pumpe_Abfall_AUS);
            this.groupBox4.Controls.Add(this.Button_Pumpe_Abfall_EIN);
            this.groupBox4.Location = new System.Drawing.Point(151, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 105);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pumpe Abfallbehandlung";
            // 
            // Button_Pumpe_Abfall_AUS
            // 
            this.Button_Pumpe_Abfall_AUS.Location = new System.Drawing.Point(25, 65);
            this.Button_Pumpe_Abfall_AUS.Name = "Button_Pumpe_Abfall_AUS";
            this.Button_Pumpe_Abfall_AUS.Size = new System.Drawing.Size(100, 25);
            this.Button_Pumpe_Abfall_AUS.TabIndex = 3;
            this.Button_Pumpe_Abfall_AUS.Text = "Aus";
            this.Button_Pumpe_Abfall_AUS.UseVisualStyleBackColor = true;
            this.Button_Pumpe_Abfall_AUS.Click += new System.EventHandler(this.btnPumpeAbfallAus);
            // 
            // Button_Pumpe_Abfall_EIN
            // 
            this.Button_Pumpe_Abfall_EIN.Location = new System.Drawing.Point(25, 33);
            this.Button_Pumpe_Abfall_EIN.Name = "Button_Pumpe_Abfall_EIN";
            this.Button_Pumpe_Abfall_EIN.Size = new System.Drawing.Size(100, 25);
            this.Button_Pumpe_Abfall_EIN.TabIndex = 2;
            this.Button_Pumpe_Abfall_EIN.Text = "Ein";
            this.Button_Pumpe_Abfall_EIN.UseVisualStyleBackColor = true;
            this.Button_Pumpe_Abfall_EIN.Click += new System.EventHandler(this.btnPumpeAbfallEin);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Button_Pumpe_MZ_AUS);
            this.groupBox3.Controls.Add(this.Button_Pumpe_MZ_EIN);
            this.groupBox3.Location = new System.Drawing.Point(7, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 105);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pumpe Messzelle";
            // 
            // Button_Pumpe_MZ_AUS
            // 
            this.Button_Pumpe_MZ_AUS.Location = new System.Drawing.Point(16, 65);
            this.Button_Pumpe_MZ_AUS.Name = "Button_Pumpe_MZ_AUS";
            this.Button_Pumpe_MZ_AUS.Size = new System.Drawing.Size(100, 25);
            this.Button_Pumpe_MZ_AUS.TabIndex = 1;
            this.Button_Pumpe_MZ_AUS.Text = "Aus";
            this.Button_Pumpe_MZ_AUS.UseVisualStyleBackColor = true;
            this.Button_Pumpe_MZ_AUS.Click += new System.EventHandler(this.btnPumpeMesszelleAus);
            // 
            // Button_Pumpe_MZ_EIN
            // 
            this.Button_Pumpe_MZ_EIN.Location = new System.Drawing.Point(15, 34);
            this.Button_Pumpe_MZ_EIN.Name = "Button_Pumpe_MZ_EIN";
            this.Button_Pumpe_MZ_EIN.Size = new System.Drawing.Size(100, 25);
            this.Button_Pumpe_MZ_EIN.TabIndex = 0;
            this.Button_Pumpe_MZ_EIN.Text = "Ein";
            this.Button_Pumpe_MZ_EIN.UseVisualStyleBackColor = true;
            this.Button_Pumpe_MZ_EIN.Click += new System.EventHandler(this.btnPumpeMesszelleEin);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.NOTSTOPP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.Disconnect);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 137);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Initialisieren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Initialisierung_Click);
            // 
            // NOTSTOPP
            // 
            this.NOTSTOPP.BackColor = System.Drawing.Color.Red;
            this.NOTSTOPP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NOTSTOPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOTSTOPP.Location = new System.Drawing.Point(369, 38);
            this.NOTSTOPP.Name = "NOTSTOPP";
            this.NOTSTOPP.Size = new System.Drawing.Size(128, 57);
            this.NOTSTOPP.TabIndex = 38;
            this.NOTSTOPP.Text = "STOPP";
            this.NOTSTOPP.UseVisualStyleBackColor = false;
            this.NOTSTOPP.Click += new System.EventHandler(this.NOTSTOPP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Status :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(11, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 43);
            this.panel1.TabIndex = 36;
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(215, 89);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Disconnect.TabIndex = 35;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(215, 23);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 34;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabDeviceParameter);
            this.tabControl1.Controls.Add(this.tabProben);
            this.tabControl1.Controls.Add(this.tabGKommunikation);
            this.tabControl1.Controls.Add(this.tabSequenzList);
            this.tabControl1.Controls.Add(this.tabSequenzedit);
            this.tabControl1.Controls.Add(this.tabMasterablauf);
            this.tabControl1.Controls.Add(this.tabMastersequenz);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 770);
            this.tabControl1.TabIndex = 3;
            // 
            // tabProben
            // 
            this.tabProben.Controls.Add(this.groupBox7);
            this.tabProben.Controls.Add(this.groupBox6);
            this.tabProben.Location = new System.Drawing.Point(4, 22);
            this.tabProben.Name = "tabProben";
            this.tabProben.Size = new System.Drawing.Size(583, 744);
            this.tabProben.TabIndex = 7;
            this.tabProben.Text = "Proben";
            this.tabProben.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox8);
            this.groupBox7.Controls.Add(this.textBox7);
            this.groupBox7.Controls.Add(this.textBox6);
            this.groupBox7.Controls.Add(this.textBox5);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(16, 208);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(504, 100);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Proben";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(325, 63);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(135, 20);
            this.textBox8.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(325, 41);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(135, 20);
            this.textBox7.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(84, 63);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(135, 20);
            this.textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(84, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(135, 20);
            this.textBox5.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(272, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Probe 4:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(272, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Probe 3:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Probe 2:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Probe 1:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(16, 23);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(504, 149);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Protokolldaten";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(119, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Standardcharge:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mediumcharge:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Linsencharge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bearbeiter:";
            // 
            // tabMastersequenz
            // 
            this.tabMastersequenz.Controls.Add(this.cmbMastersequenz);
            this.tabMastersequenz.Controls.Add(this.label20);
            this.tabMastersequenz.Controls.Add(this.MasterGrid);
            this.tabMastersequenz.Location = new System.Drawing.Point(4, 22);
            this.tabMastersequenz.Name = "tabMastersequenz";
            this.tabMastersequenz.Size = new System.Drawing.Size(583, 744);
            this.tabMastersequenz.TabIndex = 8;
            this.tabMastersequenz.Text = "Mastersequenz";
            this.tabMastersequenz.UseVisualStyleBackColor = true;
            // 
            // cmbMastersequenz
            // 
            this.cmbMastersequenz.FormattingEnabled = true;
            this.cmbMastersequenz.Location = new System.Drawing.Point(20, 23);
            this.cmbMastersequenz.Name = "cmbMastersequenz";
            this.cmbMastersequenz.Size = new System.Drawing.Size(121, 21);
            this.cmbMastersequenz.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Mastersequenz";
            // 
            // MasterGrid
            // 
            this.MasterGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MasterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasterGrid.Location = new System.Drawing.Point(3, 53);
            this.MasterGrid.Name = "MasterGrid";
            this.MasterGrid.Size = new System.Drawing.Size(435, 540);
            this.MasterGrid.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bezeichnung";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nr.:";
            this.Column1.Name = "Column1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 647);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "PharMS Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MesszyklusGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatenerfassungTab)).EndInit();
            this.tabMasterablauf.ResumeLayout(false);
            this.tabMasterablauf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabSequenzedit.ResumeLayout(false);
            this.tabSequenzedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SequenzeditorGrid)).EndInit();
            this.tabSequenzList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SequenzenGrid)).EndInit();
            this.tabGKommunikation.ResumeLayout(false);
            this.tabGKommunikation.PerformLayout();
            this.tabDeviceParameter.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpuelen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesinfektion)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericResponsetime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Messdauer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Intervall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZellspannung)).EndInit();
            this.grbTemperierung.ResumeLayout(false);
            this.grbTemperierung.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabProben.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabMastersequenz.ResumeLayout(false);
            this.tabMastersequenz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //  private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        //  private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        //  private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        //  private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.FolderBrowserDialog Verzeichnisauswahl;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnItemNeu;
        private System.Windows.Forms.ToolStripMenuItem mnItemDatenbankÖffnen;
        private System.Windows.Forms.ToolStripMenuItem mnItemSpeichern;
        private System.Windows.Forms.ToolStripMenuItem mnItemBeenden;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openDatabaseDialog;
        private System.Windows.Forms.SaveFileDialog NewDBDialog;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDeviceParameter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLeitungDes;
        private System.Windows.Forms.Button btnElektrodenTest;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.NumericUpDown numeric_Messdauer;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.NumericUpDown numeric_Intervall;
        private System.Windows.Forms.NumericUpDown numericZellspannung;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grbTemperierung;
        private System.Windows.Forms.TextBox txtboxTemperatur;
        private System.Windows.Forms.Label lbTemperatur;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button NOTSTOPP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Console_Senden;
        public System.Windows.Forms.TextBox Console_Eingabe;
        public System.Windows.Forms.TextBox Console_Ausgabe;
        private System.Windows.Forms.TabPage tabSequenzList;
        private System.Windows.Forms.Button btnUebertragen;
        public System.Windows.Forms.DataGridView SequenzenGrid;
        private System.Windows.Forms.TabPage tabSequenzedit;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox AblaufListe;
        private System.Windows.Forms.CheckBox chkFilter;
        public System.Windows.Forms.DataGridView SequenzeditorGrid;
        private System.Windows.Forms.TabPage tabMasterablauf;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button AblaufStart;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Messung_Stopp;
        private System.Windows.Forms.Button Man_Messung;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView DatenerfassungTab;
        private System.Windows.Forms.Button btnNeueMessung;
        private System.Windows.Forms.ToolStripMenuItem mnItemSpeichernUnter;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown numSpuelen;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown numDesinfektion;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_Pumpe_Abfall_AUS;
        private System.Windows.Forms.Button Button_Pumpe_Abfall_EIN;
        private System.Windows.Forms.Button Button_Pumpe_MZ_AUS;
        private System.Windows.Forms.Button Button_Pumpe_MZ_EIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridView MesszyklusGrid;
        private System.Windows.Forms.Button btnLiveChart;
        private System.Windows.Forms.NumericUpDown numericResponsetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTipResponsetime;
        public System.Windows.Forms.Label lblMaster;
        public System.Windows.Forms.TabPage tabGKommunikation;
        public System.Windows.Forms.Label lblSequenz;
        private System.Windows.Forms.Button btnLeitungen;
        private System.Windows.Forms.TabPage tabProben;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProbe1_leeren;
        private System.Windows.Forms.TabPage tabMastersequenz;
        private System.Windows.Forms.ComboBox cmbMastersequenz;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.DataGridView MasterGrid;
        public System.Windows.Forms.DataGridView MasterGrid2;


    }
}

