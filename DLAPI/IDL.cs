﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace DLAPI
{
    //CRUD Logic:
    // Create - add new instance
    // Request - ask for an instance or for a collection
    // Update - update properties of an instance
    // Delete - delete an instance
    public interface IDL
    {
        #region Bus
        IEnumerable<Bus> GetAllBuses();
        IEnumerable<Bus> GetAllBusesBy(Predicate<Bus> predicate);
        Bus GetBus(int licenseNum);
        void AddBus(Bus bus);
        void UpdateBus(Bus bus);
        void UpdateBus(int licenseNum, Action<Bus> update); //method that knows to update specific fields in Bus
        void DeleteBus(int licenseNum);
        #endregion
        #region Station
        IEnumerable<Station> GetAllStations();
        IEnumerable<Station> GetAllStationsBy(Predicate<Station> predicate);
        Station GetStation(int code);
        void AddStation(Station station);
        void UpdateStation(Station station);
        void UpdateStation(int code, Action<Station> update); //method that knows to updt specific fields in station
        void DeleteStation(int code);
        #endregion
        #region Line
        IEnumerable<Line> GetAllLines();
        IEnumerable<Line> GetAllLinesBy(Predicate<Line> predicate);
        Line GetLine(int lineId);
        void AddLine(Line line);
        void UpdateLine(Line line);
        void UpdateLine(int lineId, Action<Line> update); //method that knows to updt specific fields in line
        void DeleteLine(int lineId);
        #endregion
        #region Trip
        IEnumerable<Trip> GetAllTrips();
        IEnumerable<Trip> GetAllTripsBy(Predicate<Trip> predicate);
        Trip GetTrip(int tripId);
        void AddTrip(Trip trip);
        void UpdateTrip(Trip trip);
        void UpdateTrip(int tripId, Action<Trip> update); //method that knows to updt specific fields in trip
        void DeleteTrip(int tripId);
        #endregion
        #region AdjacentStations
        IEnumerable<AdjacentStations> GetAllAdjacentStations();
        IEnumerable<AdjacentStations> GetAllAdjacentStationsBy(Predicate<AdjacentStations> predicate);
        AdjacentStations GetAdjacentStations(int stationCode1,int stationCode2);
        void AddAdjacentStations(AdjacentStations adjacent);
        void UpdateAdjacentStations(AdjacentStations adjacent);
        void UpdateAdjacentStations(int stationCode1, int stationCode2, Action<AdjacentStations> update); //method that knows to updt specific fields in adjacent stations
        void DeleteAdjacentStations(int stationCode1, int stationCode2);
        bool IsExistAdjacentStations(int stationCode1, int stationCode2);
        #endregion
        #region LineStation

        IEnumerable<LineStation> GetAllLineStations();
        IEnumerable<LineStation> GetAllLineStationsBy(Predicate<LineStation> predicate);
        LineStation GetLineStation(int lineId,int stationCode);
        void AddLineStation(LineStation lineStation);
        void UpdateLineStation(LineStation lineStation);
        void UpdateLineStation(int lineId,int stationCode, Action<LineStation> update); //method that knows to updt specific fields in line station
        void DeleteLineStation(int lineId, int stationCode);
        #endregion
        #region LineTrip
        IEnumerable<LineTrip> GetAllLineTrips();
        IEnumerable<LineTrip> GetAllLineTripsBy(Predicate<LineTrip> predicate);
        LineTrip GetLineTrip(int lineId,TimeSpan time);
        void AddLineTrip(LineTrip lineTrip);
        void UpdateLineTrip(LineTrip lineTrip);
        void UpdateLineTrip(int lineId, TimeSpan time, Action<LineTrip> update); //method that knows to updt specific fields in Line Trip
        void DeleteLineTrip(int lineId, TimeSpan time);
        #endregion
        #region User
        IEnumerable<User> GetAllUsers();
        IEnumerable<User> GetAllUsersBy(Predicate<User> predicate);
        User GetUser(string userName);
        void AddUser(User user);
        void UpdateUser(User user);
        void UpdateUser(string userName, Action<User> update); //method that knows to updt specific fields in User
        void DeleteUser(string userName);
        #endregion
    }
}
