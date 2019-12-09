using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mvcApp2Try.Models
{
    /**
     * The Movie class contains:
     *      * The Id field which is required by the database for the primary key.
     *      * [DataType(DataType.Date)]: The DataType attribute specifies the type of the data (Date). With this attribute:
     *          - The user is not required to enter time information in the date field.
     *          - Only the date is displayed, not time information.
     */
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        // The [Column(TypeName = "decimal(18, 2)")] data annotation is required 
        // so Entity Framework Core can correctly map Price to currency in the database.
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        /**
         * 
         *  the movie model is scaffolded. 
         *  That is, the scaffolding tool produces pages for Create, Read, Update, and Delete (CRUD) operations for the movie model.
         *  
         *  Visual Studio creates:
         *      * An Entity Framework Core database context class (Data/MovieContext.cs)
         *      * A movies controller (Controllers/MoviesController.cs)
         *      * Razor view files for Create, Delete, Details, Edit, and Index pages (Views/Movies/*.cshtml)
         *      
         *  The automatic creation of the database context and CRUD (create, read, update, and delete) 
         *  action methods and views is known as scaffolding.
         */
    }
}
