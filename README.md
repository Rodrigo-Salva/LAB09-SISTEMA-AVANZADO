# Semana 09 - Caso 2: Formulario con HTML Helpers y modelo fuertemente tipado

Proyecto ASP.NET Core MVC (.NET 10) para el registro de matrícula de alumnos de un instituto.
No usa base de datos: los alumnos se guardan en una lista en memoria.

## Integrantes (Sección C)
- Yamile Ochoa Marin
- Ailyn Medina Mallqui
- Rodrigo Salva Saccatoma
- Sunmi Casaño Suarez

## Qué incluye
- `Models/Alumno.cs`: modelo con Id, Nombres, Correo, Clave, Carrera, Turno, Becado y Observaciones.
- `Controllers/AlumnosController.cs`: lista en memoria, `Create` GET/POST, `Confirmacion`, `Index` y `Comparar`.
- `Views/Alumnos/Create.cshtml`: formulario tipado con `BeginForm`, `LabelFor`, `TextBoxFor`, `PasswordFor`,
  `TextAreaFor`, `DropDownListFor`, `RadioButtonFor`, `CheckBoxFor` y `HiddenFor`.
- `Views/Alumnos/Confirmacion.cshtml`: resultado con `DisplayFor`.
- `Views/Alumnos/Comparar.cshtml`: `Html.TextBox("Nombres")` vs `Html.TextBoxFor(m => m.Nombres)`.

## Cómo ejecutar
```
cd LAB09
dotnet run
```
Luego abrir la URL que indica la consola (ver `Properties/launchSettings.json`).
