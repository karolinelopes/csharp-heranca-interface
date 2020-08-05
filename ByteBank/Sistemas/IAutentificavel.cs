using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    public interface IAutentificavel
    {
        bool Autenticar(string senha);
    }
}
