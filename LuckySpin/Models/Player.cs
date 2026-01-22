using System.ComponentModel.DataAnnotations;
namespace LuckySpin.Models
{
    public class Player 
    {
        //TODO: Annotate both Player properties as shown in the exercise Figure 1 and the resources section.
        public string FirstName { get; set; } = "Player";

        public int Luck { get; set; } = 7;
    }
}