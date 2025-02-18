﻿using Game.Scripts.Interactions;
using Godot;

namespace Game.Scripts.Maps;

[GlobalClass]
public partial class SignNode : Node2D
{
    [Export] public SignType SignType;
    [Export] public string Content;
    
    [ExportCategory("Interaction")]
    [Export] public InteractionType InteractionType;
    [Export] public string InteractionContent;
}