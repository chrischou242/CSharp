class Node
{
    constructor (val)
    {
        this.value=val;
        this.next = null;
    }
}

class List
{
    constructor()
    {
        this.head = null;
    }
    IsEmpty()
    {
       if(this.head==null) 
       {
           return true;
       }
       else{
           return false;
       }
    }

    AddToBack(val)
    {
        if(this.IsEmpty())
        {
            this.head = new Node(val)
            console.log(this.head.value)
        }
        else{
            var runner = this.head
            while ( runner.next != null)
            {
                console.log(`Before moving to next value:${runner.value} ${runner.next}`);
                runner = runner.next;
                console.log(`After moving to next value:${runner.value} ${runner.next}`);
            }
            console.log(`I got to the end. Gonna add new node now: ${runner.next}`);
            runner.next = new Node(val)
            console.log(`I added the new node now: ${runner.next}`);

        }
        return this;
    }

    PrintList()
    {
        if(this.IsEmpty())
        {
            console.log("Nothing is in the list");
        }
        else
        {
            var runner = this.head
            console.log(runner.value)
            while (runner.next !=null )
            {
                runner = runner.next;
                console.log(runner.value)
            }
        }
    }
// Day 2
    AddToFront(val)
    {
        if(this.IsEmpty()){
            this.head = new node(val)
        }
        else{
            var runner = this.head
            this.head = new node(val)
            this.head.next = runner

        }
    }

    RemoveFromFront()
    {
        if(this.IsEmpty())
        {
            console.log("There is no list")
        }
        else
        {
            this.head = this.head.next
        }
    }

    RemoveFromBack()
    {
        if(this.IsEmpty())
        {
            console.log("There is no list")
        }
        else
        {
            var runner = this.head
            console.log(runner.value)
            while (runner.next !=null )
            {
                runner = runner.next;
                console.log(runner.value)
            }
            runner.next = runner;
        }
    }

    Contains()
    {
        
    }

//Day 3

}

var listOne = new List();
listOne.IsEmpty();
listOne.AddToBack(5);
listOne.AddToBack(10);
listOne.AddToBack(15);
listOne.AddToBack(20);
console.log(listOne.IsEmpty());

listOne.AddToFront(1);
ListOne.PrintList();


// 3. Wed
// 1. removeBack
//     - remove the last node from the list and return it's data or null
// 2. contains - with & without recursion
//     - check if the list contains a value


// 4. Thur
//     1. secondToLast
//         - return the 2nd to last val
//     2. removeVal
//         - remove the node with the specified value, return the removed val, or null if nothing was removed
//     3. Extra: recursiveMax: return max val from list using recursion
//     4. Extra: prepend new val before given val