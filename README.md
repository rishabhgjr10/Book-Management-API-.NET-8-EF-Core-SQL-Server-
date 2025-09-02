# 📚 Book Management API

A simple **ASP.NET Core Web API** project for managing books.  
Implements **CRUD operations** (Create, Read, Update, Delete) using **Entity Framework Core** with a **SQL Server LocalDB** backend.

---

## 🚀 Features
- Add, update, delete, and fetch books
- Database persistence with EF Core
- Swagger UI for testing API endpoints
- Repository pattern for data access

---

## 🛠️ Tech Stack
- **.NET 8.0**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQL Server LocalDB**
- **Swagger (Swashbuckle)**

---

## 📂 Project Structure
BookApplication/
├── BookAPI/ # API project (controllers, startup, swagger)
├── DataAcess/ # Data layer (DbContext, repositories, models)
└── Migrations/ # EF Core migrations


---

2. Configure Database

Update appsettings.json if needed:

"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=BookDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}

3. Run EF Core Migrations
Update-Database

4. Run the API
dotnet run --project BookAPI


Swagger UI will open:

📖 API Endpoints
Books

GET /api/Book → Get all books

GET /api/Book/{id} → Get book by ID

POST /api/Book → Add a new book

PUT /api/Book → Update an existing book

DELETE /api/Book/{id} → Delete a book

🧪 Example Request
POST /api/Book
{
  "bookName": "Clean Code",
  "genre": "Programming",
  "availability": true
}
