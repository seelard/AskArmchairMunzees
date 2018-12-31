namespace AskWebPages
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.buttonAsk = new System.Windows.Forms.Button();
      this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
      this.buttonStart = new System.Windows.Forms.Button();
      this.buttonStop = new System.Windows.Forms.Button();
      this.numericUpDownAskingTimer = new System.Windows.Forms.NumericUpDown();
      this.labelMinutes = new System.Windows.Forms.Label();
      this.timerAsking = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAskingTimer)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonAsk
      // 
      this.buttonAsk.BackColor = System.Drawing.Color.AntiqueWhite;
      this.buttonAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.buttonAsk.ForeColor = System.Drawing.Color.Navy;
      this.buttonAsk.Location = new System.Drawing.Point(5, 417);
      this.buttonAsk.Name = "buttonAsk";
      this.buttonAsk.Size = new System.Drawing.Size(75, 25);
      this.buttonAsk.TabIndex = 0;
      this.buttonAsk.Text = "Ask";
      this.buttonAsk.UseVisualStyleBackColor = false;
      this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
      // 
      // richTextBoxLog
      // 
      this.richTextBoxLog.BackColor = System.Drawing.Color.Linen;
      this.richTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.richTextBoxLog.DetectUrls = false;
      this.richTextBoxLog.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.richTextBoxLog.ForeColor = System.Drawing.Color.DarkSlateGray;
      this.richTextBoxLog.Location = new System.Drawing.Point(5, -1);
      this.richTextBoxLog.Name = "richTextBoxLog";
      this.richTextBoxLog.ReadOnly = true;
      this.richTextBoxLog.Size = new System.Drawing.Size(626, 414);
      this.richTextBoxLog.TabIndex = 8;
      this.richTextBoxLog.Text = "";
      // 
      // buttonStart
      // 
      this.buttonStart.BackColor = System.Drawing.Color.AntiqueWhite;
      this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.buttonStart.ForeColor = System.Drawing.Color.Navy;
      this.buttonStart.Location = new System.Drawing.Point(251, 417);
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size(124, 25);
      this.buttonStart.TabIndex = 9;
      this.buttonStart.Text = "Start Timer";
      this.buttonStart.UseVisualStyleBackColor = false;
      this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
      // 
      // buttonStop
      // 
      this.buttonStop.BackColor = System.Drawing.Color.AntiqueWhite;
      this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonStop.Enabled = false;
      this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.buttonStop.ForeColor = System.Drawing.Color.Navy;
      this.buttonStop.Location = new System.Drawing.Point(507, 417);
      this.buttonStop.Name = "buttonStop";
      this.buttonStop.Size = new System.Drawing.Size(124, 25);
      this.buttonStop.TabIndex = 11;
      this.buttonStop.Text = "Stop Timer";
      this.buttonStop.UseVisualStyleBackColor = false;
      this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
      // 
      // numericUpDownAskingTimer
      // 
      this.numericUpDownAskingTimer.Location = new System.Drawing.Point(385, 420);
      this.numericUpDownAskingTimer.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
      this.numericUpDownAskingTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDownAskingTimer.Name = "numericUpDownAskingTimer";
      this.numericUpDownAskingTimer.Size = new System.Drawing.Size(67, 20);
      this.numericUpDownAskingTimer.TabIndex = 12;
      this.numericUpDownAskingTimer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // labelMinutes
      // 
      this.labelMinutes.AutoSize = true;
      this.labelMinutes.Location = new System.Drawing.Point(454, 423);
      this.labelMinutes.Name = "labelMinutes";
      this.labelMinutes.Size = new System.Drawing.Size(49, 13);
      this.labelMinutes.TabIndex = 13;
      this.labelMinutes.Text = "minute(s)";
      // 
      // timerAsking
      // 
      this.timerAsking.Tick += new System.EventHandler(this.timerAsking_Tick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SeaShell;
      this.ClientSize = new System.Drawing.Size(635, 445);
      this.Controls.Add(this.labelMinutes);
      this.Controls.Add(this.numericUpDownAskingTimer);
      this.Controls.Add(this.buttonStop);
      this.Controls.Add(this.buttonStart);
      this.Controls.Add(this.richTextBoxLog);
      this.Controls.Add(this.buttonAsk);
      this.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ForeColor = System.Drawing.Color.Navy;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.Text = "Ask Armchair Munzees";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAskingTimer)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonAsk;
    private System.Windows.Forms.RichTextBox richTextBoxLog;
    private System.Windows.Forms.Button buttonStart;
    private System.Windows.Forms.Button buttonStop;
    private System.Windows.Forms.NumericUpDown numericUpDownAskingTimer;
    private System.Windows.Forms.Label labelMinutes;
    private System.Windows.Forms.Timer timerAsking;
  }
}

