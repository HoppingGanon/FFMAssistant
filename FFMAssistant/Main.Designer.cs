namespace FFMAssistant
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IFile1 = new System.Windows.Forms.TextBox();
            this.IFile1Open = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IFile2 = new System.Windows.Forms.TextBox();
            this.IFile2Open = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OFile = new System.Windows.Forms.TextBox();
            this.OFileOpen = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BeginTime = new System.Windows.Forms.DateTimePicker();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.VCodec = new System.Windows.Forms.ComboBox();
            this.ACodec = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ABitRate = new System.Windows.Forms.TextBox();
            this.ASampling = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AdjustTime = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BorQ = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BorQValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Framerate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Beginfff = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Endfff = new System.Windows.Forms.TextBox();
            this.Option = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.OutputPlace = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FilterSettings = new System.Windows.Forms.Button();
            this.FrameInt = new System.Windows.Forms.ComboBox();
            this.Blur = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.Lbl = new System.Windows.Forms.Label();
            this.Extension = new System.Windows.Forms.ComboBox();
            this.FilterPreview = new System.Windows.Forms.CheckBox();
            this.StateSave = new System.Windows.Forms.ComboBox();
            this.StateSaveButton = new System.Windows.Forms.Button();
            this.StateCallButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.StateDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // IFile1
            // 
            resources.ApplyResources(this.IFile1, "IFile1");
            this.IFile1.Name = "IFile1";
            this.IFile1.TextChanged += new System.EventHandler(this.controlInput);
            // 
            // IFile1Open
            // 
            resources.ApplyResources(this.IFile1Open, "IFile1Open");
            this.IFile1Open.Name = "IFile1Open";
            this.IFile1Open.UseVisualStyleBackColor = true;
            this.IFile1Open.Click += new System.EventHandler(this.IFile1Open_Click);
            // 
            // SettingsButton
            // 
            resources.ApplyResources(this.SettingsButton, "SettingsButton");
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // IFile2
            // 
            resources.ApplyResources(this.IFile2, "IFile2");
            this.IFile2.Name = "IFile2";
            this.IFile2.TextChanged += new System.EventHandler(this.controlInput);
            // 
            // IFile2Open
            // 
            resources.ApplyResources(this.IFile2Open, "IFile2Open");
            this.IFile2Open.Name = "IFile2Open";
            this.IFile2Open.UseVisualStyleBackColor = true;
            this.IFile2Open.Click += new System.EventHandler(this.IFile2Open_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // OFile
            // 
            resources.ApplyResources(this.OFile, "OFile");
            this.OFile.Name = "OFile";
            this.OFile.TextChanged += new System.EventHandler(this.controlInput);
            // 
            // OFileOpen
            // 
            resources.ApplyResources(this.OFileOpen, "OFileOpen");
            this.OFileOpen.Name = "OFileOpen";
            this.OFileOpen.UseVisualStyleBackColor = true;
            this.OFileOpen.Click += new System.EventHandler(this.OFileOpen_Click);
            // 
            // OutputButton
            // 
            resources.ApplyResources(this.OutputButton, "OutputButton");
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // CloseButton
            // 
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // BeginTime
            // 
            resources.ApplyResources(this.BeginTime, "BeginTime");
            this.BeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BeginTime.Name = "BeginTime";
            this.BeginTime.ShowUpDown = true;
            this.BeginTime.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.BeginTime.ValueChanged += new System.EventHandler(this.controlInput);
            // 
            // EndTime
            // 
            resources.ApplyResources(this.EndTime, "EndTime");
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTime.Name = "EndTime";
            this.EndTime.ShowUpDown = true;
            this.EndTime.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.EndTime.ValueChanged += new System.EventHandler(this.controlInput);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // VCodec
            // 
            resources.ApplyResources(this.VCodec, "VCodec");
            this.VCodec.FormattingEnabled = true;
            this.VCodec.Name = "VCodec";
            this.VCodec.TextChanged += new System.EventHandler(this.controlInput);
            // 
            // ACodec
            // 
            resources.ApplyResources(this.ACodec, "ACodec");
            this.ACodec.FormattingEnabled = true;
            this.ACodec.Name = "ACodec";
            this.ACodec.TextChanged += new System.EventHandler(this.controlInput);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.VCodec, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ACodec, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ABitRate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ASampling, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.AdjustTime, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BorQ, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BorQValue, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Framerate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label22, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // ABitRate
            // 
            resources.ApplyResources(this.ABitRate, "ABitRate");
            this.ABitRate.Name = "ABitRate";
            this.ABitRate.TextChanged += new System.EventHandler(this.controlInput);
            // 
            // ASampling
            // 
            resources.ApplyResources(this.ASampling, "ASampling");
            this.ASampling.Name = "ASampling";
            this.ASampling.TextChanged += new System.EventHandler(this.controlInput);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // AdjustTime
            // 
            resources.ApplyResources(this.AdjustTime, "AdjustTime");
            this.AdjustTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdjustTime.FormattingEnabled = true;
            this.AdjustTime.Items.AddRange(new object[] {
            resources.GetString("AdjustTime.Items"),
            resources.GetString("AdjustTime.Items1"),
            resources.GetString("AdjustTime.Items2"),
            resources.GetString("AdjustTime.Items3")});
            this.AdjustTime.Name = "AdjustTime";
            this.AdjustTime.SelectedIndexChanged += new System.EventHandler(this.controlInput);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // BorQ
            // 
            resources.ApplyResources(this.BorQ, "BorQ");
            this.BorQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorQ.FormattingEnabled = true;
            this.BorQ.Items.AddRange(new object[] {
            resources.GetString("BorQ.Items"),
            resources.GetString("BorQ.Items1"),
            resources.GetString("BorQ.Items2")});
            this.BorQ.Name = "BorQ";
            this.BorQ.SelectedIndexChanged += new System.EventHandler(this.controlInput);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // BorQValue
            // 
            resources.ApplyResources(this.BorQValue, "BorQValue");
            this.BorQValue.Name = "BorQValue";
            this.BorQValue.TextChanged += new System.EventHandler(this.controlInput);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // Framerate
            // 
            resources.ApplyResources(this.Framerate, "Framerate");
            this.Framerate.Name = "Framerate";
            this.Framerate.TextChanged += new System.EventHandler(this.controlInput);
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BeginTime);
            this.flowLayoutPanel1.Controls.Add(this.Beginfff);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // Beginfff
            // 
            resources.ApplyResources(this.Beginfff, "Beginfff");
            this.Beginfff.Name = "Beginfff";
            this.Beginfff.Leave += new System.EventHandler(this.Beginfff_Leave);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.EndTime);
            this.flowLayoutPanel2.Controls.Add(this.Endfff);
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // Endfff
            // 
            resources.ApplyResources(this.Endfff, "Endfff");
            this.Endfff.Name = "Endfff";
            this.Endfff.Leave += new System.EventHandler(this.Endfff_Leave);
            // 
            // Option
            // 
            resources.ApplyResources(this.Option, "Option");
            this.Option.Name = "Option";
            this.Option.TextChanged += new System.EventHandler(this.controlInput);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // OutputPlace
            // 
            this.OutputPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputPlace.FormattingEnabled = true;
            this.OutputPlace.Items.AddRange(new object[] {
            resources.GetString("OutputPlace.Items"),
            resources.GetString("OutputPlace.Items1"),
            resources.GetString("OutputPlace.Items2"),
            resources.GetString("OutputPlace.Items3"),
            resources.GetString("OutputPlace.Items4"),
            resources.GetString("OutputPlace.Items5"),
            resources.GetString("OutputPlace.Items6"),
            resources.GetString("OutputPlace.Items7")});
            resources.ApplyResources(this.OutputPlace, "OutputPlace");
            this.OutputPlace.Name = "OutputPlace";
            this.OutputPlace.SelectedIndexChanged += new System.EventHandler(this.controlInput);
            this.OutputPlace.TextChanged += new System.EventHandler(this.controlInput);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.FilterSettings, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.FrameInt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Blur, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label17, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // FilterSettings
            // 
            resources.ApplyResources(this.FilterSettings, "FilterSettings");
            this.FilterSettings.Name = "FilterSettings";
            this.FilterSettings.UseVisualStyleBackColor = true;
            this.FilterSettings.Click += new System.EventHandler(this.FilterSettings_Click);
            // 
            // FrameInt
            // 
            resources.ApplyResources(this.FrameInt, "FrameInt");
            this.FrameInt.DisplayMember = "0";
            this.FrameInt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FrameInt.FormattingEnabled = true;
            this.FrameInt.Items.AddRange(new object[] {
            resources.GetString("FrameInt.Items"),
            resources.GetString("FrameInt.Items1")});
            this.FrameInt.Name = "FrameInt";
            this.FrameInt.SelectedIndexChanged += new System.EventHandler(this.controlInput);
            // 
            // Blur
            // 
            resources.ApplyResources(this.Blur, "Blur");
            this.Blur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Blur.FormattingEnabled = true;
            this.Blur.Items.AddRange(new object[] {
            resources.GetString("Blur.Items"),
            resources.GetString("Blur.Items1")});
            this.Blur.Name = "Blur";
            this.Blur.SelectedIndexChanged += new System.EventHandler(this.controlInput);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // PreviewButton
            // 
            resources.ApplyResources(this.PreviewButton, "PreviewButton");
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.UseVisualStyleBackColor = true;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // Lbl
            // 
            resources.ApplyResources(this.Lbl, "Lbl");
            this.Lbl.Name = "Lbl";
            // 
            // Extension
            // 
            this.Extension.FormattingEnabled = true;
            resources.ApplyResources(this.Extension, "Extension");
            this.Extension.Name = "Extension";
            this.Extension.TextChanged += new System.EventHandler(this.controlInput);
            // 
            // FilterPreview
            // 
            resources.ApplyResources(this.FilterPreview, "FilterPreview");
            this.FilterPreview.Name = "FilterPreview";
            this.FilterPreview.UseVisualStyleBackColor = true;
            // 
            // StateSave
            // 
            this.StateSave.FormattingEnabled = true;
            resources.ApplyResources(this.StateSave, "StateSave");
            this.StateSave.Name = "StateSave";
            // 
            // StateSaveButton
            // 
            resources.ApplyResources(this.StateSaveButton, "StateSaveButton");
            this.StateSaveButton.Name = "StateSaveButton";
            this.StateSaveButton.UseVisualStyleBackColor = true;
            this.StateSaveButton.Click += new System.EventHandler(this.StateSaveButton_Click);
            // 
            // StateCallButton
            // 
            resources.ApplyResources(this.StateCallButton, "StateCallButton");
            this.StateCallButton.Name = "StateCallButton";
            this.StateCallButton.UseVisualStyleBackColor = true;
            this.StateCallButton.Click += new System.EventHandler(this.StateCallButton_Click);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // StateDelete
            // 
            resources.ApplyResources(this.StateDelete, "StateDelete");
            this.StateDelete.Name = "StateDelete";
            this.StateDelete.UseVisualStyleBackColor = true;
            this.StateDelete.Click += new System.EventHandler(this.StateDelete_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StateDelete);
            this.Controls.Add(this.StateCallButton);
            this.Controls.Add(this.StateSaveButton);
            this.Controls.Add(this.StateSave);
            this.Controls.Add(this.FilterPreview);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Option);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Extension);
            this.Controls.Add(this.OutputPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.OFileOpen);
            this.Controls.Add(this.IFile2Open);
            this.Controls.Add(this.IFile1Open);
            this.Controls.Add(this.OFile);
            this.Controls.Add(this.IFile2);
            this.Controls.Add(this.IFile1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox IFile1;
        private Button IFile1Open;
        private Button SettingsButton;
        private Label label3;
        private TextBox IFile2;
        private Button IFile2Open;
        private Label label4;
        private TextBox OFile;
        private Button OFileOpen;
        private Button OutputButton;
        private Button CloseButton;
        private Label label5;
        private DateTimePicker BeginTime;
        private DateTimePicker EndTime;
        private Label label6;
        private ComboBox VCodec;
        private ComboBox ACodec;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label9;
        private TextBox Framerate;
        private Label label10;
        private TextBox BorQValue;
        private Label label11;
        private ComboBox BorQ;
        private Label label12;
        private TextBox ABitRate;
        private TextBox ASampling;
        private Label label13;
        private TextBox Option;
        private Label label14;
        private ComboBox OutputPlace;
        private Label label15;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label18;
        private Label label17;
        private Button PreviewButton;
        private Label Lbl;
        private ComboBox Extension;
        private ComboBox AdjustTime;
        private Label label22;
        private ComboBox Blur;
        private ComboBox FrameInt;
        private Button FilterSettings;
        private CheckBox FilterPreview;
        private ComboBox StateSave;
        private Button StateSaveButton;
        private Button StateCallButton;
        private Label label16;
        private Button StateDelete;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox Beginfff;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox Endfff;
    }
}