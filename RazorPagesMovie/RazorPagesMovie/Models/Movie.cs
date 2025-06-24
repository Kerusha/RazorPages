using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [Required, StringLength(60, MinimumLength = 3)]
    public string Title { get; set; } = string.Empty;

    [DataType(DataType.Date), Display(Name = "Release Date")]
    public DateTime ReleaseDate { get; set; }

    [Required, StringLength(30), RegularExpression(@"^[A-Z]+[a-zA-z\s]*$")]
    public string Genre { get; set; } = string.Empty;

    [DataType(DataType.Currency), Range(1, 100)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    [Required, StringLength(5), RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    public string Rating { get; set; } = string.Empty;
}