namespace Demo.Business.Models
{
    public class MainMenu
    {
        public int EntryPoint { get; set; }
        public List<MenuOption> Options { get; set; } = new List<MenuOption>();
    }
}