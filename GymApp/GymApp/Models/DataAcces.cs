using GymApp.Interfaces;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace GymApp.Models
{
    //Es una hermosa pruebita pero ahora de ubuntu, y ahora de manjaro
    class DataAcces : IDisposable
    {
        private SQLiteConnection connection;

        public DataAcces()
        {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Plataforma,
                System.IO.Path.Combine(config.DirectorioDB, "GymApp.db3"));
            connection.CreateTable<MClient>();
        }

        public void InsertClient(MClient client)
        {
            connection.Insert(client);
        }

        public void UpdateClient(MClient client)
        {
            connection.Update(client);
        }

        public void DeleteClient(MClient client)
        {
            connection.Delete(client);
        }

        public MClient GetClient(int Id)
        {
            return connection.Table<MClient>().FirstOrDefault(x => x.IDClient == Id);
        }

        public List<MClient> GetClients()
        {
            return connection.Table<MClient>().OrderBy(x => x.IDClient).ToList();
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
