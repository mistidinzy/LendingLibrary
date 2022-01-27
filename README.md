# Lab 08: Collections &middot; Phil's Lending Library

## Problem Domain

Use TDD to create a "Lending Library", filled with "Books" and a "Backpack" to hold borrowed Books.

1. Create a **Book** class to hold appropriate properties, such as Title, Author, etc.
2. Using the interface below, create a **Library** class that implements it.

``` C#
public interface ILibrary : IReadOnlyCollection<Book>
{
  // Add a Book to the library.
  void Add(string title, string firstName, string lastName, int numberOfPages);

  // Remove a Book from the library with the given title. Returns the Book, or null if not found.
  Book Borrow(string title);

  // Return a Book to the library.
  void Return(Book book);
}
```

* Since books need to be borrowed by **Title**, use a private **Dictionary<string, Book>** for storage.

3. Using the interface below, create a generic **Backpack<T>** class that implements it, to hold *anything*, such as borrowed **Book**s.

```C#
public interface IBag<T> : IEnumerable<T>
{
  // Add an item to the bag. Null items are ignored.
  void Pack(T item);

  // Remove the item from the bag at the given index. Returns the item that was removed.
  T Unpack(int index);
}
```

* Since items need to be unpacked by index, use a private **List<T>** for storage.

---

## Unit Tests

Test that your program has the following functionality:

1. Add a Book to your Library.
2. Borrowing an existing title returns the **Book** and removes it.
    * Hint: **Assert.DoesNotContain(book, library)**
    * Hint **Count** should decrease.
3. Borrowing a missing title returns **null**.
4. A returned book is once again in the Library.
    * Hint: **Assert.Contains(book, library)**
    * Hint: **Count** should increase.
5. Pack and Unpack your **Backpack**
    * Hint: **Backpack** can store *anything*, so it may be easier to test with **string** or **int**, instead of **Book**.

---

### Stretch Goals

1. Update your DSA **LinkedList** to implement **IEnumerable<int>**
    * Hint: **Assert.Equals(list, new[] { 1, 2, 3 })**
2. Update your DSA **LinkedList** to be generic, i.e. **class LinkedList<T> : IEnumerable<T>**
    * Be careful with **using**, as **System.Collections.Generic** also contains **LinkedList<T>**
3. Update **Library** to allow case-insensitive search by title
4. Add a Console user interface:
    * Use a method **LoadBooks()** to add some initial books to your Library.
    * Use a method **UserInterface()** to prompt the user with different options:
      * View all Books
        * Hint: Consider overriding **ToString()** on **Book** to make displaying easier
      * Add a Book
        * Prompt for all properties, then add to your **Library**
      * Borrow a book
        * Prompt for title
        * What if Library is empty?
      * Return a book
        * List numbered book bag and prompt for index (or maybe number, since normal people don’t count from 0?)
        * What if book bag is empty?
    * View Book Bag
    * Exit
  * Use individual methods to implement each option

---

