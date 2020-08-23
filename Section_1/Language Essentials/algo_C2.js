class Node {
    constructor(data) {
        this.data = data;
        this.next = null;
    }
}

class SLinkedList {
    constructor() {
        this.head = null;
    }

    isEmpty() {
        return this.head === null;
    }

    insertAtBack(data) {
        //while loop until it finds runner.next === null;
        const newTail = new Node(data)
        if (this.isEmpty()) {
            this.head = newTail;
            return this;
        }

        let runner = this.head;
        while (runner.next !== null) {
            runner = runner.next;
        }
        runner.next = newTail;
        return this;

    }

    seedFromArr(arr) {
        for (let i = 0; i < arr.length; i++) {
            this.insertAtBack(arr[i]);
        }
        return this;
    }

    insertAtFront(data) {
        const newHead = new Node(data);
        if (!this.isEmpty()){
            newHead.next = this.head;
        }
        this.head = newHead;
        return this;
    }

    removeHead() {
        this.head = this.head.next;
    }

    returnAvg() {
        let runner = this.head;
        let sum = 0;
        let cnt = 0
        while (runner !== null) {
            sum += runner.data;
            cnt++;
            runner = runner.next;
        }
        return sum / cnt;
    }
}

const emptyList = new SLinkedList();

// insertAtHead()

// removeHead()

//BONUS: return avg of list