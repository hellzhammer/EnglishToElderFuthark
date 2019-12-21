using System;
using System.Collections.Generic;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    //ᚨᛒᚲᛞᛖᚠᚷᚺᛁᛃᚴᛚᛗᚾᛟᛈᛩᚱᛋᛏᚢᚡᚹᛪᚤᛉ --> 
    //abcdefghijklmnopqrstuvwxyz
    public Dictionary<string, string> RuneAlphabet = new Dictionary<string, string>
    {
        {"A","ᚨ"},
        {"B","ᛒ"},
        {"C","ᚲ"},
        {"D","ᛞ"},
        {"E","ᛖ"},
        {"F","ᚠ"},
        {"G","ᚷ"},
        {"H","ᚺ"},
        {"I","ᛁ"},
        {"J","ᛃ"},
        {"K","ᚴ"},
        {"L","ᛚ"},
        {"M","ᛗ"},
        {"N","ᚾ"},
        {"O","ᛟ"},
        {"P","ᛈ"},
        {"Q","ᛩ"},
        {"R","ᚱ"},
        {"S","ᛋ"},
        {"T","ᛏ"},
        {"U","ᚢ"},
        {"V","ᚡ"},
        {"W","ᚹ"},
        {"X","ᛪ"},
        {"Y","ᚤ"},
        {"Z","ᛉ"}
    };
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        ConvertButton.Clicked += BuildRuneTranslation;
    }

    private void BuildRuneTranslation(object sender, EventArgs e)
    {
        string Translation = string.Empty;
        for (int i = 0; i < englishEntry.Text.ToUpper().Length; i++)
        {
            string s = englishEntry.Text[i].ToString().ToUpper();
            Console.WriteLine(s);
            if (s == " " || string.IsNullOrWhiteSpace(s))
            {
                Translation += " ";
            }
            else
            {
                foreach (var rune in RuneAlphabet)
                {
                    if (s == rune.Key)
                    {
                        Translation += rune.Value;
                    }
                }
            }

        }
        RuneEntry.Text = Translation;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
