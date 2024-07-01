using Practice2.Models;

namespace Practice2.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
           {
              new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil water", PlatForm = "Kettle & Pan"},
              new Command{Id = 1, HowTo = "Cut a bread", Line = "Get a knife", PlatForm = "chopping board & knife"},
              new Command{Id = 2, HowTo = "Make a cup of tea", Line = "put teabag in cup", PlatForm = "Kettle & cup"}
           };

            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", PlatForm = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
