﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_Cadastro.Model.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public string? Senha { get; set; }
        public bool TrocarSenha { get; set; }
    }
}
