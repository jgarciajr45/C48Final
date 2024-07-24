# Task Manager Application

## Description

The Task Manager application is a web-based tool designed for managing tasks with user and task management functionality. Built using ASP.NET Core and MySQL, it provides an interface for creating, updating, and deleting tasks, and managing users.

## Technologies Used

- **Frontend**: HTML, CSS, JavaScript
- **Backend**: ASP.NET Core 6.0, C#
- **Database**: MySQL
- **ORM**: Entity Framework Core 6.0

## Features

- Task Management: Create, view, update, and delete tasks.
- User Management: Add, view, update, and delete users.
- Task Assignment: Assign tasks to users and view assigned tasks.

## Installation

1. **Clone the repository:**
    ```bash
    git clone https://github.com/yourusername/yourrepository.git
    ```

2. **Navigate to the project directory:**
    ```bash
    cd yourrepository
    ```

3. **Install dependencies:**
    ```bash
    dotnet restore
    ```

4. **Set up the database:**
   - Update the `appsettings.json` file with your database connection string.
   - Run migrations:
     ```bash
     dotnet ef database update
     ```

5. **Run the application:**
    ```bash
    dotnet run
    ```

6. **Open your browser and navigate to:**
    ```
    http://localhost:5000
    ```
## Usage

- **Tasks**: Navigate to the tasks page to view, create, update, or delete tasks.
- **Users**: Navigate to the users page to manage users.

## Contributing

1. **Fork the repository.**
2. **Create a new branch:**
    ```bash
    git checkout -b feature/new-feature
    ```
3. **Make your changes and commit:**
    ```bash
    git add .
    git commit -m "Add new feature"
    ```
4. **Push to the branch:**
    ```bash
    git push origin feature/new-feature
    ```
5. **Open a pull request on GitHub.**

