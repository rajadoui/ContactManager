
public class Contact
{
    // Properties
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    // Override the ToString method
    public override string ToString()
    {
        return $"Name: {Name}, Email: {Email}, Phone: {Phone}";
    }
}
