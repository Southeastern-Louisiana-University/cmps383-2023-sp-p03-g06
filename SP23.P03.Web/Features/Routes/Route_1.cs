﻿using SP23.P03.Web.Features.Trains;
using SP23.P03.Web.Features.TrainStations;
using SP23.P03.Web.Features.Authorization;

namespace SP23.P03.Web.Features.Routes
{
    public class Route_1
    {
        public int Id { get; set; }
        public ICollection<Train>? train_Id { get; set; } //One route can have multiple trains
        public int startStation_Id { get; set; } //A route has one startStation
        public TrainStation startStation { get; set; }
        public int endStation_Id { get; set; } //A route has one endStation
        public TrainStation endStation { get; set; }
        public float distance { get; set; } //A route will have a distance between stations
        public DateTime travel_Time { get; set; } //The route will have a time for its whole movement
        public int? ManagerId { get; set; } //A route will have an optional Manager
        public virtual User? Manager { get; set; }
    }
}
