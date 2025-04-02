# ToDoListenVerwaltung

# Projektbeschreibung

Dieses Projekt dient der Entwicklung eines Todo-Listenverwaltungssystems, das sowohl einen Server als auch einen Client umfasst. Die API wurde gemäß den OpenAPI-Spezifikationen definiert und ermöglicht eine effiziente Kommunikation zwischen den Komponenten.

# Verzeichnisstruktur

Entwurf und Implementierung einer REST-Schnittstelle: Anforderungen und Spezifikationen für die REST-Schnittstelle.

20 TodoListenverwaltung_Vorlage.yaml: Vorlage der OpenAPI-Spezifikation für die Todo-Listenverwaltung.
22 openapi.yaml: OpenAPI-Spezifikation.

23 wichmann beispiel-server.py: Beispielserver-Skript in Python.
Todo-Listenverwaltung_Server/: Server-seitiger Code für das Todo-Listenverwaltungssystem.

Todo-Listenverwaltung_Client/: Quellcode und Konfigurationsdateien für den Client.
generated-client/: Automatisch generierter Client-Code basierend auf der OpenAPI-Spezifikation.

# API-Code generieren:

java -jar openapi-generator-cli-7.0.1.jar generate -i openapi.yaml -g csharp -o generated-client

# Server starten:

python Todo-Listenverwaltung_Server/main.py

# Client starten:

C#-Client in Visual Studio öffnen und ausführen.

# API-Endpunkte

Die API-Spezifikationen befinden sich in der Datei 22 openapi.yaml. Diese definiert die verfügbaren Endpunkte für das Todo-Listenverwaltungssystem.

# Lizenz

Dieses Projekt steht unter einer Open-Source-Lizenz (MIT). Bitte überprüfe die Lizenzdatei für weitere Informationen.

# Kontakt

Für Fragen oder Anregungen kontaktiere Asad Saleem

