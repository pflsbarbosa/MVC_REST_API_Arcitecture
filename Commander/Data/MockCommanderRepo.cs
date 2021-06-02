using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        List<Command> commands = new List<Command>();
        int countCmd = 0;
        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
           {
                throw new ArgumentNullException(nameof(cmd));
           }
           commands.Add(cmd);
           countCmd = commands.Count;
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllComands()
        {            
             commands.Add(new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"});
             commands.Add(new Command{Id=1, HowTo="Cut bread", Line="Get a knife", Platform="Knife & chopping board"});
             commands.Add(new Command{Id=2, HowTo="Make a Cake", Line="Put the butter in a pan and beat the egg whites until it is in a castile. Mix the flour with the yolk plus sugar and salt.", Platform="Form, beater and oven"});
            
            return commands.Where(x => x.Id >= 0);            
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
        }

        public bool SaveChanges()
        {
            return(commands.Count > countCmd);
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}