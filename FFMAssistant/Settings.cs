using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFMAssistant
{
    public partial class Settings : Form
    {
        public SettingsParams settingsParams = new SettingsParams();

        public Settings(SettingsParams settingsParams)
        {
            InitializeComponent();
            this.settingsParams = settingsParams;
            this.getParams();
        }


        /// <summary>
        /// フォームの値を、設定データに反映
        /// </summary>
        private void setParams()
        {
            this.settingsParams.ffmpegPath = FFmpegPath.Text;
            this.settingsParams.defaultOutput = DefaultOutput.Text;
            this.settingsParams.vCodecList = VCodecList.Text;
            this.settingsParams.aCodecList = ACodecList.Text;
            this.settingsParams.extensionList = ExtensionList.Text;
        }

        /// <summary>
        /// 設定データの値を、フォームに反映
        /// </summary>
        private void getParams()
        {
            FFmpegPath.Text = this.settingsParams.ffmpegPath;
            DefaultOutput.Text = this.settingsParams.defaultOutput;
            VCodecList.Text = this.settingsParams.vCodecList;
            ACodecList.Text = this.settingsParams.aCodecList;
            ExtensionList.Text = this.settingsParams.extensionList;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.setParams();
        }
    }
}
