using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json;

class TodoListenverwaltungClient
{
    private static HttpClient _httpClient = new HttpClient();
    private static string BaseURL = "http://127.0.0.1:5000";

    static async Task Main(string[] args)
    {
        string TodolistId = await GetAllTodoLists();

        Console.WriteLine("Name der neuen Liste eingeben: ");
        string NewTodoListName = Console.ReadLine();
        await CreateNewTodoList(NewTodoListName);

        if (!string.IsNullOrEmpty(TodolistId))
        {
            await GetTodoListById(TodolistId);

            await DeleteTodoListById(TodolistId);

            string EntryId = await GetAllEntriesByTodoList(TodolistId);
            if (!string.IsNullOrEmpty(EntryId))
            {
                Console.WriteLine("Name des neuen Eintrags eingeben: ");
                string NewEntryName = Console.ReadLine();
                await CreateNewEntry(TodolistId, NewEntryName);

                await DeleteEntryById(TodolistId, EntryId);

                Console.WriteLine("Neuen Namen des Eintrags eingeben: ");
                string UpdatedEntryName = Console.ReadLine();
                Console.WriteLine("Neue Description des Eintrags eingeben: ");
                string UpdatedEntryDescription = Console.ReadLine();
                await UpdateEntryById(TodolistId, EntryId, UpdatedEntryName, UpdatedEntryDescription);
            }
        }
    }
    private static async Task CreateNewTodoList(string name)
    {
        string requestUri = $"{BaseURL}/todo-list";

        var requestBody = new
        {
            name = name
        };

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri(requestUri),
            Content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json")
        };

        HttpResponseMessage response = await _httpClient.SendAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Fehler: {response.StatusCode}, Details: {errorContent}");
            return;
        }
        try
        {
            string responseData = await response.Content.ReadAsStringAsync();
            string formattedJson = JsonConvert.SerializeObject(JObject.Parse(responseData), Formatting.Indented);

            Console.WriteLine("Neue Todo-Liste");
            Console.WriteLine(formattedJson);
        }
        catch (System.Text.Json.JsonException ex)
        {
            Console.WriteLine($"Fehler beim Parsen der JSON-Antwort: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unerwarteter Fehler: {ex.Message}");
        }
    }
    private static async Task GetTodoListById(string listid)
    {
        string requestUri = $"{BaseURL}/todo-list/{listid}";

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(requestUri),
        };

        HttpResponseMessage response = await _httpClient.SendAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Fehler: {response.StatusCode}, Details: {errorContent}");
            return;
        }
        try
        {
            string responseData = await response.Content.ReadAsStringAsync();

            var jsonElement = System.Text.Json.JsonSerializer.Deserialize<JsonElement>(responseData);
            string formattedJson = System.Text.Json.JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });

            Console.WriteLine("Todo-Liste anhand der ID");
            Console.WriteLine(formattedJson);
        }
        catch (System.Text.Json.JsonException ex)
        {
            Console.WriteLine($"Fehler beim Parsen der JSON-Antwort: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unerwarteter Fehler: {ex.Message}");
        }
    }
    private static async Task DeleteTodoListById(string listid)
    {
        string requestUri = $"{BaseURL}/todo-list/{listid}";

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = new Uri(requestUri),
        };

        HttpResponseMessage response = await _httpClient.SendAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Fehler: {response.StatusCode}, Details: {errorContent}");
            return;
        }
        try
        {
            string responseData = await response.Content.ReadAsStringAsync();

            var jsonElement = System.Text.Json.JsonSerializer.Deserialize<JsonElement>(responseData);
            string formattedJson = System.Text.Json.JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });

            Console.WriteLine("Lösche Todo-Liste anhand der ID");
            Console.WriteLine(formattedJson);
        }
        catch (System.Text.Json.JsonException ex)
        {
            Console.WriteLine($"Fehler beim Parsen der JSON-Antwort: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unerwarteter Fehler: {ex.Message}");
        }
    }
    private static async Task<string> GetAllTodoLists()
    {
        string requestUri = $"{BaseURL}/todo-lists";

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(requestUri),
        };

        HttpResponseMessage response = await _httpClient.SendAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Fehler: {response.StatusCode}, Details: {errorContent}");
            return null;
        }

        try
        {
            string responseData = await response.Content.ReadAsStringAsync();
            JArray todoLists = JArray.Parse(responseData);

            string firstTodolistId = todoLists.FirstOrDefault()?["id"]?.ToString();
            string formattedJson = JsonConvert.SerializeObject(todoLists, Formatting.Indented);

            Console.WriteLine("Todo-Listen:");
            Console.WriteLine(formattedJson);
            return firstTodolistId;
        }
        catch (System.Text.Json.JsonException ex)
        {
            Console.WriteLine($"Fehler beim Parsen der JSON-Antwort: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unerwarteter Fehler: {ex.Message}");
        }
        return null;
    }
    private static async Task<string> GetAllEntriesByTodoList(string listid)
    {
        string requestUri = $"{BaseURL}/todo-list/{listid}/entries";

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(requestUri),
        };

        HttpResponseMessage response = await _httpClient.SendAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Fehler: {response.StatusCode}, Details: {errorContent}");
            return null;
        }

        try
        {
            string responseData = await response.Content.ReadAsStringAsync();
            JArray entries = JArray.Parse(responseData);

            string firstEntryId = entries.FirstOrDefault()?["id"]?.ToString();
            string formattedJson = JsonConvert.SerializeObject(entries, Formatting.Indented);

            Console.WriteLine("Entries:");
            Console.WriteLine(formattedJson);
            return firstEntryId;
        }
        catch (System.Text.Json.JsonException ex)
        {
            Console.WriteLine($"Fehler beim Parsen der JSON-Antwort: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unerwarteter Fehler: {ex.Message}");
        }
        return null;
    }
    private static async Task CreateNewEntry(string listid, string name)
    {
        string requestUri = $"{BaseURL}//todo-list/{listid}/entry";

        var requestBody = new
        {
            name = name,
            todo_list_id = listid,
        };

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri(requestUri),
            Content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json")
        };

        HttpResponseMessage response = await _httpClient.SendAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Fehler: {response.StatusCode}, Details: {errorContent}");
            return;
        }
        try
        {
            string responseData = await response.Content.ReadAsStringAsync();
            string formattedJson = JsonConvert.SerializeObject(JObject.Parse(responseData), Formatting.Indented);

            Console.WriteLine("Neues Entry");
            Console.WriteLine(formattedJson);
        }
        catch (System.Text.Json.JsonException ex)
        {
            Console.WriteLine($"Fehler beim Parsen der JSON-Antwort: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unerwarteter Fehler: {ex.Message}");
        }
    }
    private static async Task UpdateEntryById(string listid, string entryid, string name, string description)
    {
        string requestUri = $"{BaseURL}/todo-list/{listid}/entry/{entryid}";

        var requestBody = new
        {
            name = name,
            description = description,
        };

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Put,
            RequestUri = new Uri(requestUri),
            Content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json")
        };

        HttpResponseMessage response = await _httpClient.SendAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Fehler: {response.StatusCode}, Details: {errorContent}");
            return;
        }

        try
        {
            string responseData = await response.Content.ReadAsStringAsync();
            string formattedJson = JsonConvert.SerializeObject(JObject.Parse(responseData), Formatting.Indented);

            Console.WriteLine("Eintrag aktualisiert:");
            Console.WriteLine(formattedJson);
        }
        catch (System.Text.Json.JsonException ex)
        {
            Console.WriteLine($"Fehler beim Parsen der JSON-Antwort: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unerwarteter Fehler: {ex.Message}");
        }
    }
    private static async Task DeleteEntryById(string listid, string entryid)
    {
        string requestUri = $"{BaseURL}/todo-list/{listid}/entry/{entryid}";

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = new Uri(requestUri),
        };

        HttpResponseMessage response = await _httpClient.SendAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Fehler: {response.StatusCode}, Details: {errorContent}");
            return;
        }
        try
        {
            string responseData = await response.Content.ReadAsStringAsync();

            var jsonElement = System.Text.Json.JsonSerializer.Deserialize<JsonElement>(responseData);
            string formattedJson = System.Text.Json.JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });

            Console.WriteLine("Lösche Entry anhand der ID");
            Console.WriteLine(formattedJson);
        }
        catch (System.Text.Json.JsonException ex)
        {
            Console.WriteLine($"Fehler beim Parsen der JSON-Antwort: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unerwarteter Fehler: {ex.Message}");
        }
    }

}
