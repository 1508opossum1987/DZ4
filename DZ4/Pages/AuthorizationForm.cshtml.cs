using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DZ4.Pages
{
    public class AuthorizationFormModel : PageModel
    {
        [BindProperty]
        [DisplayName("Имя пользователя или адрес электронной почты")]
        [Required(ErrorMessage = "Укажите имя пользователя или адрес электронной почты")]
        public string? UserName { get; set; }

        [BindProperty]
        [DisplayName("Пароль")]
        [Required(ErrorMessage = "Введите пароль")]
        public string? Password { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/SuccessAuth");
        }
    }
}
