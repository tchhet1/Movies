using System;
using System.Collections.Generic;


namespace Movies
{
    class Movies
    {
        public string name;
        public string director;
        private string rating;
        public Movies (string aName, string aDirector, string aRating)
        {
            name = aName;
            director = aDirector;
            Rating = aRating;

        }

        public Movies()
        {

        }


        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string result = "";
        /// <summary>
        /// checkRating method checks the rating of the movie and suggest users
        /// </summary>
        /// <returns></returns>
      public string checkRating()
        {
            switch (Rating)
            {
                case "PG":
                    result = ("This movie requires Parental Guidance");
                    break;
                case "PG-13":
                    result = ("In this movie, some material may be inappropriate for children under 13");
                    break;
                case "R":
                    result = ("This movie requires anyone under 17 to accompany parent or adult guardian");
                    break;
                case "X":
                    result = ("No one under 17 admitted");
                    break;
                default:
                    result = ("This film does not have a rating");
                    break;
            }

            return result;
        }
    }
}
