using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASS_WMS.Models;

//==============================================================
//      View Model
//==============================================================

public class LoginVM
{
    [StringLength(100)]
    [EmailAddress]
    [Required]
    public string Email { get; set; }

    [StringLength(100, MinimumLength = 8)]
    [DataType(DataType.Password)]
    [Required]
    public string Password { get; set; }

    public bool RememberMe { get; set; }
}

public class RegisterVM
{
    [StringLength (100)]
    [EmailAddress]
    [Remote("CheckEmail", "Account", ErrorMessage = "Duplicated {0}.")]
    [Required]
    public string Email { get; set; }

    [StringLength (100, MinimumLength = 8)]
    [DataType(DataType.Password)]
    [Required]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Required]
    public string ConfirmPassword { get; set; }

    [StringLength(100)]
    public string Name { get; set; }

    public IFormFile Photo { get; set; }
}