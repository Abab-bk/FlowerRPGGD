using System.Collections.Generic;
using Game.Scripts.Classes;
using Game.Scripts.Interfaces;
using Godot;

namespace Game.Scripts.Base;

public partial class GameEntity : CharacterBody2D, IGameEntity
{
    public List<Component> Components { get; } = new List<Component>();
}