# DesignPatternsFinal

This is my final for Software Design Principles.
I plan to make a little console app that will read input to fire a gun that will have bullets that can be decorated.

Creational Pattern - Singleton - only one gun can be created
Structural Pattern - Decorator - bullets can be decorated with powerups
Behavioral Pattern - Command - read inputs to "fire" gun

A game I am working on has weapons that can be customized and bullets can do some crazy stuff, I think doing this can help understand a different way to handle it.

# Gun Singleton
To access it call Gun.getInstance()
This will return the same static gun

# Bullet Decorators
there is a BasicBullet that can be passed into the different decorator classes
to make a new decorator make a class and have it derive from BulletDecorator
To decorate a bullet:
```c#
//Make a bullet
BasicBullet bullet = new BasicBullet();

// pass made bullet into decorator
bullet = new FlameBullet(bullet);
```

# Input
```c#
//make input handler
InputHandler inputHandler = new InputHandler();

//add input into handler and set it to an action
inputHandler.BindCommand(ConsoleKey.F, () => YourFunction());

//listen for inputs
inputHandler.Listen();
```
