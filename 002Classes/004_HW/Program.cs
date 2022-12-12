using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создать класс Invoice. В теле класса создать три поля int account, string customer, string provider, 
которые должны быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения. 
В теле класса создать два закрытых поля string article, int quantity Создать метод расчета стоимости заказа с НДС и без НДС. 
Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
 */
namespace _004_HW
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;
        private string article;
        private int quantity;
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        private double Cost(double price)
        {
            if (price>0)
                return price*quantity;
            else
                return 0;
        }
        private double CostNDS(double price)
        {
            if (price > 0)
                return price * quantity*1.2;
            else
                return 0;
        }
        public void CostTotal(string article, int quantity)
        {
            this.quantity = quantity;
            double price = 50;
            Console.WriteLine($"account = {account}");
            Console.WriteLine($"customer = {customer}");
            Console.WriteLine($"provider = {provider}");
            Console.WriteLine($"article = {article}");
            Console.WriteLine($"quantity = {quantity}");
            Console.WriteLine($"price = {price}");
            Console.WriteLine($"сумма оплаты заказанного товара без НДС = {Cost(price)}");
            Console.WriteLine($"сумма оплаты заказанного товара с НДС = {CostNDS(price)}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(23554, "Petro", "Ukraine");
            invoice.CostTotal("1234587",5);
           
            Console.ReadLine();
        }
    }
}
