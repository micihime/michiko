using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Haiku.BusinessLogic.Data
{
    /// <summary>
    /// class that represents haiku poem 
    /// </summary>
    [Table("Haikus")]
    public class HaikuPoem
    {
        #region Fields

        private int id;

        protected string firstVerse;
        protected string secondVerse;
        protected string thirdVerse;

        protected int modelID;

        private int evaluation;
        private int numberOfEvaluations;
        private DateTime dateOfCreation;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// first verse of haiku poem
        /// </summary>
        /// <value>
        /// The first verse.
        /// </value>
        public string FirstVerse
        {
            get { return firstVerse; }
            set { firstVerse = value; }
        }

        /// <summary>
        /// second verse of haiku poem
        /// </summary>
        /// <value>
        /// The second verse.
        /// </value>
        public string SecondVerse
        {
            get { return secondVerse; }
            set { secondVerse = value; }
        }

        /// <summary>
        /// third verse of haiku poem
        /// </summary>
        /// <value>
        /// The third verse.
        /// </value>
        public string ThirdVerse
        {
            get { return thirdVerse; }
            set { thirdVerse = value; }
        }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// ID of the model that haiku poem was created from.
        /// </value>
        public int ModelID
        {
            get { return modelID; }
            set { modelID = value; }
        }

        /// <summary>
        /// Gets or sets the evaluation.
        /// </summary>
        /// <value>
        /// The evaluation.
        /// </value>
        [Required]
        [Range(-3, 3)]
        public int Evaluation
        {
            get { return evaluation; }
            set { evaluation = value; }
        }

        /// <summary>
        /// Gets or sets the number of evaluations.
        /// </summary>
        /// <value>
        /// The number of evaluations.
        /// </value>
        public int NumberOfEvaluations
        {
            get { return numberOfEvaluations; }
            set { numberOfEvaluations = value; }
        }

        /// <summary>
        /// Gets or sets the date of creation.
        /// </summary>
        /// <value>
        /// The date of creation.
        /// </value>
        public DateTime DateOfCreation
        {
            get { return dateOfCreation; }
            set { dateOfCreation = value; }
        }
        #endregion

        #region Constructor

        public HaikuPoem() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="HaikuPoem"/> class with input parameters.
        /// </summary>
        public HaikuPoem(string line1, string line2, string line3, int modelId)
        {
            firstVerse = line1;
            secondVerse = line2;
            thirdVerse = line3;
            modelID = modelId;
            evaluation = 0;
            numberOfEvaluations = 0;
            dateOfCreation = DateTime.Now;
        }
        #endregion
    }
}