using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace FFMAssistant
{
    /// <summary>
    /// ���C���Ƃ��ĕ\������t�H�[���̃N���X
    /// </summary>
    public partial class Main : Form
    {

        // �p�����[�^�X�e�[�g�Z�[�u��ۑ����鑊�΃p�X
        const String paramsPath = "params\\";
        const String settingsFileName = "settings.json";

        OpenFileDialog fdialog = new OpenFileDialog();
        SaveFileDialog sdialog = new SaveFileDialog();
        public SettingsParams settingsParams = new SettingsParams();
        public MainParams mainParams = new MainParams();

        /// <summary>
        /// �t�H�[���̏�������_�C�A���O�̏����A�ݒ�l�̓ǂݍ��݂��s���B
        /// </summary>
        public Main()
        {
            InitializeComponent();

            // �J���Җ�
            this.developer.Text = "�ق��҂񂮂��̂�";

            // �o�[�W�����̋L��
            this.version.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;

            var asm = GetType().Assembly;
            var ver = asm.GetName().Version;

            this.getParams();
            this.controlInput();

            this.fdialog.FileName = "";
            this.fdialog.Filter = "���ׂẴt�@�C��(*.*)|*.*";
            this.fdialog.Title = "���̓t�@�C����I�����Ă�������";

            this.sdialog.FileName = "";
            this.sdialog.Filter = "���ׂẴt�@�C��(*.*)|*.*";
            this.sdialog.Title = "�o�͐�����肵�Ă�������";

            // �o�͊�����̏��������Z�b�g
            this.EndProcess.SelectedIndex = 0;

            // �ݒ�ǂݍ���
            this.loadSettings();
            this.updateList();

            // �X�e�[�g���X�g�Ǎ���
            this.loadStateList();

        }

        private void loadSettings()
        {
            String jsonPath = AppDomain.CurrentDomain.BaseDirectory + "\\" + Main.settingsFileName;
            if (File.Exists(jsonPath))
            {
                StreamReader sr = new System.IO.StreamReader(jsonPath, System.Text.Encoding.UTF8);
                string jsonParams = sr.ReadToEnd();
                sr.Close();

                SettingsParams? tmp = JsonSerializer.Deserialize<SettingsParams>(jsonParams);

                if(tmp == null)
                {
                    MessageBox.Show(this, "�ݒ�t�@�C���̓Ǎ��݂Ɏ��s���܂����B");
                }
                else
                {
                    this.settingsParams = tmp;
                }
            }
        }

        private void saveSettings()
        {

            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    // �G���R�[�h�ݒ�
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    // �C���f���g��t����
                    WriteIndented = true
                };

                // �p�����[�^�t�H���_���Ȃ��Ȃ�쐬����
                string jsonParams = JsonSerializer.Serialize<SettingsParams>(this.settingsParams, options);

                // �ۑ��ꏊ�̌���
                string savePath = AppDomain.CurrentDomain.BaseDirectory + "\\" + Main.settingsFileName;

                // JSON�ۑ�
                File.WriteAllText(savePath, jsonParams);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "�ݒ�̕ۑ��Ɏ��s���܂����B\n" + ex.Message, "�ݒ�ۑ��G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ����R�[�f�b�N�A�����R�[�f�b�N�A�g���q�̃��X�g���ŐV�ɍX�V����
        /// </summary>
        private void updateList()
        {
            // ���X�g�̃N���A
            VCodec.Items.Clear();
            ACodec.Items.Clear();
            Extension.Items.Clear();

            // �ݒ肩�烊�X�g���X�V
            foreach (String val in this.settingsParams.vCodecList.Split("\n"))
            {
                VCodec.Items.Add(val);
            }
            foreach (String val in this.settingsParams.aCodecList.Split("\n"))
            {
                ACodec.Items.Add(val);
            }
            foreach (String val in this.settingsParams.extensionList.Split("\n"))
            {
                Extension.Items.Add(val);
            }

        }

        /// <summary>
        /// ���C���ݒ�f�[�^�̒l���A�t�H�[���ɔ��f
        /// </summary>
        private void getParams()
        {
            IFile1.Text = mainParams.iFile1;
            IFile2.Text = mainParams.iFile2;
            VCodec.Text = mainParams.vCodec;
            ACodec.Text = mainParams.aCodec;
            BorQ.SelectedIndex = mainParams.borQ;
            BorQValue.Text = mainParams.borQValue;
            Framerate.Text = mainParams.framerate;
            AdjustTime.SelectedIndex = mainParams.adjustTime;

            BeginTime.Value = mainParams.beginTime;
            Beginfff.Text = mainParams.beginfff;
            EndTime.Value = mainParams.endTime;
            Endfff.Text = mainParams.endfff;

            ABitRate.Text = mainParams.aBitRate;
            ASampling.Text = mainParams.aSampling;
            Option.Text = mainParams.option;

            FilterPreview.Checked = mainParams.filterPreview;
            Blur.SelectedIndex = mainParams.blur;
            FrameInt.SelectedIndex = mainParams.frameInt;

            OutputPlace.SelectedIndex = mainParams.outputPlace;
            Extension.Text = mainParams.extension;
            OFile.Text = mainParams.oFile;
        }

        /// <summary>
        /// �t�H�[���̒l���A���C���ݒ�f�[�^�ɔ��f
        /// </summary>
        private void setParams()
        {
            mainParams.iFile1 = IFile1.Text;
            mainParams.iFile2 = IFile2.Text;
            mainParams.vCodec = VCodec.Text;
            mainParams.aCodec = ACodec.Text;
            mainParams.borQ = BorQ.SelectedIndex;
            mainParams.borQValue = BorQValue.Text;
            mainParams.framerate = Framerate.Text;
            mainParams.adjustTime = AdjustTime.SelectedIndex;

            mainParams.beginTime = BeginTime.Value;
            mainParams.beginfff = Beginfff.Text;
            mainParams.endTime = EndTime.Value;
            mainParams.endfff = Endfff.Text;

            mainParams.aBitRate = ABitRate.Text;
            mainParams.aSampling = ASampling.Text;
            mainParams.option = Option.Text;

            mainParams.filterPreview = FilterPreview.Checked;
            mainParams.blur = Blur.SelectedIndex;
            mainParams.frameInt = FrameInt.SelectedIndex;

            mainParams.outputPlace = OutputPlace.SelectedIndex;
            mainParams.extension = Extension.Text;
            mainParams.oFile = OFile.Text;
        }

        /// <summary>
        /// �R���g���[����Enable������ׂ���ԂɕύX����(�ΏۃR���g���[����Change���邽�тɎ��s����)
        /// </summary>
        private void controlInput () {

            switch (AdjustTime.SelectedIndex)
            {
                case 0:
                    // �w��Ȃ�
                    BeginTime.Enabled = false;
                    Beginfff.Enabled = false;
                    EndTime.Enabled = false;
                    Endfff.Enabled = false;
                    break;
                case 1:
                    // �J�n�w��
                    BeginTime.Enabled = true;
                    Beginfff.Enabled = true;
                    EndTime.Enabled = false;
                    Endfff.Enabled = false;
                    break;
                case 2:
                    // �I���w��
                    BeginTime.Enabled = false;
                    Beginfff.Enabled = false;
                    EndTime.Enabled = true;
                    Endfff.Enabled = true;

                    break;
                case 3:
                    // ���[�w��
                    BeginTime.Enabled = true;
                    Beginfff.Enabled = true;
                    EndTime.Enabled = true;
                    Endfff.Enabled = true;

                    break;
            }

            if (OutputPlace.SelectedIndex == 0)
            {
                OFile.Enabled = true;
            }
            else
            {
                OFile.Enabled = false;
            }

        }

        /// <summary>
        /// ��v�Ȑݒ�l�R���g���[�����ύX����邽�тɌĂяo����郁�\�b�h
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void controlInput(object sender, EventArgs e)
        {
            this.controlInput();
        }

        /// <summary>
        /// ����{�^���N���b�N
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// �X�e�[�g�Z�[�u���X�g��ǂݍ���
        /// �Ώۃt�H���_�ɑ��݂���json�t�@�C��������g���qjson�����������̂�\��
        /// </summary>
        private void loadStateList ()
        {
            // �X�e�[�g���X�g�̃A�C�e���̃N���A
            this.StateSave.Items.Clear();
            this.StateSave.Items.Add("[Default]");

            try
            {

                string directory = AppDomain.CurrentDomain.BaseDirectory + "\\" + Main.paramsPath;
                string[] files = Directory.GetFiles(directory);
                foreach (string file in files)
                {
                    if (Path.GetExtension(file) == ".json")
                    {
                        // �g���q���������t�@�C������ǉ�
                        this.StateSave.Items.Add(Path.GetFileNameWithoutExtension(file));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "FFMAssistant �G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// FFmpeg�R�}���h���쐬����
        /// </summary>
        /// <param name="isFrameInt">�t���[����Ԃ��܂߂邩�ǂ���</param>
        /// <param name="isBlur">���[�V�����u���[���܂߂邩�ǂ���</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private FFMpegCommand getFFmpegCmd(Boolean isFrameInt, Boolean isBlur)
        {
            String ffmCmd = $"\"{this.settingsParams.ffmpegPath}\\ffmpeg.exe\"";
            FFMpegCommand rcode = new FFMpegCommand();

            // FFMpeg =============================================================
            if (!File.Exists($"{this.settingsParams.ffmpegPath}\\ffmpeg.exe"))
            {
                throw new Exception("ffmpeg.exe�����݂��܂���");
            }

            // �J�n���ԂƏI�����Ԃ̎w�� =============================================================
            // -i����ɋL�q����Ƒ����Ȃ�Ƃ�
            int beginTime = BeginTime.Value.Hour * 3600 + BeginTime.Value.Minute * 60 + BeginTime.Value.Second;

            if (AdjustTime.SelectedIndex == 1 || AdjustTime.SelectedIndex == 3)
            {
                if (!Common.isNumeric(Beginfff.Text, true, true) || Beginfff.Text.Length != 3)
                {
                    throw new Exception("�J�n���Ԃ̏����_�������ُ�ł��B");
                }
            }

            if (AdjustTime.SelectedIndex == 2 || AdjustTime.SelectedIndex == 3)
            {
                if (!Common.isNumeric(Endfff.Text, true, true) || Endfff.Text.Length != 3)
                {
                    throw new Exception("�I�����Ԃ̏����_�������ُ�ł��B");
                }
            }

            switch (AdjustTime.SelectedIndex)
            {
                case 0:
                    // �w��Ȃ�

                    break;
                case 1:
                    // �J�n���Ԃ̂ݎw��
                    ffmCmd += $" -ss {beginTime}.{Beginfff.Text}";
                    break;
                case 2:
                    // �I�����Ԃ̂ݎw��
                    ffmCmd += $" -to {EndTime.Value.ToString("HH:mm:ss")}.{Endfff.Text}";
                    break;
                case 3:
                    // ���[�w��
                    ffmCmd += $" -ss {beginTime}.{Beginfff.Text}";
                    ffmCmd += $" -to {EndTime.Value.ToString("HH:mm:ss")}.{Endfff.Text}";

                    break;
                default:
                    // ���̂ق�
                    throw new Exception("���Ԓ����̕������ُ�ł��B");
            }

            // ���̓t�@�C��1 =============================================================
            if (File.Exists(IFile1.Text))
            {
                ffmCmd += $" -i \"{IFile1.Text}\"";
            }
            else
            {
                throw new Exception("���̓t�@�C��1�����݂��܂���");
            }

            // ���̓t�@�C��2 =============================================================
            // �����͂ł���Ώȗ�����
            if (IFile2.Text != "")
            {
                if (File.Exists(IFile2.Text))
                {
                    ffmCmd += $" -i \"{IFile2.Text}\"";
                }
                else
                {
                    throw new Exception("���̓t�@�C��2�����݂��܂���");
                }
            }

            // ����R�[�f�b�N =============================================================
            if (VCodec.Text != "")
            {
                ffmCmd += $" -c:v {VCodec.Text}";
            }

            // �����R�[�f�b�N =============================================================
            if (ACodec.Text != "")
            {
                ffmCmd += $" -c:a {ACodec.Text}";
            }

            // �掿 =============================================================
            if (BorQValue.Text == "")
            {
                // �掿�������͂Ȃ�A�i��22�Ŏ��s
                ffmCmd += " -q:v 22";
            }
            else
            {
                // ���l�`�F�b�N
                if (Common.isNumeric(BorQValue.Text, false, true))
                {
                    // �掿�����ɂ���ĕ�����
                    switch (BorQ.SelectedIndex)
                    {
                        case 0:
                            // kbps
                            ffmCmd += $" -b:v {BorQValue.Text}k";
                            break;
                        case 1:
                            // Mbps
                            ffmCmd += $" -b:v {BorQValue.Text}M";
                            break;
                        case 2:
                            // �i��
                            ffmCmd += $" -q:v {BorQValue.Text}";
                            break;
                    }
                }
                else
                {
                    throw new Exception("�掿�̒l���ُ�ł��B");
                }
            }

            // �t���[�����[�g =============================================================
            if (Framerate.Text != "")
            {
                ffmCmd += $" -r:v {Framerate.Text}";
            }

            // ���� =============================================================
            if (ABitRate.Text != "")
            {
                if (Common.isNumeric(ABitRate.Text, true, true)) {
                    ffmCmd += $" -b:a {ABitRate.Text}k";
                }
                else
                {
                    throw new Exception("�������ُ�Ȓl�ł��B");
                }
            }

            // �T���v�����O���g�� =============================================================
            if (ASampling.Text != "")
            {
                if (Common.isNumeric(ASampling.Text, true, true))
                {
                    ffmCmd += $" -r:a {ASampling.Text}";
                } else
                {
                    throw new Exception("�T���v�����O���g�����ُ�Ȓl�ł��B");
                }
            }

            // �ǉ��I�v�V���� =============================================================
            ffmCmd += " " + Option.Text;

            // �g���q�̃`�F�b�N
            if (Extension.Text == "")
            {
                throw new Exception("�g���q�͕K�{�ł��B");
            }

            // �t�B���^�ݒ� ===========================================
            if (isFrameInt || isBlur)
            {
                ffmCmd += " -vf ";
            }

            if (isFrameInt)
            {   // me�̂݁A�u1�v����Ă邽�ߑ����Z����
                ffmCmd += $"minterpolate={this.mainParams.fiParams.fps}:{this.mainParams.fiParams.mi_mode}:{this.mainParams.fiParams.mc_mode}:{this.mainParams.fiParams.me_mode}:{this.mainParams.fiParams.me + 1}:{this.mainParams.fiParams.mb_size}:{this.mainParams.fiParams.search_param}:{this.mainParams.fiParams.vsbmc}:{this.mainParams.fiParams.scd}:{this.mainParams.fiParams.scd_threshold}";
            }

            if (isFrameInt && isBlur)
            {
                ffmCmd += ";";
            }

            if (isBlur)
            {
                ffmCmd += $"atadenoise={this.mainParams.bParams.primaryA}:{this.mainParams.bParams.primaryB}:{this.mainParams.bParams.secondaryA}:{this.mainParams.bParams.secondaryB}:{this.mainParams.bParams.tertiaryA}:{this.mainParams.bParams.tertiaryB}:{this.mainParams.bParams.blurFrame}:{this.mainParams.bParams.blurChannel}:{this.mainParams.bParams.blurMode}";
                // �g�p�s�� :{this.settingsParams.bParams.primaryS}:{this.settingsParams.bParams.secondaryS}:{this.settingsParams.bParams.tertiaryS}
            }

            rcode.inputCommand = ffmCmd;

            // �t�@�C���o�� ===========================================
            string parent = "";
            string baseName = Path.GetFileNameWithoutExtension(IFile1.Text);
            string extension = $".{Extension.Text}";
            string? tmp;

            switch (OutputPlace.SelectedIndex)
            {
                case 0:
                    // �w��ꏊ
                    tmp = Path.GetDirectoryName(OFile.Text);
                    if (tmp == null)
                    {
                        throw new Exception("�o�͐�p�X���s���ł��B");
                    }
                    else
                    {
                        parent = tmp;
                    }
                    baseName = Path.GetFileNameWithoutExtension(OFile.Text);
                    extension = Path.GetExtension(OFile.Text);

                    // �w�肵���g���q�ƈقȂ�ꍇ�ɂ́A�w�肵���g���q��baseName����ɂ���
                    if ($".{Extension.Text}" != $"{extension}") {
                        baseName += extension;
                        extension = $".{Extension.Text}";
                    }

                    break;
                case 1:
                    // ����̃t�H���_
                    parent = this.settingsParams.defaultOutput;
                    break;
                case 2:
                    // ���̓t�@�C��1�Ɠ���
                    tmp = Path.GetDirectoryName(IFile1.Text);
                    if (tmp == null)
                    {
                        throw new Exception("�o�͐�p�X���s���ł��B");
                    }
                    else
                    {
                        parent = tmp;
                    }

                    break;
                case 3:
                    //�h�L�������g�t�H���_
                    parent = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    break;
                case 4:
                    // �r�f�I�t�H���_
                    parent = System.Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

                    break;
                case 5:
                    // �s�N�`���[�t�H���_
                    parent = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                    break;
                case 6:
                    // �~���[�W�b�N�t�H���_
                    parent = System.Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

                    break;
                case 7:
                    // �f�X�N�g�b�v�t�H���_
                    parent = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    break;
                default:
                    throw new Exception("�s���ȏo�͐�ł��B");
            }
            int cnt = 1;
            String ofile = $"{parent}\\{baseName}{extension}";

            if (!Directory.Exists($"{parent}"))
            {
                throw new Exception("�o�͐�̃t�H���_�����݂��܂���B");
            }

            // ���O�����ꍇ�́A_n�����ĉ��
            if (File.Exists(ofile)) {
                while(File.Exists(ofile))
                {
                    ofile = $"{parent}\\{baseName}_{cnt}{extension}";
                    cnt++;
                }
            }

            rcode.outputCommand = ofile;
            rcode.parent = parent;
            rcode.baseName = baseName;
            rcode.extension = extension;

            ffmCmd += $" \"{ofile}\"";

            rcode.allCommand = ffmCmd;

            return rcode;
        }

        /// <summary>
        /// �V���b�g�_�E���E�X���[�v�܂��͋x�~��Ԃ����s����
        /// </summary>
        /// <param name="isSleep">true�ɂ���ƃX���[�v�܂��͋x�~��Ԃֈڍs</param>
        private void shutdown (Boolean isSleep)
        {
            ProcessStartInfo psi;
            if (isSleep)
            {
                // �x�~��ԁE�X���[�v
                psi = new ProcessStartInfo("rundll32.exe", "PowrProf.dll,SetSuspendState");
            }
            else
            {
                // �V���b�g�_�E��
                psi = new ProcessStartInfo("shutdown", "/s /t 60 /hybrid /c \"FFMAssist�̏o�͊����㏈���Ŏ����V���b�g�_�E��\"");
            }

            try
            {
                // �I���v���Z�X
                Process? process = Process.Start(psi);
                if (process != null)
                {
                    process.WaitForExit();
                    process.Close();
                }
                else
                {
                    throw new Exception("FFMpeg�̃V���b�g�_�E�����ɃG���[���������܂����B");
                }

                // �V���b�g�_�E���V�[�P���X�̉��
                if (isSleep)
                {
                    return;
                }
                else
                {
                    MessageBox.Show(this, "�o�͊�����̏����Ƃ��āA60�b��Ɏ����I�ɃV���b�g�_�E�����s���܂��B\n�uOK�v�������ƃV���b�g�_�E�����������܂��B", "FFMAssist �I���㏈��", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                psi = new ProcessStartInfo("shutdown", "/a");
                process = Process.Start(psi);
                if (process != null)
                {
                    process.WaitForExit();
                    process.Close();
                }
                else
                {
                    throw new Exception("FFMpeg�̏o�͊�����̏�����𒆂ɃG���[���������܂����B");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "FFMAssistant �G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// �t�@�C�����J���ۂɎg�p����ėp���\�b�h
        /// </summary>
        /// <returns></returns>
        private String choseFile()
        {
            //�_�C�A���O��\������
            if (this.fdialog.ShowDialog() == DialogResult.OK)
            {
                return this.fdialog.FileName;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// �t�@�C����ۑ�����ۂɎg�p����ėp���\�b�h
        /// </summary>
        /// <returns></returns>
        private String saveFile()
        {
            //�_�C�A���O��\������
            if (this.sdialog.ShowDialog() == DialogResult.OK)
            {
                return this.sdialog.FileName;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// �o�̓{�^�����������Ƃ��Ɏ��s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutputButton_Click(object sender, EventArgs e)
        {
            try
            {
                String ffmparams = this.getFFmpegCmd(this.FrameInt.SelectedIndex == Common.YES, this.Blur.SelectedIndex == Common.YES).allCommand;

                ffmparams = $"/c \"{ffmparams.Replace("\n", " ")}\"";
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", ffmparams);

                Debug.WriteLine(ffmparams);

                Process? process = Process.Start(psi);
                if (process != null)
                {
                    process.WaitForExit();
                    process.Close();

                } else
                {
                    throw new Exception("FFMpeg�̃v���Z�X���ɃG���[���������܂����B");
                }

                // �V���b�g�_�E��
                switch (this.EndProcess.SelectedIndex)
                {
                    case 0:
                        break;

                    case 1:
                        // �x�~���
                        this.shutdown(true);
                        break;

                    case 2:
                        // �V���b�g�_�E��
                        this.shutdown(false);
                        break;
                }

            } catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "FFMAssistant �G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// �v���r���[�{�^�����������Ƃ��Ɏ��s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                FFMpegCommand ffmCmd = this.getFFmpegCmd(this.FilterPreview.Checked && this.FrameInt.SelectedIndex == Common.YES, this.FilterPreview.Checked && this.Blur.SelectedIndex == Common.YES);
                String ffmparams = $"/c \"{ffmCmd.inputCommand.Replace("\n", " ")} -f matroska - | \"{this.settingsParams.ffmpegPath}\\ffplay.exe\" -i -\"";

                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", ffmparams);

                Debug.WriteLine(ffmparams);

                Process? process = Process.Start(psi);
                if (process != null)
                {
                    process.WaitForExit();
                    process.Close();

                }
                else
                {
                    throw new Exception("FFMpeg�܂���FFPlay�̃v���Z�X���ɃG���[���������܂����B");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "FFMAssistant �G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// ���̓t�@�C��1 �J���{�^�����������Ƃ��Ɏ��s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IFile1Open_Click(object sender, EventArgs e)
        {
            String path = this.choseFile();
            if (path != "")
            {
                IFile1.Text = path;
            }
        }

        /// <summary>
        /// ���̓t�@�C��2 �J���{�^�����������Ƃ��Ɏ��s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IFile2Open_Click(object sender, EventArgs e)
        {
            String path = this.choseFile();
            if (path != "")
            {
                IFile2.Text = path;
            }
        }

        /// <summary>
        /// �o�̓t�@�C�� �J���{�^�����������Ƃ��Ɏ��s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OFileOpen_Click(object sender, EventArgs e)
        {
            String path = this.saveFile();
            if (path != "")
            {
                OFile.Text = path;
            }
        }
        /// <summary>
        /// �t�B���^�[�ݒ�{�^�����������Ƃ��Ɏ��s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FilterSettings_Click(object sender, EventArgs e)
        {
            // �t�B���^�p�����[�^��n��
            FilterSettings filterSettings = new FilterSettings(this.mainParams.fiParams, this.mainParams.bParams);
            
            // �����I�ɕ\��
            filterSettings.ShowDialog();

            // �t�B���^�p�����[�^���󂯎��
            this.mainParams.fiParams = filterSettings.fiParams;
            this.mainParams.bParams = filterSettings.bParams;
        }

        /// <summary>
        /// �X�e�[�g�Z�[�u �ۑ��{�^�����������Ƃ��Ɏ��s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StateSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.StateSave.Text == "[Default]")
                {
                    throw new Exception("'[Default]'�͕ύX�ł��܂���B");
                }

                // �p�����[�^���t�H�[������擾
                this.setParams();

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    // �G���R�[�h�ݒ�
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    // �C���f���g��t����
                    WriteIndented = true
                };

                // �p�����[�^�t�H���_���Ȃ��Ȃ�쐬����
                string jsonParams = JsonSerializer.Serialize<MainParams>(this.mainParams, options);

                // �ۑ��ꏊ�̌���
                string savePath = AppDomain.CurrentDomain.BaseDirectory + "\\" + Main.paramsPath + this.StateSave.Text + ".json";
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\" + Main.paramsPath))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\" + Main.paramsPath);
                }

                // JSON�ۑ�
                File.WriteAllText(savePath, jsonParams);

                MessageBox.Show(this, $"�p�����[�^�X�e�[�g��'{savePath}'�ɕۑ����܂����B\n");

                this.loadStateList();
            } catch(Exception ex)
            {
                MessageBox.Show(this, "�p�����[�^�X�e�[�g�̕ۑ��Ɏ��s���܂����B\n" + ex.Message, "�X�e�[�g�ۑ��G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// �X�e�[�g�Z�[�u �ďo�{�^�����������Ƃ��Ɏ��s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StateCallButton_Click(object sender, EventArgs e)
        {
            try
            {
                string loadPath = AppDomain.CurrentDomain.BaseDirectory + "\\" + Main.paramsPath + this.StateSave.Text + ".json";
                if (this.StateSave.Text == "[Default]") {
                    this.mainParams = new MainParams();
                }
                else if (File.Exists(loadPath))
                {
                    StreamReader sr = new System.IO.StreamReader(loadPath, System.Text.Encoding.UTF8);
                    string jsonParams = sr.ReadToEnd();
                    sr.Close();

                    MainParams? tmp = JsonSerializer.Deserialize<MainParams>(jsonParams);
                    if (tmp == null)
                    {
                        throw new Exception("JSON�̃p�[�X�Ɏ��s���܂���");
                    }
                    else
                    {
                        this.mainParams = tmp;
                    }
                } else
                {
                    throw new Exception("�Ώۂ̃X�e�[�g������܂���");
                }

                this.getParams();
                MessageBox.Show(this, $"�p�����[�^�X�e�[�g��ǂݍ��݂܂����B\n");
            } catch(Exception ex)
            {
                MessageBox.Show(this, "�p�����[�^�X�e�[�g�̓Ǎ��݂Ɏ��s���܂����B\n" + ex.Message, "�X�e�[�g�Ǎ��G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// �X�e�[�g�Z�[�u �폜�{�^�����������Ƃ��Ɏ��s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StateDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string loadPath = AppDomain.CurrentDomain.BaseDirectory + "\\" + Main.paramsPath + this.StateSave.Text + ".json";
                if (this.StateSave.Text == "[Default]")
                {
                    throw new Exception("'[Default]'�͍폜�ł��܂���B");
                }
                else if (File.Exists(loadPath))
                {
                    File.Delete(loadPath);
                }
                else
                {
                    throw new Exception("�Ώۂ̃X�e�[�g������܂���");
                }

                // ���X�g�̍X�V
                this.loadStateList();
                this.StateSave.Text = "[Default]";
                MessageBox.Show(this, $"�p�����[�^�X�e�[�g���폜���܂����B\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "�p�����[�^�X�e�[�g�̍폜�Ɏ��s���܂����B\n" + ex.Message, "�X�e�[�g�폜�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// �ݒ�{�^�����������Ƃ��Ɏ��s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            // �p�����[�^��n��
            Settings settings = new Settings(this.settingsParams);

            // �����I�ɕ\��
            settings.ShowDialog();

            // �t�B���^�p�����[�^���󂯎��
            this.settingsParams = settings.settingsParams;

            // �ݒ����ۑ�
            this.saveSettings();

            // ���X�g�̍X�V
            this.updateList();

        }

        /// <summary>
        ///  �J�n���Ԃ̏����_��������t�H�[�J�X�����ꂽ���Ɏ��s����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Beginfff_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Common.isNumeric(Beginfff.Text, true, true))
                {
                    double val;
                    Double.TryParse(Beginfff.Text, out val);
                    Beginfff.Text = val.ToString("000");
                }
            }
            catch
            {

            }
        }

        /// <summary>
        ///  �I�����Ԃ̏����_��������t�H�[�J�X�����ꂽ���Ɏ��s����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Endfff_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Common.isNumeric(Endfff.Text, true, true))
                {
                    double val;
                    Double.TryParse(Endfff.Text, out val);
                    Endfff.Text = val.ToString("000");
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// FFmpeg�����s���邽�߂̃R�}���h��ێ���������N���X
        /// </summary>
        private class FFMpegCommand
        {
            public string allCommand = "";
            public string inputCommand = "";
            public string outputCommand = "";
            public string parent = "";
            public string baseName = "";
            public string extension = "";
        }
    }
}