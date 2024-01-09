// Brock Smith
// To-Do List Study
// Idea from Bubble Tea Go framework

// TEST Loading animation
string animationFrame = "|";
for(int i = 0; i < 100; i++)
{
    switch(i % 4)
    {
        case 0:
            animationFrame = "|";
            break;
        case 1:
            animationFrame = "/";
            break;
        case 2:
            animationFrame = "-";
            break;
        case 3:
            animationFrame = "\\";
            break;
    }
    
    Console.Write($"\rLoading {animationFrame} ");
    Thread.Sleep(500);
}
