using System;
using UnityEngine;

namespace Codebase.Infrastructure.Services.Input
{
    public interface IInputService : IService
    {
        event Action LeftMouseButtonDownEvent;
        event Action LeftMouseButtonUpEvent;

        event Action<float> MouseWheelScrollDownEvent; 
        event Action<float> MouseWheelScrollUpEvent;

        float HorizontalSpeed { get; }
        float VerticalSpeed { get; }
        Vector3 MousePositionInViewport { get; }
        Vector3 MousePositionInScreen { get; }
        Vector3 MousePositionInWorld { get; }
        float MouseX { get; }
        float MouseY { get; }
        Vector3 ConvertPosition(PositionSpace from, PositionSpace to);
        Vector3 GetMousePosition(PositionSpace positionSpace = PositionSpace.Screen);
    }
}