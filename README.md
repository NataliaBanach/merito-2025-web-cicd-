# Merito 2025 Web CI/CD

This repository is designed for learning and experimenting with automation of CI/CD processes using GitHub Actions, a .NET web application, and the Azure cloud environment.

## Key Features
- Demonstrates CI/CD pipeline setup with GitHub Actions.
- Integrates a .NET web application for deployment.
- Utilizes Azure services for hosting and cloud-based workflows.

## Purpose
The goal of this repository is to provide a practical example of modern CI/CD practices, enabling developers to understand and implement automated workflows for building, testing, and deploying applications.

## Technical Description
The solution consists of:
1. A .NET web application (`MeritoWebApp`) that serves as the core application.
2. A test project (`tests`) for validating the application's functionality.
3. GitHub Actions workflows for automating build, test, and deployment processes.
4. Integration with Azure for hosting and managing the application in the cloud.

## Setup Instructions
To set up the project locally, follow these steps:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-repo/merito-2025-web-cicd-.git
   cd merito-2025-web-cicd-
   ```

2. **Install .NET SDK**:
   Ensure you have the .NET SDK installed. You can download it from [Microsoft's .NET website](https://dotnet.microsoft.com/).

3. **Restore Dependencies**:
   Navigate to the application directory and restore dependencies:
   ```bash
   cd MeritoWebApp
   dotnet restore
   ```

4. **Run the Application**:
   Start the application locally:
   ```bash
   dotnet run
   ```

5. **Run Tests**:
   Navigate to the `tests` directory and execute the tests:
   ```bash
   cd ../tests
   dotnet test
   ```

6. **Configure Azure**:
   - Set up an Azure App Service for hosting the application.
   - Update the deployment settings in the GitHub Actions workflow to match your Azure configuration.

7. **Deploy via GitHub Actions**:
   Push changes to the repository to trigger the CI/CD pipeline and deploy the application to Azure.

For more details, refer to the documentation in the repository or the official .NET and Azure guides.
