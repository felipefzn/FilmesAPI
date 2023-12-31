﻿using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();

        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filmes.Add(filme);
            Console.WriteLine("O Filme escolhido foi: " + filme.Titulo);
            Console.WriteLine("Com uma duracao de: " + filme.Duracao);
            Console.WriteLine("Este filme é do genero : " + filme.Genero);
        }
    }
}
