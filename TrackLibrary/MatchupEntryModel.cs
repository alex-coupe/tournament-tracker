using System;
using System.Collections.Generic;
using System.Text;

namespace TrackLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting  { get; set; }

        /// <summary>
        /// Represents the score for this team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup this team came from
        /// as winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
