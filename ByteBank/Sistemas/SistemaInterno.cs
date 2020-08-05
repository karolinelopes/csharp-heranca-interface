using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutentificavel funcionario, string senha)
        {
            bool usuarioAutentificado = funcionario.Autenticar(senha);

            if(usuarioAutentificado)
            {
                Console.WriteLine("Bem-vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}
