# REST API

A simple RESTful API built with C# for handling basic operations and demonstrating backend development concepts. It is made for handling command line commands, the platform & what the command does.

## 🚀 Features

* RESTful endpoints
* CRUD operations (Create, Read, Update, Delete)
* Structured project architecture
* API testing with Postman

## 🛠 Tech Stack

* **Language:** C#
* **Framework:** .NET (ASP.NET Core)
* **Tools:** Postman

## Getting Started

### Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/download)
* Postman (optional, for testing)

### Installation

1. Clone the repository:

```bash
git clone https://github.com/FilipLagerqvist/REST_API.git
```

2. Navigate into the project folder:

```bash
cd REST_API
```

3. Run the application:

```bash
dotnet run
```

4. The API should now be running on:

```
https://localhost:5001
```

## API Endpoints

Example endpoints (adjust based on your implementation):

| Method | Endpoint        | Description     |
| ------ | --------------- | --------------- |
| GET    | /api/items      | Get all items   |
| GET    | /api/items/{id} | Get item by ID  |
| POST   | /api/items      | Create new item |
| PUT    | /api/items/{id} | Update item     |
| DELETE | /api/items/{id} | Delete item     |

## Testing

You can use the included Postman collection:

1. Open Postman
2. Import the `.postman` folder from the repo
3. Run requests against your local server

## 📁 Project Structure

```
REST_API/
├── Controllers/
├── Models/
├── Services/
├── Program.cs
└── ...
```

## 📖 About REST APIs

REST APIs allow applications to communicate over HTTP using standard methods like GET, POST, PUT, and DELETE. ([GitHub Docs][1])

## 🤝 Contributing

Feel free to fork this project and submit pull requests.

## 📄 License

This project is open source. Add a license if you plan to distribute it publicly.

---

[1]: https://docs.github.com/en/rest?utm_source=chatgpt.com "GitHub REST API documentation"
