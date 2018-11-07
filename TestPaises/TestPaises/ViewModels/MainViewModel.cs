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
        #endregion

        #region Constructores
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}