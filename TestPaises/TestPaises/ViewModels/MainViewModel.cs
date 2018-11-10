namespace TestPaises.ViewModels
{
    public class MainViewModel
    { 
        #region Viewmodels
        public LoginViewModel Login
        {
            get;
            set;
        }

        public PaisesViewModel Paises
        {
            get;
            set;
        }
        #endregion

        #region Constructores
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();

        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
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