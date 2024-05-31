## Practice Assignment: Movie Collection Organizer

This assignment will allow you to practice various concepts in C# using console applications.

**Objective:**

Develop a program that helps manage a movie collection. The program should allow users to:

1. **Add movies** to a collection (title, year)
2. **Search** for a movie by title
3. **Display** all movies in the collection

**Features to Implement:**

* **Variables:** Use variables to store movie titles, years, and potentially the entire collection.
* **Loops:** Implement a loop to allow users to add multiple movies.
* **Conditions:** Use an `if` statement to check if a searched movie exists in the collection.
* **Operations:** Perform string comparisons for searching and potentially array operations for managing the collection.
* **Inputs:** Use `Console.ReadLine()` to get user input for movie titles and year.
* **Outputs:** Use `Console.WriteLine()` to display messages, movie information, and search results.
* **Arrays** (Optional): Instead of individual variables, store movie information in an array of structs or classes.
* **Linear Search** (Optional - if using arrays): Implement a loop to search for a movie by iterating through the array and comparing titles.
* **Classes** (Optional): Create a `Movie` class to encapsulate movie information (title, year) with properties and potentially methods.

**Bonus Features:**

* Implement error handling for invalid user inputs (e.g., non-numeric year).
* Allow users to delete movies from the collection.
* Display the number of movies in the collection.

**Getting Started:**

1. Open your preferred C# development environment (e.g., Visual Studio).
2. Create a new console application project.
3. Inside the `Main` method, start by declaring variables for movie titles and years.
4. Implement a loop using `while` or `for` to allow users to add movies.
5. Within the loop, use `Console.ReadLine()` to get user input for title and year.
    * Consider parsing the year input to an integer using `int.Parse()`.
6. Implement a search function using an `if` statement:
    * Prompt the user for a movie title to search.
    * Use a loop (if using arrays) or other logic to check if the title exists in the collection.
    * Display a message depending on the search result.
7. Display all movies in the collection using a loop (if using arrays) or by printing the stored information.

**Challenge Yourself:**

* Implement the optional features mentioned above.
* Explore additional functionalities like sorting the movie collection by title or year.

This assignment allows you to practice various C# fundamentals and provides a foundation for building more complex applications. Remember to test your code thoroughly with different inputs!
