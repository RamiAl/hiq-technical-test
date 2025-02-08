# Fullstack File Processing App

A minimal setup combining a **frontend** (built with Vite) and a **backend** (built with ASP.NET Core). This README provides a quick overview of how to get started, while more detailed instructions can be found in each subfolder’s README.

## Prerequisites
- **Node.js (v18 or higher)**
- **.NET 6 or higher**

## Quick Start

1. **Clone the Repository**
2. **Backend**
    * Navigate to the Backend directory
    * Follow the instructions in Backend/README.md to build and run the server

3. **Frontend**

    * Navigate to the Frontend directory
    * Follow the instructions in Frontend/README.md to build and run the client

4. **Usage**
    * Go to the frontend’s local URL (http://localhost:5173)
    * Upload a file
    * The backend processes the file and returns the result

## Automated Tests (Unit Testing)

- The backend includes **xUnit** tests for verifying core functionality (e.g., the text-processing logic).
- To run these tests, navigate to the test project directory (/Backend_Tests) and execute:
  ```bash
  dotnet test
  ```

That’s it—check the respective README.md files in the Backend and Frontend folders for detailed build and run instructions.