using Godot;
using System;

public partial class StartScreen : Control
{
	
	private const string Level1ScenePath = "res://scenes/Level1.tscn";
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GetNode<Button>("Button").Pressed += OnStartButtonPressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GetTreee().ChangeScene(Level1ScenePath);
	}
}
