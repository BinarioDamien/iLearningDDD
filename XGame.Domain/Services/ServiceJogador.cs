using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;

namespace XGame.Domain.Services
{
    public class ServiceJogador : IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador()
        {

        }

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            Guid Id = _repositoryJogador.AdicionarJogador(request);

            return new AdicionarJogadorResponse() { Id = Id, Message = "Operação Realizada com Sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                throw new Exception("AutenticarJogadorRequest Obrigatório!");
            }

            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Email é Obrigatório!");
            }

            if (IsEmail(request.Email))
            {
                throw new Exception("Email é Obrigatório!");
            }

            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("Senha é Obrigatório!");
            }

            if (request.Senha.Length < 6)
            {
                throw new Exception("Complexidade da Senha não confere!");
            }

            var response = _repositoryJogador.AutenticarJogador(request);
            return response;
        }

        private bool IsEmail(string email)
        {
            return false;
        }
    }
}
