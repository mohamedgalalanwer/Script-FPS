# Script-FPS

 use the script in game when use the frist person controller.
 make an FPS game from scratch! Raycasting is the most common way to detect in a game.
 
  make an  FPS game from scratch! I show how to use layers to hide gameobjects in the scene and then how to use layers with cameras to change gameobject visibility.
  
  # ExampleCode
  ```c#
  void Update () {
        if (Input.GetButton("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out rayCast, rang))
            {
                Debug.Log("enmy: "+rayCast.transform.name);
            
            }
        }
    }
  
```
# Motivation
 use the script in game when use the frist person controller.
 
 # API Script FOR UNITY
 [ API SCRIPT](https://docs.unity3d.com/ScriptReference/index.html)

# Contributors

[Mohamed Galal](abogalalmedo@gmail.com) gmail

[Mohamed Galal Anwer](https://www.linkedin.com/in/mohamedgalalanwer/) linkedin

# See my project in the link

 https://www.youtube.com/watch?v=KLsg5glNYkM
