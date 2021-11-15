using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegExSample;

namespace RegexTesting1
{
    [TestClass]
    public class UnitTest1
    {
        
       

        /// <summary>
        /// 
        /// Testings the user firstname using lambda.
        /// </summary>
        [TestMethod]
        public void TestingUserFirstnameUsingLambda()
        {

            //Arrange
            string message = "Shw";
            string expected = "valid";

            //Act
            UserRegistrationUsingLambda registrationTesting = new UserRegistrationUsingLambda(message);
            string actual = registrationTesting.ValidateFirstNameUsingLambda();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        
        /// <summary>
        /// Testings the user lastname using lambda.
        /// </summary>
        /// 
        [TestMethod]
        public void TestingUserLastNameUsingLambda()
        {

            //Arrange
            string message = "Mhw";
            string expected = "valid";

            //Act
            UserRegistrationUsingLambda registrationTesting = new UserRegistrationUsingLambda(message);
            string actual = registrationTesting.ValidateLastNameUsingLambda();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestingUserEmailUsingLambda()
        {

            //Arrange
            string message = "abc.xyz@bl.co.in";
            string expected = "valid";

            //Act
            UserRegistrationUsingLambda registrationTesting = new UserRegistrationUsingLambda(message);
            string actual = registrationTesting.ValidateEmailUsingLambda();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void TestingUserMobileNumberUsingLambda()
        {

            //Arrange
            string message = "91 8686531051";
            string expected = "valid";

            //Act
            UserRegistrationUsingLambda registrationTesting = new UserRegistrationUsingLambda(message);
            string actual = registrationTesting.ValidateMobileNumberUsingLambda();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        public void TestingUserPasswordUsingLambda()
        {

            //Arrange
            string message = "S1etacm@";
            string expected = "valid";

            //Act
            UserRegistrationUsingLambda registrationTesting = new UserRegistrationUsingLambda(message);
            string actual = registrationTesting.ValidatePasswordUsingLambda();

            //Assert
            Assert.AreEqual(expected, actual);

        }







    }
}
