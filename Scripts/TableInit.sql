use [HardwareRentalApp(Development)]

CREATE TABLE Customers (
    CustomerId INT IDENTITY PRIMARY KEY,
    LesseeName NVARCHAR(100) NOT NULL,
    LesseeAddress NVARCHAR(500),
    MobileNumber NVARCHAR(10) NOT NULL
);

CREATE TABLE Bills (
    BillId INT IDENTITY PRIMARY KEY,
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
    AdvanceAmount DECIMAL(10,2) DEFAULT 0,
    RemainingAmount AS (TotalAmount - AdvanceAmount) PERSISTED,
    IsPaid BIT DEFAULT 0,
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);

CREATE TABLE Items (
    ItemId INT IDENTITY PRIMARY KEY,
    ItemName NVARCHAR(100) NOT NULL,
    RentPrice DECIMAL(10,2) NOT NULL
);

CREATE TABLE BillItems (
    BillItemId INT IDENTITY PRIMARY KEY,
    BillId INT NOT NULL,
    ItemId INT NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    LineTotal AS (Quantity * Price) PERSISTED,
    FOREIGN KEY (BillId) REFERENCES Bills(BillId),
    FOREIGN KEY (ItemId) REFERENCES Items(ItemId)
);


INSERT INTO Items (ItemName, RentPrice)
VALUES
('Plate 2x3', 0.00),
('Plate 18x36', 0.00),
('Plate 15x36', 0.00),
('Plate 12x36', 0.00),
('Plate 9x36', 0.00),
('Mixer', 0.00),
('Column Pattern', 0.00),
('Jock', 0.00),
('Kiachya', 0.00),
('Jali', 0.00),
('Channel', 0.00),
('20 feet Pipe', 0.00),
('10 feet Pipe', 0.00),
('Bar', 0.00),
('Shipping', 0.00);


CREATE TABLE Credentials (
    AdminId INT IDENTITY PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    MobileNumber NVARCHAR(10) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    UserRole NVARCHAR(20)
);

INSERT INTO Credentials (FullName, MobileNumber, PasswordHash, UserRole)
VALUES ('MohiniBharmal', '9822236529', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'Owner');
