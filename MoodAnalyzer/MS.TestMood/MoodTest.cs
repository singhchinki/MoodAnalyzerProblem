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
    }
}