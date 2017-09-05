
namespace Fiszki
{
    partial class WindowFiszki //View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowFiszki));
            this.labMemorized = new System.Windows.Forms.Label();
            this.labNotMemorized = new System.Windows.Forms.Label();
            this.labAll = new System.Windows.Forms.Label();
            this.labMemorizedValue = new System.Windows.Forms.Label();
            this.labNotMemorizedValue = new System.Windows.Forms.Label();
            this.labAllValue = new System.Windows.Forms.Label();
            this.butYes = new System.Windows.Forms.Button();
            this.butNo = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.labSentence = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfListstoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appEnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appPolishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashEnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashPolishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butCheck = new System.Windows.Forms.Button();
            this.panMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMemorized
            // 
            this.labMemorized.Location = new System.Drawing.Point(260, 40);
            this.labMemorized.Name = "labMemorized";
            this.labMemorized.Size = new System.Drawing.Size(120, 20);
            this.labMemorized.TabIndex = 0;
            this.labMemorized.Text = "Memorized:";
            this.labMemorized.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labNotMemorized
            // 
            this.labNotMemorized.Location = new System.Drawing.Point(260, 70);
            this.labNotMemorized.Name = "labNotMemorized";
            this.labNotMemorized.Size = new System.Drawing.Size(120, 20);
            this.labNotMemorized.TabIndex = 1;
            this.labNotMemorized.Text = "Not memorized:";
            this.labNotMemorized.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labAll
            // 
            this.labAll.Location = new System.Drawing.Point(260, 100);
            this.labAll.Name = "labAll";
            this.labAll.Size = new System.Drawing.Size(120, 20);
            this.labAll.TabIndex = 2;
            this.labAll.Text = "All:";
            this.labAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labMemorizedValue
            // 
            this.labMemorizedValue.Location = new System.Drawing.Point(380, 40);
            this.labMemorizedValue.Name = "labMemorizedValue";
            this.labMemorizedValue.Size = new System.Drawing.Size(40, 20);
            this.labMemorizedValue.TabIndex = 3;
            this.labMemorizedValue.Text = "000";
            this.labMemorizedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labNotMemorizedValue
            // 
            this.labNotMemorizedValue.Location = new System.Drawing.Point(380, 70);
            this.labNotMemorizedValue.Name = "labNotMemorizedValue";
            this.labNotMemorizedValue.Size = new System.Drawing.Size(40, 20);
            this.labNotMemorizedValue.TabIndex = 4;
            this.labNotMemorizedValue.Text = "000";
            this.labNotMemorizedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labAllValue
            // 
            this.labAllValue.Location = new System.Drawing.Point(380, 100);
            this.labAllValue.Name = "labAllValue";
            this.labAllValue.Size = new System.Drawing.Size(40, 20);
            this.labAllValue.TabIndex = 5;
            this.labAllValue.Text = "000";
            this.labAllValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butYes
            // 
            this.butYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butYes.Location = new System.Drawing.Point(12, 313);
            this.butYes.Name = "butYes";
            this.butYes.Size = new System.Drawing.Size(200, 100);
            this.butYes.TabIndex = 6;
            this.butYes.Text = "YES";
            this.butYes.UseVisualStyleBackColor = false;
            this.butYes.Click += new System.EventHandler(this.butYes_Click);
            // 
            // butNo
            // 
            this.butNo.BackColor = System.Drawing.Color.Red;
            this.butNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butNo.Location = new System.Drawing.Point(218, 313);
            this.butNo.Name = "butNo";
            this.butNo.Size = new System.Drawing.Size(200, 100);
            this.butNo.TabIndex = 7;
            this.butNo.Text = "NO";
            this.butNo.UseVisualStyleBackColor = false;
            this.butNo.Click += new System.EventHandler(this.butNo_Click);
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.labSentence);
            this.panMain.Controls.Add(this.labAllValue);
            this.panMain.Controls.Add(this.labNotMemorizedValue);
            this.panMain.Controls.Add(this.labMemorizedValue);
            this.panMain.Controls.Add(this.labAll);
            this.panMain.Controls.Add(this.labNotMemorized);
            this.panMain.Controls.Add(this.labMemorized);
            this.panMain.Controls.Add(this.menuStrip1);
            this.panMain.Controls.Add(this.butCheck);
            this.panMain.Controls.Add(this.butYes);
            this.panMain.Controls.Add(this.butNo);
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(430, 450);
            this.panMain.TabIndex = 8;
            // 
            // labSentence
            // 
            this.labSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSentence.Location = new System.Drawing.Point(70, 135);
            this.labSentence.Name = "labSentence";
            this.labSentence.Size = new System.Drawing.Size(300, 150);
            this.labSentence.TabIndex = 9;
            this.labSentence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem2,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListOfListstoolStripComboBox});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.MouseHover += new System.EventHandler(this.newToolStripMenuItem_Hover);
            // 
            // ListOfListstoolStripComboBox
            // 
            this.ListOfListstoolStripComboBox.Name = "ListOfListstoolStripComboBox";
            this.ListOfListstoolStripComboBox.Size = new System.Drawing.Size(121, 28);
            this.ListOfListstoolStripComboBox.Text = "Choose a list";
            this.ListOfListstoolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ListOfListstoolStripComboBox_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editListToolStripMenuItem});
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem2.Text = "Edit";
            // 
            // editListToolStripMenuItem
            // 
            this.editListToolStripMenuItem.Name = "editListToolStripMenuItem";
            this.editListToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.editListToolStripMenuItem.Text = "Editor";
            this.editListToolStripMenuItem.Click += new System.EventHandler(this.editListToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appLanguageToolStripMenuItem,
            this.flashLanguageToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // appLanguageToolStripMenuItem
            // 
            this.appLanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appEnglishToolStripMenuItem,
            this.appPolishToolStripMenuItem});
            this.appLanguageToolStripMenuItem.Name = "appLanguageToolStripMenuItem";
            this.appLanguageToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.appLanguageToolStripMenuItem.Text = "App language";
            // 
            // appEnglishToolStripMenuItem
            // 
            this.appEnglishToolStripMenuItem.Name = "appEnglishToolStripMenuItem";
            this.appEnglishToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.appEnglishToolStripMenuItem.Text = "English";
            this.appEnglishToolStripMenuItem.Click += new System.EventHandler(this.appEnglishToolStripMenuItem_Click);
            // 
            // appPolishToolStripMenuItem
            // 
            this.appPolishToolStripMenuItem.Checked = true;
            this.appPolishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.appPolishToolStripMenuItem.Name = "appPolishToolStripMenuItem";
            this.appPolishToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.appPolishToolStripMenuItem.Text = "Polish";
            this.appPolishToolStripMenuItem.Click += new System.EventHandler(this.appPolishToolStripMenuItem_Click);
            // 
            // flashLanguageToolStripMenuItem
            // 
            this.flashLanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flashEnglishToolStripMenuItem,
            this.flashPolishToolStripMenuItem});
            this.flashLanguageToolStripMenuItem.Name = "flashLanguageToolStripMenuItem";
            this.flashLanguageToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.flashLanguageToolStripMenuItem.Text = "Flashcards lang.";
            // 
            // flashEnglishToolStripMenuItem
            // 
            this.flashEnglishToolStripMenuItem.Name = "flashEnglishToolStripMenuItem";
            this.flashEnglishToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.flashEnglishToolStripMenuItem.Text = "English";
            this.flashEnglishToolStripMenuItem.Click += new System.EventHandler(this.flashEnglishToolStripMenuItem_Click);
            // 
            // flashPolishToolStripMenuItem
            // 
            this.flashPolishToolStripMenuItem.Checked = true;
            this.flashPolishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flashPolishToolStripMenuItem.Name = "flashPolishToolStripMenuItem";
            this.flashPolishToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.flashPolishToolStripMenuItem.Text = "Polish";
            this.flashPolishToolStripMenuItem.Click += new System.EventHandler(this.flashPolishToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.creditToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.howToUseToolStripMenuItem.Text = "How to use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.creditToolStripMenuItem.Text = "Author";
            this.creditToolStripMenuItem.Click += new System.EventHandler(this.creditToolStripMenuItem_Click);
            // 
            // butCheck
            // 
            this.butCheck.BackColor = System.Drawing.Color.DodgerBlue;
            this.butCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butCheck.Location = new System.Drawing.Point(13, 313);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(405, 100);
            this.butCheck.TabIndex = 10;
            this.butCheck.Text = "Check";
            this.butCheck.UseVisualStyleBackColor = false;
            this.butCheck.Click += new System.EventHandler(this.butCheck_Click);
            // 
            // WindowFiszki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.panMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "WindowFiszki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiszki";
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labMemorized;
        private System.Windows.Forms.Label labNotMemorized;
        private System.Windows.Forms.Label labAll;
        private System.Windows.Forms.Label labMemorizedValue;
        private System.Windows.Forms.Label labNotMemorizedValue;
        private System.Windows.Forms.Label labAllValue;
        private System.Windows.Forms.Button butYes;
        private System.Windows.Forms.Button butNo;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appEnglishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appPolishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.Label labSentence;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.ToolStripMenuItem flashLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashEnglishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashPolishToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ListOfListstoolStripComboBox;
    }
}

