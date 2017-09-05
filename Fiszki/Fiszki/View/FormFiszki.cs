using Fiszki.Presenter;
using System;
using System.Windows.Forms;

namespace Fiszki
{
    public partial class WindowFiszki : Form
    {
        #region Fields
        private string Congratulations;
        private string ChooseList;

        public PresenterFiszki Presenter { get; set; }
        #endregion

        public WindowFiszki()
        {
            InitializeComponent();

        }

        #region Methods
        public void SetWindowFiszki()
        {
            this.ListOfListstoolStripComboBox.Items.AddRange(Presenter.GetListsOfFlashcards);
            SetText();
        }

        public void SetText()
        {
            int index = (int)Presenter.AppLanguage;

            this.labMemorized.Text = Presenter.UItext[2][index] + ":"; //"Correct"
            this.labNotMemorized.Text = Presenter.UItext[1][index] + ":"; //"Incorrect:";
            this.labAll.Text = Presenter.UItext[0][index] + ":"; //"All:";
            this.butYes.Text = Presenter.UItext[4][index]; //"YES";
            this.butNo.Text = Presenter.UItext[5][index]; //"NO";
            this.butCheck.Text = Presenter.UItext[3][index]; //"Check";
            this.fileToolStripMenuItem.Text = Presenter.UItext[6][index]; //"File";
            this.newToolStripMenuItem.Text = Presenter.UItext[7][index]; //"New";
            //this.openToolStripMenuItem.Text = Presenter.UItext[8][index]; //"Open";
            //this.saveToolStripMenuItem.Text = Presenter.UItext[9][index]; //"Save";
            this.editToolStripMenuItem2.Text = Presenter.UItext[10][index]; //"Edit";
            this.editListToolStripMenuItem.Text = Presenter.UItext[12][index]; //"Edit list";
            this.optionsToolStripMenuItem.Text = Presenter.UItext[13][index]; //"Options";
            this.appLanguageToolStripMenuItem.Text = Presenter.UItext[14][index]; //"App language";
            this.appEnglishToolStripMenuItem.Text = Presenter.UItext[15][index]; //"English";
            this.flashEnglishToolStripMenuItem.Text = Presenter.UItext[15][index]; //"English";
            this.appPolishToolStripMenuItem.Text = Presenter.UItext[16][index]; //"Polish";
            this.flashPolishToolStripMenuItem.Text = Presenter.UItext[16][index]; //"Polish";
            this.helpToolStripMenuItem.Text = Presenter.UItext[17][index]; //"Help";
            this.howToUseToolStripMenuItem.Text = Presenter.UItext[18][index]; //"How to use";
            this.creditToolStripMenuItem.Text = Presenter.UItext[19][index]; //"Author";
            this.flashLanguageToolStripMenuItem.Text = Presenter.UItext[20][index]; //"Flashcards lang.";
            Congratulations = Presenter.UItext[21][index]; //Congratulations! You already know all the words.
            ChooseList = Presenter.UItext[26][index]; //Choose a list
            this.labSentence.Text = ChooseList;
            this.ListOfListstoolStripComboBox.Text = Presenter.UItext[26][index]; // Choose a list
        }
        #endregion

        #region Events

        #region Check_YES_NO_buttons
        private void butCheck_Click(object sender, EventArgs e)
        {
            if (Presenter.FlashcardsList != null && Presenter.Session.getNext()>-1)
            {
                butCheck.Hide();

                switch (Presenter.FlashLanguage)
                {
                    case PresenterFiszki.language.English:
                        this.labSentence.Text = Presenter.FlashcardsList[Presenter.Session.getNext()][1];
                        break;
                    case PresenterFiszki.language.Polish:
                        this.labSentence.Text = Presenter.FlashcardsList[Presenter.Session.getNext()][0];
                        break;
                    default:
                        break;
                }
            }
        }

        private void butYes_Click(object sender, EventArgs e)
        {
            butCheck.Show();
            Presenter.Session.addToMemorized();
            refreshState();
            if (Presenter.Session.getNext() > -1)
            {
                this.labSentence.Text = Presenter.FlashcardsList[Presenter.Session.getNext()][(int)Presenter.FlashLanguage];
            }
            else
            {
                this.labSentence.Text = Congratulations;
            }

        }

        private void butNo_Click(object sender, EventArgs e)
        {
            butCheck.Show();
            Presenter.Session.addToNotMemorized();
            refreshState();
            this.labSentence.Text = Presenter.FlashcardsList[Presenter.Session.getNext()][(int)Presenter.FlashLanguage];
        }
        #endregion

        #region Menu

        private void newToolStripMenuItem_Hover(object sender, EventArgs e)
        {
            this.ListOfListstoolStripComboBox.Items.Clear();
            this.ListOfListstoolStripComboBox.Items.AddRange(Presenter.GetListsOfFlashcards);
        }

        #region Option
        #region AppLanguage
        private bool[] checkIfChooseOrCongrat()
        {
            bool choose = false, congrat = false;
            if (this.labSentence.Text == ChooseList) { choose = true; }
            else if (this.labSentence.Text == Congratulations) { congrat = true; }
            return new bool[] {choose, congrat};
        }

        private void refreshSentenceState(bool[] flags)
        {
            bool choose = flags[0];
            bool congrat = flags[1];

            if (choose) { this.labSentence.Text = ChooseList; }
            else if (congrat) { this.labSentence.Text = Congratulations; }
        }

        private void appPolishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool[] ifChange = checkIfChooseOrCongrat();
            this.appPolishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.appEnglishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            Presenter.AppLanguage = PresenterFiszki.language.Polish;
            SetText();

            refreshSentenceState(ifChange);
        }

        private void appEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool[] ifChange = checkIfChooseOrCongrat();
            this.appPolishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.appEnglishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            Presenter.AppLanguage = PresenterFiszki.language.English;
            SetText();
            this.labSentence.Text = ChooseList;

            refreshSentenceState(ifChange);
        }

        #endregion

        #region FlashcardsLanguage
        private void flashEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.flashPolishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.flashEnglishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            Presenter.FlashLanguage = PresenterFiszki.language.English;
        }

        private void flashPolishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.flashPolishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flashEnglishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            Presenter.FlashLanguage = PresenterFiszki.language.Polish;
        }
        #endregion
        #endregion

        #region Edit
        private void refreshState()
        {
            this.labAllValue.Text = "" + Presenter.Session.All;
            this.labNotMemorizedValue.Text = "" + Presenter.Session.NotMemorized;
            this.labMemorizedValue.Text = "" + Presenter.Session.Memorized;
        }

        private void ListOfListstoolStripComboBox_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(this.ListOfListstoolStripComboBox.SelectedItem);
            Presenter.CreateSession(name);
            this.labSentence.Text = Presenter.FlashcardsList[0][(int)Presenter.FlashLanguage];
            this.labSentence.Show();
            refreshState();
        }

        private void editListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.CreateEditor();
        }
        #endregion

        #region Help
        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox
            string message = "           Kamil Fedio";
            string caption = this.creditToolStripMenuItem.Text;
            MessageBox.Show(message,caption);
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox
            string message = Presenter.UItext[29][(int)Presenter.AppLanguage];

            string[] messageTable = message.Split(';');
            message = "";
            foreach (var line in messageTable)
            {
                message += line + "\n";
            }

            string caption = this.howToUseToolStripMenuItem.Text;
            MessageBox.Show(message, caption);
        }
        #endregion
        #endregion

        #endregion
    }
}
