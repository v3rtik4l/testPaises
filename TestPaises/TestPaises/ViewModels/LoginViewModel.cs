﻿

namespace TestPaises.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;

    public class LoginViewModel
    {
        #region Properties
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsRunning { get; set; }
        public bool IsRemembered { get; set; }
        #endregion

        #region Comamnds
        public ICommand LoginCommand { get; set; }
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.IsRemembered = true;
        }
        #endregion
    }
}
