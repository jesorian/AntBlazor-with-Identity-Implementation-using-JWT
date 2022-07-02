using System.Threading.Tasks;
using hosted.Models;
using hosted.Services;
using Microsoft.AspNetCore.Components;
using AntDesign;
using hosted.Client.Services;
using hosted.Shared;

namespace hosted.Pages.User
{
    public partial class Login
    {
        private readonly LoginParamsType _model = new LoginParamsType();

        //[Inject] public NavigationManager NavigationManager { get; set; }

        //[Inject] public IAccountService AccountService { get; set; }

        //[Inject] public MessageService Message { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IAuthService AuthService { get; set; }

        private LoginModel loginModel = new LoginModel();

        public async void HandleSubmit()
        {
            loginModel.Email = _model.UserName;
            loginModel.Password = _model.Password;

            var result = await AuthService.Login(loginModel);

            if (result.Successful)
                NavigationManager.NavigateTo("/");
            else 
            { 
                // whatever you want
            }

            //if (_model.UserName == "admin" && _model.Password == "ant.design")
            //{
            //    NavigationManager.NavigateTo("/");
            //    return;
            //}

            //if (_model.UserName == "user" && _model.Password == "ant.design") NavigationManager.NavigateTo("/");
        }

        //public async Task GetCaptcha()
        //{
        //    var captcha = await AccountService.GetCaptchaAsync(_model.Mobile);
        //    await Message.Success($"Verification code validated successfully! The verification code is: {captcha}");
        //}
    }
}