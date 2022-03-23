Publisher publisher = new Publisher();

publisher.OnKeyPressed += print_char;

publisher.Run();


void print_char(object? sender, char ch) 
{
    Console.WriteLine("\bThe symbol has been entered: " + ch);
}

class Publisher 
{
    public void Run() 
    {
        char ch;

        while (true)
        {
            var read_key = Console.ReadKey();
            ch = read_key.KeyChar;
            if (ch != 'c' && ch != 'C')
            {
                OnKeyPressed?.Invoke(this, ch);
            }
            else
            {
                Console.Write("\b");
                break;
            }
        }
    }
    public event EventHandler<char>? OnKeyPressed;
}
