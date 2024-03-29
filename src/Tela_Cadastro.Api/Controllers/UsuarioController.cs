﻿using Microsoft.AspNetCore.Mvc;
using Tela_Cadastro.Model.Interfaces.Repositories;
using Tela_Cadastro.Model.Models;

namespace Tela_Cadastro.Api.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Cadastrar")]
        public async Task<IActionResult> Cadastrar(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _usuarioRepository.AdicionarAsync(usuario);
            return RedirectToAction("Index");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] Usuario usuario)
        {
            if (id != usuario.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _usuarioRepository.UpdateAsync(usuario);
            return View(usuario);
        }
    }
}