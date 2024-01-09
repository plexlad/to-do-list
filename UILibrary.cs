namespace UILibrary;

// An app based on the Elm Architecture
// Using console rewrites and informatiow we can use a model, view, and update
// step to create a Terminal app that works in real time.

// TODO find a way to implement key inputs
public class App {
    public string view; // Change the view string and use it to update
    
    // firstView is the first string that is loaded to the user
    public App(string? firstView)
    {
        view = firstView is string ? firstView : "";
    }
    
    public void Update()
    {
        // TODO This method updates the screen
    }

    public void Run()
    {
        // TODO this method actually runs the loop
    }
}
