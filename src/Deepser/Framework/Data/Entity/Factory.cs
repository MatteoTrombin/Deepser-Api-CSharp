using System;
using Deepser.Entity;
using Deepser.Entity.Cmdb;
using Deepser.Entity.Service;
using Deepser.Entity.Company;
using Deepser.Entity.Group;
using Deepser.Entity.Admin;
using System.Collections.Generic;
using Deepser.Entity.Address;
using Deepser.Entity.Announcement;
using Deepser.Entity.Approval;
using Deepser.Entity.Asset;
using Deepser.Entity.Catalog.Product;
using Deepser.Entity.Category;
using Deepser.Entity.Crm;
using Deepser.Entity.Contract;
using Deepser.Entity.Inventory;
using Deepser.Entity.Kb;
using Deepser.Entity.Sales;
using Deepser.Entity.Survey;
using Deepser.Entity.Tax;
using Deepser.Framework.Request;

namespace Deepser.Framework.Data.Entity
{
    public class Factory
    {
        // A dictionary that maps entity names to AbstractEntity objects (Factory Pattern)
        public Dictionary<string, AbstractEntity> entityDictionary = new Dictionary<string, AbstractEntity>()
        {
            { "account", new Account() },
            { "address", new Address() },
            { "announcement", new Announcement() },
            { "approval", new Approval() },
            { "asset_bios", new Bios() },
            { "asset_cpu", new Cpu() },
            { "asset_device", new Device() },
            { "asset_hdd", new HddLogical() },
            { "asset_ip", new Ip() },
            { "asset_motherboard", new MotherBoards() },
            { "asset_network", new NetworkInterface() },
            { "asset_os", new Os() },
            { "asset_ping", new PingSweeps() },
            { "asset_ram", new Ram() },
            { "asset_remote", new RemoteCollectors() },
            { "asset_script", new Scripts() },
            { "asset_snmp", new Snmp() },
            { "asset_software", new Software() },
            { "asset_subnet", new Subnet() },
            { "asset_subtype", new Subtype() },
            { "asset_system", new SystemChassiss() },
            { "asset_type", new Deepser.Entity.Asset.Type() },
            { "asset_update", new Update() },
            { "category", new Category() },
            { "ci", new Ci() },
            { "class", new Class() },
            { "cmdb_type", new Deepser.Entity.Cmdb.Type() },
            { "company", new Company() },
            { "contact", new ContactCrm() },
            { "contact_crm", new ContactCrm() },
            { "contact_type", new ContactType() },
            { "group", new Group() },
            { "item", new Item() },
            { "kb", new Kb() },
            { "kb_article", new KbArticle() },
            { "line", new Line() },
            { "movement", new Movement() },
            { "operation", new Operation() },
            { "opportunity", new Opportunity() },
            { "payment_condition", new PaymentCondition() },
            { "product", new Product() },
            { "quote", new Quote() },
            { "subtype", new Subtype() },
            { "survey", new Survey() },
            { "survey_template", new SurveyTemplate() },
            { "tax", new Tax() },
            { "type", new Deepser.Entity.Service.Type() },
            { "user", new User() },
            { "warehouse", new Warehouse() },
            { "warehouse_type", new WarehouseType() },
        };

        public Dictionary<string, AbstractEntity> activityEntity = new Dictionary<string, AbstractEntity>()
        {
            { "account", new Account() },
            { "address", new Address() },
            { "announcement", new Announcement() },
            { "ci", new Ci() },
            { "company", new Company() },
            { "contract", new Contract()},
            { "contact_crm", new ContactCrm() },
            { "asset_device", new Device() },
            { "item", new Item() },
            { "line", new Line() },
            { "movement", new Movement() },
            { "operation", new Operation() },
            { "opportunity", new Opportunity() },
            { "payment_condition", new PaymentCondition() },
            { "product", new Product() },
            { "quote", new Quote() },
            { "tax", new Tax() },
            { "warehouse", new Warehouse() },
        };
        public Filter CreateFilter()
        {
            return new Filter();
        }

        // Method for creating a new instance of AbstractEntity based on entity string name
        public AbstractEntity CreateEntity(string entity)
        {
            // Check if the dictionary contains the given entity name
            if (entityDictionary.ContainsKey(entity.ToLower().Replace(" ", "_")))
            {
                return entityDictionary[entity.ToLower().Replace(" ", "_")];
            }
            else
            {
                throw new Exception($"Entity not found, check that you typed correctly");
            }
        }

        public object[] GetFormattedKeys(Dictionary<string, AbstractEntity> dict)
        {
            object[] result = dict.Select(entity =>
            {
                string formattedKey = string.Join(" ", entity.Key.Replace("_", " ").Split(" ")
                    .Select(word => char.ToUpper(word[0]) + word.Substring(1)));

                return formattedKey;
            }).ToArray();
            return result;
        }
    }
}
