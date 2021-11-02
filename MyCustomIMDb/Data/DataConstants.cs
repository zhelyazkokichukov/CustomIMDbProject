using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomIMDb.Data
{
    public class DataConstants
    {
        public class Movie
        {
            public const int TitleMaxLength = 200;
            public const int TitleMinLength = 1;

            public const int PlotSummaryMaxLength = 500;
            public const int PlotSummaryMinLength = 50;

            public const int MinYearReleaseDate = 1878;
            public const int MaxYearReleaseDate = 2022;

            public const int StorylineMinLength = 50;
            public const int StorylineMaxLength = 1500;
        }

        public const int ActorNameMaxLength = 20;
        public const int GenreNameMaxLength = 20;
    }
}
