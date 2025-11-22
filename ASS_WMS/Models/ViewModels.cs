using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASS_WMS.Models;

#nullable disable warnings

//=============================================================
//View Models
//=============================================================
public class RegisterVM
{
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(20, ErrorMessage = "Name cannot exceed 20 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [MaxLength(30, ErrorMessage = "Email cannot exceed 30 characters")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MaxLength(50, ErrorMessage = "Password cannot exceed 50 characters")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*?&#]{8,}$",
        ErrorMessage = "Password must contain at least one capital letter, one number, and one symbol (@$!%*?&#)")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Confirm password is required")]
    [Compare("Password", ErrorMessage = "Password and confirmation password do not match")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [MaxLength(11, ErrorMessage = "Phone number cannot exceed 11 characters")]
    [RegularExpression(@"^\d{10,11}$", ErrorMessage = "Phone number must be 10-11 digits")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "User type is required")]
    public string UserType { get; set; } // "Admin" or "Customer"

    [Required(ErrorMessage = "Photo is required")]
    public IFormFile Photo { get; set; }

    public string Id { get; set; }

    public string PhotoURL { get; set; }
}

public class AdminRegisterVM
{
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(20, ErrorMessage = "Name cannot exceed 20 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [MaxLength(30, ErrorMessage = "Email cannot exceed 30 characters")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MaxLength(50, ErrorMessage = "Password cannot exceed 50 characters")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*?&#]{8,}$",
        ErrorMessage = "Password must contain at least one capital letter, one number, and one symbol (@$!%*?&#)")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Confirm password is required")]
    [Compare("Password", ErrorMessage = "Password and confirmation password do not match")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [MaxLength(11, ErrorMessage = "Phone number cannot exceed 11 characters")]
    [RegularExpression(@"^\d{10,11}$", ErrorMessage = "Phone number must be 10-11 digits")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Admin photo is required")]
    public IFormFile Admin_Photo { get; set; }

    // Auto-generated ID (AXXX format)
    public string Id { get; set; }
    public string Admin_PhotoURL { get; set; }
}

public class CustomerRegisterVM
{
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(20, ErrorMessage = "Name cannot exceed 20 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [MaxLength(30, ErrorMessage = "Email cannot exceed 30 characters")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MaxLength(50, ErrorMessage = "Password cannot exceed 50 characters")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*?&#]{8,}$",
        ErrorMessage = "Password must contain at least one capital letter, one number, and one symbol (@$!%*?&#)")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Confirm password is required")]
    [Compare("Password", ErrorMessage = "Password and confirmation password do not match")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [MaxLength(11, ErrorMessage = "Phone number cannot exceed 11 characters")]
    [RegularExpression(@"^\d{10,11}$", ErrorMessage = "Phone number must be 10-11 digits")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Customer photo is required")]
    public IFormFile Photo { get; set; }

    // Auto-generated ID (CXXX format)
    public string Id { get; set; }
    public string PhotoURL { get; set; }
}