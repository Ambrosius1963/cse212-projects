/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Can I add a customer to the queue?
        // Expected Result: display the customer that was added
        Console.WriteLine("Test 1\n");
        var service = new CustomerService(7);
        service.AddNewCustomer();
        service.ServeCustomer();
        // Defect(s) Found: the customer was removed from the queue before being served

        Console.WriteLine("\n=================");

        // Test 2
        // Scenario: add new customers and then serve the customers in the right order
        // Expected Result: display the customers in the same order that they were entered
        Console.WriteLine("Test 2\n");
        service = new CustomerService(3);
        service.AddNewCustomer();
        service.AddNewCustomer();
        Console.WriteLine($"Serve customers: {service}");
        service.ServeCustomer();
        service.ServeCustomer();
        Console.WriteLine($"Customers to serve: {service}");

        // Defect(s) Found: nope


        Console.WriteLine("\n=================");
        // Test 3
        // Scenario: If the queue is full and I try to add a customer, does it stop?
        // Expected Result: display a message that the queue is full
        Console.WriteLine("Test 3\n");
        service = new CustomerService(2);
        service.AddNewCustomer();
        service.AddNewCustomer();
        service.AddNewCustomer();
        Console.WriteLine($"Service Queue: {service}");
        // Defect(s) Found: AddNewCustomer should check for >= instead of >

        Console.WriteLine("\n=================");
        // Test 4
        // Scenario: Is max size of the queue defaulted to 10?
        // Expected Result: display 10 as the max size
        Console.WriteLine("Test 4\n");
        service = new CustomerService(-1);
        Console.WriteLine($"Queue size(10): {service}");
        // Defect(s) Found: no sir


        Console.WriteLine("=================");
        // Test 5
        // Scenario: Can I serve a customer if there is no customer?
        // Expected Result: display a message for an empty queue
        Console.WriteLine("Test 5");
        service = new CustomerService(9);
        service.ServeCustomer();
        // Defect(s) Found: make a statement to check for the length of the queue


    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"\n{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize) { // if queue is full, print message
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("\nCustomer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        // Check for customers in the queue
        if (_queue.Count <= 0) { // check queue size
            Console.WriteLine("No Customers in the Queue.");
        }
        else {
            var customer = _queue[0];
            _queue.RemoveAt(0); // Remove the customer from the queue after serving
            Console.WriteLine(customer);
        }
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"\n[size={_queue.Count} max_size={_maxSize} => " + String.Join(", ", _queue) + "]";
    }
}