using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace AskWebPages
{
  public partial class MainForm : Form
  {

    public struct Munzee
    {
      public string link;
      public string imgLink;

      public Munzee(string link, string imgLink)
      {
        this.link = link;
        this.imgLink = imgLink;
      }
    }
    /// <summary>
    /// Egy string tömb, ami tartalmazza a Balazs80 táblázatának munzee-jait, tetszőlegesen bővíthető...
    /// </summary>
    Munzee[] pages =
    {
      new Munzee ("https://www.munzee.com/m/munzee/26/", "http://www.munzee.nhely.hu/01-Barrier.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/21/","http://www.munzee.nhely.hu/02-Clifford.png"),
      new Munzee ("https://www.munzee.com/m/munzee/35/", "http://www.munzee.nhely.hu/03-Download.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/46/", "http://www.munzee.nhely.hu/04-Dracula.png"),
      new Munzee ("https://www.munzee.com/m/munzee/55/","http://www.munzee.nhely.hu/05-Easteregg.png"),
      new Munzee ("https://www.munzee.com/m/munzee/27/","http://www.munzee.nhely.hu/06-Extralife.png"),
      new Munzee ("https://www.munzee.com/m/munzee/25/","http://www.munzee.nhely.hu/07-Fireball.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/11/","http://www.munzee.nhely.hu/08-Forreal.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/20/", "http://www.munzee.nhely.hu/08-Forreal.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/30/","http://www.munzee.nhely.hu/10-Gutentag.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/8/","http://www.munzee.nhely.hu/11-Goldenarches.png"),
      new Munzee ("https://www.munzee.com/m/heinz57/1/","http://www.munzee.nhely.hu/12-Howdid.png"),
      new Munzee ("https://www.munzee.com/m/heinz57/2/","http://www.munzee.nhely.hu/13-Stickittome.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/25/","http://www.munzee.nhely.hu/14-Hulkpatty.png"),
      new Munzee ("https://www.munzee.com/m/CouchPotato/1/","http://www.munzee.nhely.hu/15-Humptys.png"),
      new Munzee ("https://www.munzee.com/m/munzee/17/","http://www.munzee.nhely.hu/16-Loodens.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/17/","http://www.munzee.nhely.hu/17-Kermie.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/9/","http://www.munzee.nhely.hu/18-Itsapremium.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/7/","http://www.munzee.nhely.hu/19-Whydovoodoo.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/3/","http://www.munzee.nhely.hu/20-Rainorshine.png"),
      new Munzee ("https://www.munzee.com/m/munzee/42/","http://www.munzee.nhely.hu/21-Welcometomunzee.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/83/","http://www.munzee.nhely.hu/22-Philips66.png"),
      new Munzee ("https://www.munzee.com/m/munzee/15/","http://www.munzee.nhely.hu/23-Timmy.png"),
      new Munzee ("https://www.munzee.com/m/munzee/28/","http://www.munzee.nhely.hu/24-Thenewstore.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/16/","http://www.munzee.nhely.hu/25-Therachel.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/26/","http://www.munzee.nhely.hu/26-Thefaceofcomedy.png"),
      new Munzee ("https://www.munzee.com/m/heinz57/3/","http://www.munzee.nhely.hu/27-Stucktogether.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/12/","http://www.munzee.nhely.hu/28-Stuckinthemiddle.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/28/","http://www.munzee.nhely.hu/29-Stinkinbugs.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/10/","http://www.munzee.nhely.hu/30-Stickaround.png"),
      new Munzee ("https://www.munzee.com/m/munzee/24/","http://www.munzee.nhely.hu/31-Spreader.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/22/","http://www.munzee.nhely.hu/32-Robandbig.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/19/","http://www.munzee.nhely.hu/33-Maxeisenhardt.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/18/","http://www.munzee.nhely.hu/34-Pollystyrene.png" ),
      new Munzee ("https://www.munzee.com/m/QRazy/29/","http://www.munzee.nhely.hu/35-Monthlywarning.png"),
      new Munzee ("https://www.munzee.com/m/CouchPotato/5/","http://www.munzee.nhely.hu/36-Weloveyoutoo.png"),
      new Munzee ("https://www.munzee.com/m/CouchPotato/2/","http://www.munzee.nhely.hu/37-Mellow.png"),
      new Munzee ("https://www.munzee.com/m/munzee/20/","http://www.munzee.nhely.hu/38-Pagenotfound.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/15/","http://www.munzee.nhely.hu/39-Mybuddy.png"),
      new Munzee ("https://www.munzee.com/m/munzee/29/","http://www.munzee.nhely.hu/40-Needhelp.png"),
      new Munzee ("https://www.munzee.com/m/munzee/39/","http://www.munzee.nhely.hu/41-Wikizee.png"),
      new Munzee ("https://www.munzee.com/m/munzee/31/","http://www.munzee.nhely.hu/42-Noacpress.png"),
      new Munzee ("https://www.munzee.com/m/munzee/34/","http://www.munzee.nhely.hu/43-Planofire.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/36/","http://www.munzee.nhely.hu/44-Whatdoes.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/27/","http://www.munzee.nhely.hu/45-Invisibility.png"),
      new Munzee ("https://www.munzee.com/m/MyFace/1/","http://www.munzee.nhely.hu/46-Myface.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/45/","http://www.munzee.nhely.hu/47-Generalrating.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/41/","http://www.munzee.nhely.hu/48-Onedirection.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/39/","http://www.munzee.nhely.hu/49-Opposites.png"),
      new Munzee ("https://www.munzee.com/m/munzee/58/","http://www.munzee.nhely.hu/50-Munzeeshirt.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/69/","http://www.munzee.nhely.hu/51-Quiz-1.png"),
      new Munzee ("https://www.munzee.com/m/AreOhBee/2/","http://www.munzee.nhely.hu/52-Quiz-2.png"),
      new Munzee ("https://www.munzee.com/m/AreOhBee/3/","http://www.munzee.nhely.hu/53-Quiz-3.png"),
      new Munzee ("https://www.munzee.com/m/AreOhBee/4/","http://www.munzee.nhely.hu/54-Quiz-4.png"),
      new Munzee ("https://www.munzee.com/m/munzee/58/","http://www.munzee.nhely.hu/55-Aprilaction.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/62/","http://www.munzee.nhely.hu/56-Hellomaddie.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/73/","http://www.munzee.nhely.hu/57-Thatsalot.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/63/","http://www.munzee.nhely.hu/58-Myireadthat.png"),
      new Munzee ("https://www.munzee.com/m/munzee/63/","http://www.munzee.nhely.hu/59-Fullofnews.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/67/","http://www.munzee.nhely.hu/60-Oktoberfest.png"),
      new Munzee ("https://www.munzee.com/m/munzee/65/","http://www.munzee.nhely.hu/61-Thebrave.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/68/","http://www.munzee.nhely.hu/62-Valentineday.png"),
      new Munzee ("https://www.munzee.com/m/munzee/69/","http://www.munzee.nhely.hu/63-Welcome2015.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/56/","http://www.munzee.nhely.hu/64-Lightreading.png"),
      new Munzee ("https://www.munzee.com/m/munzee/139/","http://www.munzee.nhely.hu/65-Resetblogpost.png"),
      new Munzee ("https://www.munzee.com/m/munzee/73/","http://www.munzee.nhely.hu/66-Voicesinamerica.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/75/","http://www.munzee.nhely.hu/67-Juneclanwar.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/95/","http://www.munzee.nhely.hu/68-Rmunzee.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/78/","http://www.munzee.nhely.hu/69-Munzpakteaser.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/81/","http://www.munzee.nhely.hu/70-Newsletter.png"),
      new Munzee ("https://www.munzee.com/m/MunzeeCommunityBuilding/336/","http://www.munzee.nhely.hu/71-Cctvmini.png"),
      new Munzee ("https://www.munzee.com/m/MunzeeCommunityBuilding/334/","http://www.munzee.nhely.hu/72-Globestore.png"),
      new Munzee ("https://www.munzee.com/m/MunzeeCommunityBuilding/333/","http://www.munzee.nhely.hu/73-Firewarning.png"),
      new Munzee ("https://www.munzee.com/m/MunzeeCommunityBuilding/337/","http://www.munzee.nhely.hu/74-Nosmoking.png"),
      new Munzee ("https://www.munzee.com/m/MunzeeCommunityBuilding/338/","http://www.munzee.nhely.hu/75-Nopets.png"),
      new Munzee ("https://www.munzee.com/m/MunzeeCommunityBuilding/335/","http://www.munzee.nhely.hu/76-Laserwarning.png"),
      new Munzee ("https://www.munzee.com/m/MunzeeCommunityBuilding/342/","http://www.munzee.nhely.hu/77-Grabbag.png"),
      new Munzee ("https://www.munzee.com/m/MunzeeCommunityBuilding/343/","http://www.munzee.nhely.hu/78-Inspection.png"),
      new Munzee ("https://www.munzee.com/m/MunzeeCommunityBuilding/345/","http://www.munzee.nhely.hu/79-Warranty.png"),
      new Munzee ("https://www.munzee.com/m/MunzeeCommunityBuilding/344/","http://www.munzee.nhely.hu/80-Propertyof.png"),
      new Munzee ("https://www.munzee.com/m/dderryberry60/280/","http://www.munzee.nhely.hu/81-Newcamo.png"),
      new Munzee ("https://www.munzee.com/m/hksfarm/2433/","http://www.munzee.nhely.hu/82-Luckycharms.png"),
      new Munzee ("https://www.munzee.com/m/MunzeeCommunityBuilding/381/","http://www.munzee.nhely.hu/84-Scratch.png"),
      new Munzee ("https://www.munzee.com/m/munzee/141/","http://www.munzee.nhely.hu/87-Wallabee.png"),
      new Munzee ("https://www.munzee.com/m/QRazy/80/", "")
    };

    private bool asking;
    private int found;
    private int archived;

    /// <summary>
    /// Konstruktor.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
    }

    /// <summary>
    /// A lekérdező függvény paraméter nélküli hívása, ahol a "false" az alapértelmezett.
    /// </summary>
    private async Task AskMunzeePages()
    {
      await AskMunzeePages(false);
    }

    /// <summary>
    /// Végignézi a pages tömbben lévő munzee linkeket, hogy van-e valamelyiken valami speciális.
    /// </summary>
    /// <param name="init">Timer indítás utáni első lekérdezés-e.</param>
    private async Task AskMunzeePages(bool init)
    {
      if (asking)
        return;

      try
      {
        asking = true;
        found = 0;
        archived = 0;

        DateTime now = DateTime.Now;
        DateTime next = now.AddMinutes((int)numericUpDownAskingTimer.Value);

        // Timer-es lekérdezés esetén más a szöveg... 
        if (timerAsking.Enabled)
        {
          // Ha az első lekérdezés, akkor is mást ír ki...
          if (init)
          {
            AddTextToLog($"{now.ToLongTimeString()} - Initial asking...");
          }
          else
          {
            AddTextToLog($"{now.ToLongTimeString()} - Asking by the timer...");
          }
        }
        // Kézzel indított 1 db lekérdezés...
        else
        {
          AddTextToLog($"{now.ToLongTimeString()} - Asking by hand...");
        }

        AddTextToLog("");

        buttonAsk.Enabled = false;
        buttonStart.Enabled = false;
        buttonStop.Enabled = false;
        numericUpDownAskingTimer.Enabled = false;

        // web oldal lekérdezéséhez.
        WebClient myClient = new WebClient();
        Stream responseStream = null;
        StreamReader sr = null;

        // Ciklus végig a regisztrált munzee-kon...
        for (int i = 0; i < pages.Count(); i++)
        {
          AddTextToLog(String.Format("{0}/{1} - {2}", (i + 1).ToString(), pages.Count().ToString(), pages[i].link));

          try
          {
            // A munzee linkeket tartalmazó tömbből a soron következő web oldal lekérdezése.

            // Note: Van OpenReadAsync is, de az void-ot ad vissza, azaz nem awaitable.
            // Ezért van itt Task.Run-os megoldás...
            responseStream = await Task.Run(() => myClient.OpenRead(pages[i].link));
          }
          catch (Exception ex)
          {
            AddTextToLog(ex.Message, true);
            continue;
          }

          try
          {
            // Kell egy stream olvasó, hogy be tudjuk olvasni.
            sr = new StreamReader(responseStream, Encoding.Default);

            // Az egész web oldal beolvasása egy stringbe (ez gyakorlatilag egy html szöveg).

            // Note: Az Async-os változat itt awaitable és elég a simna await...
            string data = await sr.ReadToEndAsync();

            if (data != null && data != "")
            {
              // Vizsgálja, hogy tartalmazza-e a következő stringek valamelyikét.
              // Ezt egy konkrét példából néztem:
              //   This Munzee is currently hosting Tuli #1165!
              // Ahol egy Tuli van a munzee-n. Gondolom a többi esetben is a "currently hosting" szerepel a html-ben.
              // Illetve az ilyen munzee-k lejárósak és az "Expires in" is ki van írva.
              if ((data.Contains("currently hosting") || data.Contains("Expires in")) && !data.Contains(">Pegasus Munzee #"))
              {
                found++;

                // Üzenet...
                AddTextToLog("Host munzee found.", false, true);

                // Behozza az oldalt egy böngészőben.
                Process.Start(pages[i].link);
                Process.Start(pages[i].imgLink);
              }
              else if (data.Contains(">Archived"))
              {
                archived++;
                AddTextToLog("ARCHIVED.", false, true);
              }
            }
          }
          catch (Exception ex)
          {
            AddTextToLog(ex.Message, true);
          }
          finally
          {
            if (sr != null)
              sr.Close();

            if (responseStream != null)
              responseStream.Close();
          }
        }

        AddTextToLog("");
        AddTextToLog($"{found.ToString()} found");
        AddTextToLog($"{archived.ToString()} archived");

        if (timerAsking.Enabled)
        {
          if (init)
          {
            AddTextToLog($"{DateTime.Now.ToLongTimeString()} - Asked initially");
          }
          else
          {
            AddTextToLog($"{DateTime.Now.ToLongTimeString()} - Asked by the timer");
          }

          AddTextToLog($"Next asking time: {next.ToLongTimeString()}");
        }
        else
        {
          AddTextToLog($"{DateTime.Now.ToLongTimeString()} - Asked by hand");
        }

        AddTextToLog("");
      }
      finally
      {
        if (timerAsking.Enabled)
        {
          buttonAsk.Enabled = false;
          buttonStart.Enabled = false;
          buttonStop.Enabled = true;
          numericUpDownAskingTimer.Enabled = false;
        }
        else
        {
          buttonAsk.Enabled = true;
          buttonStart.Enabled = true;
          buttonStop.Enabled = false;
          numericUpDownAskingTimer.Enabled = true;
        }

        asking = false;
      }
    }

    /// <summary>
    /// Az Ask gomb lenyomására hívódik.
    /// </summary>
    private async void buttonAsk_Click(object sender, EventArgs e)
    {
      await AskMunzeePages();
    }

    // Szimpla szövegsor log ablakba írása.
    private void AddTextToLog(string txt)
    {
      AddTextToLog(txt, false, false);
    }

    // Hiba szöveg log ablakba írása. Ha error true, akkor piros lesz a szöveg.
    private void AddTextToLog(string txt, bool error)
    {
      AddTextToLog(txt, error, false);
    }

    // Sima szöveg, piros szöveg, vastag betűs szöveg vagy ezek kombinációját írja a
    // log ablakba. Ha error true, akkor piros, ha bold true, akkor vastag betűs.
    private void AddTextToLog(string txt, bool error, bool bold)
    {
      try
      {
        int start = richTextBoxLog.TextLength;

        richTextBoxLog.AppendText(txt);
        richTextBoxLog.AppendText("\r\n");

        richTextBoxLog.Select(start, txt.Length);

        if (error)
          richTextBoxLog.SelectionColor = Color.Red;

        if (bold)
        {
          System.Drawing.Font currentFont = richTextBoxLog.SelectionFont;
          richTextBoxLog.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold);
        }

        richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
        richTextBoxLog.ScrollToCaret();
        richTextBoxLog.Refresh();
      }
      catch
      {
      }
    }

    /// <summary>
    /// Időzítő indítása gomb
    /// </summary>
    private async void buttonStart_Click(object sender, EventArgs e)
    {
      timerAsking.Interval = (int)numericUpDownAskingTimer.Value * 1000 * 60;
      timerAsking.Enabled = true;
      timerAsking.Start();

      DateTime now = DateTime.Now;
      DateTime next = now.AddMinutes((int)numericUpDownAskingTimer.Value);

      buttonAsk.Enabled = false;
      buttonStart.Enabled = false;
      buttonStop.Enabled = true;
      numericUpDownAskingTimer.Enabled = false;

      AddTextToLog("");

      AddTextToLog($"{now.ToLongTimeString()} - Timer is started");
      AddTextToLog($"Interval: {((int)numericUpDownAskingTimer.Value).ToString()} minute(s)");
      //  AddTextToLog($"First asking time: {next.ToLongTimeString()}");

      AddTextToLog("");

      await AskMunzeePages(true);
    }

    /// <summary>
    /// Időzítő leállítása gomb
    /// </summary>
    private void buttonStop_Click(object sender, EventArgs e)
    {
      timerAsking.Stop();
      timerAsking.Enabled = false;

      buttonAsk.Enabled = true;
      buttonStart.Enabled = true;
      buttonStop.Enabled = false;
      numericUpDownAskingTimer.Enabled = true;

      AddTextToLog("");

      AddTextToLog($"Timer is stopped - {DateTime.Now.ToLongTimeString()}");

      AddTextToLog("");
    }

    /// <summary>
    /// Időzítő eseménye.
    /// </summary>
    private async void timerAsking_Tick(object sender, EventArgs e)
    {
      await AskMunzeePages();
    }
  }
}
