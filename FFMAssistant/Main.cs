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
            this.fdialog.Filter = "すべてのファイル(*.*)|*.*";
            this.fdialog.Title = "入力ファイルを選択してください";

            this.sdialog.FileName = "";
            this.sdialog.Filter = "すべてのファイル(*.*)|*.*";
            this.sdialog.Title = "出力先を決定してください";

            // 設定読み込み
            this.loadSettings();
            this.updateList();

            // ステートリス読込み
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
                    MessageBox.Show(this, "設定ファイルの読込みに失敗しました。");
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
                    // エンコード設定
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    // インデントを付ける
                    WriteIndented = true
                };

                // パラメータフォルダがないなら作成する
                string jsonParams = JsonSerializer.Serialize<SettingsParams>(this.settingsParams, options);

                // 保存場所の決定
                string savePath = Directory.GetCurrentDirectory() + "\\" + Main.settingsFileName;

                // JSON保存
                File.WriteAllText(savePath, jsonParams);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "設定の保存に失敗しました。\n" + ex.Message, "設定保存エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateList()
        {
            // リストのクリア
            VCodec.Items.Clear();
            ACodec.Items.Clear();
            Extension.Items.Clear();

            // 設定からリストを更新
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
                    // 指定なし
                    BeginTime.Enabled = false;
                    Beginfff.Enabled = false;
                    EndTime.Enabled = false;
                    Endfff.Enabled = false;
                    break;
                case 1:
                    // 開始指定
                    BeginTime.Enabled = true;
                    Beginfff.Enabled = true;
                    EndTime.Enabled = false;
                    Endfff.Enabled = false;
                    break;
                case 2:
                    // 終了指定
                    BeginTime.Enabled = false;
                    Beginfff.Enabled = false;
                    EndTime.Enabled = true;
                    Endfff.Enabled = true;

                    break;
                case 3:
                    // 両端指定
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
            // ステートリストのアイテムのクリア
            this.StateSave.Items.Clear();
            this.StateSave.Items.Add("[Default]");

            string directory = Directory.GetCurrentDirectory() + "\\" + Main.paramsPath;
            string[] files = Directory.GetFiles(directory);
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".json")
                {
                    // 拡張子を除いたファイル名を追加
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
                throw new Exception("ffmpeg.exeが存在しません");
            }

            // 開始時間と終了時間の指定 =============================================================
            // -iより先に記述すると早くなるとか
            int beginTime = BeginTime.Value.Hour * 3600 + BeginTime.Value.Minute * 60 + BeginTime.Value.Second;

            if (AdjustTime.SelectedIndex == 1 || AdjustTime.SelectedIndex == 3)
            {
                if (!Common.isNumeric(Beginfff.Text, true, true) || Beginfff.Text.Length != 3)
                {
                    throw new Exception("開始時間の小数点部分が異常です。");
                }
            }

            if (AdjustTime.SelectedIndex == 2 || AdjustTime.SelectedIndex == 3)
            {
                if (!Common.isNumeric(Endfff.Text, true, true) || Endfff.Text.Length != 3)
                {
                    throw new Exception("終了時間の小数点部分が異常です。");
                }
            }

            switch (AdjustTime.SelectedIndex)
            {
                case 0:
                    // 指定なし

                    break;
                case 1:
                    // 開始時間のみ指定
                    ffmCmd += $" -ss {beginTime}.{Beginfff.Text}";
                    break;
                case 2:
                    // 終了時間のみ指定
                    ffmCmd += $" -to {EndTime.Value.ToString("HH:mm:ss")}.{Endfff.Text}";
                    break;
                case 3:
                    // 両端指定
                    ffmCmd += $" -ss {beginTime}.{Beginfff.Text}";
                    ffmCmd += $" -to {EndTime.Value.ToString("HH:mm:ss")}.{Endfff.Text}";

                    break;
                default:
                    // そのほか
                    throw new Exception("時間調整の方式が異常です。");
            }

            // 入力ファイル1 =============================================================
            if (File.Exists(IFile1.Text))
            {
                ffmCmd += $" -i \"{IFile1.Text}\"";
            }
            else
            {
                throw new Exception("入力ファイル1が存在しません");
            }

            // 入力ファイル2 =============================================================
            // 未入力であれば省略する
            if (IFile2.Text != "")
            {
                if (File.Exists(IFile2.Text))
                {
                    ffmCmd += $" -i \"{IFile2.Text}\"";
                }
                else
                {
                    throw new Exception("入力ファイル2が存在しません");
                }
            }

            // 動画コーデック =============================================================
            if (VCodec.Text != "")
            {
                ffmCmd += $" -c:v {VCodec.Text}";
            }

            // 音声コーデック =============================================================
            if (ACodec.Text != "")
            {
                ffmCmd += $" -c:a {ACodec.Text}";
            }

            // 画質 =============================================================
            if (BorQValue.Text == "")
            {
                // 画質が未入力なら、品質22で実行
                ffmCmd += " -q:v 22";
            }
            else
            {
                // 数値チェック
                if (Common.isNumeric(BorQValue.Text, false, true))
                {
                    // 画質方式によって分ける
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
                            // 品質
                            ffmCmd += $" -q:v {BorQValue.Text}";
                            break;
                    }
                }
                else
                {
                    throw new Exception("画質の値が異常です。");
                }
            }

            // フレームレート =============================================================
            if (Framerate.Text != "")
            {
                ffmCmd += $" -r:v {Framerate.Text}";
            }

            // 音質 =============================================================
            if (ABitRate.Text != "")
            {
                if (Common.isNumeric(ABitRate.Text, true, true)) {
                    ffmCmd += $" -b:a {ABitRate.Text}k";
                }
                else
                {
                    throw new Exception("音質が異常な値です。");
                }
            }

            // サンプリング周波数 =============================================================
            if (ASampling.Text != "")
            {
                if (Common.isNumeric(ASampling.Text, true, true))
                {
                    ffmCmd += $" -r:a {ASampling.Text}";
                } else
                {
                    throw new Exception("サンプリング周波数が異常な値です。");
                }
            }

            // 追加オプション =============================================================
            ffmCmd += " " + Option.Text;

            // 拡張子のチェック
            if (Extension.Text == "")
            {
                throw new Exception("拡張子は必須です。");
            }

            // フィルタ設定 ===========================================
            if (isFrameInt || isBlur)
            {
                ffmCmd += " -vf ";
            }

            if (isFrameInt)
            {   // meのみ、「1」ずれてるため足し算する
                ffmCmd += $"minterpolate={this.mainParams.fiParams.fps}:{this.mainParams.fiParams.mi_mode}:{this.mainParams.fiParams.mc_mode}:{this.mainParams.fiParams.me_mode}:{this.mainParams.fiParams.me + 1}:{this.mainParams.fiParams.mb_size}:{this.mainParams.fiParams.search_param}:{this.mainParams.fiParams.vsbmc}:{this.mainParams.fiParams.scd}:{this.mainParams.fiParams.scd_threshold}";
            }

            if (isFrameInt && isBlur)
            {
                ffmCmd += ";";
            }

            if (isBlur)
            {
                ffmCmd += $"atadenoise={this.mainParams.bParams.primaryA}:{this.mainParams.bParams.primaryB}:{this.mainParams.bParams.secondaryA}:{this.mainParams.bParams.secondaryB}:{this.mainParams.bParams.tertiaryA}:{this.mainParams.bParams.tertiaryB}:{this.mainParams.bParams.blurFrame}:{this.mainParams.bParams.blurChannel}:{this.mainParams.bParams.blurMode}";
                // 使用不可→ :{this.settingsParams.bParams.primaryS}:{this.settingsParams.bParams.secondaryS}:{this.settingsParams.bParams.tertiaryS}
            }

            rcode.inputCommand = ffmCmd;

            // ファイル出力 ===========================================
            string parent = "";
            string baseName = Path.GetFileNameWithoutExtension(IFile1.Text);
            string extension = $".{Extension.Text}";
            string? tmp;

            switch (OutputPlace.SelectedIndex)
            {
                case 0:
                    // 指定場所
                    tmp = Path.GetDirectoryName(OFile.Text);
                    if (tmp == null)
                    {
                        throw new Exception("出力先パスが不正です。");
                    }
                    else
                    {
                        parent = tmp;
                    }
                    baseName = Path.GetFileNameWithoutExtension(OFile.Text);
                    extension = Path.GetExtension(OFile.Text);

                    // 指定した拡張子と異なる場合には、指定した拡張子をbaseName後方につける
                    if ($".{Extension.Text}" != $"{extension}") {
                        baseName += extension;
                        extension = $".{Extension.Text}";
                    }

                    break;
                case 1:
                    // 既定のフォルダ
                    parent = this.settingsParams.defaultOutput;
                    break;
                case 2:
                    // 入力ファイル1と同じ
                    tmp = Path.GetDirectoryName(IFile1.Text);
                    if (tmp == null)
                    {
                        throw new Exception("出力先パスが不正です。");
                    }
                    else
                    {
                        parent = tmp;
                    }

                    break;
                case 3:
                    //ドキュメントフォルダ
                    parent = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    break;
                case 4:
                    // ビデオフォルダ
                    parent = System.Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

                    break;
                case 5:
                    // ピクチャーフォルダ
                    parent = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                    break;
                case 6:
                    // ミュージックフォルダ
                    parent = System.Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

                    break;
                case 7:
                    // デスクトップフォルダ
                    parent = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    break;
                default:
                    throw new Exception("不明な出力先です。");
            }
            int cnt = 1;
            String ofile = $"{parent}\\{baseName}{extension}";

            if (!Directory.Exists($"{parent}"))
            {
                throw new Exception("出力先のフォルダが存在しません。");
            }

            // 名前が被る場合は、_nをつけて回避
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
                    throw new Exception("FFMpegのプロセス中にエラーが発生しました。");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "FFMAssistant エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    throw new Exception("FFMpegまたはFFPlayのプロセス中にエラーが発生しました。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "FFMAssistant エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // フィルタパラメータを渡す
            FilterSettings filterSettings = new FilterSettings(this.mainParams.fiParams, this.mainParams.bParams);
            
            // 同期的に表示
            filterSettings.ShowDialog();

            // フィルタパラメータを受け取る
            this.mainParams.fiParams = filterSettings.fiParams;
            this.mainParams.bParams = filterSettings.bParams;
        }

        private void StateSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.StateSave.Text == "[Default]")
                {
                    throw new Exception("'[Default]'は変更できません。");
                }

                // パラメータをフォームから取得
                this.setParams();

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    // エンコード設定
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    // インデントを付ける
                    WriteIndented = true
                };

                // パラメータフォルダがないなら作成する
                string jsonParams = JsonSerializer.Serialize<MainParams>(this.mainParams, options);

                // 保存場所の決定
                string savePath = Directory.GetCurrentDirectory() + "\\" + Main.paramsPath + this.StateSave.Text + ".json";
                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + Main.paramsPath))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + Main.paramsPath);
                }

                // JSON保存
                File.WriteAllText(savePath, jsonParams);

                MessageBox.Show(this, $"パラメータステートを'{savePath}'に保存しました。\n");

                this.loadStateList();
            } catch(Exception ex)
            {
                MessageBox.Show(this, "パラメータステートの保存に失敗しました。\n" + ex.Message, "ステート保存エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        throw new Exception("JSONのパースに失敗しました");
                    }
                    else
                    {
                        this.mainParams = tmp;
                    }
                } else
                {
                    throw new Exception("対象のステートがありません");
                }

                this.getParams();
                MessageBox.Show(this, $"パラメータステートを読み込みました。\n");
            } catch(Exception ex)
            {
                MessageBox.Show(this, "パラメータステートの読込みに失敗しました。\n" + ex.Message, "ステート読込エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StateDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string loadPath = Directory.GetCurrentDirectory() + "\\" + Main.paramsPath + this.StateSave.Text + ".json";
                if (this.StateSave.Text == "[Default]")
                {
                    throw new Exception("'[Default]'は削除できません。");
                }
                else if (File.Exists(loadPath))
                {
                    File.Delete(loadPath);
                }
                else
                {
                    throw new Exception("対象のステートがありません");
                }

                // リストの更新
                this.loadStateList();
                this.StateSave.Text = "[Default]";
                MessageBox.Show(this, $"パラメータステートを削除しました。\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "パラメータステートの削除に失敗しました。\n" + ex.Message, "ステート削除エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            // パラメータを渡す
            Settings settings = new Settings(this.settingsParams);

            // 同期的に表示
            settings.ShowDialog();

            // フィルタパラメータを受け取る
            this.settingsParams = settings.settingsParams;

            // 設定情報を保存
            this.saveSettings();

            // リストの更新
            this.updateList();

        }

        private String choseFile()
        {
            //ダイアログを表示する
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
            //ダイアログを表示する
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