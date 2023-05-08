# Deepser API
This is a guide for consuming the Deepser API - a help desk software. More information can be found in the Deepser API Docs.

## Installation
To use Deepser.dll within your project, follow these steps:

1. Download the **[Deepser.dll](https://github.com/MatteoTrombin/api-csharp/blob/main/Deepser.dll)** file from the repository.

2. In Visual Studio, right-click on the "References" menu in the Solution Explorer and select "Add Reference".

3. In the dialog box, locate the downloaded Deepser.dll file and add it as a reference.

4. Add the Deepser namespace to your code using the "using" directive.

5. Install the **[Newtonsoft.Json](https://www.newtonsoft.com/json)** NuGet package in your project. To do this, go to the "Manage NuGet Packages" menu, search for "Newtonsoft.Json," and install the package.

6. Make sure the package has been added to your project's references along with Deepser.dll.

Once these steps are complete, you will be able to access the methods and classes defined in Deepser.dll in your code.

## Example

### Login with Basic Authentication
```c#
string host = "https://your.deepser.net";
string username = "username";
string password = "password";
Authentication auth = new Authentication(host, username, password);
```

### Login with Token Based Authentication

```c#
string host = "https://your.deepser.net";
string token = "mytokenhere";
Authentication auth = new Authentication(host, token);
```

## Factory
```c#
Factory fact = new Factory();

//create new instances of the various entities using the factory pattern
var comp = fact.CreateEntity("Company");
var op = fact.CreateEntity("Operation");
var user = fact.CreateEntity("User");
```

## Operation (Ticket)
```c#
// load an existing operation by id
await op.Load(5413);

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
await op.Delete("NewTicket", "title");
```

## User
```c#
// load an existing user by id
var result = await user.Load(48);

// get the data from the user I loaded
result.getData("username"); 

// load user collection

// set up collection for the user entity
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

## Company
```c#
// load an existing operation by id
await comp.Load(2);

// load company collection

// set up collection for the company entity
Collection collection = new Collection();
collection.SetMainModel(typeof(Company));

// add filter
var filter = collection.GetFilter();
filter.addFilter("name", Like, "ACME%");

// add parameter
var parameter = collection.GetParameter();
parameter.SetOrder("entity_id", Parameter.Ascending);

// load a collection of single data
await collection.LoadMultiple();
var items = collection.GetCollection();
collection.GetSingleData("phone");
```

## Credits
* [Matteo Trombin](https://github.com/MatteoTrombin)

## Support
[Please open an issue in github](https://github.com/MatteoTrombin/Deepser-Api-CSharp/issues)

## Conclusion

The Deepser API is a helpful tool for building and managing help desk software. By following the above examples, you can consume the Deepser API and build your own customized applications.
