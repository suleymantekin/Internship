using System;
using System.IO;
namespace Mod3_Self_Assesment_Lab
{
    abstract class Person : IDisposable
    {
        public Person(string firstName, string lastName, DateTime birthDate, string adressLine1, string adressLine2, string city, string state, string postal, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.AdressLine1 = adressLine1;
            this.AdressLine2 = adressLine2;
            this.City = city;
            this.State = state;
            this.Postal = postal;
            this.Country = country;
                    }

        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string adressLine1;
        private string adressLine2;
        private string city;
        private string state;
        private string postal;
        private string country;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string AdressLine1 { get => adressLine1; set => adressLine1 = value; }
        public string AdressLine2 { get => adressLine2; set => adressLine2 = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Postal { get => postal; set => postal = value; }
        public string Country { get => country; set => country = value; }

        StreamWriter streamWriter;


        public bool WriteDetails(string fileName){
            bool result = false;
            streamWriter = new StreamWriter(fileName);

            string[] person = { this.FirstName, this.LastName, this.BirthDate.ToString(), this.adressLine1, this.AdressLine2, this.City, this.State, this.Postal, this.Country };

            try{
                using(streamWriter){
                    foreach(string line in person){
                        streamWriter.WriteLine(line);
                    }
                }
                Console.WriteLine("\nThe {0} is written.", fileName);
                result = true;
            }
            catch{
                Console.WriteLine("\nThe file couldn't be written.");
                result = false;
            }
            finally{
                streamWriter.Close();
                streamWriter = null;
            }
            return result;
        }

        ~Person(){
            if (streamWriter != null)
            {
                Dispose(true);            }

        }

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if(streamWriter != null){
                        streamWriter.Close();
                    }
                }

                disposedValue = true;
            }
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
