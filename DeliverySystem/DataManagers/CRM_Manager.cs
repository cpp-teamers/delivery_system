using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
using DeliverySystem.DataModels;
using DeliverySystem.Repositories;

namespace DeliverySystem.DataManagers
{
    class CRM_Manager
    {
        CRM store = new CRM();
        string path = @"..\..\..\DataStorage\clients.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(CRM));

        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                store = (CRM)serializer.ReadObject(fs);
            }
        }
        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(fs, store.Clients);
            }
        }


        public void AddClient(Client clntToAdd)
        {

            store.Clients.Add(clntToAdd);

            Console.WriteLine("\n>Client has been added successfully");
        }
        public void DelClient(string clientIDToDel)
        {

            foreach (Client clnt in store.Clients)
            {
                if (clnt.Id == clientIDToDel)
                {
                    store.Clients.Remove(clnt);
                    break;
                }
            }

            Console.WriteLine("\n>Client has been deleted successfully");
        }
        public void EditClient(string clntIdToEdit, string newLocation)
        {
            foreach (Client e in store.Clients)
            {
                if (e.Id == clntIdToEdit)
                {
                    e.Location = newLocation;
                    break;
                }
            }
            Console.WriteLine("\n>Client has been edited successfully");
        }
        public void DisplayAllClients()
		{
            foreach (Client c in store.Clients)
            { 
                Console.WriteLine(c);
            }
		}


    }
}
