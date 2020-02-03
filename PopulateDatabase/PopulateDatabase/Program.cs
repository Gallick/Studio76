using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace PopulateDatabase
{
    class Program
    {
        private const string connectionString = @"Data Source=B602-012;Initial Catalog=Studio76;Integrated Security=True";
        private static Random rdm = new Random();

        static void Main(string[] args)
        {
            //GetPersonAPI();
            UpdateAddresses(GetAddressesFromFile("./Addresses.txt"));           


            Console.Read();
        }

        private static void GetPersonAPI()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://uinames.com/api/?region=england&ext&amount=50"));
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            ParseToPerson(jsonString);
        }

        private static void ParseToPerson(string data)
        {
            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(data);
            int i = 1000;
            foreach (Person person in people)
            {
                InsertPersonToDatabase(i, person);
                i++;
            }      
        }

        private static void InsertPersonToDatabase(int id, Person p)
        {
            string post = "BT" + rdm.Next(10, 99) + " " + rdm.Next(1, 9) + RandomString(2);
            string phone = p.phone.Substring(p.phone.IndexOf(')') + 1, p.phone.Length - p.phone.IndexOf(')') - 1);
            phone = phone.Replace(" ", "");
            string phoneStart = "0447" + phone;
            //Console.WriteLine(phoneStart + "\n" + phoneStart.Length);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Customer (CustomerID, CustomerForename, CustomerSurname, CustomerDOB, Street, Town, County, PostCode, TelNo, Email) VALUES (@id, @forename, @surname, @dob, @street, @town, @county, @post, @tel, @email)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DateTime d = UnixTimeStampToDateTime(p.birthday.raw);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@forename", p.name);
                    command.Parameters.AddWithValue("@surname", p.surname);
                    command.Parameters.AddWithValue("@dob", d.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@street", p.region);
                    command.Parameters.AddWithValue("@town", p.region);
                    command.Parameters.AddWithValue("@county", "Londonderry");
                    command.Parameters.AddWithValue("@post", post);
                    command.Parameters.AddWithValue("@tel", phoneStart);
                    command.Parameters.AddWithValue("@email", p.email);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result < 0)
                    {
                        Console.WriteLine("ERROR!\n" + result);
                    }
                    else
                    {
                        Console.WriteLine(p.name + " " + p.surname + " successfully added to the database!");
                    }
                }
            }
        }

     
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp);
            return dtDateTime;
        }

        private static List<Address> GetAddressesFromFile(string path)
        {
            List<Address> addresses = new List<Address>();

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (line.Contains(",") != false)
                {
                    string line2 = line.Replace('"', ' ');
                    string[] lineComps = line2.Split(',');
                    addresses.Add(new Address(lineComps[0], lineComps[1]));
                }
            }

            return addresses;
        }

        public static void UpdateAddresses(List<Address> _add)
        {
            for (int i = 1000; i < 1050; i++)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Customer SET Street = '" + _add[i - 1000].Street + "', Town = '" + _add[i - 1000].Town + "' WHERE CustomerID = '" + i + "'";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        try
                        {
                            conn.Open();
                            int result = command.ExecuteNonQuery();

                            if (result < 0)
                            {
                                Console.WriteLine("Error!\n" + result);
                            }
                            else
                            {
                                Console.WriteLine("#" + i + "\t Updated");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error!\n" + ex.Message + "\n");
                        }

                    }
                    conn.Close();
                }
            }
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rdm.Next(s.Length)]).ToArray());
        }
    }
}
