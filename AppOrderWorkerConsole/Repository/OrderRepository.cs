using AppOrderWorkerConsole.Domani;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrderWorkerConsole.Repository
{
    class OrderRepository
    {
        private readonly IMongoCollection<Order> _mongoCollection;
        private static readonly string _mongoConnection = Environment.GetEnvironmentVariable("mongoConnection");
        public OrderRepository()
        {
            var mongoClient = new MongoClient(_mongoConnection);
            //var mongoClient = new MongoClient("mongodb+srv://xl:123xl@cluster0.08wko.mongodb.net/manageOrder?retryWrites=true&w=majority");
            var dataBase = mongoClient.GetDatabase("manageOrder");
            _mongoCollection = dataBase.GetCollection<Order>("Orders");
        }
        
        public Order Create(Order order)
        {
            _mongoCollection.InsertOne(order);
            return order;
        }
    }
}
