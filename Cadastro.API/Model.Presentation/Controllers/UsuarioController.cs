using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model.Application.Interface;
using Model.Domain.Entities;
using Model.Presentation.Model;

namespace Model.Presentation.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAppService _usuarioService;
        private readonly IMapper _mapUsuario;

        public UsuarioController(IUsuarioAppService usuarioService, IMapper mapUsuario)
        {
            _usuarioService = usuarioService;
            _mapUsuario = mapUsuario;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            return _usuarioService.GetAll().ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Usuario> Get(int id)
        {
            return _usuarioService.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post(UsuarioVM usuarioVM)
        {
            try
            {
                if (usuarioVM == null)
                    return NotFound();

                var User = _mapUsuario.Map<UsuarioVM, Usuario>(usuarioVM);

                _usuarioService.Add(User);
                return RedirectToAction("Get");
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Update(UsuarioVM usuarioVM)
        {
            try
            {
                if (usuarioVM == null)
                    return NotFound();

                var User = _mapUsuario.Map<UsuarioVM, Usuario>(usuarioVM);

                _usuarioService.Update(User);

                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Usuario> Delete(int id)
        {
            try
            {
                var usuario = _usuarioService.GetById(id);
                if (usuario == null)
                    return NotFound();

                _usuarioService.Remove(usuario);

                return usuario;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}