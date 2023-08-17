using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;


namespace NoteLibrary
{
    public class DB_Connection
    {
        //mongodb+srv://opwinopwin:t25366021@cluster0.kc41ysl.mongodb.net/?retryWrites=true&w=majority
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<NoteModel> _noteCollection;
        private IMongoCollection<CreatorModel> _creatorCollection;
        public DB_Connection(string connectionString)
        {
            try
            {
                _client= new MongoClient(connectionString);
                _database = _client.GetDatabase("NoteDB");
                _noteCollection = _database.GetCollection<NoteModel>("notes");
                _creatorCollection = _database.GetCollection<CreatorModel>("creators");
                Debug.WriteLine("Connect Success!!");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void CloseConnection()
        {
        }

        public async Task InsertNote(NoteModel note)
        {
            await _noteCollection.InsertOneAsync(note);
        }
        public async Task InsertCreator(CreatorModel creator)
        {
            await _creatorCollection.InsertOneAsync(creator);
        }
        public async Task<List<NoteModel>> GetAllNotes()
        {
            return await _noteCollection.Find(new BsonDocument()).ToListAsync();
        }
        public async Task<List<CreatorModel>> GetAllCreators()
        {
            return await _creatorCollection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<List<NoteModel>> GetNoteByTitle(string title)
        {
            var filter = Builders<NoteModel>.Filter.Eq("NoteTitle", title);
            var result= await _noteCollection.Find(filter).ToListAsync();
            return result;
        }

        public async Task<bool> UpdateNote(string noteTitle,string noteContent)
        {
            var filter = Builders<NoteModel>.Filter.Eq("NoteTitle", noteTitle);
            var update = Builders<NoteModel>.Update.Set("NoteContent", noteContent);
            var result=await _noteCollection.UpdateOneAsync(filter, update);

            return result.ModifiedCount != 0;
        }

        public async Task<bool> DeleteNote(string noteTitle)
        {
            var filter = Builders<NoteModel>.Filter.Eq("NoteTitle", noteTitle);
            var result=await _noteCollection.DeleteOneAsync(filter);
            return result.DeletedCount!=0;
        }

    }
}
