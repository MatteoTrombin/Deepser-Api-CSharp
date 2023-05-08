using System.Reflection;
using Deepser;
using Deepser.Entity;
using Deepser.Entity.Service;
using Deepser.Framework;
using Deepser.Framework.Data;
using Deepser.Framework.Data.Entity;
using Deepser.Framework.Request;
using System.Runtime.CompilerServices;
using static Deepser.Framework.Request.Filter;
using System.Diagnostics;

public class Program
{
    private static async Task Main(string[] args)
    {
        try
        {
            //            BEARER AUTHENTICATION



            string host = "devtest001";
            string token = "api643551221ccba2.07253568Vv%%czu/tHU)/iNFwEGtlyYgUwFnmOEvZ%yJsiSUlJD=gz)n!fgjbgfewJFPwys1g)Uub]aYuK!{esa&EGWSYW(}%LzezId0JU)Fsx)$K!qmKsaBVAgiPswnh$YvBC]zZ%pSgZAKYZVjlWsBbZO/{8";
            // create a deep desk object
            Authentication auth = new Authentication(host, token);



            //             BASIC AUTHENTICATION

            /*
            string host = "devtest001";
            string username = "admin";
            string password = "Yi#!}74EE4$b*tT3f3UtO1Vf";
            Authentication auth = new Authentication(host, username, password);
            */


            //                  FACTORY


            //create new instances of the various entities using the factory pattern
            Factory fact = new Factory();
            var col = fact.CreateEntity("Company");
            var op = fact.CreateEntity("Operation");
            var us = fact.CreateEntity("User");


            //      SINGLE LOAD & LOAD SINGLE VALUE || ok



            
            
            // load an existing operation by id
            var result = await col.Load(2);
            // get the data from the operation I loaded
            Console.WriteLine(result.getData("name")); 
            


            // load by attribute

            /*
            var result = await op.Load("newOperation", "title");
            Console.WriteLine(result.getData("entity_id"));
            */

            //              CREATE || ok 


            /*
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
            Console.WriteLine(op.getData("entity_id"));
            Console.WriteLine(op.getData("title"));
            */


            //              UPDATE || ok


            /*
            
            // update an operation
            op.setData("title", "NewTitle");
            await op.Update("OldTitle", "title");

            // get the data from the operation I updated
            Console.WriteLine(op.getData("title"));
            */


            //              DELETE || ok

            // Delete by id 

            //Console.WriteLine(await col.Delete(5));

            // Delete by attribute

            //Console.WriteLine(await col.Delete("Google", "Name"));;


            //              COLLECTION || ok

            
            
            // set up collection for the operation entity
            Collection collection = new Collection();
            collection.SetMainModel(typeof(Company));

            // add filter
            var filter = collection.GetFilter();
            filter.addFilter("name", Like, "ACME%");

            // add parameter

            var parameter = collection.GetParameter();
            parameter.SetOrder("entity_id", Parameter.Ascending);
            

            // load collection
            
            /*
            await collection.LoadMultiple();
            var items = collection.GetCollection();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            */

            // load single data

            
            await collection.LoadMultiple();
            var _items = collection.GetCollection();
            Console.WriteLine(collection.GetSingleData("phone"));
            




            //    LOAD ACTIVITY & LOAD SINGLE VALUE || ok

            /*
             * 
            // load single activity

            var result = await op.LoadActivity(5413, 696);
            Console.WriteLine(result.getData("description")); 
            */


            //          CREATE ACTIVITY || Ok


            /*
            
            // create single actity

            op.setData("type", 3)
                .setData("description", "Activity Description")
                .setData("portal_visibility", 1)
                .setData("frontend_visibility", 1)
                .setData("status", 2);
            await op.CreateActivity(5413);
            Console.WriteLine(op.getData("description"));
            */


            //          UPDATE ACTIVITY || ok


            /*
            
            // update single activity
            op.setData("description", "UpdateCommento");
            await op.UpdateActivity(5413, 694);
            Console.WriteLine(op.getData("description"));

            */


            //          DELETE ACTIVITY || ok


            /*
            
            // delete single activity

            var result = await op.DeleteActivity(5413, 696);
            Console.WriteLine(result);

            */


            //          COLLECITON ACTIVITY || ok


            /*
            
            // load activity colleciton
            Collection collection = new Collection();
            collection.SetMainModel(typeof(Operation));

            // add filters
            var filters = collection.GetFilter();
            filters.addRange("entity_id", 691, 695);

            // add parameters
            var parameters = collection.GetParameter();
            parameters.SetOrder("entity_id", Parameter.Descending);

            // load activity collection
            await collection.LoadMultipleActivity(5413);
            var dictionarycollection = collection.GetCollection();
            foreach (var item in dictionarycollection)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            // load single data from the collection
            Console.WriteLine(collection.GetSingleData("description")); 

            */


            //          MULTIPLE_CREATE || OK


            /*
            Collection coll = new Collection();
            coll.SetMainModel(typeof(Company));
            coll.setObject("name", "Google")
                .setObject("parent_id", 1)
                .setObject("description", "Google LLC is a US company that offers the world's largest online search service.");
            coll.addObject();
            coll.setObject("name", "Amazon")
                .setObject("parent_id", 1)
                .setObject("description", "Amazon.com Inc (Amazon) is an online retailer and web service provider.");
            coll.addObject();
            await coll.MultipleCreate();
            Console.WriteLine(coll.GetSingleData("created_at"));
            */

            /*      NON FUNZIONA
            Collection coll = new Collection();
            coll.SetMainModel(typeof(Operation));
            coll.setObject("type_id", 1)
                .setObject("title", "TextTitle")
                .setObject("description", "TextDescription")
                .setObject("priority_id", 1)
                .setObject("urgency_id", 1)
                .setObject("status", 1);
            coll.addObject();
            coll.setObject("type_id", 2)
                .setObject("title", "TitleText")
                .setObject("description", "DescriptionText")
                .setObject("priority_id", 2)
                .setObject("urgency_id", 2)
                .setObject("status", 1);
            coll.addObject();
            await coll.MultipleCreate();
            Console.WriteLine(coll.GetSingleData("title"));
            */


            // MULTIPLECREATEACTIVITY NON FUNZIONA (PROBABILMENTE NON PERMESSO)


            /*
            Collection coll = new Collection();
            coll.SetMainModel(typeof(Operation));
            coll.setObject("type", "1")
                .setObject("description", "ciao")
                .setObject("portal_visibility", 1);
            coll.addObject();
            coll.setObject("type", "2")
                .setObject("description", "miao")
                .setObject("portal_visibility", 1);
            coll.addObject();
            await coll.MultipleCreateActivity(5413);
            var collection = coll.GetCollection();
            foreach (var item in collection)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }
            */


        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}