using ClassMethodDemo;

Console.WriteLine(" ---- WELCOME ----- ");

Customer customer1 = new Customer();
customer1.CustomerName = "Charlie";
customer1.CustomerSurname = "Bucket";
customer1.CustomerBirthYear = 1964;
customer1.CustomerIncome = 10000;

Customer customer2 = new Customer();
customer2.CustomerName = "Winston";
customer2.CustomerSurname = "Smith";
customer2.CustomerBirthYear = 1984;
customer2.CustomerIncome = 20000;

Customer customer3 = new Customer();
customer3.CustomerName = "Gregor";
customer3.CustomerSurname = "Samsa";
customer3.CustomerBirthYear = 1915;
customer3.CustomerIncome = 30000;


CustomerManager customerManager = new CustomerManager();
customerManager.AddCustomer(customer1);
customerManager.AddCustomer(customer2);
customerManager.AddCustomer(customer3);


Customer[] customers = new Customer[] { customer1, customer2, customer3 };
Console.WriteLine(" ----- Customer List ----- ");
customerManager.ListCustomers(customers);

Customer[] customerInformation = new Customer[] { customer1, customer2, customer3 };
Console.WriteLine(" ----- Customer Information ----- ");
customerManager.CustomerInfo(customerInformation);

