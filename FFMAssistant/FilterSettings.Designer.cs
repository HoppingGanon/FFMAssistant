namespace FFMAssistant
{
    partial class FilterSettings
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FrameResetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scd_thresholdLabel = new System.Windows.Forms.Label();
            this.mi_modeLabel = new System.Windows.Forms.Label();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.mc_modeLabel = new System.Windows.Forms.Label();
            this.me_modeLabel = new System.Windows.Forms.Label();
            this.meLabel = new System.Windows.Forms.Label();
            this.mb_sizeLabel = new System.Windows.Forms.Label();
            this.search_paramLabel = new System.Windows.Forms.Label();
            this.vsbmcLabel = new System.Windows.Forms.Label();
            this.scdLabel = new System.Windows.Forms.Label();
            this.mi_mode = new System.Windows.Forms.ComboBox();
            this.mc_mode = new System.Windows.Forms.ComboBox();
            this.me_mode = new System.Windows.Forms.ComboBox();
            this.me = new System.Windows.Forms.ComboBox();
            this.scd = new System.Windows.Forms.ComboBox();
            this.fps = new System.Windows.Forms.TextBox();
            this.mb_size = new System.Windows.Forms.TextBox();
            this.search_param = new System.Windows.Forms.TextBox();
            this.vsbmc = new System.Windows.Forms.TextBox();
            this.scd_threshold = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BlurResetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PrimaryALabel = new System.Windows.Forms.Label();
            this.PrimaryBLabel = new System.Windows.Forms.Label();
            this.SecondaryALabel = new System.Windows.Forms.Label();
            this.SecondaryBLabel = new System.Windows.Forms.Label();
            this.TertiaryALabel = new System.Windows.Forms.Label();
            this.TertiaryBLabel = new System.Windows.Forms.Label();
            this.BlurFrameLabel = new System.Windows.Forms.Label();
            this.BlurChannelLabel = new System.Windows.Forms.Label();
            this.BlurModeLabel = new System.Windows.Forms.Label();
            this.PrimarySLabel = new System.Windows.Forms.Label();
            this.SecondarySLabel = new System.Windows.Forms.Label();
            this.TertiarySLabel = new System.Windows.Forms.Label();
            this.PrimaryA = new System.Windows.Forms.TextBox();
            this.PrimaryB = new System.Windows.Forms.TextBox();
            this.BlurMode = new System.Windows.Forms.ComboBox();
            this.SecondaryA = new System.Windows.Forms.TextBox();
            this.SecondaryB = new System.Windows.Forms.TextBox();
            this.TertiaryA = new System.Windows.Forms.TextBox();
            this.TertiaryB = new System.Windows.Forms.TextBox();
            this.BlurFrame = new System.Windows.Forms.TextBox();
            this.BlurChannel = new System.Windows.Forms.TextBox();
            this.PrimaryS = new System.Windows.Forms.TextBox();
            this.SecondaryS = new System.Windows.Forms.TextBox();
            this.TertiaryS = new System.Windows.Forms.TextBox();
            this.hint = new System.Windows.Forms.TextBox();
            this.Quote = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(311, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FrameResetButton);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "フレーム補間";
            // 
            // FrameResetButton
            // 
            this.FrameResetButton.Location = new System.Drawing.Point(175, 380);
            this.FrameResetButton.Name = "FrameResetButton";
            this.FrameResetButton.Size = new System.Drawing.Size(75, 23);
            this.FrameResetButton.TabIndex = 11;
            this.FrameResetButton.Text = "リセット";
            this.FrameResetButton.UseVisualStyleBackColor = true;
            this.FrameResetButton.Click += new System.EventHandler(this.FrameResetButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.32787F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.67213F));
            this.tableLayoutPanel1.Controls.Add(this.scd_thresholdLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.mi_modeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fpsLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mc_modeLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.me_modeLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.meLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.mb_sizeLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.search_paramLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.vsbmcLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.scdLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.mi_mode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mc_mode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.me_mode, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.me, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.scd, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.fps, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mb_size, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.search_param, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.vsbmc, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.scd_threshold, 1, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // scd_thresholdLabel
            // 
            this.scd_thresholdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scd_thresholdLabel.AutoSize = true;
            this.scd_thresholdLabel.Location = new System.Drawing.Point(3, 327);
            this.scd_thresholdLabel.Name = "scd_thresholdLabel";
            this.scd_thresholdLabel.Size = new System.Drawing.Size(117, 15);
            this.scd_thresholdLabel.TabIndex = 0;
            this.scd_thresholdLabel.Text = "シーンチェンジ検出閾値";
            this.scd_thresholdLabel.MouseEnter += new System.EventHandler(this.scd_thresholdLabel_Enter);
            // 
            // mi_modeLabel
            // 
            this.mi_modeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mi_modeLabel.AutoSize = true;
            this.mi_modeLabel.Location = new System.Drawing.Point(3, 45);
            this.mi_modeLabel.Name = "mi_modeLabel";
            this.mi_modeLabel.Size = new System.Drawing.Size(99, 15);
            this.mi_modeLabel.TabIndex = 0;
            this.mi_modeLabel.Text = "モーション補間モード";
            this.mi_modeLabel.MouseEnter += new System.EventHandler(this.mi_modeLabel_Enter);
            // 
            // fpsLabel
            // 
            this.fpsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Location = new System.Drawing.Point(3, 10);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(66, 15);
            this.fpsLabel.TabIndex = 0;
            this.fpsLabel.Text = "フレームレート";
            this.fpsLabel.MouseEnter += new System.EventHandler(this.fpsLabel_Enter);
            // 
            // mc_modeLabel
            // 
            this.mc_modeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mc_modeLabel.AutoSize = true;
            this.mc_modeLabel.Location = new System.Drawing.Point(3, 80);
            this.mc_modeLabel.Name = "mc_modeLabel";
            this.mc_modeLabel.Size = new System.Drawing.Size(99, 15);
            this.mc_modeLabel.TabIndex = 0;
            this.mc_modeLabel.Text = "モーション補正モード";
            this.mc_modeLabel.MouseEnter += new System.EventHandler(this.mc_modeLabel_Enter);
            // 
            // me_modeLabel
            // 
            this.me_modeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.me_modeLabel.AutoSize = true;
            this.me_modeLabel.Location = new System.Drawing.Point(3, 115);
            this.me_modeLabel.Name = "me_modeLabel";
            this.me_modeLabel.Size = new System.Drawing.Size(99, 15);
            this.me_modeLabel.TabIndex = 0;
            this.me_modeLabel.Text = "モーション推定モード";
            this.me_modeLabel.MouseEnter += new System.EventHandler(this.me_modeLabel_Enter);
            // 
            // meLabel
            // 
            this.meLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.meLabel.AutoSize = true;
            this.meLabel.Location = new System.Drawing.Point(3, 142);
            this.meLabel.Name = "meLabel";
            this.meLabel.Size = new System.Drawing.Size(129, 30);
            this.meLabel.TabIndex = 0;
            this.meLabel.Text = "モーション推定のアルゴリズム";
            this.meLabel.MouseEnter += new System.EventHandler(this.meLabel_Enter);
            // 
            // mb_sizeLabel
            // 
            this.mb_sizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mb_sizeLabel.AutoSize = true;
            this.mb_sizeLabel.Location = new System.Drawing.Point(3, 185);
            this.mb_sizeLabel.Name = "mb_sizeLabel";
            this.mb_sizeLabel.Size = new System.Drawing.Size(97, 15);
            this.mb_sizeLabel.TabIndex = 0;
            this.mb_sizeLabel.Text = "マクロブロックサイズ";
            this.mb_sizeLabel.MouseEnter += new System.EventHandler(this.mb_sizeLabel_Enter);
            // 
            // search_paramLabel
            // 
            this.search_paramLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.search_paramLabel.AutoSize = true;
            this.search_paramLabel.Location = new System.Drawing.Point(3, 212);
            this.search_paramLabel.Name = "search_paramLabel";
            this.search_paramLabel.Size = new System.Drawing.Size(126, 30);
            this.search_paramLabel.TabIndex = 0;
            this.search_paramLabel.Text = "モーション推定の探索パラメータ";
            this.search_paramLabel.MouseEnter += new System.EventHandler(this.search_paramLabel_Enter);
            // 
            // vsbmcLabel
            // 
            this.vsbmcLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vsbmcLabel.AutoSize = true;
            this.vsbmcLabel.Location = new System.Drawing.Point(3, 247);
            this.vsbmcLabel.Name = "vsbmcLabel";
            this.vsbmcLabel.Size = new System.Drawing.Size(128, 30);
            this.vsbmcLabel.TabIndex = 0;
            this.vsbmcLabel.Text = "可変サイズブロックモーション補間";
            this.vsbmcLabel.MouseEnter += new System.EventHandler(this.vsbmcLabel_Enter);
            // 
            // scdLabel
            // 
            this.scdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scdLabel.AutoSize = true;
            this.scdLabel.Location = new System.Drawing.Point(3, 290);
            this.scdLabel.Name = "scdLabel";
            this.scdLabel.Size = new System.Drawing.Size(118, 15);
            this.scdLabel.TabIndex = 0;
            this.scdLabel.Text = "シーンチェンジ検出モード";
            this.scdLabel.MouseEnter += new System.EventHandler(this.scdLabel_Enter);
            // 
            // mi_mode
            // 
            this.mi_mode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mi_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mi_mode.FormattingEnabled = true;
            this.mi_mode.Items.AddRange(new object[] {
            "dup",
            "blend",
            "mci"});
            this.mi_mode.Location = new System.Drawing.Point(138, 41);
            this.mi_mode.Name = "mi_mode";
            this.mi_mode.Size = new System.Drawing.Size(103, 23);
            this.mi_mode.TabIndex = 2;
            this.mi_mode.MouseEnter += new System.EventHandler(this.mi_modeLabel_Enter);
            // 
            // mc_mode
            // 
            this.mc_mode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mc_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mc_mode.FormattingEnabled = true;
            this.mc_mode.Items.AddRange(new object[] {
            "obmc",
            "aobmc"});
            this.mc_mode.Location = new System.Drawing.Point(138, 76);
            this.mc_mode.Name = "mc_mode";
            this.mc_mode.Size = new System.Drawing.Size(103, 23);
            this.mc_mode.TabIndex = 3;
            this.mc_mode.MouseEnter += new System.EventHandler(this.mc_modeLabel_Enter);
            // 
            // me_mode
            // 
            this.me_mode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.me_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.me_mode.FormattingEnabled = true;
            this.me_mode.Items.AddRange(new object[] {
            "bidir",
            "bilat"});
            this.me_mode.Location = new System.Drawing.Point(138, 111);
            this.me_mode.Name = "me_mode";
            this.me_mode.Size = new System.Drawing.Size(103, 23);
            this.me_mode.TabIndex = 4;
            this.me_mode.MouseEnter += new System.EventHandler(this.me_modeLabel_Enter);
            // 
            // me
            // 
            this.me.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.me.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.me.FormattingEnabled = true;
            this.me.Items.AddRange(new object[] {
            "esa",
            "tss",
            "tdls",
            "ntss",
            "fss",
            "ds",
            "hexbs",
            "epzs",
            "umh"});
            this.me.Location = new System.Drawing.Point(138, 146);
            this.me.Name = "me";
            this.me.Size = new System.Drawing.Size(103, 23);
            this.me.TabIndex = 5;
            this.me.MouseEnter += new System.EventHandler(this.meLabel_Enter);
            // 
            // scd
            // 
            this.scd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scd.FormattingEnabled = true;
            this.scd.Items.AddRange(new object[] {
            "none",
            "fdiff"});
            this.scd.Location = new System.Drawing.Point(138, 286);
            this.scd.Name = "scd";
            this.scd.Size = new System.Drawing.Size(103, 23);
            this.scd.TabIndex = 9;
            this.scd.MouseEnter += new System.EventHandler(this.scdLabel_Enter);
            // 
            // fps
            // 
            this.fps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fps.Location = new System.Drawing.Point(138, 6);
            this.fps.Name = "fps";
            this.fps.Size = new System.Drawing.Size(103, 23);
            this.fps.TabIndex = 1;
            this.fps.MouseEnter += new System.EventHandler(this.fpsLabel_Enter);
            // 
            // mb_size
            // 
            this.mb_size.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mb_size.Location = new System.Drawing.Point(138, 181);
            this.mb_size.Name = "mb_size";
            this.mb_size.Size = new System.Drawing.Size(103, 23);
            this.mb_size.TabIndex = 6;
            this.mb_size.MouseEnter += new System.EventHandler(this.mb_sizeLabel_Enter);
            // 
            // search_param
            // 
            this.search_param.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.search_param.Location = new System.Drawing.Point(138, 216);
            this.search_param.Name = "search_param";
            this.search_param.Size = new System.Drawing.Size(103, 23);
            this.search_param.TabIndex = 7;
            this.search_param.MouseEnter += new System.EventHandler(this.search_paramLabel_Enter);
            // 
            // vsbmc
            // 
            this.vsbmc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vsbmc.Location = new System.Drawing.Point(138, 251);
            this.vsbmc.Name = "vsbmc";
            this.vsbmc.Size = new System.Drawing.Size(103, 23);
            this.vsbmc.TabIndex = 8;
            this.vsbmc.MouseEnter += new System.EventHandler(this.vsbmcLabel_Enter);
            // 
            // scd_threshold
            // 
            this.scd_threshold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scd_threshold.Location = new System.Drawing.Point(138, 323);
            this.scd_threshold.Name = "scd_threshold";
            this.scd_threshold.Size = new System.Drawing.Size(103, 23);
            this.scd_threshold.TabIndex = 10;
            this.scd_threshold.MouseEnter += new System.EventHandler(this.scd_thresholdLabel_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BlurResetButton);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(289, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 409);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "モーションブラー";
            // 
            // BlurResetButton
            // 
            this.BlurResetButton.Location = new System.Drawing.Point(175, 380);
            this.BlurResetButton.Name = "BlurResetButton";
            this.BlurResetButton.Size = new System.Drawing.Size(75, 23);
            this.BlurResetButton.TabIndex = 24;
            this.BlurResetButton.Text = "リセット";
            this.BlurResetButton.UseVisualStyleBackColor = true;
            this.BlurResetButton.Click += new System.EventHandler(this.BlurResetButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.87045F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.12955F));
            this.tableLayoutPanel2.Controls.Add(this.PrimaryALabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PrimaryBLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.SecondaryALabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.SecondaryBLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TertiaryALabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TertiaryBLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.BlurFrameLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.BlurChannelLabel, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.BlurModeLabel, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.PrimarySLabel, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.SecondarySLabel, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.TertiarySLabel, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.PrimaryA, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.PrimaryB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BlurMode, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.SecondaryA, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.SecondaryB, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TertiaryA, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TertiaryB, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.BlurFrame, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.BlurChannel, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.PrimaryS, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.SecondaryS, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.TertiaryS, 1, 11);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 349);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // PrimaryALabel
            // 
            this.PrimaryALabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PrimaryALabel.AutoSize = true;
            this.PrimaryALabel.Location = new System.Drawing.Point(3, 7);
            this.PrimaryALabel.Name = "PrimaryALabel";
            this.PrimaryALabel.Size = new System.Drawing.Size(94, 15);
            this.PrimaryALabel.TabIndex = 0;
            this.PrimaryALabel.Text = "第1チャネル閾値A";
            this.PrimaryALabel.MouseEnter += new System.EventHandler(this.PrimaryALabel_Enter);
            // 
            // PrimaryBLabel
            // 
            this.PrimaryBLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PrimaryBLabel.AutoSize = true;
            this.PrimaryBLabel.Location = new System.Drawing.Point(3, 36);
            this.PrimaryBLabel.Name = "PrimaryBLabel";
            this.PrimaryBLabel.Size = new System.Drawing.Size(93, 15);
            this.PrimaryBLabel.TabIndex = 0;
            this.PrimaryBLabel.Text = "第1チャネル閾値B";
            this.PrimaryBLabel.MouseEnter += new System.EventHandler(this.PrimaryBLabel_Enter);
            // 
            // SecondaryALabel
            // 
            this.SecondaryALabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SecondaryALabel.AutoSize = true;
            this.SecondaryALabel.Location = new System.Drawing.Point(3, 65);
            this.SecondaryALabel.Name = "SecondaryALabel";
            this.SecondaryALabel.Size = new System.Drawing.Size(94, 15);
            this.SecondaryALabel.TabIndex = 0;
            this.SecondaryALabel.Text = "第2チャネル閾値A";
            this.SecondaryALabel.MouseEnter += new System.EventHandler(this.SecondaryALabel_Enter);
            // 
            // SecondaryBLabel
            // 
            this.SecondaryBLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SecondaryBLabel.AutoSize = true;
            this.SecondaryBLabel.Location = new System.Drawing.Point(3, 94);
            this.SecondaryBLabel.Name = "SecondaryBLabel";
            this.SecondaryBLabel.Size = new System.Drawing.Size(93, 15);
            this.SecondaryBLabel.TabIndex = 0;
            this.SecondaryBLabel.Text = "第2チャネル閾値B";
            this.SecondaryBLabel.MouseEnter += new System.EventHandler(this.SecondaryBLabel_Enter);
            // 
            // TertiaryALabel
            // 
            this.TertiaryALabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TertiaryALabel.AutoSize = true;
            this.TertiaryALabel.Location = new System.Drawing.Point(3, 123);
            this.TertiaryALabel.Name = "TertiaryALabel";
            this.TertiaryALabel.Size = new System.Drawing.Size(94, 15);
            this.TertiaryALabel.TabIndex = 0;
            this.TertiaryALabel.Text = "第3チャネル閾値A";
            this.TertiaryALabel.MouseEnter += new System.EventHandler(this.TertiaryALabel_Enter);
            // 
            // TertiaryBLabel
            // 
            this.TertiaryBLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TertiaryBLabel.AutoSize = true;
            this.TertiaryBLabel.Location = new System.Drawing.Point(3, 152);
            this.TertiaryBLabel.Name = "TertiaryBLabel";
            this.TertiaryBLabel.Size = new System.Drawing.Size(93, 15);
            this.TertiaryBLabel.TabIndex = 0;
            this.TertiaryBLabel.Text = "第3チャネル閾値B";
            this.TertiaryBLabel.MouseEnter += new System.EventHandler(this.TertiaryBLabel_Enter);
            // 
            // BlurFrameLabel
            // 
            this.BlurFrameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BlurFrameLabel.AutoSize = true;
            this.BlurFrameLabel.Location = new System.Drawing.Point(3, 181);
            this.BlurFrameLabel.Name = "BlurFrameLabel";
            this.BlurFrameLabel.Size = new System.Drawing.Size(53, 15);
            this.BlurFrameLabel.TabIndex = 0;
            this.BlurFrameLabel.Text = "フレーム数";
            this.BlurFrameLabel.MouseEnter += new System.EventHandler(this.BlurFrameLabel_Enter);
            // 
            // BlurChannelLabel
            // 
            this.BlurChannelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BlurChannelLabel.AutoSize = true;
            this.BlurChannelLabel.Location = new System.Drawing.Point(3, 210);
            this.BlurChannelLabel.Name = "BlurChannelLabel";
            this.BlurChannelLabel.Size = new System.Drawing.Size(68, 15);
            this.BlurChannelLabel.TabIndex = 0;
            this.BlurChannelLabel.Text = "対象チャネル";
            this.BlurChannelLabel.MouseEnter += new System.EventHandler(this.BlurChannelLabel_Enter);
            // 
            // BlurModeLabel
            // 
            this.BlurModeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BlurModeLabel.AutoSize = true;
            this.BlurModeLabel.Location = new System.Drawing.Point(3, 239);
            this.BlurModeLabel.Name = "BlurModeLabel";
            this.BlurModeLabel.Size = new System.Drawing.Size(61, 15);
            this.BlurModeLabel.TabIndex = 0;
            this.BlurModeLabel.Text = "アルゴリズム";
            this.BlurModeLabel.MouseEnter += new System.EventHandler(this.BlurModeLabel_Enter);
            // 
            // PrimarySLabel
            // 
            this.PrimarySLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PrimarySLabel.AutoSize = true;
            this.PrimarySLabel.Location = new System.Drawing.Point(3, 268);
            this.PrimarySLabel.Name = "PrimarySLabel";
            this.PrimarySLabel.Size = new System.Drawing.Size(102, 15);
            this.PrimarySLabel.TabIndex = 0;
            this.PrimarySLabel.Text = "第1チャネルシグマ値";
            this.PrimarySLabel.MouseEnter += new System.EventHandler(this.PrimarySLabel_Enter);
            // 
            // SecondarySLabel
            // 
            this.SecondarySLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SecondarySLabel.AutoSize = true;
            this.SecondarySLabel.Location = new System.Drawing.Point(3, 297);
            this.SecondarySLabel.Name = "SecondarySLabel";
            this.SecondarySLabel.Size = new System.Drawing.Size(102, 15);
            this.SecondarySLabel.TabIndex = 0;
            this.SecondarySLabel.Text = "第2チャネルシグマ値";
            this.SecondarySLabel.MouseEnter += new System.EventHandler(this.SecondarySLabel_Enter);
            // 
            // TertiarySLabel
            // 
            this.TertiarySLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TertiarySLabel.AutoSize = true;
            this.TertiarySLabel.Location = new System.Drawing.Point(3, 326);
            this.TertiarySLabel.Name = "TertiarySLabel";
            this.TertiarySLabel.Size = new System.Drawing.Size(102, 15);
            this.TertiarySLabel.TabIndex = 0;
            this.TertiarySLabel.Text = "第3チャネルシグマ値";
            this.TertiarySLabel.MouseEnter += new System.EventHandler(this.TertiarySLabel_Enter);
            // 
            // PrimaryA
            // 
            this.PrimaryA.Location = new System.Drawing.Point(141, 3);
            this.PrimaryA.Name = "PrimaryA";
            this.PrimaryA.Size = new System.Drawing.Size(103, 23);
            this.PrimaryA.TabIndex = 12;
            this.PrimaryA.MouseEnter += new System.EventHandler(this.PrimaryALabel_Enter);
            // 
            // PrimaryB
            // 
            this.PrimaryB.Location = new System.Drawing.Point(141, 32);
            this.PrimaryB.Name = "PrimaryB";
            this.PrimaryB.Size = new System.Drawing.Size(103, 23);
            this.PrimaryB.TabIndex = 13;
            this.PrimaryB.MouseEnter += new System.EventHandler(this.PrimaryBLabel_Enter);
            // 
            // BlurMode
            // 
            this.BlurMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BlurMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BlurMode.FormattingEnabled = true;
            this.BlurMode.Items.AddRange(new object[] {
            "parallel",
            "serial"});
            this.BlurMode.Location = new System.Drawing.Point(141, 235);
            this.BlurMode.Name = "BlurMode";
            this.BlurMode.Size = new System.Drawing.Size(103, 23);
            this.BlurMode.TabIndex = 20;
            this.BlurMode.MouseEnter += new System.EventHandler(this.BlurModeLabel_Enter);
            // 
            // SecondaryA
            // 
            this.SecondaryA.Location = new System.Drawing.Point(141, 61);
            this.SecondaryA.Name = "SecondaryA";
            this.SecondaryA.Size = new System.Drawing.Size(103, 23);
            this.SecondaryA.TabIndex = 14;
            this.SecondaryA.MouseEnter += new System.EventHandler(this.SecondaryALabel_Enter);
            // 
            // SecondaryB
            // 
            this.SecondaryB.Location = new System.Drawing.Point(141, 90);
            this.SecondaryB.Name = "SecondaryB";
            this.SecondaryB.Size = new System.Drawing.Size(103, 23);
            this.SecondaryB.TabIndex = 15;
            this.SecondaryB.MouseEnter += new System.EventHandler(this.SecondaryBLabel_Enter);
            // 
            // TertiaryA
            // 
            this.TertiaryA.Location = new System.Drawing.Point(141, 119);
            this.TertiaryA.Name = "TertiaryA";
            this.TertiaryA.Size = new System.Drawing.Size(103, 23);
            this.TertiaryA.TabIndex = 16;
            this.TertiaryA.MouseEnter += new System.EventHandler(this.TertiaryALabel_Enter);
            // 
            // TertiaryB
            // 
            this.TertiaryB.Location = new System.Drawing.Point(141, 148);
            this.TertiaryB.Name = "TertiaryB";
            this.TertiaryB.Size = new System.Drawing.Size(103, 23);
            this.TertiaryB.TabIndex = 17;
            this.TertiaryB.MouseEnter += new System.EventHandler(this.TertiaryBLabel_Enter);
            // 
            // BlurFrame
            // 
            this.BlurFrame.Location = new System.Drawing.Point(141, 177);
            this.BlurFrame.Name = "BlurFrame";
            this.BlurFrame.Size = new System.Drawing.Size(103, 23);
            this.BlurFrame.TabIndex = 18;
            this.BlurFrame.MouseEnter += new System.EventHandler(this.BlurFrameLabel_Enter);
            // 
            // BlurChannel
            // 
            this.BlurChannel.Location = new System.Drawing.Point(141, 206);
            this.BlurChannel.Name = "BlurChannel";
            this.BlurChannel.Size = new System.Drawing.Size(103, 23);
            this.BlurChannel.TabIndex = 19;
            this.BlurChannel.MouseEnter += new System.EventHandler(this.BlurChannelLabel_Enter);
            // 
            // PrimaryS
            // 
            this.PrimaryS.Enabled = false;
            this.PrimaryS.Location = new System.Drawing.Point(141, 264);
            this.PrimaryS.Name = "PrimaryS";
            this.PrimaryS.Size = new System.Drawing.Size(103, 23);
            this.PrimaryS.TabIndex = 21;
            this.PrimaryS.MouseEnter += new System.EventHandler(this.PrimarySLabel_Enter);
            // 
            // SecondaryS
            // 
            this.SecondaryS.Enabled = false;
            this.SecondaryS.Location = new System.Drawing.Point(141, 293);
            this.SecondaryS.Name = "SecondaryS";
            this.SecondaryS.Size = new System.Drawing.Size(103, 23);
            this.SecondaryS.TabIndex = 22;
            this.SecondaryS.MouseEnter += new System.EventHandler(this.SecondarySLabel_Enter);
            // 
            // TertiaryS
            // 
            this.TertiaryS.Enabled = false;
            this.TertiaryS.Location = new System.Drawing.Point(141, 322);
            this.TertiaryS.Name = "TertiaryS";
            this.TertiaryS.Size = new System.Drawing.Size(103, 23);
            this.TertiaryS.TabIndex = 23;
            this.TertiaryS.MouseEnter += new System.EventHandler(this.TertiarySLabel_Enter);
            // 
            // hint
            // 
            this.hint.Enabled = false;
            this.hint.Location = new System.Drawing.Point(12, 427);
            this.hint.Multiline = true;
            this.hint.Name = "hint";
            this.hint.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.hint.Size = new System.Drawing.Size(533, 200);
            this.hint.TabIndex = 0;
            this.hint.TabStop = false;
            this.hint.Text = "ラベルをクリックすると、ここにヒントが表示されます。";
            // 
            // Quote
            // 
            this.Quote.Enabled = false;
            this.Quote.Location = new System.Drawing.Point(12, 633);
            this.Quote.Multiline = true;
            this.Quote.Name = "Quote";
            this.Quote.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Quote.Size = new System.Drawing.Size(533, 37);
            this.Quote.TabIndex = 0;
            this.Quote.TabStop = false;
            this.Quote.Text = "ラベルをクリックすると、ここにヒントが表示されます。";
            // 
            // FilterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 682);
            this.Controls.Add(this.Quote);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "FilterSettings";
            this.Text = "フィルター設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilterSettings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label scd_thresholdLabel;
        private Label mi_modeLabel;
        private Label fpsLabel;
        private Label mc_modeLabel;
        private Label me_modeLabel;
        private Label meLabel;
        private Label mb_sizeLabel;
        private Label search_paramLabel;
        private Label vsbmcLabel;
        private Label scdLabel;
        private ComboBox mi_mode;
        private ComboBox mc_mode;
        private ComboBox me_mode;
        private ComboBox me;
        private ComboBox scd;
        private TextBox fps;
        private TextBox mb_size;
        private TextBox search_param;
        private TextBox vsbmc;
        private TextBox scd_threshold;
        private GroupBox groupBox2;
        private TextBox hint;
        private TextBox Quote;
        private Button FrameResetButton;
        private Button BlurResetButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label PrimaryALabel;
        private Label PrimaryBLabel;
        private Label SecondaryALabel;
        private Label SecondaryBLabel;
        private Label TertiaryALabel;
        private Label TertiaryBLabel;
        private Label BlurFrameLabel;
        private Label BlurChannelLabel;
        private Label BlurModeLabel;
        private Label PrimarySLabel;
        private Label SecondarySLabel;
        private Label TertiarySLabel;
        private TextBox PrimaryA;
        private TextBox PrimaryB;
        private ComboBox BlurMode;
        private TextBox SecondaryA;
        private TextBox SecondaryB;
        private TextBox TertiaryA;
        private TextBox TertiaryB;
        private TextBox BlurFrame;
        private TextBox BlurChannel;
        private TextBox PrimaryS;
        private TextBox SecondaryS;
        private TextBox TertiaryS;
    }
}