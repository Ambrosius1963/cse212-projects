public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data){ // added this line to fix the issue of duplicates
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

// ~Problem 2 description
    // Implement the Contains function in the Node class. 
    //This function is called by the Contains function in the BinarySearchTree
    // to search for a value in the tree. If the value is found, true should be returned; 
    //otherwise return false. Hint: study the Insert function. You will need to use recursion to solve this problem.
    public bool Contains(int value) {
        if (value == Data) {
            return true;
        }
        else if (value < Data && Left != null) {
            return Left.Contains(value);
        }
        else if (value > Data && Right != null) {
            return Right.Contains(value);
        }
        return false;
    }

// ~Problem 4 description
    // Implement the GetHeight function in the Node class to get the height of the BinarySearchTree. 
    //The height of any tree (or subtree) is defined as one plus the height of either the left 
    //subtree or the right subtree (whichever one is bigger). If the tree has only the root node, 
    //then this would be 1 plus the maximum height of either subtree which would be 0. Therefore, 
    //the height of a tree with only the root node is 1. You will need to use recursion to solve this problem.
    public int GetHeight() {
        if (Left is null && Right is null) {
            return 1;
        }
        else if (Left is null) {
            return 1 + Right.GetHeight();
        }
        else if (Right is null) {
            return 1 + Left.GetHeight();
        }
        else {
            return 1 + Math.Max(Left.GetHeight(), Right.GetHeight());
        }
    }
}