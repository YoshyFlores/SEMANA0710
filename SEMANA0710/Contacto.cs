using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SEMANA0710
{
    class Contacto
    {

        public int _contactoId { get; set; }
        public string _nombre { get; set; }
        public int _contactoCasa_Trabajo { get; set; }
        public string _empresaT { get; set; }

        private Crud crud = new Crud();

        
        public MySqlDataReader getContacto()
        {
            //se cambio la c por C, en contacto
            string query = "SELECT contactoId, nombre, contactoCasa_Trabajo, empresaT FROM contacto";

            return crud.select(query);
        }
        public Boolean newEditContacto(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO contacto(contactoId, nombre, contactoCasa_Trabajo, empresaT)" +
                    "VALUES ('" + _contactoId + "', '" + _nombre + "', '" + _contactoCasa_Trabajo + "', '" + _empresaT + "')";
                crud.executeQuery(query); //llamato al metodo executeQuery de la clase Crud
                return true;
            }
            else if (action == "editar")
            {
                string query = "UPDATE contacto SET "
                    + "nombre='" + _nombre + "',"
                    + "contactoCasa_Trabajo='" + _contactoCasa_Trabajo + "',"
                    + "empresaT='" + _empresaT + "'"
                    + "WHERE "
                    + "contactoId='" + _contactoId + "'";
                crud.executeQuery(query);
                return true;
            }
            return false;
        }
        //metodo para eliminar
        public Boolean eliminarContacto()
        {
            string query = "DELETE FROM contacto WHERE contactoId='" + _contactoId + "'";
            crud.executeQuery(query);
            return true;
        }
    }
}
