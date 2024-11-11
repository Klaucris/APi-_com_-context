 using Exo.WebApi2.Models;
 using Exo.WebApi2.Repositories;
 using Microsoft.AspNetCore.Authorization;
 using Microsoft.AspNetCore.Mvc;
 using System;
 namespace Exo.WebApi2.Controllers
 {
 [Route("api/[controller]")]
 [ApiController]
 public class ProjetosController : ControllerBase
 {
 private readonly ProjetoRepository
 _projetoRepository;
 public ProjetosController(ProjetoRepository
 projetoRepository)
 {
 _projetoRepository = projetoRepository;
 }
 [HttpGet]
 public IActionResult Listar()
 {
 return Ok(_projetoRepository.Listar());
 }
 }
 }
 