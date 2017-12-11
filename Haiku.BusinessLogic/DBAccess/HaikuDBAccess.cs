using System.Linq;
using System.Collections.Generic;

using Haiku.BusinessLogic.Data;

namespace Haiku.BusinessLogic.DBAccess
{
    /// <summary>
    /// class that accesses Haiku database
    /// </summary>
    public static class HaikuDBAccess
    {
        /// <summary>
        /// The database
        /// </summary>
        private static HaikuContext db = new HaikuContext();

        /// <summary>
        /// Gets the haiku words.
        /// </summary>
        /// <returns></returns>
        public static List<HaikuWord> GetHaikuWords()
        {
            var dictionary = from wordDBTable in db.Words
                             orderby wordDBTable.ID
                             select wordDBTable;

            return dictionary.ToList();
        }

        /// <summary>
        /// Gets the haiku models.
        /// </summary>
        /// <returns></returns>
        public static List<HaikuDBModel> GetHaikuModels()
        {
            var modelList = from modelDBTable in db.Models
                            where modelDBTable.Evaluation > -3
                            orderby modelDBTable.ID
                            select modelDBTable;

            return modelList.ToList();
        }

        /// <summary>
        /// Saves the haiku.
        /// </summary>
        /// <param name="haiku">The haiku.</param>
        public static void SaveNewHaiku(HaikuPoem haiku)
        {
            db.Haikus.Add(haiku);
            db.SaveChanges();
        }
        
        /// <summary>
        /// Gets the haiku with identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static HaikuPoem GetHaikuWithId(int id)
        {
            var poems = from haikuDBTable in db.Haikus
                         where haikuDBTable.ID == id
                         select haikuDBTable;

            return poems.FirstOrDefault();
        }

        /// <summary>
        /// Gets the newest haikus.
        /// </summary>
        /// <param name="numberOfHaikus">The number of haikus.</param>
        /// <returns></returns>
        public static List<HaikuPoem> GetNewestHaikus(int numberOfHaikus)
        {
            var poems = (from haikuDBTable in db.Haikus
                         orderby haikuDBTable.DateOfCreation descending
                         select haikuDBTable).Take(numberOfHaikus);

            return poems.ToList();
        }

        /// <summary>
        /// Gets the best haikus.
        /// </summary>
        /// <param name="numberOfHaikus">The number of haikus.</param>
        /// <returns></returns>
        public static List<HaikuPoem> GetBestHaikus(int numberOfHaikus)
        {
            var poems = (from haikuDBTable in db.Haikus
                         orderby haikuDBTable.Evaluation descending, haikuDBTable.DateOfCreation descending
                         select haikuDBTable).Take(numberOfHaikus);

            return poems.ToList();
        }

        /// <summary>
        /// Gets the worst haikus.
        /// </summary>
        /// <param name="numberOfHaikus">The number of haikus.</param>
        /// <returns></returns>
        public static List<HaikuPoem> GetWorstHaikus(int numberOfHaikus)
        {
            var poems = (from haikuDBTable in db.Haikus
                         orderby haikuDBTable.Evaluation ascending, haikuDBTable.DateOfCreation descending
                         select haikuDBTable).Take(numberOfHaikus);

            return poems.ToList();
        }
    }
}
