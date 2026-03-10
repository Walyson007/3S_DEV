using EventPlus.WebAPI.DTO;
using EventPlus.WebAPI.Interfaces;
using EventPlus.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventPlus.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TipoEventoController : ControllerBase
{
    private ITipoEventoRepository _tipoEventoRepository;

    public TipoEventoController(ITipoEventoRepository tipoEventoRepository)
    {
        _tipoEventoRepository = tipoEventoRepository;
    }

    /// <summary>
    /// EndPoint da api que faz chamada para o repositorio listar os tipos de eventos cadastrados no banco de dados e retorna a resposta para o cliente
    /// </summary>
    /// <returns>Status code 200 e a list de eventos</returns>
    [HttpGet]
    public IActionResult Listar()
    {
        try
        {
            return Ok(_tipoEventoRepository.Listar());
        }
        catch (Exception erro)
        {
            return BadRequest(erro.Message);
        }
    }

    /// <summary>
    /// EndPoint da api que faz chamada para o repositorio buscar um tipo de evento especifico
    /// </summary>
    /// <param name="id">Id do tipo de evento buscado</param>
    /// <returns>Status code 200 e tipo de evento buscado
    /// </returns>
    [HttpGet("{id}")]
    public IActionResult BuscarPorId(Guid id)
    {
        try
        {
            return Ok(_tipoEventoRepository.BuscarPorId(id));
        }
        catch (Exception erro)
        {

            return BadRequest(erro.Message);
        }
    }

    /// <summary>
    /// EndPoint da api que faz a chamada para o metodo de cadastrar um tipo de evento no banco de dados, recebendo os dados do tipo de evento pelo corpo da requisição e retornando a resposta para o cliente
    /// </summary>
    /// <param name="tipoEvento">Tipo de evento a ser cadastrado</param>
    /// <returns>Status code 201 e o tipo de evento cadastrado</returns>
    [HttpPost]
    public IActionResult Cadastrar(TipoEventoDTO tipoEvento)
    {
        try
        {
            var novoTipoEvento = new TipoEvento
            {
                Titulo = tipoEvento.Titulo!
            };

            _tipoEventoRepository.Cadastrar(novoTipoEvento);

            return  StatusCode(201, tipoEvento);
        }
        catch (Exception erro)
        {
            return BadRequest(erro.Message);
        }
    }

    /// <summary>
    /// EndPoint da api que faz a chamada para o metodo de atualizar um tipo de evento no banco de dados o cliente
    /// </summary>
    /// <param name="id">Id do tipo de evento a ser atualizado</param>
    /// <param name="tipoEvento">tipo de evento com os dados atualizado</param>
    /// <returns>Status code 204 e o tipo de evento atualizado</returns>
    [HttpPut("{id}")]
    public IActionResult Atualizar(Guid id, TipoEvento tipoEvento)
    {
        try
        {
            _tipoEventoRepository.Atualizar(id, tipoEvento);

            return StatusCode(204, tipoEvento);
        }
        catch (Exception erro)
        {
            return BadRequest(erro.Message);
        }
    }

    /// <summary>
    /// EndPoint da api que faz a chamada para o metodo de deletar um tipo de evento do banco de dados usando o id para localizar
    /// </summary>
    /// <param name="id">Id do tipo do evento a ser excluido</param>
    /// <returns>Status code 204</returns>
    [HttpDelete("{id}")]
    public IActionResult Deletar(Guid id)
    {
        try
        {
            _tipoEventoRepository.Deletar(id);
            return StatusCode(204);
        }
        catch (Exception erro)
        {
            return BadRequest(erro.Message);
        }
    }
}
