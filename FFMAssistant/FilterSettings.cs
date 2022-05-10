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
    public partial class FilterSettings : Form
    {
        public FrameIntParams fiParams = new FrameIntParams();
        public BlurParams bParams = new BlurParams();


        public FilterSettings()
        {
            InitializeComponent();
            this.getFrameInterpolation();
            this.getBlur();
        }

        /// <summary>
        /// フィルター設定のデータを親画面から受け取り、初期化する
        /// </summary>
        /// <param name="fiParams"></param>
        /// <param name="bParams"></param>
        public FilterSettings(FrameIntParams fiParams, BlurParams bParams)
        {
            InitializeComponent();
            this.fiParams = fiParams;
            this.bParams = bParams;
            this.getFrameInterpolation();
            this.getBlur();
        }

        /// <summary>
        /// フレーム補間の設定値をすべて既定に戻す
        /// </summary>
        private void resetFrameInterpolation() {
            this.fiParams = new FrameIntParams();
            this.getFrameInterpolation();
        }


        /// <summary>
        /// フォームの値を、フレーム補間設定データに反映
        /// </summary>
        public void setFrameInterpolation()
        {
            fiParams.fps = fps.Text;
            fiParams.mi_mode = mi_mode.SelectedIndex;
            fiParams.mc_mode = mc_mode.SelectedIndex;
            fiParams.me_mode = me_mode.SelectedIndex;
            fiParams.me = me.SelectedIndex;
            fiParams.mb_size = mb_size.Text;
            fiParams.search_param = search_param.Text;
            fiParams.vsbmc = vsbmc.Text;
            fiParams.scd = scd.SelectedIndex;
            fiParams.scd_threshold = scd_threshold.Text;
        }

        /// <summary>
        /// フレーム補間設定データを、フォームの値に反映
        /// </summary>
        public void getFrameInterpolation()
        {
            fps.Text = fiParams.fps;
            mi_mode.SelectedIndex = fiParams.mi_mode;
            mc_mode.SelectedIndex = fiParams.mc_mode;
            me_mode.SelectedIndex = fiParams.me_mode;
            me.SelectedIndex = fiParams.me;
            mb_size.Text = fiParams.mb_size;
            search_param.Text = fiParams.search_param;
            vsbmc.Text = fiParams.vsbmc;
            scd.SelectedIndex = fiParams.scd;
            scd_threshold.Text = fiParams.scd_threshold;
        }

        /// <summary>
        /// モーションブラーの設定値をすべて既定に戻す
        /// </summary>
        private void resetBlur()
        {
            this.bParams = new BlurParams();
            this.getBlur();
        }

        /// <summary>
        /// フォームの値を、モーションブラー設定データに反映
        /// </summary>
        private void setBlur()
        {
            bParams.primaryA = PrimaryA.Text;
            bParams.primaryB = PrimaryB.Text;
            bParams.secondaryA = SecondaryA.Text;
            bParams.secondaryB = SecondaryB.Text;
            bParams.tertiaryA = TertiaryA.Text;
            bParams.tertiaryB = TertiaryB.Text;
            bParams.blurFrame = BlurFrame.Text;
            bParams.blurChannel = BlurChannel.Text;
            bParams.blurMode = BlurMode.SelectedIndex;
            bParams.primaryS = PrimaryS.Text;
            bParams.secondaryS = SecondaryS.Text;
            bParams.tertiaryS = TertiaryS.Text;
        }

        /// <summary>
        /// モーションブラー設定データを、フォームの値に反映
        /// </summary>
        private void getBlur()
        {
            PrimaryA.Text = bParams.primaryA;
            PrimaryB.Text = bParams.primaryB;
            SecondaryA.Text = bParams.secondaryA;
            SecondaryB.Text = bParams.secondaryB;
            TertiaryA.Text = bParams.tertiaryA;
            TertiaryB.Text = bParams.tertiaryB;
            BlurFrame.Text = bParams.blurFrame;
            BlurChannel.Text = bParams.blurChannel;
            BlurMode.SelectedIndex = bParams.blurMode;
            PrimaryS.Text = bParams.primaryS;
            SecondaryS.Text = bParams.secondaryS;
            TertiaryS.Text = bParams.tertiaryS;
        }

        private void FrameResetButton_Click(object sender, EventArgs e)
        {
            this.resetFrameInterpolation();
        }

        private void BlurResetButton_Click(object sender, EventArgs e)
        {
            this.resetBlur();
        }

        private void FilterSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.setFrameInterpolation();
            this.setBlur();
        }

        // ============================================================================================================================
        // マウスをかざした時に表示するフレーム補間の説明

        const string quote1 = "[引用元] FFmpeg Filters Documentation https://ffmpeg.org/ffmpeg-filters.html#minterpolate";

        private void fpsLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"フレーム補間:
出力フレームレートを指定。[既定値: 60]
";
            Quote.Text = quote1;
        }

        private void mi_modeLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"フレーム補間:
Motion interpolation mode.
モーション補間モード
  dup: 前後フレームの重複部分から、新しいフレームを生成する
  blend: 前後フレームの平均から、新しいフレームを生成する
  mci: モーションから推定した新しいフレームを生成する。[既定値]
";
            Quote.Text = quote1;
        }

        private void mc_modeLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"フレーム補間:
モーション補正モード
  obmc: Overlapped Block Motion Compensation 
    重複モーションブロックからフレーム補間する[既定値]
  aobmc: Adaptive Overlapped Block Motion Compensation
    モーションベクトルから適応的に係数を推定し、フレームを補間する
";
            Quote.Text = quote1;
        }

        private void me_modeLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"フレーム補間:
モーション推定モード
  bidir: 双方向のモーション推定 前後のフレームからモーションを推定する
  bilat: 両側モーション推定 モーションベクトルは補間フレームに対して直接推定する [既定値]
";
            Quote.Text = quote1;
        }

        private void meLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"フレーム補間:
モーション推定のアルゴリズム
  esa: Exhaustive Search Algorithm (処理が一番重いらしい)
  tss: Three Step Search Algorithm
  tdls: Two Dimensional Logarithmic Search Algorithm
  ntss: New Three Step Search Algorithm
  fss: Four Step Search Algorithm
  ds: Diamond Search Algorithm
  hexbs: Hexagon-Based Search Algorithm
  epzs: Enhanced Predictive Zonal Search Algorithm (処理が一番軽いらしい) [既定値]
  umh: Uneven Multi-Hexagon Search Algorithm
";
            Quote.Text = quote1;
        }

        private void mb_sizeLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"フレーム補間:
マクロブロックサイズ[既定値: 16]
  出力解像度の縦および横の約数に合わせる
";
            Quote.Text = quote1;
        }

        private void search_paramLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"フレーム補間:
モーション推定の探索パラメータ[既定値: 32]
";
            Quote.Text = quote1;
        }

        private void vsbmcLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"フレーム補間:
可変サイズのブロックモーション補間[規定値: 0]
  有効にすると、モーション推定はオブジェクトの境界でぼやけにくい、より小さなブロックサイズが適用される
";
            Quote.Text = quote1;
        }

        private void scdLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"フレーム補間:
シーンチェンジ検出モード
  none: 検出しない
  fdiff: フレーム間で対応するピクセル同士を比較し、scd_thresholdの条件を満たすとシーンチェンジが検出される[既定値]
";
            Quote.Text = quote1;
        }

        private void scd_thresholdLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"フレーム補間:
シーンチェンジ検出モードの閾値[規定値: 10]
";
            Quote.Text = quote1;
        }


        // ============================================================================================================================
        // マウスをかざした時に表示するモーションブラーの説明

        const string quote2 = "[引用元] FFmpeg Filters Documentation https://ffmpeg.org/ffmpeg-filters.html#atadenoise";

        private void PrimaryALabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"モーションブラー:
第1チャネルの閾値A[規定値: 0.02]
  範囲は0～0.3
";
            Quote.Text = quote2;
        }

        private void PrimaryBLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"モーションブラー:
第1チャネルの閾値B[規定値: 0.04]
  範囲は0～0.5
";
            Quote.Text = quote2;
        }

        private void SecondaryALabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"モーションブラー:
第2チャネルの閾値A[規定値: 0.02]
  範囲は0～0.3
";
            Quote.Text = quote2;
        }

        private void SecondaryBLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"モーションブラー:
第2チャネルの閾値B[規定値: 0.04]
  範囲は0～0.5
";
            Quote.Text = quote2;
        }

        private void TertiaryALabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"モーションブラー:
第3チャネルの閾値A[規定値: 0.02]
  範囲は0～0.3
";
            Quote.Text = quote2;
        }

        private void TertiaryBLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"モーションブラー:
第3チャネルの閾値B[規定値: 0.04]
  範囲は0～0.5
";
            Quote.Text = quote2;
        }

        private void BlurFrameLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"モーションブラー:
平均化に使用するフレーム数[規定値: 9]
  範囲は5～129で、奇数を指定
";
            Quote.Text = quote2;
        }

        private void BlurChannelLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"モーションブラー:
平面の平均化に使用するチャンネル[規定値: 15]
  範囲は0～15の整数
  2進数'0000'～'1111'のフラグ？
";
            Quote.Text = quote2;
        }

        private void BlurModeLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"モーションブラー:
平均化アルゴリズム
  parallel: serialよりも高速に処理をする 最初の変化が閾値を超える場合は処理を中断する[既定値]
  serial: 反対側のフレームの変化が閾値を超えない場合は、処理が継続される
";
            Quote.Text = quote2;
        }

        private void PrimarySLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"モーションブラー:
第1チャネルのシグマ[規定値: 32767]
  範囲は0〜32767で、0を指定すると無効
";
            Quote.Text = quote2;
        }

        private void SecondarySLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"モーションブラー:
第2チャネルのシグマ[規定値: 32767]
  範囲は0〜32767で、0を指定すると無効
";
            Quote.Text = quote2;
        }

        private void TertiarySLabel_Enter(object sender, EventArgs e)
        {
            hint.Text = @"モーションブラー:
第3チャネルのシグマ[規定値: 32767]
  範囲は0〜32767で、0を指定すると無効
";
            Quote.Text = quote2;
        }
    }
}
