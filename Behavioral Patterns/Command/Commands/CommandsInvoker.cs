
namespace Behavioral_Patterns.Command.Commands
{
    public class CommandsInvoker
    {
        private List<ICommand> _commands = new();
        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }
        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
