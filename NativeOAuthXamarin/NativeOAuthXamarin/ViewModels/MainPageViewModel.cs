using Xamarin.Forms;

namespace NativeOAuthXamarin
{
    public class MainPageViewModel : BaseNotifyViewModel
    {
        #region Commands
        public Command GoogleLoginCommand { get; set; }
        public Command GoogleLogoutCommand { get; set; }
        #endregion

        #region Constructors
        public MainPageViewModel() { }
        #endregion

        #region Fields
        private bool _isLoggedIn;
        private GoogleUser _googleUser;
        #endregion

        #region Properties
        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set { SetProperty(ref _isLoggedIn, value); }
        }

        public GoogleUser GoogleUser
        {
            get { return _googleUser; }
            set { SetProperty(ref _googleUser, value); }
        }
        #endregion
    }
}
