namespace Zylix
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Propósito Geral");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Controle de Fluxo");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Precisão de Volume");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Diretório do Sistema", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelEdit = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button13 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnPushSelected = new System.Windows.Forms.Button();
            this.btnPullSelected = new System.Windows.Forms.Button();
            this.btnPushAll = new System.Windows.Forms.Button();
            this.btnPullAll = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCortar = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnColar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelEdit.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Location = new System.Drawing.Point(4, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 133);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHome.Controls.Add(this.panel4);
            this.tabHome.Controls.Add(this.panel3);
            this.tabHome.Controls.Add(this.panel2);
            this.tabHome.Controls.Add(this.PanelEdit);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1250, 107);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button13);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.button12);
            this.panel4.Location = new System.Drawing.Point(748, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 102);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Location = new System.Drawing.Point(572, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 102);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPushSelected);
            this.panel2.Controls.Add(this.btnPullSelected);
            this.panel2.Controls.Add(this.btnPushAll);
            this.panel2.Controls.Add(this.btnPullAll);
            this.panel2.Location = new System.Drawing.Point(231, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 102);
            this.panel2.TabIndex = 1;
            // 
            // PanelEdit
            // 
            this.PanelEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelEdit.Controls.Add(this.panel1);
            this.PanelEdit.Controls.Add(this.button7);
            this.PanelEdit.Controls.Add(this.button8);
            this.PanelEdit.Controls.Add(this.button2);
            this.PanelEdit.Controls.Add(this.button3);
            this.PanelEdit.Controls.Add(this.btnCortar);
            this.PanelEdit.Controls.Add(this.button9);
            this.PanelEdit.Controls.Add(this.button6);
            this.PanelEdit.Controls.Add(this.btnColar);
            this.PanelEdit.Location = new System.Drawing.Point(0, 0);
            this.PanelEdit.Name = "PanelEdit";
            this.PanelEdit.Size = new System.Drawing.Size(225, 102);
            this.PanelEdit.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(238, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 100);
            this.panel1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "paste.png");
            this.imageList1.Images.SetKeyName(1, "copy.png");
            this.imageList1.Images.SetKeyName(2, "cut.png");
            this.imageList1.Images.SetKeyName(3, "Logo.png");
            this.imageList1.Images.SetKeyName(4, "clear.png");
            this.imageList1.Images.SetKeyName(5, "down.png");
            this.imageList1.Images.SetKeyName(6, "find.png");
            this.imageList1.Images.SetKeyName(7, "input.png");
            this.imageList1.Images.SetKeyName(8, "up.png");
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1250, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1242, 368);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "node1";
            treeNode1.Text = "Propósito Geral";
            treeNode2.Name = "node2";
            treeNode2.Text = "Controle de Fluxo";
            treeNode3.Name = "node3";
            treeNode3.Text = "Precisão de Volume";
            treeNode4.Name = "node0";
            treeNode4.Text = "Diretório do Sistema";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(146, 375);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(742, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Location = new System.Drawing.Point(4, 167);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1258, 402);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.abrirToolStripButton,
            this.salvarToolStripButton,
            this.imprimirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(104, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.novoToolStripButton.Text = "&Novo";
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton.Text = "&Abrir";
            this.abrirToolStripButton.Click += new System.EventHandler(this.abrirToolStripButton_Click);
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.imprimirToolStripButton.Text = "&Imprimir";
            this.imprimirToolStripButton.Click += new System.EventHandler(this.imprimirToolStripButton_Click);
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Image = global::Zylix.Properties.Resources.retrieve;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button13.Location = new System.Drawing.Point(335, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(84, 93);
            this.button13.TabIndex = 4;
            this.button13.Text = "Obter Totalizadores";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Zylix.Properties.Resources.console;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(245, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 93);
            this.button1.TabIndex = 3;
            this.button1.Text = "Terminal";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Zylix.Properties.Resources.offline;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(161, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 93);
            this.button4.TabIndex = 2;
            this.button4.Text = "Ficar Offline";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Image = global::Zylix.Properties.Resources.retry;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.Location = new System.Drawing.Point(81, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(74, 93);
            this.button11.TabIndex = 1;
            this.button11.Text = "Reconectar";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Image = global::Zylix.Properties.Resources.settings;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.Location = new System.Drawing.Point(7, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(68, 93);
            this.button12.TabIndex = 0;
            this.button12.Text = "Opções";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Zylix.Properties.Resources.upload;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(97, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 93);
            this.button5.TabIndex = 1;
            this.button5.Text = "Push All";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = global::Zylix.Properties.Resources.download;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.Location = new System.Drawing.Point(7, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 93);
            this.button10.TabIndex = 0;
            this.button10.Text = "Pull All";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnPushSelected
            // 
            this.btnPushSelected.Enabled = false;
            this.btnPushSelected.FlatAppearance.BorderSize = 0;
            this.btnPushSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPushSelected.Image = ((System.Drawing.Image)(resources.GetObject("btnPushSelected.Image")));
            this.btnPushSelected.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPushSelected.Location = new System.Drawing.Point(239, 4);
            this.btnPushSelected.Name = "btnPushSelected";
            this.btnPushSelected.Size = new System.Drawing.Size(84, 93);
            this.btnPushSelected.TabIndex = 3;
            this.btnPushSelected.Text = "Push Selected";
            this.btnPushSelected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPushSelected.UseVisualStyleBackColor = true;
            // 
            // btnPullSelected
            // 
            this.btnPullSelected.Enabled = false;
            this.btnPullSelected.FlatAppearance.BorderSize = 0;
            this.btnPullSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPullSelected.Image = global::Zylix.Properties.Resources.pull;
            this.btnPullSelected.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPullSelected.Location = new System.Drawing.Point(155, 4);
            this.btnPullSelected.Name = "btnPullSelected";
            this.btnPullSelected.Size = new System.Drawing.Size(78, 93);
            this.btnPullSelected.TabIndex = 2;
            this.btnPullSelected.Text = "Pull Selected";
            this.btnPullSelected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPullSelected.UseVisualStyleBackColor = true;
            // 
            // btnPushAll
            // 
            this.btnPushAll.Enabled = false;
            this.btnPushAll.FlatAppearance.BorderSize = 0;
            this.btnPushAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPushAll.Image = ((System.Drawing.Image)(resources.GetObject("btnPushAll.Image")));
            this.btnPushAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPushAll.Location = new System.Drawing.Point(81, 4);
            this.btnPushAll.Name = "btnPushAll";
            this.btnPushAll.Size = new System.Drawing.Size(68, 93);
            this.btnPushAll.TabIndex = 1;
            this.btnPushAll.Text = "Push All";
            this.btnPushAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPushAll.UseVisualStyleBackColor = true;
            // 
            // btnPullAll
            // 
            this.btnPullAll.Enabled = false;
            this.btnPullAll.FlatAppearance.BorderSize = 0;
            this.btnPullAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPullAll.Image = global::Zylix.Properties.Resources.pull;
            this.btnPullAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPullAll.Location = new System.Drawing.Point(7, 4);
            this.btnPullAll.Name = "btnPullAll";
            this.btnPullAll.Size = new System.Drawing.Size(68, 93);
            this.btnPullAll.TabIndex = 0;
            this.btnPullAll.Text = "Pull All";
            this.btnPullAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPullAll.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageKey = "input.png";
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(78, 63);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Inserir";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.ImageKey = "copy.png";
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(0, 63);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Copiar";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "down.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(156, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Mover Abaixo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "clear.png";
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(78, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Limpar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCortar
            // 
            this.btnCortar.FlatAppearance.BorderSize = 0;
            this.btnCortar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCortar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCortar.ImageKey = "cut.png";
            this.btnCortar.ImageList = this.imageList1;
            this.btnCortar.Location = new System.Drawing.Point(0, 32);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(72, 23);
            this.btnCortar.TabIndex = 7;
            this.btnCortar.Text = "Recortar";
            this.btnCortar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCortar.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.ImageKey = "up.png";
            this.button9.ImageList = this.imageList1;
            this.button9.Location = new System.Drawing.Point(156, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 42);
            this.button9.TabIndex = 6;
            this.button9.Text = "Mover Acima";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageKey = "find.png";
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(78, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Procurar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnColar
            // 
            this.btnColar.FlatAppearance.BorderSize = 0;
            this.btnColar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColar.ImageKey = "paste.png";
            this.btnColar.ImageList = this.imageList1;
            this.btnColar.Location = new System.Drawing.Point(0, 0);
            this.btnColar.Name = "btnColar";
            this.btnColar.Size = new System.Drawing.Size(72, 23);
            this.btnColar.TabIndex = 0;
            this.btnColar.Text = "Colar";
            this.btnColar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnColar.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 567);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zylix - Avaliação Dev Jr.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelEdit.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Panel PanelEdit;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnColar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPullAll;
        private System.Windows.Forms.Button btnPushSelected;
        private System.Windows.Forms.Button btnPullSelected;
        private System.Windows.Forms.Button btnPushAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}

