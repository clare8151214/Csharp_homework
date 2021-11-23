namespace Homepage
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.另存新檔AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.預覽列印VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.復原ZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消復原RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全選AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選項OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.顏色CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toUpperUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toLowerLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自動換行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快選顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.內容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索引IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜尋SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.關於AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟OCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存SCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.複製CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案FToolStripMenuItem,
            this.編輯EToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.格式MToolStripMenuItem,
            this.說明HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案FToolStripMenuItem
            // 
            this.檔案FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.開啟OCtrlOToolStripMenuItem,
            this.儲存SCtrlSToolStripMenuItem,
            this.另存新檔AToolStripMenuItem,
            this.列印PToolStripMenuItem,
            this.預覽列印VToolStripMenuItem});
            this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
            this.檔案FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.檔案FToolStripMenuItem.Text = "檔案(F)";
            // 
            // 編輯EToolStripMenuItem
            // 
            this.編輯EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.復原ZToolStripMenuItem,
            this.取消復原RToolStripMenuItem,
            this.剪下ToolStripMenuItem,
            this.複製CToolStripMenuItem,
            this.貼上PToolStripMenuItem,
            this.全選AToolStripMenuItem});
            this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
            this.編輯EToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.編輯EToolStripMenuItem.Text = "編輯(E)";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂CToolStripMenuItem,
            this.選項OToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.工具ToolStripMenuItem.Text = "工具(T)";
            // 
            // 格式MToolStripMenuItem
            // 
            this.格式MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顏色CToolStripMenuItem,
            this.字型VToolStripMenuItem,
            this.toUpperUToolStripMenuItem,
            this.toLowerLToolStripMenuItem,
            this.自動換行ToolStripMenuItem,
            this.快選顏色ToolStripMenuItem});
            this.格式MToolStripMenuItem.Name = "格式MToolStripMenuItem";
            this.格式MToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.格式MToolStripMenuItem.Text = "格式(M)";
            // 
            // 說明HToolStripMenuItem
            // 
            this.說明HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.內容ToolStripMenuItem,
            this.索引IToolStripMenuItem,
            this.搜尋SToolStripMenuItem,
            this.toolStripSeparator3,
            this.關於AToolStripMenuItem});
            this.說明HToolStripMenuItem.Name = "說明HToolStripMenuItem";
            this.說明HToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.說明HToolStripMenuItem.Text = "說明(H)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator2,
            this.toolStripButton8});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(600, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 324);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            // 
            // 另存新檔AToolStripMenuItem
            // 
            this.另存新檔AToolStripMenuItem.Name = "另存新檔AToolStripMenuItem";
            this.另存新檔AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.另存新檔AToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.另存新檔AToolStripMenuItem.Text = "另存新檔(A)";
            this.另存新檔AToolStripMenuItem.Click += new System.EventHandler(this.另存新檔AToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // 預覽列印VToolStripMenuItem
            // 
            this.預覽列印VToolStripMenuItem.Name = "預覽列印VToolStripMenuItem";
            this.預覽列印VToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.預覽列印VToolStripMenuItem.Text = "預覽列印(V)";
            this.預覽列印VToolStripMenuItem.Click += new System.EventHandler(this.預覽列印VToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // 復原ZToolStripMenuItem
            // 
            this.復原ZToolStripMenuItem.Name = "復原ZToolStripMenuItem";
            this.復原ZToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.復原ZToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.復原ZToolStripMenuItem.Text = "復原(U)";
            this.復原ZToolStripMenuItem.Click += new System.EventHandler(this.復原ZToolStripMenuItem_Click);
            // 
            // 取消復原RToolStripMenuItem
            // 
            this.取消復原RToolStripMenuItem.Name = "取消復原RToolStripMenuItem";
            this.取消復原RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.取消復原RToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.取消復原RToolStripMenuItem.Text = "取消復原(R)";
            this.取消復原RToolStripMenuItem.Click += new System.EventHandler(this.取消復原RToolStripMenuItem_Click);
            // 
            // 全選AToolStripMenuItem
            // 
            this.全選AToolStripMenuItem.Name = "全選AToolStripMenuItem";
            this.全選AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.全選AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.全選AToolStripMenuItem.Text = "全選(A)";
            this.全選AToolStripMenuItem.Click += new System.EventHandler(this.全選AToolStripMenuItem_Click);
            // 
            // 自訂CToolStripMenuItem
            // 
            this.自訂CToolStripMenuItem.Name = "自訂CToolStripMenuItem";
            this.自訂CToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.自訂CToolStripMenuItem.Text = "自訂(C)";
            // 
            // 選項OToolStripMenuItem
            // 
            this.選項OToolStripMenuItem.Name = "選項OToolStripMenuItem";
            this.選項OToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.選項OToolStripMenuItem.Text = "選項(O)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(600, 275);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // 顏色CToolStripMenuItem
            // 
            this.顏色CToolStripMenuItem.Name = "顏色CToolStripMenuItem";
            this.顏色CToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.顏色CToolStripMenuItem.Text = "顏色(&C)";
            this.顏色CToolStripMenuItem.Click += new System.EventHandler(this.顏色CToolStripMenuItem_Click);
            // 
            // 字型VToolStripMenuItem
            // 
            this.字型VToolStripMenuItem.Name = "字型VToolStripMenuItem";
            this.字型VToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.字型VToolStripMenuItem.Text = "字型(&V)";
            this.字型VToolStripMenuItem.Click += new System.EventHandler(this.字型VToolStripMenuItem_Click);
            // 
            // toUpperUToolStripMenuItem
            // 
            this.toUpperUToolStripMenuItem.Name = "toUpperUToolStripMenuItem";
            this.toUpperUToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.toUpperUToolStripMenuItem.Text = "To Upper(U)";
            this.toUpperUToolStripMenuItem.Click += new System.EventHandler(this.toUpperUToolStripMenuItem_Click);
            // 
            // toLowerLToolStripMenuItem
            // 
            this.toLowerLToolStripMenuItem.Name = "toLowerLToolStripMenuItem";
            this.toLowerLToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.toLowerLToolStripMenuItem.Text = "To Lower(L)";
            this.toLowerLToolStripMenuItem.Click += new System.EventHandler(this.toLowerLToolStripMenuItem_Click);
            // 
            // 自動換行ToolStripMenuItem
            // 
            this.自動換行ToolStripMenuItem.Name = "自動換行ToolStripMenuItem";
            this.自動換行ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.自動換行ToolStripMenuItem.Text = "自動換行";
            this.自動換行ToolStripMenuItem.Click += new System.EventHandler(this.自動換行ToolStripMenuItem_Click);
            // 
            // 快選顏色ToolStripMenuItem
            // 
            this.快選顏色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.blackToolStripMenuItem});
            this.快選顏色ToolStripMenuItem.Name = "快選顏色ToolStripMenuItem";
            this.快選顏色ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.快選顏色ToolStripMenuItem.Text = "快選顏色";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // 內容ToolStripMenuItem
            // 
            this.內容ToolStripMenuItem.Name = "內容ToolStripMenuItem";
            this.內容ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.內容ToolStripMenuItem.Text = "內容(C)";
            this.內容ToolStripMenuItem.Click += new System.EventHandler(this.內容ToolStripMenuItem_Click);
            // 
            // 索引IToolStripMenuItem
            // 
            this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
            this.索引IToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.索引IToolStripMenuItem.Text = "索引(I)";
            // 
            // 搜尋SToolStripMenuItem
            // 
            this.搜尋SToolStripMenuItem.Name = "搜尋SToolStripMenuItem";
            this.搜尋SToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.搜尋SToolStripMenuItem.Text = "搜尋(S)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // 關於AToolStripMenuItem
            // 
            this.關於AToolStripMenuItem.Name = "關於AToolStripMenuItem";
            this.關於AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.關於AToolStripMenuItem.Text = "關於(A)";
            this.關於AToolStripMenuItem.Click += new System.EventHandler(this.內容ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Homepage.Properties.Resources.NEW;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "新增(N)";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Homepage.Properties.Resources.OPEN;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "開啟(O)";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Homepage.Properties.Resources.SAVE;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "儲存(S)";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Homepage.Properties.Resources.PRINT;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "列印(P)";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Homepage.Properties.Resources.CUT;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "剪下(T)";
            this.toolStripButton5.Click += new System.EventHandler(this.剪下ToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::Homepage.Properties.Resources.COPY;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "複製(C)";
            this.toolStripButton6.Click += new System.EventHandler(this.複製CToolStripMenuItem_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::Homepage.Properties.Resources.PASTE;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "貼上(P)";
            this.toolStripButton7.Click += new System.EventHandler(this.貼上PToolStripMenuItem_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::Homepage.Properties.Resources.question_mark;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "說明(L)";
            this.toolStripButton8.Click += new System.EventHandler(this.內容ToolStripMenuItem_Click);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Image = global::Homepage.Properties.Resources.NEW;
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.新增ToolStripMenuItem.Text = "新增(N)";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // 開啟OCtrlOToolStripMenuItem
            // 
            this.開啟OCtrlOToolStripMenuItem.Image = global::Homepage.Properties.Resources.OPEN;
            this.開啟OCtrlOToolStripMenuItem.Name = "開啟OCtrlOToolStripMenuItem";
            this.開啟OCtrlOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開啟OCtrlOToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.開啟OCtrlOToolStripMenuItem.Text = "開啟(O)";
            this.開啟OCtrlOToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // 儲存SCtrlSToolStripMenuItem
            // 
            this.儲存SCtrlSToolStripMenuItem.Image = global::Homepage.Properties.Resources.SAVE;
            this.儲存SCtrlSToolStripMenuItem.Name = "儲存SCtrlSToolStripMenuItem";
            this.儲存SCtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.儲存SCtrlSToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.儲存SCtrlSToolStripMenuItem.Text = "儲存(S)";
            this.儲存SCtrlSToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // 列印PToolStripMenuItem
            // 
            this.列印PToolStripMenuItem.Image = global::Homepage.Properties.Resources.PRINT;
            this.列印PToolStripMenuItem.Name = "列印PToolStripMenuItem";
            this.列印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.列印PToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.列印PToolStripMenuItem.Text = "列印(P)";
            this.列印PToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // 剪下ToolStripMenuItem
            // 
            this.剪下ToolStripMenuItem.Image = global::Homepage.Properties.Resources.CUT;
            this.剪下ToolStripMenuItem.Name = "剪下ToolStripMenuItem";
            this.剪下ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪下ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.剪下ToolStripMenuItem.Text = "剪下(T)";
            this.剪下ToolStripMenuItem.Click += new System.EventHandler(this.剪下ToolStripMenuItem_Click);
            // 
            // 複製CToolStripMenuItem
            // 
            this.複製CToolStripMenuItem.Image = global::Homepage.Properties.Resources.COPY;
            this.複製CToolStripMenuItem.Name = "複製CToolStripMenuItem";
            this.複製CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.複製CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.複製CToolStripMenuItem.Text = "複製(C)";
            this.複製CToolStripMenuItem.Click += new System.EventHandler(this.複製CToolStripMenuItem_Click);
            // 
            // 貼上PToolStripMenuItem
            // 
            this.貼上PToolStripMenuItem.Image = global::Homepage.Properties.Resources.PASTE;
            this.貼上PToolStripMenuItem.Name = "貼上PToolStripMenuItem";
            this.貼上PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼上PToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.貼上PToolStripMenuItem.Text = "貼上(P)";
            this.貼上PToolStripMenuItem.Click += new System.EventHandler(this.貼上PToolStripMenuItem_Click);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(600, 346);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明HToolStripMenuItem;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟OCtrlOToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 儲存SCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列印PToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem 預覽列印VToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem 復原ZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消復原RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 複製CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼上PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全選AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 選項OToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem 顏色CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型VToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem toUpperUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toLowerLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自動換行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快選顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 內容ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜尋SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 關於AToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}