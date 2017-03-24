using System;
using System.Collections.Generic;

namespace mvc.Models
{
    public class DbName : Attribute
    {
        // Private fields.
        private string name;

        private static string Read(IEnumerable <System.Reflection.CustomAttributeData> customAttributes)
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
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ReadTable(Object obj)
        {
            if(obj == null)
            {
                return null;
            }
            return Read(obj.GetType().CustomAttributes);
        }

        public static void ReadFields(Object obj)
        {
            
            foreach (var prop in (System.Reflection.PropertyInfo[])((System.Reflection.TypeInfo)obj.GetType()).DeclaredProperties)
            {
                var type = prop.PropertyType.Name;
                var dbName = Read(prop.CustomAttributes);
            }
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
}