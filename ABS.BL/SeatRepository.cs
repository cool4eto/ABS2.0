using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.BL
{
    public class SeatRepository
    {
        public void AddSeatsForFlight(Flight flight, int row, int col, SeatClass seatClass)
        {
            using (var context = new ABS())
            {
                // Gets the section for the enum seatClass
                var section = context.Sections.Where(s => s.SeatClassName == seatClass.ToString())
                                              .FirstOrDefault();

                // Checks if such section is already associated with the flight
                var existingSection = context.Seats.Where(s => s.FlightId == flight.FlightId && s.SectionId == section.SectionId)
                                                   .FirstOrDefault();
                if (existingSection != null)
                    throw new Exception(ExceptionHelper.ExistingSection);

                List<Seat> seats = new List<Seat>();
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Seat seatToAdd = new Seat();
                        seatToAdd.Col = Convert.ToChar('A' + j).ToString();//translates the integer value to alphabethical char
                        seatToAdd.Row = i + 1;//because we want the rows to start at 1 not at 0
                        seatToAdd.FlightId = flight.FlightId;
                        seatToAdd.Status = true;
                        seatToAdd.SectionId = section.SectionId;
                        seats.Add(seatToAdd);
                    }
                }
                context.Seats.AddRange(seats);
                context.SaveChanges();
            }
        }
        public bool HasAvailableSeats(Flight fl)
        {
            using (var context = new ABS())
            {
                var freeSeatForFlight = context.Seats.Where(s => s.FlightId == fl.FlightId && s.Status == true)
                                                     .FirstOrDefault();
                if (freeSeatForFlight == null)
                    return false;

                return true;
            }
        }

        public List<Seat> AllAvailableSeatsList(Flight fl)
        {
            using (var context = new ABS())
            {
                var freeSeatForFlight = context.Seats.Include(co => co.Section)
                                                     .Where(s => s.FlightId == fl.FlightId && s.Status == true)
                                                     .ToList();

                return freeSeatForFlight;
            }
        }

        public static string DisplayDetailsForSeatsInFlight(Flight flight)
        {
            StringBuilder builder = new StringBuilder();
            using (var context = new ABS())
            {
                // Gets the seats for a given flight.
                var query = context.Seats.Where(s => s.FlightId == flight.FlightId);
                // Foreach First Buisiness Economy.
                foreach (string name in Enum.GetNames(typeof(SeatClass))) 
                {
                    // Finds the section by SeatClass.
                    var section = context.Sections.Where(m => m.SeatClassName == name).FirstOrDefault();

                    // Checks if the associated floght have such seatClass.
                    var checker = query.Where(s => s.SectionId == section.SectionId).FirstOrDefault();
                    // If the flight does not have such seat class nothing more is appended.
                    if (checker == null) continue; 

                    // Appends the name of the seat class and the seats.
                    builder.Append($"\n\t{name} \n\t");
                    foreach (var seat in query.Where(s => s.SectionId == section.SectionId))
                    {
                        builder.Append($"{seat.Row}{seat.Col} {seat.Status};");
                    }
                }
                builder.Append("\n");

                return builder.ToString();
            }
        }
        public string DisplaySeatsDetails()
        {
            StringBuilder builder = new StringBuilder();
            using (var context = new ABS())
            {
                foreach (var flight in context.Flights)
                {
                    var query = context.Seats.Where(s => s.FlightId == flight.FlightId);
                    foreach (string name in Enum.GetNames(typeof(SeatClass)))
                    {
                        var section = context.Sections.Where(m => m.SeatClassName == name)
                                                      .FirstOrDefault();
                        builder.Append($"\n {name} \n");
                        foreach (var seat in query.Where(s => s.SectionId == section.SectionId))
                        {
                            builder.Append($"{seat.Col}{seat.Row} {seat.Status};");
                        }
                    }

                }

                return builder.ToString();
            }
        }

        public bool BookSeat(Flight flight, SeatClass seatClass, int row, string col)
        {
            using (var context = new ABS())
            {
                var section = context.Sections.Where(s => s.SeatClassName == seatClass.ToString())
                                              .FirstOrDefault();
                var seatToBook = context.Seats.Where(s => s.FlightId == flight.FlightId 
                                                       && s.SectionId == section.SectionId
                                                       && s.Row == row
                                                       && s.Col == col)
                                              .FirstOrDefault();

                if (seatToBook.Status == false)
                    return false;
                seatToBook.Status = false;
                context.SaveChanges();

                return true;
            }
        }
    }
}
