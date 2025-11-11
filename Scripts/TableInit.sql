use [HardwareRentalApp(Dev)]

CREATE TABLE Customers (
    CustomerId INT IDENTITY(1,1) PRIMARY KEY,
    LesseeName NVARCHAR(100) NOT NULL,
    LesseeAddress NVARCHAR(500),
    MobileNumber NVARCHAR(10) NOT NULL
);

CREATE TABLE Bills (
    BillId BIGINT IDENTITY(1,1) PRIMARY KEY,
    CustomerId INT NOT NULL,          -- Reference to Customers
	AdminId INT NOT NULL,               -- Reference to Credentials
    BillDate DATETIME DEFAULT GETDATE(), -- When bill is created
    RentalStartDate DATE NOT NULL,    -- Rental period start
    RentalEndDate DATE NULL,      -- Rental period end
    ProjectOwner NVARCHAR(100) NOT NULL,
    Reference NVARCHAR(100) NOT NULL,
    WorkLocation NVARCHAR(200),
    PaymentDate DATE NULL,            -- When payment was made
    TotalAmount DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);

CREATE TABLE Items (
    ItemId INT IDENTITY(1,1) PRIMARY KEY,
    ItemName NVARCHAR(100) NOT NULL,
    Rent DECIMAL(10,2) NOT NULL,
    MinRentDays INT NOT NULL DEFAULT 1
);


INSERT INTO Items (ItemName, Rent, MinRentDays)
VALUES
('Plate 2x3', 1.00, 15),
('Plate 18x36', 2.00, 15),
('Plate 15x36', 3.00, 15),
('Plate 12x36', 4.00, 15),
('Plate 9x36', 5.00, 15),
('Mixer', 6.00, 1),
('Column Pattern', 7.00, 1),
('Jock', 8.00, 30),
('Kaichya', 9.00, 1),
('Jali', 10.00, 1),
('Channel', 11.00, 1),
('20 feet Pipe', 12.00, 1),
('10 feet Pipe', 13.00, 1),
('Bar', 14.00, 1);

CREATE TABLE BillItems (
    BillItemId INT IDENTITY(1,1) PRIMARY KEY,
    BillId BIGINT NOT NULL,
    ItemId INT NOT NULL,
    Quantity INT NOT NULL,
    Rent DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (BillId) REFERENCES Bills(BillId),
    FOREIGN KEY (ItemId) REFERENCES Items(ItemId)
);

CREATE TABLE Credentials (
    AdminId INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    MobileNumber NVARCHAR(10) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    UserRole NVARCHAR(20)
);

INSERT INTO Credentials (FullName, MobileNumber, PasswordHash, UserRole)
VALUES ('MohiniBharmal', '9822236529', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'Owner');

CREATE TABLE ProductActivations (
    ActivationID INT IDENTITY(1,1) PRIMARY KEY,
    ActivationKey NVARCHAR(100) NOT NULL,
    UserID INT NOT NULL,
    MACAddress NVARCHAR(50) NOT NULL,
    ProductType NVARCHAR(50) NOT NULL,
    LicenseType NVARCHAR(50) NOT NULL,
    ActivationDays INT NOT NULL,
    RequestDate DATETIME NOT NULL,
    ActivationDate DATETIME NOT NULL,
    ExpiryDate DATETIME NOT NULL
);