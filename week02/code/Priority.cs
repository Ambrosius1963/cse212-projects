public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue one value and then Dequeue it.
        // Expected Result: Item 1
        Console.WriteLine("\tTest 1");
        priorityQueue.Enqueue("Item 1", 5);
        Console.WriteLine(priorityQueue.Dequeue()); // Expected output: "Item 1"

        // Defect(s) Found: 

        Console.WriteLine("------------------");

        // Test 2
        // Scenario: Enqueue multiple items with same priority and dequeue
        // Expected Result:  Item 2, Item 3, Item 4
        Console.WriteLine("\tTest 2");
        priorityQueue.Enqueue("Item 2", 7);
        priorityQueue.Enqueue("Item 3", 7);
        priorityQueue.Enqueue("Item 4", 7);
        Console.WriteLine(priorityQueue.Dequeue()); 
        Console.WriteLine(priorityQueue.Dequeue()); 
        Console.WriteLine(priorityQueue.Dequeue()); 
        Console.WriteLine("------------------");

        // Test 3
        // Scenario: Enqueue multiple items with different priorities and dequeue
        // Expected Result: Item 7, Item 5, Item 6
        Console.WriteLine("\tTest 3");
        priorityQueue.Enqueue("Item 5", 3);
        priorityQueue.Enqueue("Item 6", 1);
        priorityQueue.Enqueue("Item 7", 5);
        Console.WriteLine(priorityQueue.Dequeue()); 
        Console.WriteLine(priorityQueue.Dequeue()); 
        Console.WriteLine(priorityQueue.Dequeue()); 
        Console.WriteLine("------------------");

        // Test 4
        // Scenario: Dequeue from empty queue
        // Expected Result: The queue is empty

        Console.WriteLine("\tTest 4");
        try
        {
            priorityQueue.Dequeue();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message); // Expected output: "The queue is empty."
        }
        Console.WriteLine("------------------");

    }
}