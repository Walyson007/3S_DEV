using EventPlus.WebAPI.BdContextEvent;
using EventPlus.WebAPI.Interfaces;
using EventPlus.WebAPI.Models;

namespace EventPlus.WebAPI.Repositories;

public class InstituicaoRepository : IInstituicaoRepository
{
    private readonly EventContext _context;
    public InstituicaoRepository(EventContext context)
    {
        _context = context;
    }
    public void Atualizar(Guid id, Instituicao instituicao)
    {
        var instituicaoBuscado = _context.Instituicaos.Find(id);

        if (instituicaoBuscado != null)
        {
            instituicaoBuscado.NomeFantasia = instituicao.NomeFantasia;
            _context.SaveChanges();
        }
    }

    public Instituicao BuscarPorId(Guid id)
    {
        return _context.Instituicaos.Find(id)!;
    }

    public void Cadastrar(Instituicao instituicao)
    {
        _context.Instituicaos.Add(instituicao);
        _context.SaveChanges();
    }

    public void Deletar(Guid id)
    {
        var instituicaoBuscado = _context.Instituicaos.Find(id);
        if (instituicaoBuscado != null)
        {
            _context.Instituicaos.Remove(instituicaoBuscado);
            _context.SaveChanges();
        }
    }

    public List<Instituicao> Listar()
    {
        return _context.Instituicaos
            .OrderBy(instituicao => instituicao.NomeFantasia)
            .ToList();
    }
}
