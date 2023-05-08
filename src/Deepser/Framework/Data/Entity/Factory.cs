using Deepser.Entity;
using Deepser.Entity.Cmdb;
using Deepser.Entity.Service;
using System;
using System.Collections.Generic;

namespace Deepser.Framework.Data.Entity
{
    public class Factory
    {
        // A dictionary that maps entity names to AbstractEntity objects (Factory Pattern)
        internal Dictionary<string, AbstractEntity> factDictionary = new Dictionary<string, AbstractEntity>()
        {
            { "operation", new Operation() },
            { "type", new Deepser.Entity.Service.Type() },
            { "company", new Company() },
            { "ci", new Ci() },
            { "group", new Group() },
            { "user", new User() }
        };

        // Method for creating a new instance of AbstractEntity based on entity string name
        public AbstractEntity CreateEntity(string entity)
        {
            // Check if the dictionary contains the given entity name
            if (factDictionary.ContainsKey(entity.ToLower()))
            {
                return factDictionary[entity.ToLower()];
            }
            else
            {
                throw new Exception($"Entity not found, check that you typed correctly");
            }
        }
    }
}
