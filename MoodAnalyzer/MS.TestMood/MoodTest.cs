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
            Assert.AreEqual(expected, mood);
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

        [Test]
        public void GivenMoodAnalseClassName_shouldReturnMoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzerProblem", "MoodAnalyser");
            expected.Equals(obj);
        }
        /// <summary>
        /// Givens the mood analyse class name shoul return mood analyser oject parameterized constructor.
        /// </summary>
        /// -----------------------Tc5.1-----------------
        [Test]
        public void GivenMoodAnalyseClassName_ShoulReturnMoodAnalyserOjectParameterizedConstructor()
        {
            object expected = new MoodAnalyser("Happy");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser", "Happy");
            expected.Equals(obj);
        }
        [Test]
        /// <summary>
        /// TC 5.2 Given class name  when not proper then throw no such class exception
        /// </summary>
        public void GivenClassName_WhenImproper_ThenShouldThrowNoSuchClassException()
        {
            string expected = "Class Not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyzerProblem.WrongClass", "MoodAnalyzer", "Happy");
            }
            catch (MoodAnalyzerCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
    [Test]
    public void GivenClass_WhenConstructorNotProper_ThenShouldThrowNoSuchConstructorException()
    {
        string expected = "Constructor is Not Found";
        try
        {
            object obj = MoodAnalyzerFactory.CreateMoodAnalyzerUsingParameterizedConstructor("MoodAnalyzerProblem.MoodAnalyzer", "WrongConstructor", "Happy");
        }
        catch (MoodAnalyzerException exception)
        {
            Assert.AreEqual(expected, exception.Message);
        }
    }
    /// <summary>
    ///  TC 6.1 Given happy message using reflection when proper should return happy mood
    /// </summary>
    [Test]
    public void GivenHappyMessage_WhenUsingReflection_ThenShouldReturnHappyMood()
    {
        string expected = "Happy";
        object obj = MoodAnalyzerFactory.InvokeAnalyseMood("Happy", "analyseMood");
        Assert.AreEqual(expected, obj);
    }
    /// <summary>
    ///  TC 6.2 Given happy message when improper methode then should throw 
    /// </summary>
    [Test]
    public void GivenHappyMessage_WhenImproperMethode_ThenShouldThrowMoodAnalysisException()
    {
        string expected = "Method is not found";
        try
        {
            object obj = MoodAnalyzerCustomFactory.InvokeAnalyseMood("Happy", "WrongAnalyseMood");
        }
        catch (MoodAnalyzerCustomException exception)
        {
            Assert.AreEqual(expected, exception.Message);
        }
    }
}