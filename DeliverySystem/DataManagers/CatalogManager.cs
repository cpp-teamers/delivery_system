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
    class CatalogManager
    {
		Catalog catalog = new Catalog();
		string path = @"..\..\..\DataStorage\goods.json";
		DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Catalog));


        public void LoadData()
		{
			using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
			{
				catalog = (Catalog)serializer.ReadObject(fs);
			}
		}
        public void SaveData()
		{
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
			{
				serializer.WriteObject(fs, catalog.Products);
			}
		}
		public void AddProduct(Product new_prod)
		{
			catalog.Products.Add(new_prod);
			Console.WriteLine("\n>New product has been added successfully");
		}
		public void DelProduct(string nameOfProdToDel)
		{
			foreach (Product p in catalog.Products)
				if (nameOfProdToDel == p.NameProduct)
				{
					catalog.Products.Remove(p);
					break;
				}

			Console.WriteLine("\n>Product has been deleted successfully");
		}
		public void EditProduct(string nameOfProdToEdit, string newNameOfProd, decimal newPrice, double newWeight)
		{
			foreach (Product p in catalog.Products)
			{
				if (nameOfProdToEdit == p.NameProduct)
				{
					p.NameProduct = newNameOfProd;
					p.Price = newPrice;
					p.Weight = newWeight;
					break;
				}
			}
			Console.WriteLine("\n>Product has been edited successfully");
		}
		public void DisplayAllEmps()
		{
			foreach (Product prod in catalog.Products)
			{
				Console.WriteLine(prod);
			}
		}
	}
}
