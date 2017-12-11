using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Haiku.BusinessLogic.DBAccess
{
    /// <summary>
    /// class that represents haiku model that was extracted from haiku corpus
    /// </summary>
    [Table("HaikuModels")]
    public class HaikuDBModel
    {
        #region Fields

        private int id;
                
        private string firstVerseModel;
        private string secondVerseModel;
        private string thirdVerseModel;
        private int evaluation;
        #endregion
                
        #region Properties
        
        [Key]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstVerseModel
        {
            get { return firstVerseModel; }
            set { firstVerseModel = value; }
        }

        public string SecondVerseModel
        {
            get { return secondVerseModel; }
            set { secondVerseModel = value; }
        }

        public string ThirdVerseModel
        {
            get { return thirdVerseModel; }
            set { thirdVerseModel = value; }
        }

        public int Evaluation
        {
            get { return evaluation; }
            set { evaluation = value; }
        }
        #endregion
    }
}
