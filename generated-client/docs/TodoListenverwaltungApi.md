# Org.OpenAPITools.Api.TodoListenverwaltungApi

All URIs are relative to *http://127.0.0.1:5000*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEntry**](TodoListenverwaltungApi.md#createentry) | **POST** /todo-list/{list_id}/entry | Eintrag erstellen |
| [**CreateTodoList**](TodoListenverwaltungApi.md#createtodolist) | **POST** /todo-list | Todo-Liste hinzufügen |
| [**DeleteEntry**](TodoListenverwaltungApi.md#deleteentry) | **DELETE** /todo-list/{list_id}/entry/{entry_id} | Eintrag löschen |
| [**DeleteTodoList**](TodoListenverwaltungApi.md#deletetodolist) | **DELETE** /todo-list/{list_id} | Todo-Liste löschen |
| [**GetTodoList**](TodoListenverwaltungApi.md#gettodolist) | **GET** /todo-list/{list_id} | Todo-Liste abrufen |
| [**GetallEntries**](TodoListenverwaltungApi.md#getallentries) | **GET** /todo-list/{list_id}/entries | Einträge abrufen |
| [**GetallTodoList**](TodoListenverwaltungApi.md#getalltodolist) | **GET** /todo-lists | Todo-Listen abrufen |
| [**UpdateEntry**](TodoListenverwaltungApi.md#updateentry) | **PUT** /todo-list/{list_id}/entry/{entry_id} | Eintrag aktualisieren |

<a id="createentry"></a>
# **CreateEntry**
> Entries CreateEntry (Guid listId, NewEntry newEntry)

Eintrag erstellen

Dieser Endpunkt erstellt einen neuen Eintrag in einer bestimmten Todo-Liste

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:5000";
            var apiInstance = new TodoListenverwaltungApi(config);
            var listId = "listId_example";  // Guid | URL-Element; ID der gewünschten Todo-Liste
            var newEntry = new NewEntry(); // NewEntry | JSON-Objekt mit dem Namen und der Beschreibung des Eintrags

            try
            {
                // Eintrag erstellen
                Entries result = apiInstance.CreateEntry(listId, newEntry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodoListenverwaltungApi.CreateEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Eintrag erstellen
    ApiResponse<Entries> response = apiInstance.CreateEntryWithHttpInfo(listId, newEntry);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TodoListenverwaltungApi.CreateEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **Guid** | URL-Element; ID der gewünschten Todo-Liste |  |
| **newEntry** | [**NewEntry**](NewEntry.md) | JSON-Objekt mit dem Namen und der Beschreibung des Eintrags |  |

### Return type

[**Entries**](Entries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Fehlerhafte Anfrage |  -  |
| **404** | Nicht gefunden |  -  |
| **405** | Methode nicht erlaubt |  -  |
| **500** | Interner Serverfehler |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtodolist"></a>
# **CreateTodoList**
> TodoList CreateTodoList (NewTodoList newTodoList)

Todo-Liste hinzufügen

Dieser Endpunkt erstellt eine neue Todo-Liste

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateTodoListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:5000";
            var apiInstance = new TodoListenverwaltungApi(config);
            var newTodoList = new NewTodoList(); // NewTodoList | JSON-Objekt mit dem Namen der Liste

            try
            {
                // Todo-Liste hinzufügen
                TodoList result = apiInstance.CreateTodoList(newTodoList);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodoListenverwaltungApi.CreateTodoList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTodoListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Todo-Liste hinzufügen
    ApiResponse<TodoList> response = apiInstance.CreateTodoListWithHttpInfo(newTodoList);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TodoListenverwaltungApi.CreateTodoListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newTodoList** | [**NewTodoList**](NewTodoList.md) | JSON-Objekt mit dem Namen der Liste |  |

### Return type

[**TodoList**](TodoList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Fehlerhafte Anfrage |  -  |
| **405** | Methode nicht erlaubt |  -  |
| **500** | Interner Serverfehler |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteentry"></a>
# **DeleteEntry**
> DeleteTodoList200Response DeleteEntry (Guid listId, Guid entryId)

Eintrag löschen

Dieser Endpunkt löscht einen bestimmten Eintrag in einer bestimmten Todo-Liste

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:5000";
            var apiInstance = new TodoListenverwaltungApi(config);
            var listId = "listId_example";  // Guid | URL-Element; ID der gewünschten Todo-Liste
            var entryId = "entryId_example";  // Guid | URL-Element; ID des gewünschten Eintrags

            try
            {
                // Eintrag löschen
                DeleteTodoList200Response result = apiInstance.DeleteEntry(listId, entryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodoListenverwaltungApi.DeleteEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Eintrag löschen
    ApiResponse<DeleteTodoList200Response> response = apiInstance.DeleteEntryWithHttpInfo(listId, entryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TodoListenverwaltungApi.DeleteEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **Guid** | URL-Element; ID der gewünschten Todo-Liste |  |
| **entryId** | **Guid** | URL-Element; ID des gewünschten Eintrags |  |

### Return type

[**DeleteTodoList200Response**](DeleteTodoList200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Fehlerhafte Anfrage |  -  |
| **404** | Nicht gefunden |  -  |
| **405** | Methode nicht erlaubt |  -  |
| **500** | Interner Serverfehler |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetodolist"></a>
# **DeleteTodoList**
> DeleteTodoList200Response DeleteTodoList (Guid listId)

Todo-Liste löschen

Dieser Endpunkt löscht eine einzelne bestimmte Todo-Liste mitsamt ihren Einträgen anhand der ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteTodoListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:5000";
            var apiInstance = new TodoListenverwaltungApi(config);
            var listId = "listId_example";  // Guid | URL-Element; ID der gewünschten Todo-Liste

            try
            {
                // Todo-Liste löschen
                DeleteTodoList200Response result = apiInstance.DeleteTodoList(listId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodoListenverwaltungApi.DeleteTodoList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTodoListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Todo-Liste löschen
    ApiResponse<DeleteTodoList200Response> response = apiInstance.DeleteTodoListWithHttpInfo(listId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TodoListenverwaltungApi.DeleteTodoListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **Guid** | URL-Element; ID der gewünschten Todo-Liste |  |

### Return type

[**DeleteTodoList200Response**](DeleteTodoList200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Nicht gefunden |  -  |
| **405** | Methode nicht erlaubt |  -  |
| **500** | Interner Serverfehler |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettodolist"></a>
# **GetTodoList**
> TodoList GetTodoList (Guid listId)

Todo-Liste abrufen

Dieser Endpunkt liefert eine einzelne bestimmte Todo-Liste anhand der ID zurück

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTodoListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:5000";
            var apiInstance = new TodoListenverwaltungApi(config);
            var listId = "listId_example";  // Guid | URL-Element; ID der gewünschten Todo-Liste

            try
            {
                // Todo-Liste abrufen
                TodoList result = apiInstance.GetTodoList(listId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodoListenverwaltungApi.GetTodoList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTodoListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Todo-Liste abrufen
    ApiResponse<TodoList> response = apiInstance.GetTodoListWithHttpInfo(listId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TodoListenverwaltungApi.GetTodoListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **Guid** | URL-Element; ID der gewünschten Todo-Liste |  |

### Return type

[**TodoList**](TodoList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Nicht gefunden |  -  |
| **405** | Methode nicht erlaubt |  -  |
| **500** | Interner Serverfehler |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallentries"></a>
# **GetallEntries**
> List&lt;Entries&gt; GetallEntries (Guid listId)

Einträge abrufen

Dieser Endpunkt liefert eine Liste aller Einträge einer bestimmten Todo-Liste zurück

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetallEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:5000";
            var apiInstance = new TodoListenverwaltungApi(config);
            var listId = "listId_example";  // Guid | URL-Element; ID der gewünschten Todo-Liste

            try
            {
                // Einträge abrufen
                List<Entries> result = apiInstance.GetallEntries(listId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodoListenverwaltungApi.GetallEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetallEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Einträge abrufen
    ApiResponse<List<Entries>> response = apiInstance.GetallEntriesWithHttpInfo(listId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TodoListenverwaltungApi.GetallEntriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **Guid** | URL-Element; ID der gewünschten Todo-Liste |  |

### Return type

[**List&lt;Entries&gt;**](Entries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Nicht gefunden |  -  |
| **405** | Methode nicht erlaubt |  -  |
| **500** | Interner Serverfehler |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltodolist"></a>
# **GetallTodoList**
> List&lt;TodoList&gt; GetallTodoList ()

Todo-Listen abrufen

Dieser Endpunkt liefert eine Liste aller Todo-Listen zurück

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetallTodoListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:5000";
            var apiInstance = new TodoListenverwaltungApi(config);

            try
            {
                // Todo-Listen abrufen
                List<TodoList> result = apiInstance.GetallTodoList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodoListenverwaltungApi.GetallTodoList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetallTodoListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Todo-Listen abrufen
    ApiResponse<List<TodoList>> response = apiInstance.GetallTodoListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TodoListenverwaltungApi.GetallTodoListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;TodoList&gt;**](TodoList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **405** | Methode nicht erlaubt |  -  |
| **500** | Interner Serverfehler |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateentry"></a>
# **UpdateEntry**
> UpdateEntry200Response UpdateEntry (Guid listId, Guid entryId, NewEntry newEntry)

Eintrag aktualisieren

Dieser Endpunkt aktualisiert einen bestimmten Eintrag in einer bestimmten Todo-Liste

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:5000";
            var apiInstance = new TodoListenverwaltungApi(config);
            var listId = "listId_example";  // Guid | URL-Element; ID der gewünschten Todo-Liste
            var entryId = "entryId_example";  // Guid | URL-Element; ID des gewünschten Eintrags
            var newEntry = new NewEntry(); // NewEntry | JSON-Objekt mit dem Namen und der Beschreibung des Eintrags

            try
            {
                // Eintrag aktualisieren
                UpdateEntry200Response result = apiInstance.UpdateEntry(listId, entryId, newEntry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodoListenverwaltungApi.UpdateEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Eintrag aktualisieren
    ApiResponse<UpdateEntry200Response> response = apiInstance.UpdateEntryWithHttpInfo(listId, entryId, newEntry);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TodoListenverwaltungApi.UpdateEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **Guid** | URL-Element; ID der gewünschten Todo-Liste |  |
| **entryId** | **Guid** | URL-Element; ID des gewünschten Eintrags |  |
| **newEntry** | [**NewEntry**](NewEntry.md) | JSON-Objekt mit dem Namen und der Beschreibung des Eintrags |  |

### Return type

[**UpdateEntry200Response**](UpdateEntry200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Fehlerhafte Anfrage |  -  |
| **404** | Nicht gefunden |  -  |
| **405** | Methode nicht erlaubt |  -  |
| **500** | Interner Serverfehler |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

