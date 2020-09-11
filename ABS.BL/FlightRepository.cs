using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using System.Data.Entity;

namespace ABS.BL
{
    public class FlightRepository
    {
        public void AddNewFlight(Flight flight)
        {
            using (var context = new ABS())
            {
                var flight1 = context.Flights.Where(f => f.AirlineId == flight.AirlineId)
                                             .Where(f => f.FlightName == flight.FlightName)
                                             .FirstOrDefault();
                if (flight1 != null)
                    throw new Exception(ExceptionHelper.AlreadyExistentFlight);
                context.Flights.Add(flight);
                context.SaveChanges();
            }
        }
        // Retreives flight by airlineID and flightName
        public Flight Retreive(int airlineId, string flightName)
        {
            using (var context = new ABS())
            {
                var flight1 = context.Flights.Where(f => f.AirlineId == airlineId)
                                                 .Where(f => f.FlightName == flightName)
                                                 .FirstOrDefault();
                if (flight1 == null)
                    throw new Exception(ExceptionHelper.NonExistentFlight);

                return flight1;
            }
        }
        // Retreives flight by Id
        public Flight Retreive(int flId)
        {
            using (var context = new ABS())
            {
                var flight1 = context.Flights.Where(f => f.FlightId == flId)
                                             .FirstOrDefault();
                if (flight1 == null)
                    throw new Exception(ExceptionHelper.NonExistentFlight);

                return flight1;
            }
        }

        public IEnumerable<Flight> RetreiveAllFlightsForAirline(Airline airline)
        {
            using (var context = new ABS())
            {
                var flights = context.Flights.Where(f => f.AirlineId == airline.AirlineId).ToList();

                return flights;
            }
        }

        public IEnumerable<Flight> FlightsFromOriginToDestination(Airport originAirport, Airport destinationAirport)
        {
            using (var context = new ABS())
            {
                var flightsFromOrigToDest = context.Flights.Include(co => co.Airline)
                                                           .Where(f => f.OrgAirportId == originAirport.AirportId)
                                                           .Where(f => f.DestAirportId == destinationAirport.AirportId)
                                                           .ToList();
                // ToList is used to not dispose dbcontext before we need it
                return flightsFromOrigToDest; 
            };
        }

        public string DisplayFlightsDetails()
        {
            StringBuilder builder = new StringBuilder();
            using (var context = new ABS())
            {
                foreach (Flight flight in context.Flights)
                {
                    builder.Append($"\nFlight name: {flight.FlightName}, " +
                        $"Airline: {flight.Airline.Name}, " +
                        $"Origin: {context.Airports.Find(flight.OrgAirportId).Name}, " +
                        $"Destination: {context.Airports.Find(flight.DestAirportId).Name}, " +
                        $"Date: {flight.Date.ToString("dd.MM.yyyy")} \n Seats: \n");
                    builder.Append(SeatRepository.DisplayDetailsForSeatsInFlight(flight));
                }
            }
            return builder.ToString();
        }
    }
}
