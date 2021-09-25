﻿using System;
using Dominio;
using Persistencia;

namespace Consola
{
    class Program
    {
        private static I_RepositorioPersona _repositorioPersona = new RepositorioPersona(new Persistencia.AppContext());
        private static I_RepositorioEmpresa _repositorioEmpresa = new RepositorioEmpresa(new Persistencia.AppContext());
        private static I_RepositorioCliente _repositorioCliente = new RepositorioCliente(new Persistencia.AppContext());
        private static I_RepositorioEmpleado _repositorioEmpleado = new RepositorioEmpleado(new Persistencia.AppContext());
        private static I_RepositorioDirectivo _RepositorioDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine(" ------ Bienvenido ----- ");
            
            //CRUD para "Persona"
            //AddPersona();
            //UpdatePersona();
            //DeletePersona();
            //GetPersona();

            //CRUD para "Empresa"
            //AddEmpresa();
            UpdateEmpresa();

            //CRUD para "Cliente"

            //CRUD para "Empleado"

            //CRUD para "Directivo"
        }

//CRUD para "Persona"

        //Metodo para crear la Persona
        private static void AddPersona()
        {
            Console.WriteLine(" -- Se añadirá una 'Persona' en la BD 'Empresa' TB 'Personas'. -- ");

            var persona = new Persona
            {
                Nombre = "Juan Urdaneta",
                FechaNacimiento = new DateTime(1995, 05, 12)
            };

            _repositorioPersona.AddPersona(persona);
            Console.WriteLine("-- Se ha añadido correctamente, por favor verifique la BD. -- ");
        }

        
        //Metodo para actualizar la Persona
        private static void UpdatePersona()
        {
            Console.WriteLine(" -- Se actualizará una 'Persona' en la BD 'Empresa' TB 'Personas'. -- ");

            var persona = new Persona
            {
                Id = 4,
                Nombre = "Juan Editado",
                FechaNacimiento = new DateTime(1995, 05, 12)
            };
            
            _repositorioPersona.UpdatePersona(persona);
            Console.WriteLine("-- Se ha actualizado correctamente, por favor verifique la BD. -- ");
        }

        //Metodo para eliminar la Persona
        private static void DeletePersona()
        {
            Console.WriteLine(" -- Se eliminará una 'Persona' en la BD 'Empresa' TB 'Personas'. -- ");
                       
            _repositorioPersona.DeletePersona(4); //se registra en el () el Id de la persona

            Console.WriteLine("-- Se ha eliminado correctamente, por favor verifique la BD. -- ");
        }

//CRUD para "Empresa"

        //Metodo para crear la Empresa
        private static void AddEmpresa()
        {
            Console.WriteLine(" -- Se añadirá una 'Empresa' en la BD 'Empresa' TB 'Empresas'. -- ");

            var empresa = new Empresa
            {
                Nombre = "Nany SAS",
                CIF = "AAS2Prueba2"
            };

            _repositorioEmpresa.AddEmpresa(empresa);
            Console.WriteLine("-- Se ha añadido correctamente, por favor verifique la BD. -- ");
        }

        //Metodo para actualizar la Empresa
        private static void UpdateEmpresa()
        {
            Console.WriteLine(" -- Se actualizará una 'Empresa' en la BD 'Empresa' TB 'Empresas'. -- ");

            var empresa = new Empresa
            {
                Id = 1,
                Nombre = "Lala SAS",
                CIF = "AAS2Prueba1"
            };
            
            _repositorioEmpresa.UpdateEmpresa(empresa);
            Console.WriteLine("-- Se ha actualizado correctamente, por favor verifique la BD. -- ");
        }
        
    }
}