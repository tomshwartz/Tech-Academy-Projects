CREATE DATABASE db_library
USE db_library
Go
							/* ========= Creating Tables ====== */
/* Publisher Table */
CREATE TABLE tbl_Publisher (
	Name varchar(50) Primary Key NOT NULL,
	Address varchar(50),
	Phone varchar(50)
);

/* Book Table */
CREATE TABLE tbl_Book (
	BookId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Title varchar(50),
	PublisherName varchar(50) FOREIGN KEY (PublisherName) REFERENCES tbl_Publisher(Name)
);

/* Library Branch Table */
CREATE TABLE tbl_Library_Branch (
	BranchId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	BranchName VARCHAR(50),
	Address VARCHAR(50)
);

/* Book Author Table */
CREATE TABLE tbl_Book_Author (
	BookId INT NOT NULL FOREIGN KEY (BookId) REFERENCES tbl_Book(BookId),
	AuthorName varchar(50)
);

/* Book Copies Table */
CREATE TABLE tbl_Book_Copies (
	BookId  INT NOT NULL FOREIGN KEY (BookId) REFERENCES tbl_Book(BookId),
	BranchID INT FOREIGN KEY (BranchId) REFERENCES tbl_Library_Branch(BranchId),
	No_Of_Copies INT
);

/* Borrower Table */
CREATE TABLE tbl_Borrower (
	CardNo INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Name VARCHAR(50),
	Address VARCHAR(50),
	Phone VARCHAR(50)
);

/* Book Loans Table */
CREATE TABLE tbl_Book_Loans (
	BookId INT NOT NULL FOREIGN KEY (BookId) REFERENCES tbl_Book(BookId),
	BranchId INT FOREIGN KEY (BranchId) REFERENCES tbl_Library_Branch(BranchId),
	CardNo INT FOREIGN KEY (CardNo) REFERENCES tbl_Borrower(CardNo),
	DateOut DATE,
	DueDate DATE
);

							/* ===== INSERT STATEMENTS ========= */

/* === Pubilishers === */
INSERT INTO tbl_Publisher (Name, Address, Phone)
VALUES ('Scribner', 'Providence, Rhode Island', '432-234-1234'),
	('Viking Press', 'Seattle, Washington', '324-354-9456'),
	('Tor', 'Seattle, Washington', '543-123-1245'),
	('Sylvia Beach', 'Portland, Oregon', '123-432-6542'),
	('Picador', 'Austin, Texas', '321-123-4921'),
	('Simon & Schuster', 'Austin, Texas', '432-555-1111'),
	('Doubleday', 'New York City, New York', '666-666-1234'),
	('Allen & Unwin', 'London, England', '555-122-1222')
;

/* === Library Branch === */
INSERT INTO tbl_Library_Branch (BranchName, Address)
VALUES ('Sharpstown', 'Mexico City, Mexico'),
	('Central', 'Seattle, Washington'),
	('East', 'Providence, Rhode Island'),
	('South', 'Austin, Texas')
;

/* === Borrowers === */
INSERT INTO tbl_Borrower (Name, Address, Phone)
VALUES ('Tom', 'Portland, Oregon', '123-123-1234'),
	('Will', 'New Orleans, Louisiana', '234-234-2345'),
	('John', 'Saint Louis, Missouri', '345-345-3456'),
	('Jack', 'Providence, Rhode Island', '456-456-4567'),
	('Jade', 'Boston, Massachussetts', '567-567-5678'),
	('Sophie', 'Cranston, Rhode Island', '678-678-6789'),
	('Lily', 'Johnston, Rhode Island', '789-789-7890'),
	('Sarah', 'Providence, Rhode Island', '401-123-2345')
;

/* === Books === */
INSERT INTO tbl_Book (title, PublisherName)
VALUES ('The Great Gatsby', 'Scribner'),
	('The Grapes of Wrath', 'Viking Press'),
	('Ender''s Game', 'Tor'),
	('Speaker for the Dead', 'Tor'),
	('Xenocide','Tor'),
	('Ulysses', 'Sylvia Beach'),
	('The Lost Tribe', 'Picador'),
	('It', 'Simon & Schuster'),
	('The Shining', 'Doubleday'),
	('The Forgotten Villiage', 'Viking Press'),
	('Hidden Empire', 'Tor'),
	('The Stand', 'Doubleday'),
	('The Fellowship of the Ring', 'Allen & Unwin'),
	('The Two Towers', 'Allen & Unwin'),
	('The Return of the King', 'Allen & Unwin'),
	('The Philospoher''s Stone', 'Tor'),
	('The Great Escape','Tor'),
	('Wheel of Time', 'Viking Press'),
	('Zelda', 'Doubleday'),
	('Halo', 'Viking Press')
;

/* ==== Book Authors ===*/
INSERT INTO tbl_Book_Author (BookId, AuthorName)
VALUES (1 ,'F. Scott Fitzgerald'),
	(2, 'John Steinbeck'),
	(3, 'Orson Scott Card'),
	(4, 'Orson Scott Card'),
	(5, 'Orson Scott Card'),
	(6, 'James Joyce'),
	(7, 'Mark Lee'),
	(8, 'Stephen King'),
	(9, 'Stephen King'),
	(10, 'John Steinbeck'),
	(11, 'Orson Scott Card'),
	(12, 'Stephen King'),
	(13, 'J. R. R. Tolkien'),
	(14, 'J. R. R. Tolkien'),
	(15, 'J. R. R. Tolkien'),
	(16, 'J. K. Rowling'),
	(17, 'Author 9'),
	(18, 'Author 9'),
	(19, 'Author 10'),
	(20, 'Author 10')
;

/* === Book Copies === */
INSERT INTO tbl_Book_Copies (BookId, BranchID, No_Of_Copies)
VALUES /* In Sharpstown */
	(1, 1,3),
	(2,1,4),
	(3,1,2),
	(4,1,4),
	(5,1,5),
	(6,1,6),
	(7,1,7),
	(8,1,4),
	(9,1,5),
	(10,1,6),
	/* In Central */
	(11,2,2),
	(12,2,3),
	(13,2,4),
	(14,2,5),
	(15,2,6),
	(16,2,7),
	(17,2,9),
	(18,2,4),
	(19,2,7),
	(20,2,4),
	(9,2,4),
	/* In East */
	(1,3,5),
	(3,3,7),
	(5,3,9),
	(7,3,8),
	(9,3,3),
	(11,3,5),
	(13,3,4),
	(14,3,3),
	(16,3,4),
	(19,3,7),
	/* In South */
	(2,4,7),
	(4,4,4),
	(6,4,3),
	(8,4,5),
	(10,4,6),
	(12,4,7),
	(14,4,8),
	(16,4,9),
	(18,4,7),
	(20,4,6)
;

/* === Book Loans === */
INSERT INTO tbl_Book_Loans (BookId, BranchID, CardNo, DateOut, DueDate)
VALUES 
	/*Person 1 (7)*/
	(1,1,1,'2018-05-12','2018-07-20'),
	(2,1,1,'2018-05-12','2018-07-20'),
	(11,2,1,'2018-05-12','2018-07-20'),
	(13,2,1,'2018-05-12','2018-07-20'),
	(3,3,1,'2018-05-12','2018-07-20'),
	(14,2,1,'2018-05-12','2018-07-20'),
	(7,1,1,'2018-05-12','2018-07-20'),
	
	/*Person 2 (7) */
	(3,3,2,'2018-05-10','2018-08-20'),
	(12,2,2,'2018-05-10','2018-08-20'),
	(18,4,2,'2018-05-10','2018-08-20'),
	(20,4,2,'2018-05-10','2018-08-20'),
	(9,1,2,'2018-05-10','2018-08-20'),
	(16,4,2,'2018-05-10','2018-08-20'),
	(8,1,2,'2018-05-10','2018-08-20'),
	
	/* Person 3 (4)*/
	(1,1,3,'2018-06-12','2018-09-12'),
	(2,1,3,'2018-06-12','2018-09-12'),
	(4,4,3,'2018-06-12','2018-09-12'),
	(13,2,3,'2018-06-12','2018-09-12'),
	
	/* Person 4 (10)*/
	(1,1,4,'2018-02-1','2018-10-11'),
	(3,1,4,'2018-02-1','2018-10-15'),
	(5,1,4,'2018-02-1','2018-10-1'),
	(7,1,4,'2018-02-1','2018-10-1'),
	(9,1,4,'2018-02-1','2018-10-17'),
	(11,2,4,'2018-02-1','2018-10-1'),
	(12,2,4,'2018-02-1','2018-10-13'),
	(13,2,4,'2018-02-1','2018-10-1'),
	(16,2,4,'2018-02-1','2018-10-14'),
	(19,2,4,'2018-02-1','2018-10-1'),
	/* Person 5 (2)*/
	(20,4,5,'2018-1-1','2019-1-1'),
	(12,4,5,'2018-1-1','2019-1-13'),
	/* Person 6 (15)*/
	(2,2,6,'2018-4-12','2018-9-12'),
	(4,1,6,'2018-4-12','2018-9-15'),
	(6,1,6,'2018-4-12','2018-9-14'),
	(8,4,6,'2018-4-12','2018-9-18'),
	(10,4,6,'2018-4-12','2018-9-19'),
	(12,2,6,'2018-4-12','2018-9-12'),
	(14,2,6,'2018-4-12','2018-9-13'),
	(16,4,6,'2018-4-12','2018-9-14'),
	(18,4,6,'2018-4-12','2018-9-11'),
	(20,4,6,'2018-4-12','2018-9-11'),
	(3,3,6,'2018-4-12','2018-9-13'),
	(5,3,6,'2018-4-12','2018-9-12'),
	(7,3,6,'2018-4-12','2018-9-11'),
	(9,3,6,'2018-4-12','2018-9-18'),
	(11,3,6,'2018-4-12','2018-9-13'),
	/* Person 7 (5)*/
	(2,1,7,'2018-03-12','2018-08-08'),
	(3,3,7,'2018-03-12','2018-08-08'),
	(5,3,7,'2018-03-12','2018-08-08'),
	(6,4,7,'2018-03-12','2018-08-08'),
	(12,4,7,'2018-03-12','2018-08-08')
;
							/* ============ Procedures ========== */

/* How many copies of'The Lost Tribe' in 'Sharpstown' */
CREATE PROC Lost_Tribe_Copies
AS
SELECT No_Of_Copies
	FROM tbl_Book_Copies
	INNER JOIN tbl_Book ON tbl_Book_Copies.BookId = tbl_Book.BookId
	INNER JOIN tbl_Library_Branch ON tbl_Book_Copies.BranchID = tbl_Library_Branch.BranchId
WHERE tbl_Book.Title = 'The Lost Tribe' and tbl_Library_Branch.BranchName = 'Sharpstown'
;

/* How many copies of 'The Lost Tribe' are in each branch */
CREATE PROC Lost_Tribe
AS
SELECT a1.No_Of_Copies, a2.BranchName
	FROM tbl_Book_Copies as a1
	INNER JOIN tbl_Book ON a1.BookId = tbl_Book.BookId
	INNER JOIN tbl_Library_Branch as a2 ON a1.BranchID = a2.BranchId
	WHERE tbl_Book.Title = 'The Lost Tribe'
GO
;

/* Retrieve the names of all borrowers who do not have any books cheked out */
CREATE PROC Bookless
AS
SELECT DISTINCT a1.Name
	FROM tbl_Borrower a1
	WHERE NOT EXISTS (
		SELECT * 
			FROM tbl_Book_Loans a2 
			WHERE a1.CardNo = a2.CardNo
			)
GO
;

/* For each book that is loaned out of Sharpstown and has a due date of today, get the book title, borrowers name and borrowers address */
CREATE PROC Sharpstown_Loans
AS
SELECT a3.Title, a2.Name, a2.Address
	FROM tbl_Book_Loans as a1
	INNER JOIN tbl_Borrower a2 ON a1.CardNo = a2.CardNo
	INNER JOIN tbl_Book a3 ON a1.BookId = a3.BookId
	INNER JOIN tbl_Library_Branch a4 ON a1.BranchId = a4.BranchId
	WHERE a1.DueDate = CAST(CURRENT_TIMESTAMP AS DATE) and a4.BranchName = 'Sharpstown'
GO
;

/* For each library branch, retrieve the branch name and total number of books loaned out from that branch */
CREATE PROC Branch_Loans
AS
SELECT a1.BranchName, COUNT(a2.BookId) AS 'Loaned Books'
	FROM tbl_Library_Branch AS a1
	INNER JOIN tbl_Book_Loans a2 ON a1.BranchId = a2.BranchId
	GROUP BY a1.BranchName
GO
;

/* Get names,addresses, and number of books checked out from all borrowers who have more than five books checked out */
CREATE PROC Five_books_out
AS
SELECT a2.Name, a2.Address, COUNT(a1.BookId)
	FROM tbl_Book_Loans a1
	INNER JOIN tbl_Borrower a2 ON a1.CardNo = a2.CardNo
	GROUP BY a2.Name, a2.Address
	HAVING COUNT(a1.BookId) > 5
GO
;

/* For each book authored by Stephen King, get the title, number of copies owned by library branch Central */
CREATE PROC KING
AS
SELECT a3.Title, a1.No_Of_Copies
	FROM tbl_Book_Copies as a1
	INNER JOIN tbl_Library_Branch a2 ON a1.BranchID = a2.BranchId
	INNER JOIN tbl_Book a3 ON a1.BookId = a3.BookId
	INNER JOIN tbl_Book_Author a4 ON a1.BookId = a4.BookId
	WHERE a4.AuthorName = 'Stephen King' and a2.BranchName = 'Central'
GO
;