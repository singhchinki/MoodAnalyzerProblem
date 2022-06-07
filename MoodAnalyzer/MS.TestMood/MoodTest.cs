using MoodAnalyzer;

namespace MS.TestMood
{
    public class MsTestMood
    {

        [Test]
        public void GivenSadMoodShouldReturnSad()
        {
            string expected = "Sad";
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);
            string mood = moodAnalyse.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        [Test]
       
        public void GivenHappyMoodShouldReturnHappy()
        {
            string expected = "Happy";
            string message = "I am in any Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);
            string mood = moodAnalyse.AnalyseMood();
            Assert.AreEqual (expected, mood);
        }

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
    }
}