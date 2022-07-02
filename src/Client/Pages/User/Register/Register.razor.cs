using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using hosted.Shared;
using System.Collections.Generic;
using hosted.Client.Services;

namespace hosted.Pages.User
{
    //public class RegisterModel
    //{
    //    [Required]
    //    public string UserName { get; set; }

    //    [Required]
    //    public string Password { get; set; }

    //    [Required]
    //    public string ConfirmPassword { get; set; }

    //    [Required]
    //    public string Phone { get; set; }

    //    [Required]
    //    public string Captcha { get; set; }
    //}

    public partial class Register
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IAuthService AuthService { get; set; }

        //private readonly RegisterModel _user = new RegisterModel();

        private RegisterModel RegisterModel = new RegisterModel();
        private bool ShowErrors;
        private IEnumerable<string> Errors;

        public async void Reg()
        {
            ShowErrors = false;

            var result = await AuthService.Register(RegisterModel);

            if (result.Successful)
                NavigationManager.NavigateTo("/user/login");
            else
            {
                Errors = result.Errors;
                ShowErrors = true;
            }
        }
    }
}