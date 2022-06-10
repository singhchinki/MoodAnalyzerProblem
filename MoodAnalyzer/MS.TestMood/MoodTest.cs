using MoodAnalyzer;

namespace MS.TestMood
{
    public class MsTestMood
    {
        /// <summary>
        /// Tc 1.1: Given-I am in said Mood message should return Sad
        /// </summary>
        [Test]
        public void GivenSadMoodShouldReturnSad()
        {
            string expected = "Sad";
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);
            string mood = moodAnalyse.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Tc 1.2 & 2.1 : Givens i am in Happy mood should return Happy.
        /// </summary>
        [Test]
       
        public void GivenHappyMoodShouldReturnHappy()
        {
            string expected = "Happy";
            string message = "I am in any Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);
            string mood = moodAnalyse.AnalyseMood();
            Assert.AreEqual (expected, mood);
        }
        /// <summary>
        /// TC.3.2: Givens the empty mood should throw mood analysis exception indicating empty mood.
        /// </summary>
        [Test]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
        /// <summary>
        /// TC 3.1: Givens the null mood should throw mood analysis exception.
        /// </summary>
        [Test]
        public void Given_Null_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        /// <summary>
        /// TC Case 4.1 Givens the mood analse class name should return mood analyser object.
        /// </summary>
        public void GivenMoodAnalseClassName_shouldReturnMoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message) ;
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzerProblem", "MoodAnalyser" );
            expected.Equals(obj) ;
        }
    }
}