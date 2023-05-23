using Godot;
namespace Entities;
public partial class Player : CharacterBody2D
{
    [Export] public int Speed {get;set;} = 350;
    public void GetInput()
    {
        Vector2 direction = Input.GetVector("left", "right", "up", "down");
        Velocity = Speed * direction;
    }
    public override void _PhysicsProcess(double delta)
    {
        GetInput();
        MoveAndSlide();
    }
}