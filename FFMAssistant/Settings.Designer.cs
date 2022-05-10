namespace FFMAssistant
{
    partial class Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FrameResetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scd_thresholdLabel = new System.Windows.Forms.Label();
            this.mi_modeLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FFmpegPath = new System.Windows.Forms.TextBox();
            this.DefaultOutput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VCodecList = new System.Windows.Forms.TextBox();
            this.ACodecList = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExtensionList = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FrameResetButton);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // FrameResetButton
            // 
            this.FrameResetButton.Location = new System.Drawing.Point(175, 380);
            this.FrameResetButton.Name = "FrameResetButton";
            this.FrameResetButton.Size = new System.Drawing.Size(75, 23);
            this.FrameResetButton.TabIndex = 2;
            this.FrameResetButton.Text = "リセット";
            this.FrameResetButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.32787F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.67213F));
            this.tableLayoutPanel1.Controls.Add(this.scd_thresholdLabel, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // scd_thresholdLabel
            // 
            this.scd_thresholdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scd_thresholdLabel.AutoSize = true;
            this.scd_thresholdLabel.Location = new System.Drawing.Point(3, 35);
            this.scd_thresholdLabel.Name = "scd_thresholdLabel";
            this.scd_thresholdLabel.Size = new System.Drawing.Size(93, 30);
            this.scd_thresholdLabel.TabIndex = 0;
            this.scd_thresholdLabel.Text = "シーンチェンジ検出閾値";
            // 
            // mi_modeLabel
            // 
            this.mi_modeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mi_modeLabel.AutoSize = true;
            this.mi_modeLabel.Location = new System.Drawing.Point(3, 0);
            this.mi_modeLabel.Name = "mi_modeLabel";
            this.mi_modeLabel.Size = new System.Drawing.Size(99, 15);
            this.mi_modeLabel.TabIndex = 0;
            this.mi_modeLabel.Text = "モーション補間モード";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 87);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "パス設定";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.7907F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.2093F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.FFmpegPath, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DefaultOutput, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(344, 58);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FFmpegフォルダ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "既定の保存先";
            // 
            // FFmpegPath
            // 
            this.FFmpegPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FFmpegPath.Location = new System.Drawing.Point(133, 3);
            this.FFmpegPath.Name = "FFmpegPath";
            this.FFmpegPath.Size = new System.Drawing.Size(208, 23);
            this.FFmpegPath.TabIndex = 1;
            // 
            // DefaultOutput
            // 
            this.DefaultOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DefaultOutput.Location = new System.Drawing.Point(133, 32);
            this.DefaultOutput.Name = "DefaultOutput";
            this.DefaultOutput.Size = new System.Drawing.Size(208, 23);
            this.DefaultOutput.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(9, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 228);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "パス設定";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.7907F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.2093F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.VCodecList, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ACodecList, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ExtensionList, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(344, 198);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "動画コーデック";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "音声コーデック";
            // 
            // VCodecList
            // 
            this.VCodecList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VCodecList.Location = new System.Drawing.Point(133, 3);
            this.VCodecList.Multiline = true;
            this.VCodecList.Name = "VCodecList";
            this.VCodecList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.VCodecList.Size = new System.Drawing.Size(208, 59);
            this.VCodecList.TabIndex = 3;
            // 
            // ACodecList
            // 
            this.ACodecList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ACodecList.Location = new System.Drawing.Point(133, 69);
            this.ACodecList.Multiline = true;
            this.ACodecList.Name = "ACodecList";
            this.ACodecList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ACodecList.Size = new System.Drawing.Size(208, 59);
            this.ACodecList.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "出力拡張子";
            // 
            // ExtensionList
            // 
            this.ExtensionList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExtensionList.Location = new System.Drawing.Point(133, 135);
            this.ExtensionList.Multiline = true;
            this.ExtensionList.Name = "ExtensionList";
            this.ExtensionList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ExtensionList.Size = new System.Drawing.Size(208, 59);
            this.ExtensionList.TabIndex = 5;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 341);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button FrameResetButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label scd_thresholdLabel;
        private Label mi_modeLabel;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private TextBox FFmpegPath;
        private TextBox DefaultOutput;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Label label4;
        private TextBox VCodecList;
        private TextBox ACodecList;
        private Label label5;
        private TextBox ExtensionList;
    }
}