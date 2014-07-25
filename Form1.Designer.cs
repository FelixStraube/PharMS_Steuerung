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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Verzeichnisauswahl = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemDatenbankÖffnen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemSpeichern = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemSpeichernUnter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseDialog = new System.Windows.Forms.OpenFileDialog();
            this.NewDBDialog = new System.Windows.Forms.SaveFileDialog();
            this.tmCheckCOM = new System.Windows.Forms.Timer(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Live_Chart_anzeigen = new System.Windows.Forms.Button();
            this.LiveGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiveChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbMessmethode = new System.Windows.Forms.Label();
            this.btnNeueMessung = new System.Windows.Forms.Button();
            this.Messung_Stopp = new System.Windows.Forms.Button();
            this.Man_Messung = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DatenerfassungTab = new System.Windows.Forms.DataGridView();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sensor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sensor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMasterablauf = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AblaufStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MasterGrid = new System.Windows.Forms.DataGridView();
            this.colOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpeicherplatzMaster = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNameMaster = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabSequenzedit = new System.Windows.Forms.TabPage();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.btnSaveOneSequenz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AblaufListe = new System.Windows.Forms.ComboBox();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.SequenzeditorGrid = new System.Windows.Forms.DataGridView();
            this.colBefehl = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colParametereingabe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHelp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSequenzList = new System.Windows.Forms.TabPage();
            this.btnUebertragen = new System.Windows.Forms.Button();
            this.SequenzenGrid = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpeicherplatz = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Console_Senden = new System.Windows.Forms.Button();
            this.Console_Eingabe = new System.Windows.Forms.TextBox();
            this.Console_Ausgabe = new System.Windows.Forms.TextBox();
            this.tabDeviceParameter = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numSpuelen = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLeitungDes = new System.Windows.Forms.Button();
            this.numDesinfektion = new System.Windows.Forms.NumericUpDown();
            this.btnElektrodenTest = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numeric_Messdauer = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numeric_Intervall = new System.Windows.Forms.NumericUpDown();
            this.numericZellspannung = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.rbManuelleMessung = new System.Windows.Forms.RadioButton();
            this.rbAktiveMessung = new System.Windows.Forms.RadioButton();
            this.grbTemperierung = new System.Windows.Forms.GroupBox();
            this.txtboxTemperatur = new System.Windows.Forms.TextBox();
            this.rbTemperierungAus = new System.Windows.Forms.RadioButton();
            this.lbTemperatur = new System.Windows.Forms.Label();
            this.rbTemperierungEin = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbPumpeAbfallAus = new System.Windows.Forms.RadioButton();
            this.rbPumpeAbfallEin = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPumpeMesszelleAus = new System.Windows.Forms.RadioButton();
            this.rbPumpeMesszelleEin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.NOTSTOPP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProben = new System.Windows.Forms.TabPage();
            this.txtProbe4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chtMessung = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtProbe3 = new System.Windows.Forms.TextBox();
            this.txtProbe2 = new System.Windows.Forms.TextBox();
            this.txtProbe1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiveGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatenerfassungTab)).BeginInit();
            this.tabMasterablauf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid)).BeginInit();
            this.tabSequenzedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SequenzeditorGrid)).BeginInit();
            this.tabSequenzList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SequenzenGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabDeviceParameter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpuelen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesinfektion)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Messdauer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Intervall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZellspannung)).BeginInit();
            this.grbTemperierung.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabProben.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMessung)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
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
            this.mnItemImport,
            this.mnItemBeenden});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Datei";
            // 
            // mnItemNeu
            // 
            this.mnItemNeu.Name = "mnItemNeu";
            this.mnItemNeu.Size = new System.Drawing.Size(183, 22);
            this.mnItemNeu.Text = "Neu";
            this.mnItemNeu.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // mnItemDatenbankÖffnen
            // 
            this.mnItemDatenbankÖffnen.Name = "mnItemDatenbankÖffnen";
            this.mnItemDatenbankÖffnen.Size = new System.Drawing.Size(183, 22);
            this.mnItemDatenbankÖffnen.Text = "Datenbank öffnen";
            this.mnItemDatenbankÖffnen.Click += new System.EventHandler(this.datenbankÖffnenToolStripMenuItem_Click);
            // 
            // mnItemSpeichern
            // 
            this.mnItemSpeichern.Name = "mnItemSpeichern";
            this.mnItemSpeichern.Size = new System.Drawing.Size(183, 22);
            this.mnItemSpeichern.Text = "Speichern";
            this.mnItemSpeichern.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // mnItemSpeichernUnter
            // 
            this.mnItemSpeichernUnter.Name = "mnItemSpeichernUnter";
            this.mnItemSpeichernUnter.Size = new System.Drawing.Size(183, 22);
            this.mnItemSpeichernUnter.Text = "Speichern unter...";
            this.mnItemSpeichernUnter.Click += new System.EventHandler(this.mnItemSpeichernUnter_Click);
            // 
            // mnItemImport
            // 
            this.mnItemImport.Name = "mnItemImport";
            this.mnItemImport.Size = new System.Drawing.Size(183, 22);
            this.mnItemImport.Text = "Sequenz importieren";
            this.mnItemImport.Click += new System.EventHandler(this.ImportStripMenuItem2_Click);
            // 
            // mnItemBeenden
            // 
            this.mnItemBeenden.Name = "mnItemBeenden";
            this.mnItemBeenden.Size = new System.Drawing.Size(183, 22);
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
            this.openDatabaseDialog.Filter = "Pharms (*.pharms)|*.pharms|Textdateien|*.txt";
            // 
            // tmCheckCOM
            // 
            this.tmCheckCOM.Interval = 10000;
            this.tmCheckCOM.Tick += new System.EventHandler(this.tmCheckCOM_Tick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Live_Chart_anzeigen);
            this.tabPage4.Controls.Add(this.LiveGrid);
            this.tabPage4.Controls.Add(this.LiveChart);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(582, 574);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Live Chart";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Live_Chart_anzeigen
            // 
            this.Live_Chart_anzeigen.Location = new System.Drawing.Point(70, 518);
            this.Live_Chart_anzeigen.Name = "Live_Chart_anzeigen";
            this.Live_Chart_anzeigen.Size = new System.Drawing.Size(75, 23);
            this.Live_Chart_anzeigen.TabIndex = 2;
            this.Live_Chart_anzeigen.Text = "Live Chart";
            this.Live_Chart_anzeigen.UseVisualStyleBackColor = true;
            this.Live_Chart_anzeigen.Visible = false;
            this.Live_Chart_anzeigen.Click += new System.EventHandler(this.LiveChart_klick);
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
            this.Column1.HeaderText = "Nr.:";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bezeichnung";
            this.Column2.Name = "Column2";
            // 
            // LiveChart
            // 
            chartArea2.AxisX.Title = " Time [s]";
            chartArea2.AxisY.Title = "Signal [nA]";
            chartArea2.Name = "ChartArea1";
            this.LiveChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.LiveChart.Legends.Add(legend2);
            this.LiveChart.Location = new System.Drawing.Point(31, 32);
            this.LiveChart.Name = "LiveChart";
            this.LiveChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.White;
            series3.Name = "Sensor 1";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Sensor 2";
            this.LiveChart.Series.Add(series3);
            this.LiveChart.Series.Add(series4);
            this.LiveChart.Size = new System.Drawing.Size(466, 289);
            this.LiveChart.TabIndex = 0;
            this.LiveChart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbMessmethode);
            this.tabPage2.Controls.Add(this.btnNeueMessung);
            this.tabPage2.Controls.Add(this.Messung_Stopp);
            this.tabPage2.Controls.Add(this.Man_Messung);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.DatenerfassungTab);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Messdaten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbMessmethode
            // 
            this.lbMessmethode.AutoSize = true;
            this.lbMessmethode.Location = new System.Drawing.Point(431, 18);
            this.lbMessmethode.Name = "lbMessmethode";
            this.lbMessmethode.Size = new System.Drawing.Size(82, 13);
            this.lbMessmethode.TabIndex = 10;
            this.lbMessmethode.Text = "aktive Messung";
            // 
            // btnNeueMessung
            // 
            this.btnNeueMessung.Enabled = false;
            this.btnNeueMessung.Location = new System.Drawing.Point(434, 104);
            this.btnNeueMessung.Name = "btnNeueMessung";
            this.btnNeueMessung.Size = new System.Drawing.Size(96, 23);
            this.btnNeueMessung.TabIndex = 9;
            this.btnNeueMessung.Text = "Neue Messung";
            this.btnNeueMessung.UseVisualStyleBackColor = true;
            this.btnNeueMessung.Click += new System.EventHandler(this.btnNeueMessung_Click);
            // 
            // Messung_Stopp
            // 
            this.Messung_Stopp.Location = new System.Drawing.Point(434, 182);
            this.Messung_Stopp.Name = "Messung_Stopp";
            this.Messung_Stopp.Size = new System.Drawing.Size(75, 23);
            this.Messung_Stopp.TabIndex = 8;
            this.Messung_Stopp.Text = "Stopp";
            this.Messung_Stopp.UseVisualStyleBackColor = true;
            this.Messung_Stopp.Click += new System.EventHandler(this.Messung_Stopp_Click);
            // 
            // Man_Messung
            // 
            this.Man_Messung.Location = new System.Drawing.Point(434, 142);
            this.Man_Messung.Name = "Man_Messung";
            this.Man_Messung.Size = new System.Drawing.Size(75, 23);
            this.Man_Messung.TabIndex = 7;
            this.Man_Messung.Text = "Start";
            this.Man_Messung.UseVisualStyleBackColor = true;
            this.Man_Messung.Click += new System.EventHandler(this.Man_Messung_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 64);
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
            this.colDateTime,
            this.colTime,
            this.Sensor1,
            this.Sensor2});
            this.DatenerfassungTab.Location = new System.Drawing.Point(9, 18);
            this.DatenerfassungTab.Name = "DatenerfassungTab";
            this.DatenerfassungTab.Size = new System.Drawing.Size(416, 522);
            this.DatenerfassungTab.TabIndex = 0;
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "Time";
            this.colDateTime.FillWeight = 120F;
            this.colDateTime.HeaderText = "Zeit";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.Width = 140;
            // 
            // colTime
            // 
            this.colTime.DataPropertyName = "Sec";
            this.colTime.HeaderText = "Sec";
            this.colTime.Name = "colTime";
            this.colTime.Visible = false;
            this.colTime.Width = 40;
            // 
            // Sensor1
            // 
            this.Sensor1.DataPropertyName = "Sensor1";
            this.Sensor1.HeaderText = "Sensor 1 [ nA ]";
            this.Sensor1.Name = "Sensor1";
            // 
            // Sensor2
            // 
            this.Sensor2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sensor2.DataPropertyName = "Sensor2";
            this.Sensor2.HeaderText = "Sensor 2 [ nA ]";
            this.Sensor2.Name = "Sensor2";
            // 
            // tabMasterablauf
            // 
            this.tabMasterablauf.Controls.Add(this.numericUpDown1);
            this.tabMasterablauf.Controls.Add(this.AblaufStart);
            this.tabMasterablauf.Controls.Add(this.label5);
            this.tabMasterablauf.Controls.Add(this.MasterGrid);
            this.tabMasterablauf.Location = new System.Drawing.Point(4, 22);
            this.tabMasterablauf.Name = "tabMasterablauf";
            this.tabMasterablauf.Size = new System.Drawing.Size(582, 574);
            this.tabMasterablauf.TabIndex = 5;
            this.tabMasterablauf.Text = "Masterablauf";
            this.tabMasterablauf.UseVisualStyleBackColor = true;
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
            this.MasterGrid.Size = new System.Drawing.Size(582, 512);
            this.MasterGrid.TabIndex = 1;
            this.MasterGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.MasterGrid_DataError);
            this.MasterGrid.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.MasterGrid_UserDeletedRow);
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
            this.colNameMaster.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNameMaster.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(11, 624);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(590, 15);
            this.progressBar1.TabIndex = 33;
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
            this.tabSequenzedit.Size = new System.Drawing.Size(582, 574);
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
            this.SequenzeditorGrid.Size = new System.Drawing.Size(582, 456);
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
            // tabSequenzList
            // 
            this.tabSequenzList.Controls.Add(this.btnUebertragen);
            this.tabSequenzList.Controls.Add(this.SequenzenGrid);
            this.tabSequenzList.Location = new System.Drawing.Point(4, 22);
            this.tabSequenzList.Name = "tabSequenzList";
            this.tabSequenzList.Size = new System.Drawing.Size(582, 574);
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
            this.SequenzenGrid.Size = new System.Drawing.Size(581, 500);
            this.SequenzenGrid.TabIndex = 0;
            this.SequenzenGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SequenzenGrid_CellMouseClick);
            this.SequenzenGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.SequenzenGrid_CellValidating);
            this.SequenzenGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SequenzenGrid_MouseClick);
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
            "       "});
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.Console_Senden);
            this.tabPage1.Controls.Add(this.Console_Eingabe);
            this.tabPage1.Controls.Add(this.Console_Ausgabe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gerätesteuerung";
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
            this.tabDeviceParameter.Size = new System.Drawing.Size(582, 574);
            this.tabDeviceParameter.TabIndex = 6;
            this.tabDeviceParameter.Text = "Geräteparameter";
            this.tabDeviceParameter.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Size = new System.Drawing.Size(540, 396);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geräteparameter";
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
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.numeric_Messdauer);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.numeric_Intervall);
            this.groupBox5.Controls.Add(this.numericZellspannung);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.rbManuelleMessung);
            this.groupBox5.Controls.Add(this.rbAktiveMessung);
            this.groupBox5.Location = new System.Drawing.Point(11, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(508, 132);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Messung";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Messdauer /min";
            // 
            // numeric_Messdauer
            // 
            this.numeric_Messdauer.Location = new System.Drawing.Point(261, 87);
            this.numeric_Messdauer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_Messdauer.Name = "numeric_Messdauer";
            this.numeric_Messdauer.Size = new System.Drawing.Size(120, 20);
            this.numeric_Messdauer.TabIndex = 22;
            this.numeric_Messdauer.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Intervall /s";
            // 
            // numeric_Intervall
            // 
            this.numeric_Intervall.Location = new System.Drawing.Point(261, 35);
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
            1,
            0,
            0,
            0});
            // 
            // numericZellspannung
            // 
            this.numericZellspannung.Location = new System.Drawing.Point(152, 35);
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
            this.label11.Location = new System.Drawing.Point(152, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Zellspannung /mV";
            // 
            // rbManuelleMessung
            // 
            this.rbManuelleMessung.AutoSize = true;
            this.rbManuelleMessung.Location = new System.Drawing.Point(11, 47);
            this.rbManuelleMessung.Name = "rbManuelleMessung";
            this.rbManuelleMessung.Size = new System.Drawing.Size(114, 17);
            this.rbManuelleMessung.TabIndex = 17;
            this.rbManuelleMessung.Text = "Manuelle Messung";
            this.rbManuelleMessung.UseVisualStyleBackColor = true;
            this.rbManuelleMessung.CheckedChanged += new System.EventHandler(this.rbAktiveMessung_CheckedChanged);
            // 
            // rbAktiveMessung
            // 
            this.rbAktiveMessung.AutoSize = true;
            this.rbAktiveMessung.Checked = true;
            this.rbAktiveMessung.Location = new System.Drawing.Point(11, 23);
            this.rbAktiveMessung.Name = "rbAktiveMessung";
            this.rbAktiveMessung.Size = new System.Drawing.Size(101, 17);
            this.rbAktiveMessung.TabIndex = 16;
            this.rbAktiveMessung.TabStop = true;
            this.rbAktiveMessung.Text = "Aktive Messung";
            this.rbAktiveMessung.UseVisualStyleBackColor = true;
            this.rbAktiveMessung.CheckedChanged += new System.EventHandler(this.rbAktiveMessung_CheckedChanged);
            // 
            // grbTemperierung
            // 
            this.grbTemperierung.Controls.Add(this.txtboxTemperatur);
            this.grbTemperierung.Controls.Add(this.rbTemperierungAus);
            this.grbTemperierung.Controls.Add(this.lbTemperatur);
            this.grbTemperierung.Controls.Add(this.rbTemperierungEin);
            this.grbTemperierung.Location = new System.Drawing.Point(323, 37);
            this.grbTemperierung.Name = "grbTemperierung";
            this.grbTemperierung.Size = new System.Drawing.Size(196, 105);
            this.grbTemperierung.TabIndex = 2;
            this.grbTemperierung.TabStop = false;
            this.grbTemperierung.Text = "Temperierung";
            // 
            // txtboxTemperatur
            // 
            this.txtboxTemperatur.Location = new System.Drawing.Point(104, 45);
            this.txtboxTemperatur.Name = "txtboxTemperatur";
            this.txtboxTemperatur.ReadOnly = true;
            this.txtboxTemperatur.Size = new System.Drawing.Size(70, 20);
            this.txtboxTemperatur.TabIndex = 4;
            this.txtboxTemperatur.Text = "37";
            // 
            // rbTemperierungAus
            // 
            this.rbTemperierungAus.AutoSize = true;
            this.rbTemperierungAus.Location = new System.Drawing.Point(13, 67);
            this.rbTemperierungAus.Name = "rbTemperierungAus";
            this.rbTemperierungAus.Size = new System.Drawing.Size(43, 17);
            this.rbTemperierungAus.TabIndex = 1;
            this.rbTemperierungAus.TabStop = true;
            this.rbTemperierungAus.Text = "Aus";
            this.rbTemperierungAus.UseVisualStyleBackColor = true;
            this.rbTemperierungAus.CheckedChanged += new System.EventHandler(this.rbTemperierungAus_CheckedChanged);
            // 
            // lbTemperatur
            // 
            this.lbTemperatur.AutoSize = true;
            this.lbTemperatur.Location = new System.Drawing.Point(10, 47);
            this.lbTemperatur.Name = "lbTemperatur";
            this.lbTemperatur.Size = new System.Drawing.Size(89, 13);
            this.lbTemperatur.TabIndex = 3;
            this.lbTemperatur.Text = "Temperatur in °C:";
            // 
            // rbTemperierungEin
            // 
            this.rbTemperierungEin.AutoSize = true;
            this.rbTemperierungEin.Checked = true;
            this.rbTemperierungEin.Location = new System.Drawing.Point(13, 22);
            this.rbTemperierungEin.Name = "rbTemperierungEin";
            this.rbTemperierungEin.Size = new System.Drawing.Size(40, 17);
            this.rbTemperierungEin.TabIndex = 0;
            this.rbTemperierungEin.TabStop = true;
            this.rbTemperierungEin.Text = "Ein";
            this.rbTemperierungEin.UseVisualStyleBackColor = true;
            this.rbTemperierungEin.CheckedChanged += new System.EventHandler(this.rbTemperierungEin_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbPumpeAbfallAus);
            this.groupBox4.Controls.Add(this.rbPumpeAbfallEin);
            this.groupBox4.Location = new System.Drawing.Point(151, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 105);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pumpe der Abfallbehandlungs";
            // 
            // rbPumpeAbfallAus
            // 
            this.rbPumpeAbfallAus.AutoSize = true;
            this.rbPumpeAbfallAus.Checked = true;
            this.rbPumpeAbfallAus.Location = new System.Drawing.Point(15, 67);
            this.rbPumpeAbfallAus.Name = "rbPumpeAbfallAus";
            this.rbPumpeAbfallAus.Size = new System.Drawing.Size(43, 17);
            this.rbPumpeAbfallAus.TabIndex = 1;
            this.rbPumpeAbfallAus.TabStop = true;
            this.rbPumpeAbfallAus.Text = "Aus";
            this.rbPumpeAbfallAus.UseVisualStyleBackColor = true;
            this.rbPumpeAbfallAus.CheckedChanged += new System.EventHandler(this.rbPumpeAbfallAus_CheckedChanged);
            // 
            // rbPumpeAbfallEin
            // 
            this.rbPumpeAbfallEin.AutoSize = true;
            this.rbPumpeAbfallEin.Location = new System.Drawing.Point(15, 22);
            this.rbPumpeAbfallEin.Name = "rbPumpeAbfallEin";
            this.rbPumpeAbfallEin.Size = new System.Drawing.Size(40, 17);
            this.rbPumpeAbfallEin.TabIndex = 0;
            this.rbPumpeAbfallEin.TabStop = true;
            this.rbPumpeAbfallEin.Text = "Ein";
            this.rbPumpeAbfallEin.UseVisualStyleBackColor = true;
            this.rbPumpeAbfallEin.CheckedChanged += new System.EventHandler(this.rbPumpeAbfallEin_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbPumpeMesszelleAus);
            this.groupBox3.Controls.Add(this.rbPumpeMesszelleEin);
            this.groupBox3.Location = new System.Drawing.Point(7, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 105);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pumpe der Messzelle";
            // 
            // rbPumpeMesszelleAus
            // 
            this.rbPumpeMesszelleAus.AutoSize = true;
            this.rbPumpeMesszelleAus.Checked = true;
            this.rbPumpeMesszelleAus.Location = new System.Drawing.Point(15, 67);
            this.rbPumpeMesszelleAus.Name = "rbPumpeMesszelleAus";
            this.rbPumpeMesszelleAus.Size = new System.Drawing.Size(43, 17);
            this.rbPumpeMesszelleAus.TabIndex = 1;
            this.rbPumpeMesszelleAus.TabStop = true;
            this.rbPumpeMesszelleAus.Text = "Aus";
            this.rbPumpeMesszelleAus.UseVisualStyleBackColor = true;
            this.rbPumpeMesszelleAus.CheckedChanged += new System.EventHandler(this.rbPumpeMesszelleAus_CheckedChanged);
            // 
            // rbPumpeMesszelleEin
            // 
            this.rbPumpeMesszelleEin.AutoSize = true;
            this.rbPumpeMesszelleEin.Location = new System.Drawing.Point(15, 22);
            this.rbPumpeMesszelleEin.Name = "rbPumpeMesszelleEin";
            this.rbPumpeMesszelleEin.Size = new System.Drawing.Size(40, 17);
            this.rbPumpeMesszelleEin.TabIndex = 0;
            this.rbPumpeMesszelleEin.Text = "Ein";
            this.rbPumpeMesszelleEin.UseVisualStyleBackColor = true;
            this.rbPumpeMesszelleEin.CheckedChanged += new System.EventHandler(this.rbPumpeMesszelleEin_CheckedChanged);
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabSequenzList);
            this.tabControl1.Controls.Add(this.tabSequenzedit);
            this.tabControl1.Controls.Add(this.tabMasterablauf);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(7, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 600);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabProben
            // 
            this.tabProben.Controls.Add(this.txtProbe4);
            this.tabProben.Controls.Add(this.label9);
            this.tabProben.Controls.Add(this.chtMessung);
            this.tabProben.Controls.Add(this.txtProbe3);
            this.tabProben.Controls.Add(this.txtProbe2);
            this.tabProben.Controls.Add(this.txtProbe1);
            this.tabProben.Controls.Add(this.label6);
            this.tabProben.Controls.Add(this.label4);
            this.tabProben.Controls.Add(this.label3);
            this.tabProben.Location = new System.Drawing.Point(4, 22);
            this.tabProben.Name = "tabProben";
            this.tabProben.Padding = new System.Windows.Forms.Padding(3);
            this.tabProben.Size = new System.Drawing.Size(582, 574);
            this.tabProben.TabIndex = 7;
            this.tabProben.Text = "Proben";
            this.tabProben.UseVisualStyleBackColor = true;
            // 
            // txtProbe4
            // 
            this.txtProbe4.Location = new System.Drawing.Point(191, 101);
            this.txtProbe4.Name = "txtProbe4";
            this.txtProbe4.Size = new System.Drawing.Size(127, 20);
            this.txtProbe4.TabIndex = 8;
            this.txtProbe4.Text = "Probe 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Bezeichnung Inkubationsgefäß 3:";
            // 
            // chtMessung
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 90;
            chartArea1.Name = "ChartArea1";
            this.chtMessung.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtMessung.Legends.Add(legend1);
            this.chtMessung.Location = new System.Drawing.Point(54, 127);
            this.chtMessung.Name = "chtMessung";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            series1.Legend = "Legend1";
            series1.Name = "Sensor1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Sensor2";
            this.chtMessung.Series.Add(series1);
            this.chtMessung.Series.Add(series2);
            this.chtMessung.Size = new System.Drawing.Size(464, 300);
            this.chtMessung.TabIndex = 6;
            this.chtMessung.Text = "chart1";
            // 
            // txtProbe3
            // 
            this.txtProbe3.Location = new System.Drawing.Point(191, 73);
            this.txtProbe3.Name = "txtProbe3";
            this.txtProbe3.Size = new System.Drawing.Size(127, 20);
            this.txtProbe3.TabIndex = 5;
            this.txtProbe3.Text = "Probe 3";
            // 
            // txtProbe2
            // 
            this.txtProbe2.Location = new System.Drawing.Point(191, 47);
            this.txtProbe2.Name = "txtProbe2";
            this.txtProbe2.Size = new System.Drawing.Size(127, 20);
            this.txtProbe2.TabIndex = 4;
            this.txtProbe2.Text = "Probe 2";
            // 
            // txtProbe1
            // 
            this.txtProbe1.Location = new System.Drawing.Point(191, 21);
            this.txtProbe1.Name = "txtProbe1";
            this.txtProbe1.Size = new System.Drawing.Size(127, 20);
            this.txtProbe1.TabIndex = 3;
            this.txtProbe1.Text = "Probe 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bezeichnung Inkubationsgefäß 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bezeichnung Inkubationsgefäß 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bezeichnung Inkubationsgefäß 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 641);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "PharMS Controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LiveGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatenerfassungTab)).EndInit();
            this.tabMasterablauf.ResumeLayout(false);
            this.tabMasterablauf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid)).EndInit();
            this.tabSequenzedit.ResumeLayout(false);
            this.tabSequenzedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SequenzeditorGrid)).EndInit();
            this.tabSequenzList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SequenzenGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabDeviceParameter.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpuelen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesinfektion)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Messdauer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Intervall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZellspannung)).EndInit();
            this.grbTemperierung.ResumeLayout(false);
            this.grbTemperierung.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabProben.ResumeLayout(false);
            this.tabProben.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMessung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      //     private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
      //    private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
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
        private System.Windows.Forms.ToolStripMenuItem mnItemImport;
        private System.Windows.Forms.SaveFileDialog NewDBDialog;
        private System.Windows.Forms.Timer tmCheckCOM;
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
        public System.Windows.Forms.RadioButton rbManuelleMessung;
        public System.Windows.Forms.RadioButton rbAktiveMessung;
        private System.Windows.Forms.GroupBox grbTemperierung;
        private System.Windows.Forms.TextBox txtboxTemperatur;
        private System.Windows.Forms.RadioButton rbTemperierungAus;
        private System.Windows.Forms.Label lbTemperatur;
        private System.Windows.Forms.RadioButton rbTemperierungEin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbPumpeAbfallAus;
        private System.Windows.Forms.RadioButton rbPumpeAbfallEin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPumpeMesszelleAus;
        private System.Windows.Forms.RadioButton rbPumpeMesszelleEin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button NOTSTOPP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Console_Senden;
        public System.Windows.Forms.TextBox Console_Eingabe;
        public System.Windows.Forms.TextBox Console_Ausgabe;
        private System.Windows.Forms.TabPage tabSequenzList;
        private System.Windows.Forms.Button btnUebertragen;
        public System.Windows.Forms.DataGridView SequenzenGrid;
        private System.Windows.Forms.TabPage tabSequenzedit;
        public System.Windows.Forms.TextBox txtNewName;
        public System.Windows.Forms.Label lblNewName;
        public System.Windows.Forms.Button btnSaveOneSequenz;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox AblaufListe;
        private System.Windows.Forms.CheckBox chkFilter;
        public System.Windows.Forms.DataGridView SequenzeditorGrid;
        private System.Windows.Forms.DataGridViewComboBoxColumn colBefehl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParametereingabe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHelp;
        private System.Windows.Forms.TabPage tabMasterablauf;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button AblaufStart;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView MasterGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrder;
        private System.Windows.Forms.DataGridViewComboBoxColumn colSpeicherplatzMaster;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNameMaster;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Messung_Stopp;
        private System.Windows.Forms.Button Man_Messung;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView DatenerfassungTab;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Live_Chart_anzeigen;
        public System.Windows.Forms.DataGridView LiveGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataVisualization.Charting.Chart LiveChart;
        private System.Windows.Forms.TabPage tabProben;
        private System.Windows.Forms.Button btnNeueMessung;
        private System.Windows.Forms.Label lbMessmethode;
        private System.Windows.Forms.ToolStripMenuItem mnItemSpeichernUnter;
        private System.Windows.Forms.TextBox txtProbe3;
        private System.Windows.Forms.TextBox txtProbe2;
        private System.Windows.Forms.TextBox txtProbe1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colSpeicherplatz;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMessung;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown numSpuelen;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown numDesinfektion;
        private System.Windows.Forms.TextBox txtProbe4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sensor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sensor2;


    }
}

