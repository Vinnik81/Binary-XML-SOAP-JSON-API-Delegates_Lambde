using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        class Person
        {
            public Person()
            {
            }
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{Name} {Surname} {Age}";
            }
        }
        static void Main(string[] args)
        {
            // Binary, XML, SOAP, JSON

            //List<Person> people = new List<Person>();
            //people.Add(new Person { Name = "Farid", Surname = "Abdullayev", Age = 26 });
            //people.Add(new Person { Name = "Farid", Surname = "Abdullayev", Age = 26 });
            //people.Add(new Person { Name = "Farid", Surname = "Abdullayev", Age = 26 });

            //using (FileStream stream = new FileStream("text.txt", FileMode.OpenOrCreate))
            //{
            //    foreach (var item in people)
            //    {
            //        byte[] bytes = Encoding.UTF8.GetBytes(item.ToString() + "\n");
            //        stream.Write(bytes, 0, bytes.Length);
            //    }
            //}


            //using (FileStream stream = new FileStream("text.txt", FileMode.Open))
            //{
            //    byte[] buffer = new byte[20];
            //    int count;

            //    while ((count = stream.Read(buffer, 0, 20)) != 0)
            //    {
            //        var str = Encoding.UTF8.GetString(buffer);
            //        Console.WriteLine(str);
            //    }

            //}


            ///////// 1 - Binary Write
            ///
            // var person = new Person { Name = "Farid", Surname = "Abdullayev", Age = 26 };
            //BinaryFormatter formatter = new BinaryFormatter();

            //using (var fs = new FileStream("person.bin",FileMode.Create))
            //{
            //    formatter.Serialize(fs, person);
            //}




            ///////// 2 - Binary Read

            //Person person;

            //BinaryFormatter formatter = new BinaryFormatter();
            //using (var fs = new FileStream("person.bin",FileMode.Open))
            //{
            //    person = formatter.Deserialize(fs) as Person;
            //}


            //Console.WriteLine(person);


            /////////// 3 - Binary Write list
            //List<Person> people = new List<Person>();
            //people.Add(new Person { Name = "Farid", Surname = "Abdullayev", Age = 26 });
            //people.Add(new Person { Name = "Sawa", Surname = "Cerkasov", Age = 26 });
            //people.Add(new Person { Name = "Mawa", Surname = "Slepcov", Age = 26 });


            //BinaryFormatter formatter = new BinaryFormatter();
            //using (var fs = new FileStream("people.bin", FileMode.Create))
            //{
            //    formatter.Serialize(fs, people);
            //}



            ///////// 4 - Binary Read list
            //List<Person> people;


            //BinaryFormatter formatter = new BinaryFormatter();
            //using (var fs = new FileStream("people.bin", FileMode.Open))
            //{
            //    people = formatter.Deserialize(fs) as List<Person>;
            //}

            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}



            /////////// 5 - XML //      [Serializable] , Constructor()
            //List<Person> people = new List<Person>();
            //people.Add(new Person { Name = "Farid", Surname = "Abdullayev", Age = 26 });
            //people.Add(new Person { Name = "Sawa", Surname = "Cerkasov", Age = 26 });
            //people.Add(new Person { Name = "Mawa", Surname = "Slepcov", Age = 26 });

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
            //using (var fs = new FileStream("people.xml",FileMode.Create))
            //{
            //    xmlSerializer.Serialize(fs, people);
            //}


            ///////// 6 - XML READ //    
            //List<Person> people;

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
            //using (var fs = new FileStream("people.xml", FileMode.Open))
            //{
            //   people = xmlSerializer.Deserialize(fs) as List<Person>;
            //}

            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}


            /////////// 7   JSON FORMAT WRITE

            //List<Person> people = new List<Person>();
            //people.Add(new Person { Name = "Farid", Surname = "Abdullayev", Age = 26 });
            //people.Add(new Person { Name = "Sawa", Surname = "Cerkasov", Age = 26 });
            //people.Add(new Person { Name = "Mawa", Surname = "Slepcov", Age = 26 });


            //string json = JsonSerializer.Serialize(people);
            //Console.WriteLine(json);
            //File.WriteAllText("people.json", json);



            /////// 8   JSON FORMAT READ

            List<Person> people;
            string json = File.ReadAllText("people.json");
            people = JsonSerializer.Deserialize<List<Person>>(json);

            //people.Add(new Person { Name = "999", Surname = "9999", Age = 9999 });

            //string jsonjs = JsonSerializer.Serialize(people); 
            //File.WriteAllText("people.json", jsonjs);

            foreach (var item in people)
            {
                Console.WriteLine(item);
            }


            ///////////// 9   JSON FORMAT WRITE

            //var person = new Person { Name = "Farid", Surname = "Abdullayev", Age = 26 };


            //string json = JsonSerializer.Serialize(person);
            //Console.WriteLine(json);
            //File.WriteAllText("person.json", json);


            /////////// 10   JSON FORMAT READ

            //string json = File.ReadAllText("person.json");

            //var person  = JsonSerializer.Deserialize<Person>(json);
            //Console.WriteLine(person);


        }
    }
}