﻿
namespace BashSoft
{
    using System;
    using System.Collections.Generic;

    public static class RepositoryFilters
    {
        public static void FilterAndTake(Dictionary<string, List<string, int>> wantedData, string wantedFilter, int studentsToTake)
        {

        }

        private static void FilterAndTake(Dictionary<string, List<string, int>> wantedData, Predicate<double> GivenFilter, int studentsToTake)
        {

        }

        private static bool ExcellentFilter(double mark)
        {
            return mark >= 5.0;
        }

        private static bool AverageFilter(double mark)
        {
            return mark < 5.0 && mark >= 3.5;
        }

        private static bool PoorFilter(double mark)
        {
            return mark < 3.5;
        }
    }
}
