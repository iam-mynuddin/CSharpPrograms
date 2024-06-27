using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpPrograms.SOLID
{
    public static class SingleResponsibityPrinciple
    {
        // The Customer class is responsible for storing customer details.
        public class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }

        // The Invoice class is responsible for storing invoice details.
        public class Invoice
        {
            public int InvoiceId { get; set; }
            public Customer Customer { get; set; }
            public DateTime Date { get; set; }
            public decimal Amount { get; set; }
        }

        // The InvoicePrinter class is responsible for printing invoices.
        public class InvoicePrinter
        {
            public void Print(Invoice invoice)
            {
                Console.WriteLine("Invoice ID: " + invoice.InvoiceId);
                Console.WriteLine("Customer: " + invoice.Customer.Name);
                Console.WriteLine("Date: " + invoice.Date.ToShortDateString());
                Console.WriteLine("Amount: " + invoice.Amount.ToString("C"));
            }
        }

        // The InvoiceRepository class is responsible for storing and retrieving invoices.
        public class InvoiceRepository
        {
            private readonly List<Invoice> _invoices = new List<Invoice>();

            public void Add(Invoice invoice)
            {
                _invoices.Add(invoice);
            }

            public IEnumerable<Invoice> GetAll()
            {
                return _invoices;
            }
        }

        public static void Run()
        {
            // Create a customer
            Customer customer = new Customer
            {
                CustomerId = 1,
                Name = "John Doe",
                Email = "john.doe@example.com"
            };

            // Create an invoice
            Invoice invoice = new Invoice
            {
                InvoiceId = 1001,
                Customer = customer,
                Date = DateTime.Now,
                Amount = 500.00m
            };

            // Add the invoice to the repository
            InvoiceRepository invoiceRepository = new InvoiceRepository();
            invoiceRepository.Add(invoice);

            // Print the invoice
            InvoicePrinter invoicePrinter = new InvoicePrinter();
            invoicePrinter.Print(invoice);
        }
    }
}