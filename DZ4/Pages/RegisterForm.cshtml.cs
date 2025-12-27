using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DZ4.Pages
{
    public class RegisterFormModel : PageModel
    {
        [BindProperty]
        [DisplayName("Имя пользователя")]
        [Required(ErrorMessage = "Укажите имя пользователя")]
        [MinLength(3, ErrorMessage = "Минимальная длина - 3 символа")]
        public string? UserName { get; set; }

        [BindProperty]
        [DisplayName("Адрес электронной почты")]
        [Required(ErrorMessage = "Укажите адрес электронной почты")]
        [EmailAddress(ErrorMessage = "Неверный адрес электронной почты")]
        public string? EmailAddress { get; set; }

        [BindProperty]
        [DisplayName("Пароль")]
        [Required(ErrorMessage = "Введите пароль")]
        [MinLength(3, ErrorMessage = "Минимальная длина - 6 символов")]
        public string? Password { get; set; }

        [BindProperty]
        [DisplayName("Подтвердите пароль")]
        [Compare("Password", ErrorMessage ="Пароли не совпадают")]
        public string? ConfirmPassword { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/SuccessReg");
        }
    }
}
