 using Exo.WebApi2.Contexts;
 using Exo.WebApi2.Models;
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;
 namespace Exo.WebApi2.Repositories
 {
 public class ProjetoRepository
 {
 private readonly ExoContext _context;
 public ProjetoRepository(ExoContext context)
 {
 _context = context;
 }
 public List<Projeto> Listar()
 {
 return _context.Projetos.ToList();
 }
 }
 }
