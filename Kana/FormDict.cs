using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Kana.Properties;

namespace Kana;

public partial class FormDict : Form
{
    protected const string HiraganaType = "hiragana";
    protected const string KatakanaType = "katakana";
    protected const string Sharp = "#";
    protected const string TranslationRegExp = @"(.*)\((.+)\)";
    protected const char RomaSplitter = '/';

    protected Dictionary<string, (string, string)> KanasToRomasDict = [];
    protected Dictionary<string, string> RomasToHiraganasDict = [];
    protected Dictionary<string, string> RomasToKatakanasDict = [];

    public FormDict()
    {
        InitializeComponent();
    }
    private void FormDict_Load(object sender, EventArgs e)
    {
        this.LoadTranslations();

        this.textBoxRoma.Text = "a";
    }

    protected virtual void LoadTranslations()
    {
        var reg = new Regex(TranslationRegExp);

        using var reader = new StringReader(Resources.Kana);
        var type = HiraganaType;
        var line = "";
        while ((line = reader.ReadLine()) != null)
        {
            line = line.Trim();

            if (line.Length == 0)
            {
                continue;
            }
            else if (line.StartsWith(Sharp))
            {
                //#hiragana
                //#katakana
                type = line.Substring(Sharp.Length).Trim();
                continue;
            }
            else
            {
                var parts = reg.Split(line);

                if (parts != null && parts.Length == 4 && parts[0] == string.Empty && parts[parts.Length - 1] == string.Empty)
                {
                    var kana = parts[1];
                    var roma = parts[2];
                    var roma1 = roma;
                    var roma2 = string.Empty;

                    if (roma.Contains(RomaSplitter))
                    {
                        var rs = roma.Split(RomaSplitter);
                        if (rs != null && rs.Length == 2)
                        {
                            roma1 = rs[0];
                            roma2 = rs[1];
                        }
                    }
                    if (!string.IsNullOrEmpty(kana))
                    {
                        this.KanasToRomasDict[kana] = (roma1, roma2);
                    }

                    if (!string.IsNullOrEmpty(roma))
                    {
                        if (type == HiraganaType)
                        {
                            this.RomasToHiraganasDict[roma1] = kana;
                            if (!string.IsNullOrEmpty(roma2))
                            {
                                this.RomasToHiraganasDict[roma2] = kana;
                            }
                        }
                        else if (type == KatakanaType)
                        {
                            this.RomasToKatakanasDict[roma1] = kana;
                            if (!string.IsNullOrEmpty(roma2))
                            {
                                this.RomasToKatakanasDict[roma2] = kana;
                            }
                        }
                    }
                }
            }
        }
    }

    private void TextBoxKana_TextChanged(object sender, EventArgs e)
    {
        this.textBoxRoma.Text = this.KanaToRoma(this.textBoxKana.Text);
    }

    protected virtual string KanaToRoma(string kanas)
    {
        List<string> romas = [];

        if (!string.IsNullOrEmpty(kanas))
        {
            for (int i = 0; i < kanas.Length; i++)
            {
                var kana = kanas.Substring(i, (i < kanas.Length - 1) ? 2 : 1);

                if (this.KanasToRomasDict.TryGetValue(kana, out (string roma1, string roma2) roma))
                {
                    romas.Add(roma.roma1);
                    i++;
                }
                else if (this.KanasToRomasDict.TryGetValue(kana.Substring(0, 1), out roma))
                {
                    romas.Add(roma.roma1);
                }
            }
        }
        return string.Join(" ", romas);
    }
    private void TextBoxRoma_TextChanged(object sender, EventArgs e)
    {
        this.textBoxKana.TextChanged -= this.TextBoxKana_TextChanged;

        this.textBoxKana.Text = this.RomaToKana(this.textBoxRoma.Text, this.checkBoxKatakana.Checked);

        this.textBoxKana.TextChanged += this.TextBoxKana_TextChanged;
    }

    protected virtual string RomaToKana(string roma, bool katakana)
    {
        var parts = (roma ?? string.Empty).Split(' ');

        if (parts != null && parts.Length > 0)
        {
            var kanas = new StringBuilder();

            foreach (var part in parts)
            {
                if (katakana)
                {
                    if (this.RomasToKatakanasDict.TryGetValue(part, out var kana))
                    {
                        kanas.Append(kana);
                    }
                }
                else
                {
                    if (this.RomasToHiraganasDict.TryGetValue(part, out var kana))
                    {
                        kanas.Append(kana);
                    }
                }
            }
            return kanas.ToString();
        }
        return string.Empty;
    }
    private void ButtonCopyKana_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(this.textBoxKana.Text);
    }

    private void ButtonPasteKana_Click(object sender, EventArgs e)
    {
        this.textBoxKana.Text = Clipboard.GetText();
    }

    private void ButtonCopyRoma_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(this.textBoxRoma.Text);
    }

    private void ButtonPasteRoma_Click(object sender, EventArgs e)
    {
        this.textBoxRoma.Text = Clipboard.GetText();
    }

    private void CheckBoxKatakana_CheckedChanged(object sender, EventArgs e)
    {
        this.textBoxKana.Text = this.RomaToKana(this.textBoxRoma.Text, this.checkBoxKatakana.Checked);
    }
}
