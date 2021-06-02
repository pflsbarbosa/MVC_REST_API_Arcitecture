using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public  interface   ICommanderRepo
    {
        bool SaveChanges();// when we change data in DB, what we gone call?

        IEnumerable<Command> GetAllComands(); 
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}