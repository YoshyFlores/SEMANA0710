﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SEMANA0710
{
    class Connection
    {
        //propiedades
        private MySqlConnection conn = 
            new MySqlConnection("Server=localhost;Database=smis537818;Uid=root;" +
                "Pwd=usbw;SSL Mode=None");
        public MySqlCommand command;

        //abrir conexion
        public MySqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        //cerrar la conexion
        public MySqlConnection closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }

    }
}
