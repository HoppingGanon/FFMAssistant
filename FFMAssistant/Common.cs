using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFMAssistant
{
    /// <summary>
    /// 全体で使用する情報を持つクラス
    /// </summary>
    public class Common
    {
        public const int YES = 0;
        public const int NO = 1;

        public static Boolean isNumeric(String val, Boolean isInt, Boolean isPositive)
        {
            double dummy;
            Boolean rev = Double.TryParse(val, out dummy);
            if (isInt) { rev = rev && !val.Contains("."); }
            if (isPositive) { rev = rev && dummy >= 0; }

            return rev;
        }
    }

    /// <summary>
    /// フレーム補間の設定情報
    /// </summary>
    public class FrameIntParams
    {
        public String fps { get; set; } = "60";
        public int mi_mode { get; set; } = 2;
        public int mc_mode { get; set; } = 0;
        public int me_mode { get; set; } = 1;
        public int me { get; set; } = 7;
        public String mb_size { get; set; } = "16";
        public String search_param { get; set; } = "32";
        public String vsbmc { get; set; } = "0";
        public int scd { get; set; } = 1;
        public String scd_threshold { get; set; } = "5";
    }

    /// <summary>
    /// モーションブラーの設定情報
    /// </summary>
    public class BlurParams
    {
        public String primaryA { get; set; } = "0.02";
        public String primaryB { get; set; } = "0.04";
        public String secondaryA { get; set; } = "0.02";
        public String secondaryB { get; set; } = "0.04";
        public String tertiaryA { get; set; } = "0.02";
        public String tertiaryB { get; set; } = "0.04";
        public String blurFrame { get; set; } = "9";
        public String blurChannel { get; set; } = "15";
        public int blurMode { get; set; } = 0;
        public String primaryS { get; set; } = "32767";
        public String secondaryS { get; set; } = "32767";
        public String tertiaryS { get; set; } = "32767";
    }

    /// <summary>
    /// メインの設定情報
    /// </summary>
    public class MainParams
    {
        public String iFile1 { get; set; } = "";
        public String iFile2 { get; set; } = "";
        public String oFile { get; set; } = "";
        public DateTime beginTime { get; set; } = DateTime.Parse("1970/01/01 0:00:00");
        public String beginfff { get; set; } = "000";
        public DateTime endTime { get; set; } = DateTime.Parse("1970/01/01 0:00:00");
        public String endfff { get; set; } = "000";
        public String vCodec { get; set; } = "libx264";
        public String aCodec { get; set; } = "aac";
        public String framerate { get; set; } = "60";
        public String borQValue { get; set; } = "22";
        public int borQ { get; set; } = 2;
        public String aBitRate { get; set; } = "160";
        public String aSampling { get; set; } = "48000";
        public String option { get; set; } = "";
        public int outputPlace { get; set; } = 2;
        public String extension { get; set; } = "mp4";
        public int adjustTime { get; set; } = 0;
        public int blur { get; set; } = Common.NO;
        public int frameInt { get; set; } = Common.NO;
        public Boolean filterPreview { get; set; } = false;

        public FrameIntParams fiParams { get; set; } = new FrameIntParams();
        public BlurParams bParams { get; set; } = new BlurParams();
    }

    /// <summary>
    /// システムの設定情報
    /// </summary>
    public class SettingsParams
    {
        public String ffmpegPath { get; set; } = "C:\\Tools\\FFMPEG";
        public String defaultOutput { get; set; } = "C:\\Temp";
        public String vCodecList { get; set; } = "";
        public String aCodecList { get; set; } = "";
        public String extensionList { get; set; } = "";
    }
}
