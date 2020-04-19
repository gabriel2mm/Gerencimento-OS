﻿
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GDR.Models
{
    [Table("Users")]
    public class User : IdentityUser
    {
        [Column("First_name")]
        [Display(Name="Nome")]
        [Required(ErrorMessage = "Este campo é obrogatório")]
        [StringLength(50, ErrorMessage = "First_name só pode conter 50 caractres")]
        public string First_Name { get; set; }

        [Column("Last_name")]
        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "Este campo é obrogatório")]
        [StringLength(50, ErrorMessage = "Last_name só pode conter 50 caractres")]
        public string Last_name { get; set; }

        [Column("Login")]
        [Required(ErrorMessage = "Este campo é obrogatório")]
        [MinLength(6, ErrorMessage = "Este campo deve ter no mínimo 6 caracteres")]
        [StringLength(30, ErrorMessage = "Login só pode conter 30 caractres")]
        public string Login { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        [EmailAddress(ErrorMessage = "Informe um E-mail válido")]
        public override string Email { get => base.Email ; set => base.Email = value; }

    }
}
