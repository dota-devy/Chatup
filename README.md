# Chatup Project

Chatup is a cross-platform chat application built using .NET MAUI for the client-side and ASP.NET for the backend. The application allows users to communicate in real-time and utilizes Bluetooth Low Energy for fast pairing with other clients in the local area.

## Features

- **Cross-Platform Support**: The application runs on Android, iOS, Windows, and MacOS.
- **Real-Time Chat**: Users can send and receive messages instantly.
- **Bluetooth Low Energy Fast Pairing**: Quickly connect with nearby clients using Bluetooth technology.
- **MongoDB Integration**: The backend is powered by MongoDB for storing chat messages.

## Project Structure

- **Chatup.App**: Contains the client-side application.
  - **Platforms**: Platform-specific implementations for Android, iOS, MacCatalyst, and Windows.
  - **Views**: Contains XAML files for the user interface.
  - **ViewModels**: Contains the ViewModel classes for data binding.
  - **Services**: Contains services such as Bluetooth handling.
  
- **Chatup.Backend**: Contains the ASP.NET backend application.
  - **Controllers**: Handles HTTP requests related to chat messages.
  - **Models**: Defines the structure of chat messages.
  - **Services**: Manages MongoDB connections and operations.
  
- **.github**: Contains GitHub Actions workflows for CI/CD.
  - **workflows/build.yml**: Builds the application for all target platforms.
  - **workflows/deploy-backend.yml**: Deploys the backend to Google Cloud Platform.

## Setup Instructions

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/Chatup.git
   cd Chatup
   ```

2. **Backend Configuration**:
   - Navigate to `Chatup.Backend/appsettings.json` and update the MongoDB connection string.

3. **Build the Application**:
   - Use the provided GitHub Actions workflows to build the application for your desired platform.

4. **Deploy the Backend**:
   - Use the `deploy-backend.yml` workflow to deploy the backend to Google Cloud Platform.

## Usage

- Launch the application on your preferred platform.
- Use Bluetooth Low Energy to connect with nearby clients.
- Start chatting in real-time!

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.