using Fiszki.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fiszki.View
{
    public partial class Editor : Form
    {
        #region Fields
        List<string[]> NewFlashcardsList;
        public PresenterFiszki Presenter { get; set; }
        #endregion

        public Editor()
        {
            InitializeComponent();
            
            NewFlashcardsList = new List<string[]>();
        }

        #region Methods
        public void SetEditor()
        {
            this.EditorListcomboBox.Items.AddRange(Presenter.GetListsOfFlashcards);
            SetText();
        }

        public void SetText()
        {
            int index = (int)Presenter.AppLanguage;

            this.EnglishColumn.HeaderText = Presenter.UItext[15][index]; //"English";
            this.PolishColumn.HeaderText = Presenter.UItext[16][index]; //"Polish";
            this.AddListButton.Text = Presenter.UItext[23][index]; //"Add list";
            this.CancelButtonF.Text = Presenter.UItext[24][index]; //"Cancel";
            this.SaveButton.Text = Presenter.UItext[25][index]; //"Save";
            this.EditorListcomboBox.Text = Presenter.UItext[26][index]; // Chose a list
            this.RemoveListButton.Text = Presenter.UItext[27][index]; //Remove list
        }
        #endregion

        #region Events
        private void EditorListcomboBox_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(this.EditorListcomboBox.SelectedItem);

            this.ListDataGridView.Rows.Clear();
            foreach (var flashcard in Presenter.GetEditFlashcardsList(name))
            {
                this.ListDataGridView.Rows.Add(flashcard[(int)PresenterFiszki.language.English], flashcard[(int)PresenterFiszki.language.Polish]);
            }
        }

        private void AddListButton_Click(object sender, EventArgs e)
        {
            bool ifListExist = false;
            string newListName = this.EditorListcomboBox.Text.Replace(" ", "_");

            foreach (var list in Presenter.GetListsOfFlashcards)
            {
                if (list == newListName)
                {
                    ifListExist = true;
                }
            }

            if (ifListExist)
            {
                //MessageBox
                string message = Presenter.UItext[30][(int)Presenter.AppLanguage]; // Change name of list
                string[] messageTable = message.Split(';');
                message = "";
                foreach (var line in messageTable)
                {
                    message += line + "\n";
                }
                MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Presenter.AddTable(this.EditorListcomboBox.Text);

                this.EditorListcomboBox.Items.Clear();
                this.EditorListcomboBox.Items.AddRange(Presenter.GetListsOfFlashcards);

                this.EditorListcomboBox.Text = newListName;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ListDataGridView.Rows.Count>1)
            {
                if (NewFlashcardsList.Count != 0) { NewFlashcardsList.Clear(); }

                string[] NewRow = new string[2];
                foreach (DataGridViewRow row in ListDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null || row.Cells[1].Value != null)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            NewRow[i] = row.Cells[i].Value.ToString();
                        }
                        NewFlashcardsList.Add(NewRow);
                    }
                }

                Presenter.RemoveFlashcards(this.EditorListcomboBox.Text);

                foreach (var flashcard in NewFlashcardsList)
                {
                    Presenter.AddFlashcards(this.EditorListcomboBox.Text, flashcard);
                }
                this.Close();
            }
            else
            {
                //MessageBox
                string message = Presenter.UItext[28][(int)Presenter.AppLanguage]; //must have at least one word
                string[] messageTable = message.Split(';');
                message = "";
                foreach (var line in messageTable)
                {
                    message += line + "\n";
                }
                MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void RemoveListButton_Click(object sender, EventArgs e)
        {
            Presenter.RemoveTable(this.EditorListcomboBox.Text);

            this.EditorListcomboBox.Items.Clear();
            this.EditorListcomboBox.Items.AddRange(Presenter.GetListsOfFlashcards);
            this.EditorListcomboBox.Text = Presenter.UItext[26][(int)Presenter.AppLanguage]; // Chose a list
            this.ListDataGridView.Rows.Clear();
        }
        #endregion
    }
}
