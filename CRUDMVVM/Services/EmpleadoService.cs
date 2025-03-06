

using CRUDMVVM.Models;
using SQLite;

namespace CRUDMVVM.Services
{
    public class EmpleadoService
    {
        private readonly SQLiteConnection _connection;
        public EmpleadoService()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Empleado.db3");
           //Initialize Connection and create database
            _connection = new SQLiteConnection(dbPath);
            //create table
            _connection.CreateTable<Empleado>();

            /*Empleado empleado = new Empleado();
            empleado.Nombre = "Juan Perez";
            empleado.Direccion = "Choloma";
            empleado.Email = "juancito.perez@gmail.com";*/
        }

        public List<Empleado> GetAll()
        {
            //Its equal to SELECT * FROM Empleado
            return _connection.Table<Empleado>().ToList();
        }

        public int Insert(Empleado Empleado)
        {
            //Its equal to INSERT Empleado VALUES(id,....)
            return _connection.Insert(Empleado);
        }
        public int Update(Empleado Empleado) 
        {
            // Its equal to DELETE FROM Empleado WHERE id=1
            return _connection.Delete(Empleado);
        }

    }
}
