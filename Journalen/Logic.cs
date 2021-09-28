using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Journalen
{
    class Logic
    {
        #region Methods
        public void CreateJournal(string name, string cpr, string adress, string pefDoctor, string phone, string email)
        {
            //instantiating object
            Journal journal = new Journal(name, cpr, adress, pefDoctor, phone, email);

            journal.AddToList(journal);
            journal.AddFile(name);
        }
        public string ReadJournal(string findName)
        {
            //instantiating object
            Journal j = new Journal();

            return j.ReadFromFile(findName);
        }
        public void CalcuateAge()
        {
            Journal j = new Journal();

            string age;
            string cpr = j.Cpr;
            DateTime cprDate = Convert.ToDateTime(cpr);
            DateTime timeNow = DateTime.Now;
            Console.WriteLine(cprDate);
        }
        #endregion
    }
}
