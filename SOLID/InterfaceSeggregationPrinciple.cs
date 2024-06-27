using System;
using System.Collections.Generic;

namespace CSharpPrograms.SOLID
{
    // Interface for entities that can be printed
    public interface IPrintable
    {
        void Print();
    }

    // Interface for entities that can be stored and retrieved
    public interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
    }

    // Interface for entities that can provide details suitable for display
    public interface IDisplayable
    {
        string GetDisplayDetails();
    }

    // Interface for entities that represent a customer
    public interface ICustomer
    {
        int CustomerId { get; set; }
        string Name { get; set; }
        string Email { get; set; }
    }

    // Interface for entities that represent an invoice
    public interface IInvoice : IDisplayable
    {
        int InvoiceId { get; set; }
        ICustomer Customer { get; set; }
        DateTime Date { get; set; }
        decimal Amount { get; set; }
    }

    // Interface for entities that can print invoices
    public interface IInvoicePrinter
    {
        void Print(IInvoice invoice);
    }

    // Customer class implementing ICustomer
    public class Customer : ICustomer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    // Invoice class implementing IInvoice
    public class Invoice : IInvoice
    {
        public int InvoiceId { get; set; }
        public ICustomer Customer { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        public string GetDisplayDetails()
        {
            return $"Invoice ID: {InvoiceId}\nCustomer: {Customer.Name}\nDate: {Date.ToShortDateString()}\nAmount: {Amount.ToString("C")}";
        }
    }

    // InvoicePrinter class implementing IInvoicePrinter
    public class InvoicePrinter : IInvoicePrinter
    {
        public void Print(IInvoice invoice)
        {
            Console.WriteLine(invoice.GetDisplayDetails());
        }
    }

    // InvoiceRepository class implementing IRepository<IInvoice>
    public class InvoiceRepository : IRepository<IInvoice>
    {
        private readonly List<IInvoice> _invoices = new List<IInvoice>();

        public void Add(IInvoice invoice)
        {
            _invoices.Add(invoice);
        }

        public IEnumerable<IInvoice> GetAll()
        {
            return _invoices;
        }
    }

    public static class InterfaceSeggregationPrinciple
    {
        public static void Run()
        {
            // Create a customer
            ICustomer customer = new Customer
            {
                CustomerId = 1,
                Name = "John Doe",
                Email = "john.doe@example.com"
            };

            // Create an invoice
            IInvoice invoice = new Invoice
            {
                InvoiceId = 1001,
                Customer = customer,
                Date = DateTime.Now,
                Amount = 500.00m
            };

            // Add the invoice to the repository
            IRepository<IInvoice> invoiceRepository = new InvoiceRepository();
            invoiceRepository.Add(invoice);

            // Print the invoice
            IInvoicePrinter invoicePrinter = new InvoicePrinter();
            invoicePrinter.Print(invoice);
        }
    }
}
