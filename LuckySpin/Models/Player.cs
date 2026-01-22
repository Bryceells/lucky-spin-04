using System.ComponentModel.DataAnnotations;
namespace LuckySpin.Models
{
    public class Player 
    {
        //TODO: Annotate both Player properties as shown in the exercise Figure 1 and the resources section.
        [Required]
        public required string FirstName { get; set; } = "Player";
        

        [Range(1, 10)]
        public int Luck { get; set; } = 7;
    }
}   