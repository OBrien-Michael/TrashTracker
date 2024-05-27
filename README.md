

# Trash Tracker

TrashTracker is a final year project for the BSc Honours in Contemporary Software Development 2023/2024.

## Overview

The application is designed to track trash in different locations. It uses the .NET MAUI framework for cross-platform development, allowing the application to run on multiple platforms including iOS, Android, and Windows. 

The application uses the MVVM pattern, which separates the application into three main components: the Model, the View, and the ViewModel. This separation allows for efficient code reuse and separation of concerns.

## Key Features

- **Map View**: The application uses the .NET MAUI Maps for displaying the locations of the trash. Depending on the platform the app is running on, it uses the appropriate map renderer.

- **Trash Pinning**: Users can pin the location of trash on the map. This is handled by the `TrashPinService`.

- **Trash Details**: Each trash pin has details associated with it, such as name, description, and severity. These details can be viewed and edited in the `TrashPinModalView`.

- **Add New Trash Pin**: Users can add new trash pins using the `CreateNewTrashPinModalView`.

## Project Structure

The project is structured into several files and directories:

- `MauiProgram.cs`: This is the entry point of the application. It sets up the .NET MAUI app, registers services, views, and view models, and configures the app based on the platform it's running on.

- `View`: This directory contains the views of the application. Each view is associated with a ViewModel.

- `ViewModel`: This directory contains the ViewModels of the application. Each ViewModel contains the logic for a View.

- `Services`: This directory contains the services used in the application. For example, `TrashPinService` is used for handling the trash pins.

- `Model`: This directory contains the models used in the application. For example, `TrashPin` is a model representing a trash pin.

- `Platforms`: This directory contains platform-specific code.

## Technologies Used

- [.NET MAUI](https://dotnet.microsoft.com/apps/maui): A framework for building native device applications spanning mobile, tablet, and desktop.

- [MVVM](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm): Model-View-ViewModel is a software architectural pattern that facilitates the separation of the development of the graphical user interface.

- [CommunityToolkit.Maui](https://github.com/CommunityToolkit/Maui): A set of behaviors, converters, and effects for .NET MAUI.

- [Firebase.Database](https://firebase.google.com/docs/database): A NoSQL cloud database to store and sync data in realtime.


## Author

Michael O'Brien

Atlantic Technological University

BSc Honours in Contemporary Software Development 2023/2024
