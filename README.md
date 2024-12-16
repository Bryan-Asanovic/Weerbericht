# Weather App - C# Razor Pages

This is a weather application built using C# Razor Pages. The app allows users to view real-time weather forecasts for specific locations.

## Features
- **Current Weather**: Displays the current temperature, weather conditions, and location.
- **Forecast**: Provides a weather forecast for the upcoming days.
- **Responsive UI**: A user-friendly interface styled with Razor Pages and CSS.
- **Scalable Architecture**: Organized with a focus on maintainability and scalability.

## Project Structure
The project structure is organized as follows:

```plaintext
Weerbericht/
├── Models/                 # Contains data models (e.g., WeatherData.cs)
├── Pages/                  # Razor pages (UI logic and layout)
├── Properties/             # Project properties (configuration files)
├── Services/               # Weather API service logic
├── wwwroot/                # Static files (CSS, JavaScript, images)
├── Program.cs              # Main entry point of the application
├── appsettings.json        # Application configuration (e.g., API keys)
├── appsettings.Development.json
├── Weerbericht.csproj      # Project file for the Razor app
├── Weerbericht.sln         # Solution file for the project
```

## Prerequisites
Before running the project, ensure you have the following installed:
- **.NET SDK 8.0 or later**  
- A valid **weather API key** (e.g., from OpenWeatherMap or another provider).

## Installation and Setup

1. **Clone the Repository**  
   Clone the project to your local machine using Git:
   ```bash
   git clone https://github.com/your-username/Weerbericht.git
   cd Weerbericht
   ```

2. **Add the Weather API Key**  
   - Open `appsettings.json` or `appsettings.Development.json`.
   - Add your weather API key:
     ```json
     {
       "WeatherApi": {
         "ApiKey": "YOUR_API_KEY"
       }
     }
     ```

3. **Restore Dependencies**  
   Run the following command to restore all required NuGet packages:
   ```bash
   dotnet restore
   ```

4. **Run the Application**  
   Use the following command to run the application:
   ```bash
   dotnet run
   ```

5. **Access the App**  
   Open your web browser and go to `http://localhost:5000` to view the weather app.

## Usage
1. Enter the location you want to check the weather for in the search bar.
2. View the current weather and a detailed forecast for the next few days.
3. Enjoy a responsive and simple user experience.

## Technologies Used
- **C# Razor Pages**  
- **ASP.NET Core**  
- **Weather API** for fetching real-time data  
- **CSS** for styling  
