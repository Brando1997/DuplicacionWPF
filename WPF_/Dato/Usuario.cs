using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_.Modelo;

namespace WPF_.Dato
{
    public class Usuario
    {
        List<UsuarioModelo> lista = new List<UsuarioModelo>();
        public void Guardar(UsuarioModelo modelo)
        {
            lista.Add(modelo);
        }
        public List<UsuarioModelo> Consultar()
        {
            return lista;
        }
    }
}
