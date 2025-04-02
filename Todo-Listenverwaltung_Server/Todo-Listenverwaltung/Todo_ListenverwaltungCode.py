
from flask import Flask, request, jsonify, abort
import uuid
 
# Initialisiere Flask-Server
app = Flask(__name__)

# Dummy-Daten erzeugen
todo_list1_id = str(uuid.uuid4())
todo_list2_id = str(uuid.uuid4())
todo_list3_id = str(uuid.uuid4())

todo_lists = [
    {"id": todo_list1_id, "name": "Einkaufsliste"},
    {"id": todo_list2_id, "name": "Hausaufgabenliste"},
    {"id": todo_list3_id, "name": "Projekteliste"},
]
entries = [
    {
        "id": str(uuid.uuid4()),
        "name": "Brot",
        "description": "glutenfrei",
        "todo_list_id": todo_list1_id,
    },
    {
        "id": str(uuid.uuid4()),
        "name": "Pizza",
        "description": "Tonno 5x",
        "todo_list_id": todo_list1_id,
    },
    {
        "id": str(uuid.uuid4()),
        "name": "Wasser",
        "description": "Saskia gruen",
        "todo_list_id": todo_list1_id,
    },
    {
        "id": str(uuid.uuid4()),
        "name": "Deutsch",
        "description": "Diktat abschreiben",
        "todo_list_id": todo_list2_id,
    },
    {
        "id": str(uuid.uuid4()),
        "name": "Praesentation",
        "description": "Projektleiter mag viele Effekte",
        "todo_list_id": todo_list3_id,
    },
]

@app.after_request
def apply_cors_header(response):
    response.headers["Access-Control-Allow-Origin"] = "*"
    response.headers["Access-Control-Allow-Methods"] = "GET,POST,DELETE,PUT"
    response.headers["Access-Control-Allow-Headers"] = "Content-Type"
    return response


## Endpunkte
# Todo-Liste hinzufuegen
@app.route("/todo-list", methods=["POST"])
def add_new_todo_list():
    new_todo_list = request.get_json(force=True)

    new_todo_list["id"] = str(uuid.uuid4())
    print(f"Es wurde eine neue Liste hinzugefuegt: {new_todo_list}")
    todo_lists.append(new_todo_list)
    return jsonify(new_todo_list), 200


# Todo-Liste loeschen/abrufen
@app.route("/todo-list/<list_id>", methods=["GET", "DELETE"])
def handle_todolist(list_id):
    # ID abfangen
    todo_list_item = None
    for todo_list in todo_lists:
        if todo_list["id"] == list_id:
            todo_list_item = todo_list
            break
    if not todo_list_item:
        abort(404)
    # HTTP Methoden abfangen
    if request.method == "DELETE":
        print(f"Todo-Liste mit ID {list_id} loeschen...")
        todo_lists.remove(todo_list_item)
        return jsonify({"message": "Todo-Liste geloescht"}), 200
    elif request.method == "GET":
        print(f"Todo-Liste mit ID {list_id} abrufen...")
        return jsonify(todo_list_item), 200


# Todo-Listen abrufen
@app.route("/todo-lists", methods=["GET"])
def get_all_todolists():
    print(f"Alle Todo-Listen abrufen...")
    return jsonify(todo_lists), 200


# Eintraege abrufen
@app.route("/todo-list/<list_id>/entries", methods=["GET"])
def get_all_entries(list_id):
    someEntries = []
    # ID abfangen
    for entry in entries:
        if entry["todo_list_id"] == list_id:
            someEntries.append(entry)
    if not someEntries:
        abort(404)
    print(f"Alle Eintraege einer Todo-Liste abrufen...")
    return jsonify(someEntries), 200


# Eintrag erstellen
@app.route("/todo-list/<list_id>/entry", methods=["POST"])
def add_entry(list_id):
    # ID abfangen
    todo_list_item = None
    for todo_list in todo_lists:
        if todo_list["id"] == list_id:
            todo_list_item = todo_list
            break
    if not todo_list_item:
        abort(404)
    newEntry = request.get_json(force=True)

    newEntry["id"] = str(uuid.uuid4())
    newEntry["todo_list_id"] = list_id
    print(f"Neuen Eintraeg erstellen...")
    entries.append(newEntry)
    return jsonify(newEntry), 200


# Eintrag aktualisieren/loeschen
@app.route("/todo-list/<list_id>/entry/<entry_id>", methods=["PUT", "DELETE"])
def update_entry(list_id, entry_id):
    # ID's abfangen
    todo_list_item = None
    for todo_list in todo_lists:
        if todo_list["id"] == list_id:
            todo_list_item = todo_list
            break
    if not todo_list_item:
        abort(404)

    entry_item = None
    for entry in entries:
        if entry["id"] == entry_id:
            entry_item = entry
            break
    if not entry_item:
        abort(404)
    # HTTP Methoden abfangen
    if request.method == "DELETE":
        print(f"Entry mit ID {entry_id} loeschen...")
        entries.remove(entry_item)
        return jsonify({"message": "Entry geloescht"}), 200

    elif request.method == "PUT":
        print(f"Entry mit ID {entry_id} aendern...")
        updatedEntry = request.get_json(force=True)
        entry_item["name"] = updatedEntry["name"]
        entry_item["description"] = updatedEntry["description"]
        for index, _ in enumerate(entries):
            if entries[index]["id"] == entry_item["id"]:
                entries[index] = entry_item
        return jsonify(entry_item), 200


if __name__ == "__main__":
    # Flask-Server starten
    app.run(host="127.0.0.1", port=5000, debug=False)
