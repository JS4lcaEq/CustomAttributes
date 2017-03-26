using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace mvc.Models
{
    [DbName("CLASS1")]
    public class Class1
    {
        private string _prop1;

        [DbName("PROP1")]
        public string Prop1
        {
            get
            {
                return _prop1;
            }

            set
            {
                _prop1 = value;
            }
        }

        public static List<Class1> GetList()
        {
            List<Class1> list = new List<Class1>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select * from INFORMATION_SCHEMA.COLUMNS";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = new SqlConnection(ConfigurationManager.AppSettings["SqlConnection"] as string);

            cmd.Connection.Open();

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Class1 item = new Class1();
                    item.Prop1 = reader.GetString(3);
                    list.Add(item);
                }
            }
            else
            {
                
            }
            reader.Close();

            cmd.Connection.Close();
            return list;
        }
    }
}