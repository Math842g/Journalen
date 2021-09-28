using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Journalen
{
    class Journal
    {
        #region Attributes
        public List<Journal> journals = new List<Journal>();
        string name;
        string cpr;
        string address;
        string prefDoctor;
        string phone;
        string email;
        string age;
        #endregion
        #region Constructors
        public Journal()
        {

        }
        public Journal(string _name, string _cpr, string _address, string _prefDoctor, string _phone, string _email)
        {
            Name = _name;
            Cpr = _cpr;
            Address = _address;
            PrefDoctor = _prefDoctor;
            Phone = _phone;
            Email = _email;
        }
        #endregion
        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Cpr
        {
            get { return cpr; }
            set { cpr = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string PrefDoctor
        {
            get { return prefDoctor; }
            set { prefDoctor = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone= value; }
        }
        public string Email
        {
            get { return email; }
            set { email= value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }



        #endregion
        #region Methods
        public void AddToList(Journal j)
        {
            journals.Add(j);
        }
        public void AddFile(string name)
        {
            FileStream file = new FileStream(@".\" + name + ".txt", FileMode.Create);
            using (StreamWriter writer = new StreamWriter(file))

                foreach (Journal j in journals)
                {
                    writer.WriteLine("Name: " + j.Name + "\nCpr: " + j.Cpr + "\nAdress: " + j.Address + "\nPreferred doctor: " + j.PrefDoctor + "\nPhone number: " + j.Phone + "\nEmail: " + j.Email);
                }
        }
        public string ReadFromFile(string findName)
        {
            FileStream file = new FileStream(@".\" + findName + ".txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string journalText = "";
            while (!reader.EndOfStream)
            {
                journalText += reader.ReadLine().ToString() + "\n";
            }
            file.Close();
            reader.Close();
            return journalText;
        }
        #endregion
    }
}
