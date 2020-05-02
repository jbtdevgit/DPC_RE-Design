﻿using System;

namespace Predictions.Models
{
    public class UpcomingMatchesModel
    {
        public int MatchID { get; set; }
        public string TeamA_ImgSource { get; set; }
        public string TeamA_Name { get; set; }
        public string TeamB_ImgSource { get; set; }
        public string TeamB_Name { get; set; }
        public string GameRound { get; set; }
        public string GameScore { get; set; }
        public string PredictedTeam { get; set; }
        public string WagerShards { get; set; }
        public string ReturnShards { get; set; }
        public string MatchTime { get; set; }
        public DateTime MatchDate { get; set; }
        public string MatchSchedule { get; set; }
        public string MatchDay { get; set; }
    }
}
