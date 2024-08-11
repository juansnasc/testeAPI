using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]

public class UsuarioController : ControllerBase
{
    [HttpGet("ObterDataHoraAtual")]
    public IActionResult ObterDataHora()
    {
        var obj = new{
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToShortTimeString(),
        };

        return Ok(obj);
    }

    [HttpPost("ObterDataHoraAtual2")]
    public IActionResult ObterDataHora2()
    {
        var obj = new{
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToShortTimeString(),
        };

        return Ok(obj);
    }

    [HttpPut("ObterDataHoraAtual3")]
    public IActionResult ObterDataHora3()
    {
        var obj = new{
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToShortTimeString(),
        };

        return Ok(obj);
    }

    [HttpDelete("ObterDataHoraAtual4")]
    public IActionResult ObterDataHora4()
    {
        var obj = new{
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToShortTimeString(),
        };

        return Ok(obj);
    }

    [HttpOptions("ObterDataHoraAtual5")]
    public IActionResult ObterDataHora5()
    {
        var obj = new{
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToShortTimeString(),
        };

        return Ok(obj);
    }

    [HttpGet("Apresentar/{nome}")]
    public IActionResult Apresentar(string nome)
    {
        var mensagem = $"Olá, {nome}, seja bem vindo!";
        return Ok(new {mensagem});
    }
}