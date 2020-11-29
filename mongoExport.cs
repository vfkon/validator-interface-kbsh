using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class mongoExport
    {
        public static IMongoCollection<stations> initMongoStationCollection()
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");

            var database = dbClient.GetDatabase("dbTimesAndStations");
            var collection = database.GetCollection<stations>("stations");
            bool isMongoLive = database.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);
            if (isMongoLive == false) throw new Exception();
            return collection;
        }

        public static async Task<List<stations>> getStationDocumentsAsync(IMongoCollection<stations> collection)
        {
            var filter = new BsonDocument();
            List<stations> list = new List<stations>();
            using (var cursor = collection.FindSync(filter))
            {
                while (await cursor.MoveNextAsync())
                {

                    var docs = cursor.Current;
                    foreach (var doc in docs)
                    {
                        list.Add(doc);
                    }
                }
            }
            return list;
        }

        public static IMongoCollection<trains> initMongoTrainsCollection()
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");

            var database = dbClient.GetDatabase("dbTimesAndStations");
            var collection = database.GetCollection<trains>("trains");
            bool isMongoLive = database.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);
            if (isMongoLive == false) throw new Exception();
            return collection;
        }
        public static async Task<List<trains>> getTrainDocumentsAsync(IMongoCollection<trains> collection)
        {
            var filter = new BsonDocument();
            List<trains> list = new List<trains>();
            using (var cursor = collection.FindSync(filter))
            {
                while (await cursor.MoveNextAsync())
                {

                    var docs = cursor.Current;
                    foreach (var doc in docs)
                    {
                        list.Add(doc);
                    }
                }
            }
            return list;
        }
    }
    public class stations
    {
        public ObjectId Id { get; set; }
        public string station_id { get; set; }
        public string Station { get; set; }
    }

    public class trains
    {
        public ObjectId Id { get; set; }
        public string train_id { get; set; }
        public string TrainNumber { get; set; }
        public string arrive_id { get; set; }
        public string depart_id { get; set; }
        public string time { get; set; }
    }
}
