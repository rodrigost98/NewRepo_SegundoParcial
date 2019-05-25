namespace apo.app.ViewModels

{
    using global::app.Droid.Views;
    public class MainViewModel

    {

        #region Properties

        public string Token { get; set; }

        public string TokenType { get; set; }

        #endregion

        #region ViewModels

        public NotesPage Login { get; set; }

        #endregion

        #region Constructors

        public MainViewModel()

        {

            instance = this;

            this.Login = new LoginViewModel();

        }

        #endregion       
        #region Singleton

        private static MainViewModel instance; public static MainViewModel GetInstance()

        {

            if (instance == null)

            {

                return new MainViewModel();

            }

            return instance;

        }

        #endregion
    }
}