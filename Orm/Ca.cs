using System;
using System.Collections.Generic;

namespace mvc.Models
{
    public class DbName : Attribute
    {
        // Private fields.
        private string name;

        private static string Read(IEnumerable<System.Reflection.CustomAttributeData> customAttributes)
        {
            foreach (var ca in customAttributes)
            {
                if (ca.AttributeType.Name == "DbName")
                {
                    return ca.ConstructorArguments[0].Value.ToString();
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns></returns>
        public static string ReadTableName(Object obj)
        {
            if (obj == null)
            {
                return null;
            }
            return Read(obj.GetType().CustomAttributes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">objects type</param>
        /// <returns></returns>
        public static List<PropertyInfo> ReadFieldsInfo(Type type)
        {
            List<PropertyInfo> list = new List<PropertyInfo>();
            foreach (var prop in (System.Reflection.PropertyInfo[])((System.Reflection.TypeInfo)type).DeclaredProperties)
            {
                list.Add(new PropertyInfo(Read(prop.CustomAttributes), prop.PropertyType.Name));
            }
            return list;
        }

        public static List<PropertyInfo> ReadFieldsInfo(Object obj)
        {
            return ReadFieldsInfo(obj.GetType());
        }

        // This constructor defines two required parameters: name and level.

        public DbName(string name)
        {
            this.name = name;
        }

        // Define Name property.
        // This is a read-only attribute.

        public virtual string Name
        {
            get { return name; }
        }


    }

    public class PropertyInfo 
    {
        public string DbName;
        public string TypeName;


        public PropertyInfo(string dbName, string typeName)
        {
            DbName = dbName;
            TypeName = typeName;
        }
    }
}