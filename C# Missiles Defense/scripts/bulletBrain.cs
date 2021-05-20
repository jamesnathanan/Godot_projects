using Godot;
using System;

public class bulletBrain : Node
{
    scenes scenes = new scenes();

    public override void _Ready()
    {
        
    }

    public void _on_enemySpawner_timeout()
    {
        // GD.Print("Timer Works !");
        spawnEnemy();
    }

    public void spawnEnemy()
    {
        Vector2 spawnPosition = new Vector2(Convert.ToSingle(GD.RandRange(0,1000)), -30);
        Vector2 targetPosition = new Vector2(Convert.ToSingle(GD.RandRange(0,1000)), 550);
        spawnBullet(spawnPosition, targetPosition, "enemy");
    }

    public void spawnBullet(Vector2 spawnPosition, Vector2 targetPosition, string animationName)
    {
        // spawn bullet at position and look at target position

        var bullet = (bullet)scenes._sceneBullet.Instance();
        GetNode("/root/game/bullets").AddChild(bullet);
        bullet.GlobalPosition = spawnPosition;
        bullet.LookAt(targetPosition);

        // set the bullet animation
        var bulletSprite = (AnimatedSprite)bullet.GetNode("AnimatedSprite");
        bulletSprite.Play(animationName);

    }

    public void spawnExplosion(Vector2 spawnPosition, string animationName)
    {
        var explosion = (Area2D)scenes._sceneExplosion.Instance();
        GetNode("/root/game/bullets").AddChild(explosion);
        explosion.GlobalPosition = spawnPosition;

        // animation
        var explosionSprite = (AnimatedSprite)explosion.GetNode("AnimatedSprite");
        explosionSprite.Play(animationName);
    }


}
