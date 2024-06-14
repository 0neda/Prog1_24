using System;
using MySql.Data.MySqlClient;

namespace FlyWithUs.Utils
{
    public static class DatabaseAux
    {
        public static bool dbConnected = false;
        public static void ConnectDatabase()
        {
            string myConnectionString = "server=127.0.0.1;port=3306;uid=progbd;pwd=A12o#ek%asn!@#;database=IMOVEIS_NOIMAGES";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();
                    Console.WriteLine("Conectado ao banco de dados com sucesso!");
                    dbConnected = true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"[ERRO]: {ex.Message}");
                dbConnected = false;
            }
        }
    }
}