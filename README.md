# Lab 08: Collections

## The Problem Domain

Use TDD to create your own Lending Library filled with Books, and a Backpack to hold borrowed Books.

## Program Specifications

Your solution should include the following:

- Create a `Book` class to hold appropriate properties (e.g. `Title`, `Author`)

- Then create a `Library` class that implements an `ILibrary` public interface named `IReadOnlyCollection` from starter code.

- Since books need to be borrowed by `Title`, use a `private Dictionary<string, Book>` for storage.

- Create a generic `Backpack<T>` class that implements it to hold anything (like borrowed Books!)

-Since items need to be unpacked by index, use a `private List<T>` for storage.

## Unit Tests

Test that your program has the following functionality:

|| Add a Book to your Library
|| Borrowing an existing title returns the Book and remove it

- Hint: Assert.DoesNotContain(book, library)
- Hint: Count should decrease

|| Borrowing a missing title returns null
|| A returned book is once again in the Library

- Hint: Assert.Contains(book, library)
- Hint: Count should increase

|| Pack and Unpack your Backpack

- Hint: Backpack can store anything so it may be easier to test with string or int instead of Book
