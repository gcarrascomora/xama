using System;
using System.Collections.Generic;

namespace holamundo.lista
{
    public class Datos
    {
        public Datos()
        {
        }
        public List<Person> Persona()
        {
            var lista = new List<Person>();
            lista.Add(new Person() { personId = 1, nombrePersona = "gustavo", apellidoPersona = "carrasco", correoPersona = "gustavo@gustavo.cl" });
            lista.Add(new Person() { personId = 2, nombrePersona = "gustavo", apellidoPersona = "carrasco", correoPersona = "gustavo@gustavo.cl" });
            lista.Add(new Person() { personId = 3, nombrePersona = "pamela", apellidoPersona = "carrasco", correoPersona = "gustavo@gustavo.cl" });
            lista.Add(new Person() { personId = 4, nombrePersona = "lastenia", apellidoPersona = "carrasco", correoPersona = "gustavo@gustavo.cl" });
            lista.Add(new Person() { personId = 5, nombrePersona = "juan", apellidoPersona = "carrasco", correoPersona = "gustavo@gustavo.cl" });
            lista.Add(new Person() { personId = 6, nombrePersona = "daniel", apellidoPersona = "carrasco", correoPersona = "gustavo@gustavo.cl" });
            lista.Add(new Person() { personId = 7, nombrePersona = "luna", apellidoPersona = "carrasco", correoPersona = "gustavo@gustavo.cl" });

            return lista;
        }
    }
}
