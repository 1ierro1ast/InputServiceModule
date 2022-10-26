using Codebase.Infrastructure.Services.Input;

namespace Codebase.Infrastructure.Services.Settings
{
    public interface IGameSettings : IService
    {
        InputSettings InputSettings { get; }
    }
}