using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace ABS.BL
{
    /// <summary>
    /// Holds information about airport.
    /// </summary>
    [Table("Airport")]
    public partial class Airport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Airport()
        {
            Flights = new HashSet<Flight>();
            Flights1 = new HashSet<Flight>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AirportId { get; set; }

        private string _name;
        [Required]
        [StringLength(3)]
        public string Name
        {
            get { return _name; }
            set
            {
                // Matches the passed string against regex to ensure that it is exactly three upper case letters.
                if (value.Length != 3)
                    throw new Exception(ExceptionHelper.InvalidAirportNameSize);
                if (!Regex.IsMatch(value, @"[A-Za-z]{3}"))
                    throw new Exception(ExceptionHelper.InvalidAirportNameCharacters);

                _name = value;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights1 { get; set; }

    }
}
