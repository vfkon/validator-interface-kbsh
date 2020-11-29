using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class mongoImport
    {
        public static IMongoCollection<tickets> initMongoTicketCollection()
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");

            var database = dbClient.GetDatabase("dbTimesAndStations");
            var collection = database.GetCollection<tickets>("tickets");
            bool isMongoLive = database.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);

            return collection;
        }
        public static async Task setTicketDocumentsAsync(IMongoCollection<tickets> collection)
        {
            DateTime localDate = DateTime.Now;
            tickets ticket = new tickets();
            string str = "";
            using (var sr = new StreamReader("buf.txt"))
            {
                 str = sr.ReadLine();
            }
            string[] index = str.Split(new char[] { ' ' });

            ticket.arrive_station_id = index[0];
            ticket.depart_station_id = index[1];
            ticket.lgota = index[2];
            ticket.time = localDate.Hour.ToString()+":"+localDate.Minute.ToString() + ":"+localDate.Second.ToString();
            ticket.date = localDate.Day.ToString() + "." + localDate.Month.ToString() + "." + localDate.Year.ToString();
            await collection.InsertOneAsync(ticket);
        }

    }
    public class tickets
    {
        public ObjectId Id { get; set; }
        public string arrive_station_id { get; set; }
        public string depart_station_id { get; set; }
        public string time { get; set; }
        public string date { get; set; }
        public string lgota { get; set; }
    }
}
