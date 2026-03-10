using EventPlus.WebAPI.Models;

namespace EventPlus.WebAPI.Interfaces;

public interface IComentarioEventoRepository
{
    void CadastroEvento(ComentarioEvento comentarioEvento);
    void Deletar(Guid id);
    List<ComentarioEvento> Listar(Guid Id_Evento);
    ComentarioEvento BuscarPorIdUsuario(Guid Id_Usuario, Guid Id_Evento);
    List<ComentarioEvento> ListarSomenteExibir(Guid Id_Evento);
}
