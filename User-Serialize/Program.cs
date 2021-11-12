using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace User_Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //User user = new User();
            //user.Name = "Martin";
            //user.Surname = "Heidegger";
            //user.Age = 77;

            //Serialize(user, "Martin");

            //Console.WriteLine(Deserialize("Martin"));
            //List<string> strList = new List<string>();
            //strList.Add("kdk");
            //strList.Add("kdkjdj");
            //strList.Add("kdkkdckdh");

            string path = @"C:\Users\agilab\Desktop\Martin.txt";
            //WriteAll(path, strList);
            foreach (var item in ReadAll(path))
            {
                Console.WriteLine(item);
            }

        }
        public static void Serialize(User user, string filename)
        {
            string path = @"C:\Users\agilab\Desktop\" + filename + ".txt";

            Stream stream = new FileStream(path, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, user);
        }
        public static User Deserialize(string filename)
        {
            string path = @"C:\Users\agilab\Desktop\" + filename + ".txt";
            Stream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            var data = (User)bf.Deserialize(stream);
            return data;
        }

        public static void WriteAll(string path, List<string> arr)
        {
            File.WriteAllLines(path, arr);
        }

        public static List<string> ReadAll(string path)
        {
            List<string> newList = new List<string>();

            foreach (var item in File.ReadAllLines(path))
            {
                newList.Add(item);
            }
            return newList;
        }
    }
}
