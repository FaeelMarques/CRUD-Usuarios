using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model.Application.Interface;
using Model.Domain.Entities;
using Model.Presentation.Mapping.Interface;
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
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_usuarioService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_usuarioService.GetById(id));
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
                return Ok("Usuario Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Update( UsuarioVM usuarioVM)
        {
            try
            {
                if (usuarioVM == null)
                    return NotFound();

                var User = _mapUsuario.Map<UsuarioVM, Usuario>(usuarioVM);

                _usuarioService.Update(User);

                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete(UsuarioVM usuarioVM)
        {
            try
            {
                if (usuarioVM == null)
                    return NotFound();

                var User = _mapUsuario.Map<UsuarioVM, Usuario>(usuarioVM);
                _usuarioService.Remove(User);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}