using Fiszki.Model;
using Fiszki.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiszki.Presenter
{
    public class PresenterFiszki
    {
        #region Fields
        private DataBase DBFiszki;
        private WindowFiszki FormFiszki;
        private Session CurrentSession;
        public enum language
        {
            English = 0,
            Polish
        }

        private language appLanguage = language.Polish;
        private language flashLanguage = language.Polish;
        #endregion

        public PresenterFiszki(DataBase DBFiszki, WindowFiszki FormFiszki)
        {
            this.DBFiszki = DBFiszki;
            this.FormFiszki = FormFiszki;

            FormFiszki.Presenter = this;
            FormFiszki.SetWindowFiszki();
        }

        #region Properties
        public List<string[]> UItext
        {
            get { return DBFiszki.GetUItext(); }
        }

        public language AppLanguage
        {
            get { return appLanguage; }
            set { appLanguage = value; }
        }

        public language FlashLanguage
        {
            get { return flashLanguage; }
            set { flashLanguage = value; }
        }

        public string[] GetListsOfFlashcards
        {
            get { return DBFiszki.GetListsOfFlashcards(); }
        }

        public List<string[]> FlashcardsList
        {
            get { return DBFiszki.GetFlashcards(CurrentSession.Theme); }
        }

        public Session Session
        {
            get { return CurrentSession; }
        }

        #endregion

        #region Methods
        public void CreateSession(string Theme)
        {
            int numberOfWords = DBFiszki.GetFlashcards(Theme).Count;
            CurrentSession = new Session(Theme, numberOfWords);

        }

        public void CreateEditor()
        {
            Editor Editor = new Editor();
            Editor.Presenter = this;
            Editor.SetEditor();
            Editor.ShowDialog();
        }

        public void AddTable(string tableName)
        {
            DBFiszki.AddTable(tableName);
        }

        public void RemoveTable(string tableName)
        {
            DBFiszki.RemoveTable(tableName);
        }

        public void AddFlashcards(string tableName, string[] word)
        {
            DBFiszki.AddFlashcards(tableName, word);
        }

        public void RemoveFlashcards(string tableName)
        {
            DBFiszki.RemoveFlashcards(tableName);
        }

        public List<string[]> GetEditFlashcardsList(string Theme)
        {
            return DBFiszki.GetFlashcards(Theme);
        }
        #endregion
    }
}
