using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Mapper 
    {
        public TMapTo Map<TMapTo>(object mapFrom) where TMapTo : class, new()
        {

            var propertiesInfos = mapFrom.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).ToList();
            
            var mapToProperties = typeof(TMapTo).GetProperties(BindingFlags.Public | BindingFlags.Instance).ToList();
            //propertiesInfos.ForEach(prop =>
            //{
            //    Console.WriteLine(mapFrom);
            //    Console.WriteLine(prop.GetValue(mapFrom));
            //    Console.WriteLine(prop.PropertyType);
            //    prop.SetValue(mapFrom, "reza");
                
            //});

            var result = (TMapTo)new();
            foreach(var mapFromPropertyInfo in propertiesInfos)
            {
                var mapToSinglePorp = mapToProperties.Where(prop => prop.PropertyType == mapFromPropertyInfo.PropertyType && prop.Name == mapFromPropertyInfo.Name).FirstOrDefault();
                var test = result.GetType().GetProperties();
                var t1 = mapFromPropertyInfo.GetValue(mapFrom);

                if (mapToSinglePorp != null)
                {
                    mapToSinglePorp.SetValue(result, mapFromPropertyInfo.GetValue(mapFrom));
                }
                //foreach(var mapToPropertyInfo in mapToProperties)
                //{

                //}
            }
            return result;
        }

        private Dictionary<string, MethodInfo> GetMethods()
        {
            //Type type = typeof(TMapTo);
            Type type = typeof(string);
            //Console.WriteLine("Type is :{0}"/*, type.GetMethod()*/);
            Dictionary<string, MethodInfo> methods = new Dictionary<string, MethodInfo>();

            MethodInfo[] methodInfos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (MethodInfo methodInfo in methodInfos)
            {
                methods[methodInfo.Name] = methodInfo;
            }
            return methods;

        }

        private Dictionary<string, PropertyInfo> GetProperties()
        {
            //Type type = typeof(TMapTo);
            Type type = typeof(string);
            Dictionary<string, PropertyInfo> properties = [];

            PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                properties[propertyInfo.Name] = propertyInfo;
            }
            return properties;
        }
    }
}
