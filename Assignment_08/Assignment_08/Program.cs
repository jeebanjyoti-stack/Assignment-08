using System;
using System.Linq;

namespace Assignment_08
{
    internal class Program
    {
        static AdvancedDBEntities db;
        static Employee employee;
        static Product product;
        static Order order;

        static void Main(string[] args)
        {
            try
            {
                db = new AdvancedDBEntities();
                int choice;

                do
                {
                    Console.WriteLine("Choose CRUD Operation:");
                    Console.WriteLine("1. Create Employee");
                    Console.WriteLine("2. Read Employee");
                    Console.WriteLine("3. Update Employee");
                    Console.WriteLine("4. Delete Employee");
                    Console.WriteLine("5. Create Product");
                    Console.WriteLine("6. Read Product");
                    Console.WriteLine("7. Update Product");
                    Console.WriteLine("8. Delete Product");
                    Console.WriteLine("9. Create Order");
                    Console.WriteLine("10. Read Order");
                    Console.WriteLine("11. Update Order");
                    Console.WriteLine("12. Delete Order");
                    Console.WriteLine("13. Exit");
                    Console.Write("Enter choice: ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CreateEmployee();
                            break;
                        case 2:
                            ReadEmployee();
                            break;
                        case 3:
                            UpdateEmployee();
                            break;
                        case 4:
                            DeleteEmployee();
                            break;
                        case 5:
                            CreateProduct();
                            break;
                        case 6:
                            ReadProduct();
                            break;
                        case 7:
                            UpdateProduct();
                            break;
                        case 8:
                            DeleteProduct();
                            break;
                        case 9:
                            CreateOrder();
                            break;
                        case 10:
                            ReadOrder();
                            break;
                        case 11:
                            UpdateOrder();
                            break;
                        case 12:
                            DeleteOrder();
                            break;
                        case 13:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                } while (choice != 13);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Employee CRUD Operations
        static void CreateEmployee()
        {
            Console.WriteLine("Enter New Employee Details:");
            employee = new Employee();
            Console.Write("Enter ID: ");
            employee.EmployeeId = int.Parse(Console.ReadLine());
            Console.Write("First Name: ");
            employee.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            employee.LastName = Console.ReadLine();
            Console.Write("Birth Date (dd-mm-yyyy): ");
            employee.BirthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Salary: ");
            employee.Salary = decimal.Parse(Console.ReadLine());
            db.Employees.Add(employee);
            db.SaveChanges();
            Console.WriteLine("Employee Created!!!");
        }

        static void ReadEmployee()
        {
            Console.WriteLine("Enter Employee ID to Retrieve Details:");
            int employeeId = int.Parse(Console.ReadLine());
            employee = db.Employees.SingleOrDefault(e => e.EmployeeId == employeeId);
            if (employee != null)
            {
                Console.WriteLine($"Employee Details: {employee.EmployeeId}, {employee.FirstName}, {employee.LastName}, {employee.BirthDate}, {employee.Salary}");
            }
            else
            {
                Console.WriteLine("No Employee Found with the given ID.");
            }
        }

        static void UpdateEmployee()
        {
            Console.WriteLine("Enter Employee ID to Update Details:");
            int employeeId = int.Parse(Console.ReadLine());
            employee = db.Employees.SingleOrDefault(e => e.EmployeeId == employeeId);
            if (employee != null)
            {
                Console.Write("Enter New First Name: ");
                employee.FirstName = Console.ReadLine();
                Console.Write("Enter New Last Name: ");
                employee.LastName = Console.ReadLine();
                Console.Write("Enter New Birth Date (yyyy-MM-dd): ");
                employee.BirthDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter New Salary: ");
                employee.Salary = decimal.Parse(Console.ReadLine());
                db.SaveChanges();
                Console.WriteLine("Employee Updated!!!");
            }
            else
            {
                Console.WriteLine("No Employee Found with the given ID.");
            }
        }

        static void DeleteEmployee()
        {
            Console.WriteLine("Enter Employee ID to Delete Record:");
            int employeeId = int.Parse(Console.ReadLine());
            employee = db.Employees.SingleOrDefault(e => e.EmployeeId == employeeId);
            if (employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
                Console.WriteLine("Employee Deleted!!!");
            }
            else
            {
                Console.WriteLine("No Employee Found with the given ID.");
            }
        }

        // Product CRUD Operations
        static void CreateProduct()
        {
            Console.WriteLine("Enter New Product Details:");
            product = new Product();
            Console.Write("Product Id");
            product.ProductId =int.Parse(Console.ReadLine());
            Console.Write("Product Name: ");
            product.ProductName = Console.ReadLine();
            Console.Write("Description: ");
            product.Description = Console.ReadLine();
            Console.Write("Price: ");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Release Date (yyyy-MM-dd HH:mm:ss): ");
            product.ReleaseDate = DateTime.Parse(Console.ReadLine());
            db.Products.Add(product);
            db.SaveChanges();
            Console.WriteLine("Product Created!!!");
        }

        static void ReadProduct()
        {
            Console.WriteLine("Enter Product ID to Retrieve Details:");
            int productId = int.Parse(Console.ReadLine());
            product = db.Products.SingleOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                Console.WriteLine($"Product Details: {product.ProductId}, {product.ProductName}, {product.Description}, {product.Price}, {product.ReleaseDate}");
            }
            else
            {
                Console.WriteLine("No Product Found with the given ID.");
            }
        }

        static void UpdateProduct()
        {
            Console.WriteLine("Enter Product ID to Update Details:");
            int productId = int.Parse(Console.ReadLine());
            product = db.Products.SingleOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                Console.Write("Enter New Product Name: ");
                product.ProductName = Console.ReadLine();
                Console.Write("Enter New Description: ");
                product.Description = Console.ReadLine();
                Console.Write("Enter New Price: ");
                product.Price = decimal.Parse(Console.ReadLine());
                Console.Write("Enter New Release Date (yyyy-MM-dd HH:mm:ss): ");
                product.ReleaseDate = DateTime.Parse(Console.ReadLine());
                db.SaveChanges();
                Console.WriteLine("Product Updated!!!");
            }
            else
            {
                Console.WriteLine("No Product Found with the given ID.");
            }
        }

        static void DeleteProduct()
        {
            Console.WriteLine("Enter Product ID to Delete Record:");
            int productId = int.Parse(Console.ReadLine());
            product = db.Products.SingleOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                Console.WriteLine("Product Deleted!!!");
            }
            else
            {
                Console.WriteLine("No Product Found with the given ID.");
            }
        }

        // Order CRUD Operations
        static void CreateOrder()
        {
            Console.WriteLine("Enter New Order Details:");
            order = new Order();
            Console.Write("OrderId");
            order.OrderId = int.Parse(Console.ReadLine());
            Console.Write("Order Date (yyyy-MM-dd HH:mm:ss): ");
            order.OrderDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            order.Quantity = short.Parse(Console.ReadLine());
            Console.Write("Discount: ");
            order.Discount = float.Parse(Console.ReadLine());
            Console.Write("Is Shipped (true/false): ");
            order.IsShipped = bool.Parse(Console.ReadLine());
            db.Orders.Add(order);
            db.SaveChanges();
            Console.WriteLine("Order Created!!!");
        }

        static void ReadOrder()
        {
            Console.WriteLine("Enter Order ID to Retrieve Details:");
            int orderId = int.Parse(Console.ReadLine());
            order = db.Orders.SingleOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                Console.WriteLine($"Order Details: {order.OrderId}, {order.OrderDate}, {order.Quantity}, {order.Discount}, {order.IsShipped}");
            }
            else
            {
                Console.WriteLine("No Order Found with the given ID.");
            }
        }

        static void UpdateOrder()
        {
            Console.WriteLine("Enter Order ID to Update Details:");
            int orderId = int.Parse(Console.ReadLine());
            order = db.Orders.SingleOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                Console.Write("Enter New Order Date (yyyy-MM-dd HH:mm:ss): ");
                order.OrderDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter New Quantity: ");
                order.Quantity = short.Parse(Console.ReadLine());
                Console.Write("Enter New Discount: ");
                order.Discount = float.Parse(Console.ReadLine());
                Console.Write("Enter New Is Shipped (true/false): ");
                order.IsShipped = bool.Parse(Console.ReadLine());
                db.SaveChanges();
                Console.WriteLine("Order Updated!!!");
            }
            else
            {
                Console.WriteLine("No Order Found with the given ID.");
            }
        }

        static void DeleteOrder()
        {
            Console.WriteLine("Enter Order ID to Delete Record:");
            int orderId = int.Parse(Console.ReadLine());
            order = db.Orders.SingleOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                db.Orders.Remove(order);
                db.SaveChanges();
                Console.WriteLine("Order Deleted!!!");
            }
            else
            {
                Console.WriteLine("No Order Found with the given ID.");
            }
        }
    }
}
