﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
   public static class ProjectManager
    {
        /// <summary>
        /// Функция, выполняющая функцию сериализации
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        public static void SaveToFile(Project data, string filename)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {

                serializer.Serialize(writer,data);
            }
        }
        /// <summary>
        /// Функция, выполняющая функцию десериализации
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static Project LoadFromFile(string filename)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return (Project)serializer.Deserialize<Project>(reader);
            }
        }

    }
}
