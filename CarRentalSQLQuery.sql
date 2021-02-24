CREATE TABLE Cars(
	CarId int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Descriptions nvarchar(25),
	FOREIGN KEY(ColorId) REFERENCES Colors(ColorId),
	FOREIGN KEY(BrandId) REFERENCES Brands(BrandId)
)

CREATE TABLE Colors(
	ColorId int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25),

)

CREATE TABLE Brands(
	BrandId int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25)
)

CREATE TABLE Users(
	UserId int PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(25),
	LastName nvarchar(25),
	Email nvarchar(55),
	Password nvarchar(35),
)

CREATE TABLE Customers(
	CustomerId int PRIMARY KEY IDENTITY(1,1),
	UserId int,
	CustomerName nvarchar(25),
	FOREIGN KEY (UserId) REFERENCES Users(UserId)
)

CREATE TABLE Rentals(
	RentalId int PRIMARY KEY IDENTITY(1,1),
	CarId int,
	CustomerId int,
	RentDate datetime,
	ReturnDate datetime,
	FOREIGN KEY(CarId) REFERENCES Cars(CarId),
	FOREIGN KEY(CustomerId) REFERENCES Customers(CustomerId)
)

INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
		('1','1','2012','350','Manuel'),
		('2','1','2020','500','Otomatik'),
		('3','1','2020','350','Otomatik'),
		('4','2','2019','300','Otomatik');

INSERT INTO Colors(ColorName)
VALUES
		('Beyaz'),
		('Siyah');

INSERT INTO Brands(BrandName)
VALUES
		('Toyota'),
		('Seat'),
		('Renault'),
		('Honda');