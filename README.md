# EvShevnin.DarkSwagger

*Dark theme for Swagger UI*

Let your eyes rest with a dark theme for Swagger UI

## Features

- Easy to integrate with existing Swagger UI setups
- Custom dark theme CSS for comfortable viewing
- Compatible with ASP.NET Core projects using Swashbuckle

## Installation

Install via NuGet:

```bash
dotnet add package EvShevnin.DarkSwagger
```

## Usage

Example of configuring DarkSwagger in `Program.cs` for a standard ASP.NET Core application:

```csharp
using DarkSwagger
    
// ...

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseDarkSwaggerUI();
}
```

## License

This project is licensed under the MIT License. See the [LICENSE](https://licenses.nuget.org/MIT) file for details.

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests.

## Contact

For questions or feedback, reach out on Telegram: [@EvShevnin](https://t.me/ev_shevnin)