/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	function validateTitle(title) {
		if (typeof (title) !== 'string' ||
			title.length < 2 || title.length > 100) {
			throw new Error("Invalid title");
		}
	}

	function validateAuthor(authorName) {
		if (typeof (authorName) !== 'string' || authorName.length === 0) {
			throw new Error("Invalid author name");
		}
	}

	function validateISBN(isbn) {
		if (!(/^[0-9]{10,13}$/.test(isbn))) {
			throw new Error('Invalid ISBN');
		}
	}

	var library = (function () {
		var books = [];
		var categories = [];
		function listBooks() {
			let obj = arguments[0];

			books.sort(function (a, b) {
				return a.id > b.id;
			});

			if (obj) {
				books = books.filter(function (currBook) {
					return currBook.category === obj.category || currBook.author === obj.author;
				})
			}
			return books;
		}
		function addBook(book) {
			validateTitle(book.title);
			validateTitle(book.category);
			validateAuthor(book.author);
			validateISBN(book.isbn);
			if (books.find(function (currBook) { return (book.title === currBook.title || book.isbn === currBook.isbn); }) !== undefined) {
				throw new Error("Book already in library");
			}

			book.ID = books.length + 1;
			books.push(book);
			if (categories.indexOf(book.category) === -1) {
				categories.push(book.category);
			}
			return book;
		}

		function listCategories() {
			return categories.sort(function (a, b) { return a.category > b.category; });
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	}());
	return library;

}
module.exports = solve;
