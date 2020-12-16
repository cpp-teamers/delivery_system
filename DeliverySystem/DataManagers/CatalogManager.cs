using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
using DeliverySystem.DataModels;

namespace DeliverySystem.DataManagers
{
    class CatalogManager
    {
		List<Product> prods = new List<Product>();
		string path = @"..\..\..\DataStorage\goods.json";
		DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Product>));


        public void LoadData()
		{
			using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
			{
				prods = (List<Product>)serializer.ReadObject(fs);
			}
		}

        public void SaveData()
		{
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
			{
				serializer.WriteObject(fs, prods);
			}
		}

		public void AddProduct(Product new_prod)
		{
			prods.Add(new_prod);
			Console.WriteLine("\n>New product has been added successfully");
		}

		public void DelProduct(string nameOfProd)
		{
			foreach (Product p in prods)
				if (nameOfProd == p.Name)
					prods.Remove(p);

			Console.WriteLine("\n>New product has been deleted successfully");
		}


		public void EditProduct(string nameOfProdToEditi, string newNameOfProd)
		{
			foreach (Product p in prods)
			{
				if (nameOfProdToEditi == p.Name)
				{
					p.Name = newNameOfProd;
				}
			}

			Console.WriteLine("\n>New product has been edited successfully");
		}
	}
}
