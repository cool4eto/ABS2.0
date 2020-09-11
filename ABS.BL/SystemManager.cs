using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ABS.BL
{
    public class SystemManager
    {
        private AirlineRepository _airlineRepository = new AirlineRepository();
        private AirportRepository _airportRepository = new AirportRepository();
        private FlightRepository _flightRepository = new FlightRepository();
        private SeatRepository _seatRepository = new SeatRepository();

        public void CreateAirport(string name)
        {
            try
            {
                var airport = new Airport { Name = name };
                _airportRepository.AddNewAirport(airport);
                Console.WriteLine("Successfuly inserted new airport");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} Airport name: {name}");
            }
        }

        public void CreateAirline(string name)
        {
            try
            {
                var airline = new Airline { Name = name };
                _airlineRepository.AddNewAirline(airline);
                Console.WriteLine("Successfuly inserted new airline");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} Airline name: {name}");
            }
        }

        public void CreateFlight(string aName, string orig, string dest, int year, int month, int day, string id)
        {
            try
            {
                Airline airline = _airlineRepository.Retreive(aName);
                Airport origin = _airportRepository.Retreive(orig);
                Airport destination = _airportRepository.Retreive(dest);
                if (airline == null)
                    throw new Exception(ExceptionHelper.NonExistentAirline);
                if (origin == null)
                    throw new Exception(ExceptionHelper.NonExistentAirport);
                if (destination == null)
                    throw new Exception(ExceptionHelper.NonExistentAirport);

                Flight flight = new Flight()
                {
                    AirlineId = airline.AirlineId,
                    OrgAirportId = origin.AirportId,
                    DestAirportId = destination.AirportId,
                    Date = new DateTime(year, month, day),
                    FlightName = id
                };
                _flightRepository.AddNewFlight(flight);
                Console.WriteLine("Succesfully inserted flight");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }

        }

        public void CreateSection(string aName, string flightName, int rows, int cols, SeatClass s)
        {
            try
            {
                if (rows < 1 || rows > 100 || cols < 1 || cols > 10)
                    throw new Exception(ExceptionHelper.FlightSectionOutOfBound);
                using (var context = new ABS())
                {
                    Airline airline = _airlineRepository.Retreive(aName);
                    Flight flight = _flightRepository.Retreive(airline.AirlineId, flightName);
                    if (airline == null)
                        throw new Exception(ExceptionHelper.NonExistentAirline);
                    if (flight == null)
                        throw new Exception(ExceptionHelper.FlightNotFound);
                    _seatRepository.AddSeatsForFlight(flight, rows, cols, s);
                    Console.WriteLine("Succesfully inserted section");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} - {aName} {flightName}");
            }
        }



        public List<Flight> FindAvailableFlights(string orig, string dest)
        {
            try
            {
                Airport origin = _airportRepository.Retreive(orig);
                Airport destination = _airportRepository.Retreive(dest);
                if (origin == null || destination == null)
                    throw new Exception(ExceptionHelper.NonExistentAirport);
                Console.WriteLine($"All available flights from: {orig} to: {dest} are: \n\n");
                IEnumerable<Flight> flights = _flightRepository.FlightsFromOriginToDestination(origin, destination);
                List<Flight> flightsWithAvailableSeats = new List<Flight>();
                foreach (var flight in flights)
                {
                    // The ObjectContext instance has been disposed and can no longer be used for operations that require a connection.
                    // I use this because the lazy loading is removing my flight and i cant print it

                    //I should ask if this is the best way to do it

                    if (_seatRepository.HasAvailableSeats(flight))
                    {
                        // I dont need the next row because i included the airline in the query for FlightsFromOriginToDestination
                        //Airline airline = _airlineRepository.Retreive(flight.AirlineId);
                        Console.WriteLine($"Airline: {flight.Airline.Name} Flight: {flight.FlightName} Date: {flight.Date.ToString("dd.MM.yyyy")}");
                        flightsWithAvailableSeats.Add(flight);
                    }
                }
                return flightsWithAvailableSeats;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public void BookSeat(string aName, string flightName, SeatClass s, int row, string col)
        {
            try
            {
                Airline airline = _airlineRepository.Retreive(aName);
                Flight flight = _flightRepository.Retreive(airline.AirlineId, flightName);
                if (airline == null)
                    throw new Exception(ExceptionHelper.NonExistentAirline);
                if (flight == null)
                    throw new Exception(ExceptionHelper.NonExistentFlight);
                if (!_seatRepository.BookSeat(flight, s, row, col))
                    throw new Exception(ExceptionHelper.SeatAlreadyBooked);
                Console.WriteLine($"Succesfully booked- {aName} Seat: {row}{col}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}- Airline: {aName} : {flightName} Seat: {row} {col}");
            }
        }
        public void DisplaySystemDetails()
        {
            Console.WriteLine("List of all airports: ");
            Console.WriteLine(_airportRepository.DisplayAirportsDetails());
            Console.WriteLine("List of all airlines:");
            Console.WriteLine(_airlineRepository.DisplayAirlinesDetails());
            Console.WriteLine("List of all flights: ");
            Console.WriteLine(_flightRepository.DisplayFlightsDetails());
        }

        public IEnumerable<string> GetAirlines()
        {
            List<string> airlineNames = new List<string>();
            foreach (var airline in _airlineRepository.Retreive())
            {
                airlineNames.Add(airline.Name);
            }
            return airlineNames;
        }
        public IEnumerable<string> GetAirports()
        {
            List<string> airportNames = new List<string>();
            foreach (var airport in _airportRepository.Retreive())
            {
                airportNames.Add(airport.Name);
            }
            return airportNames;
        }
        public IEnumerable<string> GetFlightsForAirline(string airlineName)
        {
            List<string> flightNames = new List<string>();
            foreach (var flight in _flightRepository.RetreiveAllFlightsForAirline(_airlineRepository.Retreive(airlineName)))
            {
                flightNames.Add(flight.FlightName);
            }

            return flightNames;
        }

        public List<Seat> GetAvailableSeatsForFlight(string flightNameAndAirline)
        {
            string[] array = flightNameAndAirline.Split(' ');
            Airline airline = _airlineRepository.Retreive(array[0]);
            Flight flight = _flightRepository.Retreive(airline.AirlineId, array[1]);

            return _seatRepository.AllAvailableSeatsList(flight);
        }
        
    }
}
