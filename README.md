# Deepser Api
Let's consume the Deepser API 

Deepser is a help desk software and you can find more information in Deepser API Docs

# Installation

# Example
Login with Basic Authentication

```c#
string host = "https://your.deepser.net";
string username = "username";
string password = "password";
Authentication auth = new Authentication(host, username, password);
```

Login with Token Based Authentication
```c#
string host = "https://your.deepser.net";
string token = "mytokenhere";
// create a deep desk object
Authentication auth = new Authentication(host, token);
```

# Factory
```c#
//create new instances of the various entities using the factory pattern
Factory fact = new Factory();
var col = fact.CreateEntity("Company");
var op = fact.CreateEntity("Operation");
var us = fact.CreateEntity("User");
```
# Operation (Ticket)
```c#
// load an existing operation by id
var result = await op.Load(5413);

// get the data from the operation I loaded
result.getData("description");

// create new operation object
op.setData("type_id", 1)
    .setData("title", "iPhone 13")
    .setData("category1", 17)
    .setData("description", "Description")
    .setData("priority_id", 1)
    .setData("urgency_id", 1)
    .setData("status", 1);
var result = await op.Create();
// get the data from the operation I created
op.getData("entity_id");

// update an operation
op.setData("title", "NewTitle");
op.Update("OldTitle", "title");
// get the data from the operation I updated
op.getData("title");

// delete by id 
await op.Delete(5396);
// delete by attribute
await col.Delete("NewTicket", "title");
```

# User
```c#
// load an existing user by id
var result = await us.Load(48);
// get the data from the user I loaded
result.getData("username"); 

// load user collection
// set up collection for the operation entity
Collection collection = new Collection();
collection.SetMainModel(typeof(User));

// add filter
var filter = collection.GetFilter();
filter.addFilter("username", EqualTo, "admin");

// load collection
await collection.LoadMultiple();
var items = collection.GetCollection();
foreach (var item in items)
{
    $"{item.Key} : {item.Value}";
}
```
# Company

