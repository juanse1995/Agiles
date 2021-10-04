using System.ComponentModel;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Data.Common;
using System;
using Dominio;
using Persistencia;

namespace Consola
{
    class Program
    {
        private static I_RepositorioPersona _repositorioPersona = new RepositorioPersona(new Persistencia.ApplicationContext());
        private static I_RepositorioEmpresa _repositorioEmpresa = new RepositorioEmpresa(new Persistencia.ApplicationContext());
        private static I_RepositorioCliente _repositorioCliente = new RepositorioCliente(new Persistencia.ApplicationContext());
        private static I_RepositorioEmpleado _repositorioEmpleado = new RepositorioEmpleado(new Persistencia.ApplicationContext());
        private static I_RepositorioDirectivo _RepositorioDirectivo = new RepositorioDirectivo(new Persistencia.ApplicationContext());
        static void Main(string[] args)
        {
            Console.WriteLine(" ------ Bienvenido ----- ");
            //Hola esta prueba
            //CRUD para "Persona"
            AddPersona();
            //BuscarPersona(3);

            //UpdatePersona();
            //DeletePersona();
            //GetPersona();

            //CRUD para "Empresa"
            //AddEmpresa();
            //UpdateEmpresa();
            //DeleteEmpresa();
            //GetEmpresa();

            //CRUD para "Cliente"
            //AddCliente();
            //EsCliente();
            //UpdateCliente();
            //DeleteCliente();

            //CRUD para "Empleado"
            //AddEmpleado();
            //TrabajaEn();
            //UpdateEmpleado();
            //DeleteEmpleado();

            //CRUD para "Directivo"
            //AddDirectivo();
            //Subordinado();
            //Dirige();
            //UpdateDirectivo();
            //DeleteDirectivo();
        }
        //CRUD para "Persona"

        //Metodo para crear la Persona
        private static void AddPersona()
        {
            Console.WriteLine(" -- Se añadirá una 'Persona' en la BD 'Empresa' TB 'Personas'. -- ");

            var persona = new Persona
            {
                Nombre = "Fabian",
                Apellidos = "Jaramillo",
                Documento = "9771362",
                FechaNacimiento = new DateTime(1984, 12, 25)
            };

            _repositorioPersona.AddPersona(persona);
            Console.WriteLine("-- Se ha añadido correctamente, por favor verifique la BD. -- ");
        }

        //Metodo para buscar persona
        private static void BuscarPersona(int idPersona)
        {
            Console.WriteLine(" -- Se buscará una 'Persona' en la BD 'Empresa' TB 'Personas'. -- ");

            var persona = _repositorioPersona.GetPersona(idPersona);
            Console.WriteLine("La persona encontrada con el ID " + persona.Id + " es " + persona.Nombre + " " + persona.Apellidos);
        }


        //Metodo para actualizar la Persona
        private static void UpdatePersona()
        {
            Console.WriteLine(" -- Se actualizará una 'Persona' en la BD 'Empresa' TB 'Personas'. -- ");

            var persona = new Persona
            {
                Id = 1,
                Nombre = "Juan Esteban",
                Apellidos = "Urdaneta",
                Documento = "1234",
                FechaNacimiento = new DateTime(1995, 05, 12)
            };

            _repositorioPersona.UpdatePersona(persona);
            Console.WriteLine("-- Se ha actualizado correctamente, por favor verifique la BD. -- ");
        }

        //Metodo para eliminar la Persona
        private static void DeletePersona()
        {
            Console.WriteLine(" -- Se eliminará una 'Persona' en la BD 'Empresa' TB 'Personas'. -- ");

            _repositorioPersona.DeletePersona(1); //se registra en el () el Id de la persona

            Console.WriteLine("-- Se ha eliminado correctamente, por favor verifique la BD. -- ");
        }

        //CRUD para "Empresa"

        //Metodo para crear la Empresa
        private static void AddEmpresa()
        {
            Console.WriteLine(" -- Se añadirá una 'Empresa' en la BD 'Empresa' TB 'Empresas'. -- ");

            var empresa = new Empresa
            {
                Nombre = "Anonimo",
                CIF = "AAS2Prueba3"
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

        //Metodo para eliminar una Empresa
        private static void DeleteEmpresa()
        {
            Console.WriteLine(" -- Se eliminará una 'Empresa' en la BD 'Empresa' TB 'Empresas'. -- ");

            _repositorioEmpresa.DeleteEmpresa(1); //se registra en el () el Id de la Empresa

            Console.WriteLine("-- Se ha eliminado correctamente, por favor verifique la BD. -- ");
        }

        //CRUD para "Cliente"

        //Metodo para crear el Cliente
        private static void AddCliente()
        {
            Console.WriteLine(" -- Se añadirá un 'Cliente' en la BD 'Empresa' TB 'Clientes'. -- ");

            var cliente = new Cliente
            {
                Telefono = "310000000"
            };

            _repositorioCliente.AddCliente(cliente);
            Console.WriteLine("-- Se ha añadido correctamente, por favor verifique la BD. -- ");
        }

        //Metodo para relacionar el Cliente con la Empresa
        private static void EsCliente()
        {
            Console.WriteLine(" -- Se relacionará un 'Cliente' con una 'Empresa'. -- ");

            var cliente = _repositorioCliente.EsCliente(2, 1); //Id del cliente + Id Empresa

            Console.WriteLine("-- Se ha relacionado correctamente, por favor verifique la BD. -- ");
            Console.WriteLine("El cliente con teléfono" + cliente.Telefono + " está relacionado con la empresa" + cliente.Id);
        }


        //Metodo para actualizar el Cliente
        private static void UpdateCliente()
        {
            Console.WriteLine(" -- Se actualizará un 'Cliente' en la BD 'Empresa' TB 'Personas'. -- ");

            var cliente = new Cliente

            {
                Id = 2,
                Telefono = "3123456",
            };

            _repositorioCliente.UpdateCliente(cliente);
            Console.WriteLine("-- Se ha actualizado correctamente, por favor verifique la BD. -- ");
        }

        //Metodo para eliminar un Cliente
        private static void DeleteCliente()
        {
            Console.WriteLine(" -- Se eliminará un 'Cliente' en la BD 'Empresa' TB 'Clientes'. -- ");

            _repositorioCliente.DeleteCliente(1); //se registra en el () el Id de la Empresa

            Console.WriteLine("-- Se ha eliminado correctamente, por favor verifique la BD. -- ");
        }

        //CRUD para "Empleado"

        //Metodo para crear el Empleado
        private static void AddEmpleado()
        {
            Console.WriteLine(" -- Se añadirá un 'Empleado' en la BD 'Empresa' TB 'Empleados'. -- ");

            var empleado = new Empleado
            {
                SueldoBruto = 3500000,
                Cargo = "Programador",
            };

            _repositorioEmpleado.AddEmpleado(empleado);
            Console.WriteLine("-- Se ha añadido correctamente, por favor verifique la BD. -- ");
        }

        //Metodo para relacionar el Empleado con la Empresa
        private static void TrabajaEn()
        {
            Console.WriteLine(" -- Se relacionará un 'Empleado' con una 'Empresa'. -- ");

            var empleado = _repositorioEmpleado.TrabajaEn(2, 1); //Id del empleado + Id Empresa

            Console.WriteLine("-- Se ha relacionado correctamente, por favor verifique la BD. -- ");
            Console.WriteLine("El empleado con ID " + empleado.Id + " Está relacionado con la empresa" + empleado.Nombre);
        }


        //Metodo para actualizar el Empleado
        private static void UpdateEmpleado()
        {

            Console.WriteLine(" -- Se actualizará un 'Empleado' en la BD 'Empresa' TB 'Empleados'. -- ");

            var empleado = new Empleado

            {
                Id = 2,
                SueldoBruto = 4000000,
                Cargo = "Programador Senior"
            };

            _repositorioEmpleado.UpdateEmpleado(empleado);
            Console.WriteLine("-- Se ha actualizado correctamente, por favor verifique la BD. -- ");
        }

        //Metodo para eliminar un Empleado
        private static void DeleteEmpleado()
        {
            Console.WriteLine(" -- Se eliminará un 'Empleado' en la BD 'Empresa' TB 'Empleados'. -- ");

            _repositorioEmpleado.DeleteEmpleado(1); //se registra en el () el Id de la Empresa

            Console.WriteLine("-- Se ha eliminado correctamente, por favor verifique la BD. -- ");
        }

        //CRUD para "Directivo"

        //Metodo para crear el Directivo
        private static void AddDirectivo()
        {
            Console.WriteLine(" -- Se añadirá un 'Directivo' en la BD 'Empresa' TB 'Directivos'. -- ");

            var directivo = new Directivo
            {
                Categoria = 2,
            };

            _RepositorioDirectivo.AddDirectivo(directivo);
            Console.WriteLine("-- Se ha añadido correctamente, por favor verifique la BD. -- ");
        }

        //Metodo para relacionar el Directivo con el Empleado que dirige
        private static void Subordinado()
        {
            Console.WriteLine(" -- Se relacionará un 'Directivo' con un 'Empleado'. -- ");

            var directivo = _RepositorioDirectivo.Subordinado(2, 2); //Id del Directivo + Id Empleado subordinado

            Console.WriteLine("-- Se ha relacionado correctamente, por favor verifique la BD. -- ");
            Console.WriteLine("El Directivo con categoria " + directivo.Categoria + " su subordinado es" + directivo.Subordinado);
        }

        //Metodo para relacionar el Directivo con la Empresa que dirige
        private static void Dirige()
        {
            Console.WriteLine(" -- Se relacionará un 'Directivo' con una 'Empresa'. -- ");

            var directivo = _RepositorioDirectivo.Dirige(2, 1); //Id del Directivo + Id Empresa

            Console.WriteLine("-- Se ha relacionado correctamente, por favor verifique la BD. -- ");
            Console.WriteLine("El Directivo con categoria " + directivo.Categoria + " su empresa es" + directivo.Dirige);
        }


        //Metodo para actualizar el Directivo
        private static void UpdateDirectivo()
        {

            Console.WriteLine(" -- Se actualizará un 'Directivo' en la BD 'Empresa' TB 'Directivos'. -- ");

            var directivo = new Directivo

            {
                Id = 2,
                Categoria = 1
            };

            _RepositorioDirectivo.UpdateDirectivo(directivo);
            Console.WriteLine("-- Se ha actualizado correctamente, por favor verifique la BD. -- ");
        }

        //Metodo para eliminar un Directivo
        private static void DeleteDirectivo()
        {
            Console.WriteLine(" -- Se eliminará un 'Directivo' en la BD 'Empresa' TB 'Directivos'. -- ");

            _RepositorioDirectivo.DeleteDirectivo(1); //se registra en el () el Id de la Empresa

            Console.WriteLine("-- Se ha eliminado correctamente, por favor verifique la BD. -- ");
        }

    }

}
