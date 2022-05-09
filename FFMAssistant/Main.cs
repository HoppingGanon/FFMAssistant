using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace FFMAssistant
{
    public partial class Main : Form
    {
        const String paramsPath = "params\\";
        const String settingsFileName = "settings.json";

        OpenFileDialog fdialog = new OpenFileDialog();
        SaveFileDialog sdialog = new SaveFileDialog();
        public SettingsParams settingsParams = new SettingsParams();
        public MainParams mainParams = new MainParams();

        public Main()
        {
            InitializeComponent();

            this.getParams();
            this.controlInput();

            this.fdialog.FileName = "";
            this.fdialog.Filter = "���ׂẴt�@�C��(*.*)|*.*";
            this.fdialog.Title = "���̓t�@�C����I�����Ă�������";

            this.sdialog.FileName = "";
            this.sdialog.Filter = "���ׂẴt�@�C��(*.*)|*.*";
            this.sdialog.Title = "�o�͐�����肵�Ă�������";

            // �ݒ�ǂݍ���
            this.loadSettings();
            this.updateList();

            // �X�e�[�g���X�Ǎ���
            this.loadStateList();

        }

        private void loadSettings()
        {
            String jsonPath = Directory.GetCurrentDirectory() + "\\" + Main.settingsFileName;
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
                string savePath = Directory.GetCurrentDirectory() + "\\" + Main.settingsFileName;

                // JSON�ۑ�
                File.WriteAllText(savePath, jsonParams);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "�ݒ�̕ۑ��Ɏ��s���܂����B\n" + ex.Message, "�ݒ�ۑ��G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void controlInput(object sender, EventArgs e)
        {
            this.controlInput();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadStateList ()
        {
            // �X�e�[�g���X�g�̃A�C�e���̃N���A
            this.StateSave.Items.Clear();
            this.StateSave.Items.Add("[Default]");

            string directory = Directory.GetCurrentDirectory() + "\\" + Main.paramsPath;
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
            } catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "FFMAssistant �G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void IFile1Open_Click(object sender, EventArgs e)
        {
            String path = this.choseFile();
            if (path != "")
            {
                IFile1.Text = path;
            }
        }

        private void IFile2Open_Click(object sender, EventArgs e)
        {
            String path = this.choseFile();
            if (path != "")
            {
                IFile2.Text = path;
            }
        }

        private void OFileOpen_Click(object sender, EventArgs e)
        {
            String path = this.saveFile();
            if (path != "")
            {
                OFile.Text = path;
            }
        }

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
                string savePath = Directory.GetCurrentDirectory() + "\\" + Main.paramsPath + this.StateSave.Text + ".json";
                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + Main.paramsPath))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + Main.paramsPath);
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

        private void StateCallButton_Click(object sender, EventArgs e)
        {
            try
            {
                string loadPath = Directory.GetCurrentDirectory() + "\\" + Main.paramsPath + this.StateSave.Text + ".json";
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

        private void StateDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string loadPath = Directory.GetCurrentDirectory() + "\\" + Main.paramsPath + this.StateSave.Text + ".json";
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

        private class FFMpegCommand
        {
            public string allCommand = "";
            public string inputCommand = "";
            public string outputCommand = "";
            public string parent = "";
            public string baseName = "";
            public string extension = "";
        }

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
    }
}