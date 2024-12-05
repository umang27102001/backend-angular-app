# Use the official .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy the project files into the container
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application files
COPY . ./

# Publish the application to a folder named "out"
RUN dotnet publish -c Release -o out

# Use the official ASP.NET Core runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build-env /app/out .

# Expose the port your application listens on (e.g., 80 or 5000)
EXPOSE 5000

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "backend.dll"]