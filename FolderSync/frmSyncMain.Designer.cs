namespace FolderSync
{
    partial class frmSyncMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.readXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SCMain = new System.Windows.Forms.SplitContainer();
            this.SCFolder = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstSource = new System.Windows.Forms.ListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip4 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstDestination = new System.Windows.Forms.ListView();
            this.SCFilter = new System.Windows.Forms.SplitContainer();
            this.chkListFiles = new System.Windows.Forms.CheckBox();
            this.lblTimerAt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimerCount = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Label();
            this.chkConsole = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dpFilter = new System.Windows.Forms.DateTimePicker();
            this.lblpercentage = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.pgBarLabel = new System.Windows.Forms.ProgressBar();
            this.SCConsole = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.lblTimerStarts = new System.Windows.Forms.Label();
            this.ScListMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstMain = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statusStrip5 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMailMessage = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.tmrBackup = new System.Windows.Forms.Timer(this.components);
            this.clearConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCMain)).BeginInit();
            this.SCMain.Panel1.SuspendLayout();
            this.SCMain.Panel2.SuspendLayout();
            this.SCMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCFolder)).BeginInit();
            this.SCFolder.Panel1.SuspendLayout();
            this.SCFolder.Panel2.SuspendLayout();
            this.SCFolder.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCFilter)).BeginInit();
            this.SCFilter.Panel1.SuspendLayout();
            this.SCFilter.Panel2.SuspendLayout();
            this.SCFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCConsole)).BeginInit();
            this.SCConsole.Panel1.SuspendLayout();
            this.SCConsole.Panel2.SuspendLayout();
            this.SCConsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScListMain)).BeginInit();
            this.ScListMain.Panel1.SuspendLayout();
            this.ScListMain.Panel2.SuspendLayout();
            this.ScListMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.statusStrip5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readXMLFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.readFromListToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.clearConsoleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // readXMLFileToolStripMenuItem
            // 
            this.readXMLFileToolStripMenuItem.Name = "readXMLFileToolStripMenuItem";
            this.readXMLFileToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.readXMLFileToolStripMenuItem.Text = "Read XML File";
            this.readXMLFileToolStripMenuItem.Click += new System.EventHandler(this.readXMLFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 20);
            this.toolStripMenuItem1.Text = "Read From List";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // readFromListToolStripMenuItem
            // 
            this.readFromListToolStripMenuItem.Name = "readFromListToolStripMenuItem";
            this.readFromListToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.readFromListToolStripMenuItem.Text = "Start Sync";
            this.readFromListToolStripMenuItem.Click += new System.EventHandler(this.readFromListToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // SCMain
            // 
            this.SCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCMain.Location = new System.Drawing.Point(0, 0);
            this.SCMain.Name = "SCMain";
            this.SCMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SCMain.Panel1
            // 
            this.SCMain.Panel1.Controls.Add(this.SCFolder);
            // 
            // SCMain.Panel2
            // 
            this.SCMain.Panel2.Controls.Add(this.SCFilter);
            this.SCMain.Size = new System.Drawing.Size(779, 645);
            this.SCMain.SplitterDistance = 320;
            this.SCMain.TabIndex = 1;
            // 
            // SCFolder
            // 
            this.SCFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCFolder.Location = new System.Drawing.Point(0, 0);
            this.SCFolder.Name = "SCFolder";
            // 
            // SCFolder.Panel1
            // 
            this.SCFolder.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SCFolder.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // SCFolder.Panel2
            // 
            this.SCFolder.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SCFolder.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.SCFolder.Size = new System.Drawing.Size(779, 320);
            this.SCFolder.SplitterDistance = 419;
            this.SCFolder.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lstSource, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(419, 320);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusStrip3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 28);
            this.panel2.TabIndex = 2;
            // 
            // statusStrip3
            // 
            this.statusStrip3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip3.Location = new System.Drawing.Point(0, 0);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip3.Size = new System.Drawing.Size(419, 28);
            this.statusStrip3.SizingGrip = false;
            this.statusStrip3.TabIndex = 0;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(86, 23);
            this.toolStripStatusLabel2.Text = "Source List";
            // 
            // lstSource
            // 
            this.lstSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSource.Location = new System.Drawing.Point(3, 31);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(413, 286);
            this.lstSource.TabIndex = 1;
            this.lstSource.UseCompatibleStateImageBehavior = false;
            this.lstSource.View = System.Windows.Forms.View.Details;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lstDestination, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(356, 320);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusStrip4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 28);
            this.panel3.TabIndex = 2;
            // 
            // statusStrip4
            // 
            this.statusStrip4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3});
            this.statusStrip4.Location = new System.Drawing.Point(0, 0);
            this.statusStrip4.Name = "statusStrip4";
            this.statusStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip4.Size = new System.Drawing.Size(356, 28);
            this.statusStrip4.SizingGrip = false;
            this.statusStrip4.TabIndex = 0;
            this.statusStrip4.Text = "statusStrip4";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(117, 23);
            this.toolStripStatusLabel3.Text = "Destination List";
            // 
            // lstDestination
            // 
            this.lstDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDestination.Location = new System.Drawing.Point(3, 31);
            this.lstDestination.Name = "lstDestination";
            this.lstDestination.Size = new System.Drawing.Size(350, 286);
            this.lstDestination.TabIndex = 1;
            this.lstDestination.UseCompatibleStateImageBehavior = false;
            this.lstDestination.View = System.Windows.Forms.View.Details;
            // 
            // SCFilter
            // 
            this.SCFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCFilter.Location = new System.Drawing.Point(0, 0);
            this.SCFilter.Name = "SCFilter";
            this.SCFilter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SCFilter.Panel1
            // 
            this.SCFilter.Panel1.BackColor = System.Drawing.Color.White;
            this.SCFilter.Panel1.Controls.Add(this.chkListFiles);
            this.SCFilter.Panel1.Controls.Add(this.lblTimerAt);
            this.SCFilter.Panel1.Controls.Add(this.label2);
            this.SCFilter.Panel1.Controls.Add(this.lblTimerCount);
            this.SCFilter.Panel1.Controls.Add(this.tmr);
            this.SCFilter.Panel1.Controls.Add(this.chkConsole);
            this.SCFilter.Panel1.Controls.Add(this.btnFilter);
            this.SCFilter.Panel1.Controls.Add(this.dpFilter);
            this.SCFilter.Panel1.Controls.Add(this.lblpercentage);
            this.SCFilter.Panel1.Controls.Add(this.lblFileName);
            this.SCFilter.Panel1.Controls.Add(this.pgBarLabel);
            // 
            // SCFilter.Panel2
            // 
            this.SCFilter.Panel2.Controls.Add(this.SCConsole);
            this.SCFilter.Size = new System.Drawing.Size(779, 321);
            this.SCFilter.SplitterDistance = 73;
            this.SCFilter.TabIndex = 1;
            // 
            // chkListFiles
            // 
            this.chkListFiles.AutoSize = true;
            this.chkListFiles.Location = new System.Drawing.Point(527, 26);
            this.chkListFiles.Name = "chkListFiles";
            this.chkListFiles.Size = new System.Drawing.Size(122, 17);
            this.chkListFiles.TabIndex = 44;
            this.chkListFiles.Text = "Show All Listed Files";
            this.chkListFiles.UseVisualStyleBackColor = true;
            // 
            // lblTimerAt
            // 
            this.lblTimerAt.AutoSize = true;
            this.lblTimerAt.BackColor = System.Drawing.SystemColors.Control;
            this.lblTimerAt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimerAt.Location = new System.Drawing.Point(586, 49);
            this.lblTimerAt.Name = "lblTimerAt";
            this.lblTimerAt.Size = new System.Drawing.Size(48, 15);
            this.lblTimerAt.TabIndex = 43;
            this.lblTimerAt.Text = "Enabled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Timer At";
            // 
            // lblTimerCount
            // 
            this.lblTimerCount.AutoSize = true;
            this.lblTimerCount.BackColor = System.Drawing.SystemColors.Control;
            this.lblTimerCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimerCount.Location = new System.Drawing.Point(470, 48);
            this.lblTimerCount.Name = "lblTimerCount";
            this.lblTimerCount.Size = new System.Drawing.Size(48, 15);
            this.lblTimerCount.TabIndex = 41;
            this.lblTimerCount.Text = "Enabled";
            // 
            // tmr
            // 
            this.tmr.AutoSize = true;
            this.tmr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmr.Location = new System.Drawing.Point(389, 47);
            this.tmr.Name = "tmr";
            this.tmr.Size = new System.Drawing.Size(76, 15);
            this.tmr.TabIndex = 6;
            this.tmr.Text = "Timer Count";
            // 
            // chkConsole
            // 
            this.chkConsole.AutoSize = true;
            this.chkConsole.Location = new System.Drawing.Point(295, 48);
            this.chkConsole.Name = "chkConsole";
            this.chkConsole.Size = new System.Drawing.Size(94, 17);
            this.chkConsole.TabIndex = 5;
            this.chkConsole.Text = "Show Console";
            this.chkConsole.UseVisualStyleBackColor = true;
            this.chkConsole.CheckedChanged += new System.EventHandler(this.chkConsole_CheckedChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(214, 44);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Show List";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // dpFilter
            // 
            this.dpFilter.Location = new System.Drawing.Point(7, 46);
            this.dpFilter.Name = "dpFilter";
            this.dpFilter.Size = new System.Drawing.Size(200, 20);
            this.dpFilter.TabIndex = 3;
            // 
            // lblpercentage
            // 
            this.lblpercentage.AutoSize = true;
            this.lblpercentage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpercentage.Location = new System.Drawing.Point(451, 25);
            this.lblpercentage.Name = "lblpercentage";
            this.lblpercentage.Size = new System.Drawing.Size(24, 15);
            this.lblpercentage.TabIndex = 2;
            this.lblpercentage.Text = "0%";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(11, 7);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(40, 15);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "label1";
            // 
            // pgBarLabel
            // 
            this.pgBarLabel.Location = new System.Drawing.Point(8, 26);
            this.pgBarLabel.Name = "pgBarLabel";
            this.pgBarLabel.Size = new System.Drawing.Size(434, 13);
            this.pgBarLabel.TabIndex = 0;
            // 
            // SCConsole
            // 
            this.SCConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCConsole.Location = new System.Drawing.Point(0, 0);
            this.SCConsole.Name = "SCConsole";
            // 
            // SCConsole.Panel1
            // 
            this.SCConsole.Panel1.Controls.Add(this.dataGridView1);
            // 
            // SCConsole.Panel2
            // 
            this.SCConsole.Panel2.Controls.Add(this.txtConsole);
            this.SCConsole.Panel2Collapsed = true;
            this.SCConsole.Size = new System.Drawing.Size(779, 244);
            this.SCConsole.SplitterDistance = 398;
            this.SCConsole.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(779, 244);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(96, 100);
            this.txtConsole.TabIndex = 0;
            // 
            // lblTimerStarts
            // 
            this.lblTimerStarts.AutoSize = true;
            this.lblTimerStarts.BackColor = System.Drawing.SystemColors.Control;
            this.lblTimerStarts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimerStarts.Location = new System.Drawing.Point(1063, 6);
            this.lblTimerStarts.Name = "lblTimerStarts";
            this.lblTimerStarts.Size = new System.Drawing.Size(48, 15);
            this.lblTimerStarts.TabIndex = 42;
            this.lblTimerStarts.Text = "Enabled";
            // 
            // ScListMain
            // 
            this.ScListMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScListMain.Location = new System.Drawing.Point(0, 24);
            this.ScListMain.Name = "ScListMain";
            // 
            // ScListMain.Panel1
            // 
            this.ScListMain.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // ScListMain.Panel2
            // 
            this.ScListMain.Panel2.Controls.Add(this.SCMain);
            this.ScListMain.Size = new System.Drawing.Size(1173, 645);
            this.ScListMain.SplitterDistance = 390;
            this.ScListMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lstMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 645);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lstMain
            // 
            this.lstMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMain.Location = new System.Drawing.Point(3, 30);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(384, 315);
            this.lstMain.TabIndex = 0;
            this.lstMain.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 27);
            this.panel1.TabIndex = 1;
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 0);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip2.Size = new System.Drawing.Size(390, 27);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 22);
            this.toolStripStatusLabel1.Text = "Job List";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.statusStrip5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 348);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 29);
            this.panel4.TabIndex = 2;
            // 
            // statusStrip5
            // 
            this.statusStrip5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4});
            this.statusStrip5.Location = new System.Drawing.Point(0, 0);
            this.statusStrip5.Name = "statusStrip5";
            this.statusStrip5.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip5.Size = new System.Drawing.Size(390, 29);
            this.statusStrip5.SizingGrip = false;
            this.statusStrip5.TabIndex = 0;
            this.statusStrip5.Text = "statusStrip5";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(105, 24);
            this.toolStripStatusLabel4.Text = "Mail Message";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtMailMessage);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 377);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 268);
            this.panel5.TabIndex = 3;
            // 
            // txtMailMessage
            // 
            this.txtMailMessage.BackColor = System.Drawing.Color.White;
            this.txtMailMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMailMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMailMessage.Multiline = true;
            this.txtMailMessage.Name = "txtMailMessage";
            this.txtMailMessage.ReadOnly = true;
            this.txtMailMessage.Size = new System.Drawing.Size(390, 268);
            this.txtMailMessage.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSFileName,
            this.TSSTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 669);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1173, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSFileName
            // 
            this.TSSFileName.Name = "TSSFileName";
            this.TSSFileName.Size = new System.Drawing.Size(60, 19);
            this.TSSFileName.Text = "File Name";
            // 
            // TSSTime
            // 
            this.TSSTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.TSSTime.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.TSSTime.Name = "TSSTime";
            this.TSSTime.Size = new System.Drawing.Size(38, 19);
            this.TSSTime.Text = "Time";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // tmrBackup
            // 
            this.tmrBackup.Enabled = true;
            this.tmrBackup.Tick += new System.EventHandler(this.tmrBackup_Tick);
            // 
            // clearConsoleToolStripMenuItem
            // 
            this.clearConsoleToolStripMenuItem.Name = "clearConsoleToolStripMenuItem";
            this.clearConsoleToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.clearConsoleToolStripMenuItem.Text = "Clear Console";
            this.clearConsoleToolStripMenuItem.Click += new System.EventHandler(this.clearConsoleToolStripMenuItem_Click);
            // 
            // frmSyncMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 693);
            this.Controls.Add(this.lblTimerStarts);
            this.Controls.Add(this.ScListMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSyncMain";
            this.Text = "Sync Main";
            this.Load += new System.EventHandler(this.frmSyncMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SCMain.Panel1.ResumeLayout(false);
            this.SCMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCMain)).EndInit();
            this.SCMain.ResumeLayout(false);
            this.SCFolder.Panel1.ResumeLayout(false);
            this.SCFolder.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCFolder)).EndInit();
            this.SCFolder.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip4.ResumeLayout(false);
            this.statusStrip4.PerformLayout();
            this.SCFilter.Panel1.ResumeLayout(false);
            this.SCFilter.Panel1.PerformLayout();
            this.SCFilter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCFilter)).EndInit();
            this.SCFilter.ResumeLayout(false);
            this.SCConsole.Panel1.ResumeLayout(false);
            this.SCConsole.Panel2.ResumeLayout(false);
            this.SCConsole.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCConsole)).EndInit();
            this.SCConsole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ScListMain.Panel1.ResumeLayout(false);
            this.ScListMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScListMain)).EndInit();
            this.ScListMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.statusStrip5.ResumeLayout(false);
            this.statusStrip5.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem readXMLFileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer SCMain;
        private System.Windows.Forms.SplitContainer SCFolder;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.ToolStripMenuItem readFromListToolStripMenuItem;
        private System.Windows.Forms.ListView lstSource;
        private System.Windows.Forms.ListView lstDestination;
        private System.Windows.Forms.SplitContainer ScListMain;
        private System.Windows.Forms.ListView lstMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSFileName;
        private System.Windows.Forms.SplitContainer SCFilter;
        private System.Windows.Forms.Label lblpercentage;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ProgressBar pgBarLabel;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dpFilter;
        private System.Windows.Forms.CheckBox chkConsole;
        private System.Windows.Forms.SplitContainer SCConsole;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusStrip statusStrip4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.StatusStrip statusStrip5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMailMessage;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.Timer tmrBackup;
        internal System.Windows.Forms.Label lblTimerCount;
        private System.Windows.Forms.Label tmr;
        internal System.Windows.Forms.Label lblTimerStarts;
        private System.Windows.Forms.ToolStripStatusLabel TSSTime;
        internal System.Windows.Forms.Label lblTimerAt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkListFiles;
        private System.Windows.Forms.ToolStripMenuItem clearConsoleToolStripMenuItem;
    }
}